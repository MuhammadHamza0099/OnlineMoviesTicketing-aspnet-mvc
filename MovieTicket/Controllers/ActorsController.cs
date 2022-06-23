using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicket.Data;
using MovieTicket.Data.Services;
using MovieTicket.Models;
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
        // Get Request // Create Actor
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var actorsDetails = await _service.GetByIdAsync(id);
            return actorsDetails == null ? NotFound() : View(actorsDetails);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var actorsDetails = await _service.GetByIdAsync(id);
            return actorsDetails == null ? NotFound() : View(actorsDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int Id, [Bind("Id,FullName,ProfilePictureUrl,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(Id , actor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var actorsDetails = await _service.GetByIdAsync(id);
            return actorsDetails == null ? NotFound() : View(actorsDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorsDetails = await _service.GetByIdAsync(id);
            if(actorsDetails == null) return NotFound();
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
