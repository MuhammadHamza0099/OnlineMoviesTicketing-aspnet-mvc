using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicket.Data;

namespace MovieTicket.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        //private readonly AppDbContext context;

        //private AppDbContext context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
