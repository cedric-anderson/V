using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VenteVehicule.Models
{
    public class Acheteur
    {
        [Key]
        public int id_Acheteur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NumeroTelephone { get; set; }
        public string Email { get; set; }
        public string NoteEvaluation { get; set; }
        public string NCompteBancaire { get; set; }
        public string Transaction { get; set; }
        public string HistoriqAchat { get; set; }
        public string AddressAchetur { get; set; }



    // Collection des objets de la Vendeur et Annonce
    public ICollection<Vendeur> Vendeurs { get; set; }
    public ICollection<Annonce> Annonces { get; set; }
    }
}
