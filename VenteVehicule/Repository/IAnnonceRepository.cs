using VenteVehicule.Models;

namespace VenteVehicule.Repository
{
    public interface IAnnonceRpository
    {
        IEnumerable<Annonce> GetAllAnnonces();
        Annonce GetAnnonceById(int id);
    }
}
