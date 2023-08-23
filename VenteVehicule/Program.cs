using Microsoft.EntityFrameworkCore;
using VenteVehicule.Models;
using VenteVehicule.Repository;

namespace VenteVehicule
{
    public class Program
    {
        public static void Main(string[] args)
        {

           var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // -->
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")
                ));
            // --> Permet de creer des instance pour les utilisateurs
            builder.Services.AddScoped<IVehiculeOccasRepository, VehiculeOccasRepository>();
            builder.Services.AddScoped<IAnnonceRpository, AnnonceRepository>();
            builder.Services.AddScoped<IVendeurRepository, VendeurRepository>();
            builder.Services.AddScoped<IAcheteurRepository, AcheteurRepository>();

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
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.MapControllerRoute(
            name: "annonces",
            pattern: "Annonce/ListAnnonces",
            defaults: new { controller = "Annonce", action = "ListAnnonces" });


            app.Run();
        }
            
              
        
    }
}

