using System.ComponentModel.DataAnnotations;

namespace MovieTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display (Name = "Profile Picture Url")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        public string FullName { get; set; }

        [Display(Name = "BioGraphy")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }
        public virtual List<Movie> Movies { get; set; }

        public Actor()
        {
            Movies = new List<Movie>();
        }
    }
}
