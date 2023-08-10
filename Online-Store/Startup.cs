namespace Online_Store
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Online_Store.Service;
    using Online_Store.Domain;
	using Online_Store.Domain.Repository.Abstract;
	using Online_Store.Domain.Repository.EntityFramework;
    using AutoMapper;
    using Online_Store.Domain.Entities;
    using Online_Store.Models;
    using Microsoft.Extensions.FileProviders;

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
            services.AddTransient<IOrderRepository, EFOrderRepository>();
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddTransient<IProductImagesRepository, EFProductImagesRepository>();

            services.AddTransient<DataManager>();
            services.AddTransient<UserManager>();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAnyOrigin",
                    builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });

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
                options.Cookie.MaxAge = TimeSpan.FromMinutes(30);
            });

            services.AddDistributedMemoryCache();

            services.AddHttpContextAccessor();

            //add mvc
            services.AddControllersWithViews()
                .AddSessionStateTempDataProvider();

            services.AddAutoMapper(typeof(MappingProfile));
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

            app.UseCors("AllowAnyOrigin");


            //routes
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}