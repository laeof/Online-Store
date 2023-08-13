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
    using System.Text;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.IdentityModel.Tokens;

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

            services.AddCors();

            services.AddAuthentication("MyAuthScheme") // Укажите имя схемы аутентификации
                .AddCookie("MyAuthScheme", options =>
                {
                    options.Cookie.HttpOnly = true;
                });

            services.AddSession(options =>
            {
                options.Cookie.Name = "Session";
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.MaxAge = TimeSpan.FromMinutes(30);
            });

            services.AddDistributedMemoryCache();

            services.AddHttpContextAccessor();

            services.AddScoped<JwtService>();

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

            app.UseAuthorization();

            //static files css html etc
            app.UseStaticFiles();

            app.UseCors(options => options
                .WithOrigins(new[] { "http://localhost:3000", "http://localhost:8080", "http://localhost:4200" })
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials()
            );

            //routes 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}