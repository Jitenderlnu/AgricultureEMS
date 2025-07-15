using AgricultureEMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgricultureEMS.Controllers
{
    public class CropsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CropsController(ApplicationDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            var crops = _context.Crops.Include(c => c.Field);
            return View(await crops.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewBag.Fields = _context.Fields.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Crop crop)
        {
            if (ModelState.IsValid)
            {
                _context.Crops.Add(crop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Fields = _context.Fields.ToList();
            return View(crop);
        }
        // Add Edit, Delete, Details actions similarly
    }
}