using System.ComponentModel.DataAnnotations;

namespace MovieTicket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "ProfilePictureUrl")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "BioGraphy")]
        public string Bio { get; set; }

        // RelationShip
        public List<Movie> Movies { get; set; }

        public Producer()
        {
            Movies= new List<Movie>();
        }
    }
}
