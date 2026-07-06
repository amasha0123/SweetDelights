using Microsoft.AspNetCore.Mvc;
using SweetDelights.Data;
using SweetDelights.Models;

namespace SweetDelights.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Contact
        public IActionResult Index()
        {
            return View();
        }

        // POST: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Name,Email,Phone,Message")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Thank you for contacting us! We will get back to you soon.";
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }
    }
}
