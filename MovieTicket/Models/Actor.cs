using System.ComponentModel.DataAnnotations;

namespace MovieTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display (Name = "Profile Picture Url")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "BioGraphy")]
        public string Bio { get; set; }
        public virtual List<Movie> Movies { get; set; }

        public Actor()
        {
            Movies = new List<Movie>();
        }
    }
}
