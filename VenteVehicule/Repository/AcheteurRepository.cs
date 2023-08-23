using VenteVehicule.Models;

namespace VenteVehicule.Repository
{
    public class AcheteurRepository : IAcheteurRepository
    {
        private readonly AppDbContext _appDbContext;

        public AcheteurRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Acheteur> GetAllAcheteurs()
        {
            return _appDbContext.Acheteurs;
        }

        public Vendeur GetAcheteurById(int id)
        {
            return _appDbContext.Vendeurs.FirstOrDefault(ach => ach.id_Vendeur == id);
        }

    }
}
