using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VenteVehicule.Models
{
    public class Vendeur
    {
        [Key]
        public int id_Vendeur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NumeroTelephone { get; set; }
        public string Email { get; set; }
        public string AddressVendeur { get; set; }

        // Clé etrangere qui fais reference a la classe Acheteur
        [ForeignKey("Acheteur")]
        public int id_Acheteur { get; set; }
        public Acheteur Acheteur { get; set; }


        //Collection des objets de la classe Annonce
        public ICollection<Annonce> Annonces { get; set; }

    }
}
