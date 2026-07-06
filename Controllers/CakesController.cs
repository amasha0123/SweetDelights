using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SweetDelights.Data;

namespace SweetDelights.Controllers
{
    public class CakesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CakesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cakes
        public async Task<IActionResult> Index()
        {
            var cakes = await _context.Cakes.Where(c => c.IsAvailable).ToListAsync();
            return View(cakes);
        }

        // GET: Cakes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cake = await _context.Cakes
                .FirstOrDefaultAsync(m => m.CakeId == id);
            
            if (cake == null)
            {
                return NotFound();
            }

            return View(cake);
        }
    }
}
