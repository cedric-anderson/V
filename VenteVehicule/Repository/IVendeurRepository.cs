using VenteVehicule.Models;

namespace VenteVehicule.Repository
{
    public interface IVendeurRepository
    {
        IEnumerable<Vendeur> GetAllVendeurs();
        Vendeur GetVendeurById(int id);
    }
}
