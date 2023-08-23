using VenteVehicule.Models;

namespace VenteVehicule.Repository
{
    public class VendeurRepository : IVendeurRepository
    {
        private readonly AppDbContext _appDbContext;

        public VendeurRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Vendeur> GetAllVendeurs()
        {
            return _appDbContext.Vendeurs;
        }

        public Vendeur GetVendeurById(int id)
        {
            return _appDbContext.Vendeurs.FirstOrDefault(ven => ven.id_Vendeur == id);
        }     
    }
}
