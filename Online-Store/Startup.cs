namespace Online_Store
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using Online_Store.Service;
    using Online_Store.Domain;
    using Online_Store.Domain.Repository.Abstract;
    using Online_Store.Domain.Repository.EntityFramework;
    using Online_Store.Domain.Entities.Products;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.CodeAnalysis.Options;
    using Microsoft.IdentityModel.Tokens;
    using System.Text;
    using Online_Store.Helpers;

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
            services.AddTransient<IOrderRepository, EFOrderRepository>();
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddTransient<IProductImagesRepository, EFProductImagesRepository>();
            services.AddTransient<ICategoryRepository, EFCategoryRepository>();
            services.AddTransient<ICartRepository, EFCartRepository>();
            services.AddTransient<ICartItemsRepository, EFCartItemsRepository>();
            services.AddTransient<ICharacteristicsRepository, EFCharacteristicsRepository>();
            services.AddTransient<DataManager>();

            services.AddCors();

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["JwtToken:Issuer"],
                    ValidAudience = Configuration["JwtToken:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtToken:SecretKey"]))
                };
            });

            //services
            services.AddTransient<JwtService>();
            services.AddScoped<AuthService>();
            services.AddScoped<SecurePasswordHasher>();
            services.AddScoped<GoogleOAuthService>(provider =>
            {
                var httpClientHelper = provider.GetRequiredService<HttpClientHelper>();
                var clientId = Config.clientId;
                var clientSecret = Config.clientsecret;
                return new GoogleOAuthService(httpClientHelper, clientId, clientSecret);
            });
            services.AddScoped<GoogleProfileService>();
            services.AddScoped<HttpClientHelper>();

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

            app.UseRouting();

            app.UseAuthorization();

            //static files css html etc
            app.UseStaticFiles();

            app.UseCors(options => options
                //.WithOrigins(new[] { "http://localhost:3000", "http://localhost:8080", "http://localhost:4200"})
                //.AllowAnyHeader()
                .AllowAnyMethod()
            //.AllowCredentials()
            );

            //routes 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}