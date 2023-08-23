using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VenteVehicule.Controllers;
using VenteVehicule.Models;


namespace VenteVehicule.Controllers
{
    public class AnnonceController : Controller
    {
        private readonly AppDbContext _context;

        public AnnonceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult ListAnnonces()
        {
            var annonces = _context.Annonces.Include(a => a.VehiculeDoccasion).ToList();
            return View(annonces);
        }

        private object Include(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}