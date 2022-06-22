using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicket.Data;

namespace MovieTicket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        //private AppDbContext context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
