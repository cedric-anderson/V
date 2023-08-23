using Microsoft.EntityFrameworkCore;
using System;
using VenteVehicule.Models;


namespace VenteVehicule.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        // --> Mapping des differents tables
        public DbSet<Annonce> Annonces { get; set; }
        public DbSet<VehiculeDoccasion> VehiculeDoccasions { get; set; }
        public DbSet<Vendeur> Vendeurs { get; set; }
        public DbSet<Acheteur> Acheteurs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Precision sur la valeur decimale du prix VehiculeDoccasion
            modelBuilder.Entity<VehiculeDoccasion>()
                .Property(a => a.Prix)
                .HasColumnType("decimal(18, 2)");

            // Precision sur la valeur decimale du prix Annonce
            modelBuilder.Entity<Annonce>()
               .Property(a => a.Prix)
               .HasColumnType("decimal(18, 2)");


            // Relation entre VehiculeDoccasion et Annonce
            modelBuilder.Entity<VehiculeDoccasion>()               
                 .HasMany(veh => veh.Annonces)                   // Un véhicule a plusieurs annonces
                 .WithOne(a => a.VehiculeDoccasion)          // Une annonce est liée à un seul véhicule
                 .HasForeignKey(a => a.id_Vehicule);         // Clé étrangère pour la relation


            // Relation entre Vendeur et Annonce
            modelBuilder.Entity<Vendeur>()
            .HasMany(ven => ven.Annonces)                   // Un vendeur a plusieurs annonces
            .WithOne(a => a.Vendeur)                    // Une annonce est liée à un seul vendeur
            .HasForeignKey(a => a.id_Vendeur);         // Clé étrangère pour la relation




            // Relation entre Vendeur et Acheteur
            modelBuilder.Entity<Acheteur>()
            .HasMany(ach => ach.Vendeurs)                   // Un Acheteur a plusieurs Vendeurs
            .WithOne(ve => ve.Acheteur)                    // Une Vendeur est liée à un seul Acheteur
            .HasForeignKey(a => a.id_Acheteur);         // Clé étrangère pour la relation


            // Relation entre Annonce et Acheteur
            modelBuilder.Entity<Acheteur>()
            .HasMany(ach => ach.Annonces)                   // Un Acheteur a plusieurs Vendeurs
            .WithOne(a => a.Acheteur)                    // Une Vendeur est liée à un seul Acheteur
            .HasForeignKey(a => a.id_Acheteur);         // Clé étrangère pour la relation



            base.OnModelCreating(modelBuilder);

            // Données d'exemple pour l'entités VehiculeDoccasion

            modelBuilder.Entity<VehiculeDoccasion>().HasData(
                new VehiculeDoccasion { id_Vehicule = 1, Marque = "Toyota", 
                                        Modele = "Corolla", 
                                        AnneFab = 2020, Prix = 15000.00m, Kilometrage = 15000, 
                                        Carburant = "Essence", Transmission = "Automatique", 
                                        Couleur = "Bleu", DescriptionVehicule = "Bonne condition, faible kilométrage.",
                                        DateMiseEnVente = DateTime.Now.AddDays(-30) },

                new VehiculeDoccasion {id_Vehicule = 2, Marque = "Honda", Modele = "Civic", AnneFab = 2018, 
                                        Prix = 18000.00m, Kilometrage = 20000, Carburant = "Essence", Transmission = "Manuelle",
                                        Couleur = "Rouge", DescriptionVehicule = "Économique et fiable.", DateMiseEnVente = DateTime.Now.AddDays(-15) },

                new VehiculeDoccasion {id_Vehicule = 3, Marque = "Ford", Modele = "Mustang", AnneFab = 2022, Prix = 40000.00m, 
                                        Kilometrage = 1000, Carburant = "Essence", Transmission = "Automatique", Couleur = "Noir", 
                                       DescriptionVehicule = "Voiture de sport puissante.", DateMiseEnVente = DateTime.Now.AddDays(-45) } );



            // Données d'exemple pour l'entités Annonce
            modelBuilder.Entity<Annonce>().HasData(
            new Annonce
            {
               
                id_Annance = 1,
                DescriptionAnnonce = "Belle voiture d'occasion à vendre.",
                Prix = 15000.00m,
                DateMiseEnLigne = DateTime.Now.AddDays(-10),
                Nom = "Dupont", Prenom = "Jean ",
                NumeroTelephone = "123-456-7890",
                Email = "jean.dupont@example.com",
                ImageURL = "https://www.bing.com/ck/a?!&&p=d68ee4752550c699JmltdHM9MTY5MjQ4OTYwMCZpZ3VpZD0wZDkxMjQ0Yy0xZWRjLTZjZDgtMmRmNi0zNzUxMWYxNzZkMDgmaW5zaWQ9NTU3NA&ptn=3&hsh=3&fclid=0d91244c-1edc-6cd8-2df6-37511f176d08&u=a1L2ltYWdlcy9zZWFyY2g_cT1pbWFnZSB0b3lvdGEgY29yb2xhIGJsZXUmRk9STT1JUUZSQkEmaWQ9OTREMUIxNDYxQTg4ODA5OTMxMkE4ODBDRjdBRDRDNkMxNzJBODdCNA&ntb=1",
                id_Vehicule = 1  // L'ID du véhicule d'occasion auquel cette annonce est liée
               
            },

           new Annonce
           {
               
               id_Annance = 2,
               DescriptionAnnonce = "Voiture familiale spacieuse en bon état.",
               Prix = 18000.00m,
               DateMiseEnLigne = DateTime.Now.AddDays(-15),
               Nom = "Martin", Prenom = " Alice ",
               NumeroTelephone = "987-654-3210",
               Email = "alice.martin@example.com",
               ImageURL = "https://www.bing.com/ck/a?!&&p=f7da2d3084d58b6aJmltdHM9MTY5MjQ4OTYwMCZpZ3VpZD0wZDkxMjQ0Yy0xZWRjLTZjZDgtMmRmNi0zNzUxMWYxNzZkMDgmaW5zaWQ9NTUwNg&ptn=3&hsh=3&fclid=0d91244c-1edc-6cd8-2df6-37511f176d08&u=a1L2ltYWdlcy9zZWFyY2g_cT1pbWFnZSBvbmRhIGNpdmljIHJvdWdlJkZPUk09SVFGUkJBJmlkPUNEOUQ4OUE1OUE5NTYzRTVEOTgyMDQ1NjlGMkNBMEY2RDJCN0NCNTk&ntb=1",
               id_Vehicule = 2  
           },

            new Annonce
            {
                
                id_Annance = 3,
                DescriptionAnnonce = "Véhicule économique idéal pour la ville.",
                Prix = 40000.00m,
                DateMiseEnLigne = DateTime.Now.AddDays(-5),
                Nom = "Anderson", Prenom = "Cedric",
                NumeroTelephone = "555-123-4567",
                Email = "cedric.anderson@example.com",
                ImageURL = "https://www.bing.com/ck/a?!&&p=4ed3fa001699c42aJmltdHM9MTY5MjQ4OTYwMCZpZ3VpZD0wZDkxMjQ0Yy0xZWRjLTZjZDgtMmRmNi0zNzUxMWYxNzZkMDgmaW5zaWQ9NTUxMw&ptn=3&hsh=3&fclid=0d91244c-1edc-6cd8-2df6-37511f176d08&u=a1L2ltYWdlcy9zZWFyY2g_cT1pbWFnZSBmb3J0IG11c3RhbmQgbm9pcmUmRk9STT1JUUZSQkEmaWQ9QkY0RjEzMkE2QkRGOUE2NTQ1NTE1NERERTVCRjA2NjY0RTdDQ0NFMQ&ntb=1",
                id_Vehicule = 3  
            });;
        }
    }

}

