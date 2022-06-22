using Microsoft.EntityFrameworkCore;
using MovieTicket.Models;

namespace MovieTicket.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Actor actor = _context.Actors.Find(id);
            _context.Actors.Remove(actor);
        }

        public Actor GetById(int id)
        {
            return _context.Actors.Find(id);
        }

        public void Update(int id, Actor newActor)
        {
            Actor actorInDb = _context.Actors.FirstOrDefault(x => x.Id == id);
            if (actorInDb == null)
                return;
            actorInDb.FullName = newActor.FullName;
            _context.Actors.Update(actorInDb);
            _context.SaveChanges();
        }

        public IEnumerable<Actor> GetAll()
        {
            return _context.Actors.ToList();
        }
    }
}


