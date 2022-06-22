using MovieTicket.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicket.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public string CinemaName { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public string MovieProducer { get; set; }


        // RelationShip

        public virtual List<Actor> Actors { get; set; }

        // Cinema
        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }
        

        public Cinema Cinema { get; set; }

        // Producer
        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }

        public Producer Producer { get; set; }

        public Movie()
        {
            Actors = new List<Actor>();
        }
    }
}
