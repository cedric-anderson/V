using VenteVehicule.Models;

namespace VenteVehicule.Repository
{
    public class AnnonceRepository : IAnnonceRpository
    {
        private readonly AppDbContext _appDbContext;

        public AnnonceRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Annonce> GetAllAnnonces()
        {
            return _appDbContext.Annonces;
        }

        public Annonce GetAnnonceById(int id)
        {
            return _appDbContext.Annonces.FirstOrDefault(a => a.id_Annance == id);
        }
    }
}
