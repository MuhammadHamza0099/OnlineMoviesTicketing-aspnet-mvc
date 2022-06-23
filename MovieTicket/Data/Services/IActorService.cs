using MovieTicket.Models;

namespace MovieTicket.Data.Services
{
    public interface IActorService
    {
        IEnumerable<Actor> GetAll();

        Task<Actor> GetByIdAsync(int id);

        void Add(Actor actor);
        void Update(int id, Actor newActor);

        Task DeleteAsync(int id);
        Task UpdateAsync(int id, Actor actor);
        Task UpdateAsync(Actor actor);
    }
}
