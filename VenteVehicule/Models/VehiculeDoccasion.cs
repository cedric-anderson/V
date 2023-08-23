using System.ComponentModel.DataAnnotations;

namespace VenteVehicule.Models
{
    public class VehiculeDoccasion
    {
        [Key]
        public int id_Vehicule { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public Decimal Prix { get; set; }
        public int AnneFab { get; set; }
        public int Kilometrage { get; set; }
        public string Carburant { get; set; }
        public string Transmission { get; set; }
        public string Couleur { get; set; }
        public string DescriptionVehicule { get; set; }
        public DateTime DateMiseEnVente { get; set; }

        // Collection d'objet Annonce
        public ICollection<Annonce> Annonces { get; set; }
        
    }
}


