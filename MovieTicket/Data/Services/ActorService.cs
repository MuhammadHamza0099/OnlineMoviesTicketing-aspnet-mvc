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

        public async Task DeleteAsync(int id)
        {
            var results = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
           // Actor actor = _context.Actors.Find(id);
            _context.Actors.Remove(results);
            await _context.SaveChangesAsync();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var results =await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return results;
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

        public async Task UpdateAsync(int id, Actor actor)
        {
            Actor actorInDb = _context.Actors.FirstOrDefault(x => x.Id == id);
            if (actorInDb == null)
                return;
            actorInDb.ProfilePictureUrl= actor.ProfilePictureUrl;
            actorInDb.FullName = actor.FullName;
            actorInDb.Bio = actor.Bio;
            _context.Actors.Update(actorInDb);
            await _context.SaveChangesAsync();
        }

        void IActorService.Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public async Task UpdateAsync(Actor actor)
        {
           await _context.Actors.AddAsync(actor);
            _context.SaveChanges();
        }
    }
}


