using MovieTicket.Models;

namespace MovieTicket.Data.Services
{
    public interface IActorService
    {
        IEnumerable<Actor> GetAll();

        Actor GetById(int id);

        void Add(Actor actor);
        void Update(int id, Actor newActor);

        void Delete(int id);
    }
}
