namespace Online_Store
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Online_Store.Service;
    using Online_Store.Domain;
	using Online_Store.Domain.Repository.Abstract;
	using Online_Store.Domain.Repository.EntityFramework;

	public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            //appsettings.json
            Configuration.Bind("Project", new Config());

            //db context
            services.AddDbContext<AppDbContext>(x => x.UseNpgsql(Config.ConnectionString));

            services.AddTransient<IUserRepository, EFUserRepository>();
            services.AddTransient<IRoleRepository, EFRoleRepository>();
            services.AddTransient<IUserRoleRepository, EFUserRoleRepository>();
            services.AddTransient<IOrdersRepository, EFOrdersRepository>();

            services.AddTransient<DataManager>();
            services.AddTransient<UserManager>();

            //cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "default";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Home";
                options.SlidingExpiration = true;
            });

            //auth policy for admin area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });

            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie();

            services.AddSession(options =>
            {
                options.Cookie.Name = "Session";
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            services.AddDistributedMemoryCache();

            services.AddHttpContextAccessor();

            //add mvc
            services.AddControllersWithViews()
                .AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if exceptions
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();

            app.UseRouting();

            //auth and cookie
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            //static files css html etc
            app.UseStaticFiles();

            //routes
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}