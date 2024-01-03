using Event_Management_App.Extension;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;

namespace Event_Management_App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddControllers().AddJsonOptions(options => 
                options.JsonSerializerOptions.PropertyNamingPolicy = null);

            builder.Services.AddControllers(options =>
            {
                options.ModelMetadataDetailsProviders.Add(new SystemTextJsonValidationMetadataProvider());
            });

            builder.Services.AddAppSetting();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                //pattern: "{controller=Home}/{action=Index}/{id?}");
                //pattern: "{controller=Login}/{action=Login}/{id?}");
                pattern: "{controller=User}/{action=SignUp}/{id?}");

            app.Run();
        }
    }
}
