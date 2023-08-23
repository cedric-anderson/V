using VenteVehicule.Models;
using VenteVehicule.Repository;

namespace VenteVehicule.Repository
{
    public class VehiculeOccasRepository : IVehiculeOccasRepository
    {
        private readonly AppDbContext _appDbContext;

        public VehiculeOccasRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<VehiculeDoccasion> GetAllVehiculeDoccasions()
        {
            return _appDbContext.VehiculeDoccasions;
        }

        public VehiculeDoccasion GetVehiculeDoccasionById(int id)
        {
            return _appDbContext.VehiculeDoccasions.FirstOrDefault(v => v.id_Vehicule == id);
        }
    }
}
