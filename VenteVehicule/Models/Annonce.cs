using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VenteVehicule.Models
{
    public class Annonce
    {
        [Key]
        public int id_Annance { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NumeroTelephone { get; set; }
        public string Email { get; set; }
        public Decimal Prix { get; set; }
        public string DescriptionAnnonce { get; set; }
        public DateTime DateMiseEnLigne { get; set; }
        public string ImageURL { get; set; }



        // Clés étrangère 
        [ForeignKey("VehiculeDoccasion")]
         public int id_Vehicule { get; set; }
        [ForeignKey("Vendeur")]
        public int id_Vendeur { get; set; }
        [ForeignKey("Acheteur")]
        public int id_Acheteur { get; set; }


        // Navigation vers l'entité VehiculeOccasion
        public VehiculeDoccasion VehiculeDoccasion { get; set; }
        public Vendeur Vendeur { get; set; }
        public Acheteur Acheteur { get; set;}

    }
}
