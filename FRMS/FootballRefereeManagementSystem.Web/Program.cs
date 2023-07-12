namespace FootballRefereeManagementSystem.Web
{
    using Microsoft.EntityFrameworkCore;

    using Microsoft.Extensions.Hosting;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using SendGrid;

    using Data;
    using Data.Models;
    using Services;
    using Services.Contracts;
    using SendGrid.Helpers.Mail;

    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // Database
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<FootballRefereeManagementSystemDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Identity and SignIn settings
            builder.Services
                .AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
                    options.Password.RequireLowercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
                    options.Password.RequireUppercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
                    options.Password.RequireDigit = builder.Configuration.GetValue<bool>("Identity:Password:RequireDigit");
                    options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
                    options.Password.RequiredLength = builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
                })
                .AddEntityFrameworkStores<FootballRefereeManagementSystemDbContext>();

            builder.Services.AddControllersWithViews();

            // Add custom services
            builder.Services.AddScoped<INewsService, NewsService>();
            builder.Services.AddScoped<ICareerService, CareerService>();
            builder.Services.AddScoped<EmailService>();

            builder.Services.Configure<EmailSettings>
                 (options => builder.Configuration.GetSection("EmailSettings").Bind(options));

            WebApplication app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapDefaultControllerRoute();
            app.MapRazorPages();

            app.Run();
        }
    }
}