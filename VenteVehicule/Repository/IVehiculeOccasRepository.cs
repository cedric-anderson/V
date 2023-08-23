using VenteVehicule.Models;

namespace VenteVehicule.Repository
{
    public interface IVehiculeOccasRepository
    {
        IEnumerable<VehiculeDoccasion> GetAllVehiculeDoccasions();
        VehiculeDoccasion GetVehiculeDoccasionById(int id);

    }
}