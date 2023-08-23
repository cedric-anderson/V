using VenteVehicule.Models;

namespace VenteVehicule.Repository
{
    public interface IAcheteurRepository
    {
        public interface IAcheteurRepository
        {
            IEnumerable<Acheteur> GetAllAcheteurs();
            Acheteur GetAcheteurById(int id);
        }
    }
}
