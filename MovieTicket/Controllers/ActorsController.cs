using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicket.Data;
using MovieTicket.Data.Services;
using System.Linq;

namespace MovieTicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _service;
       // private AppDbContext context;

        public ActorsController(IActorService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = _service.GetAll();
            return View(data);
        }
    }
}
