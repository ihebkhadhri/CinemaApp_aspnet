using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Producteur
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Image Profil")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilImageUrl { get; set; }
        [Display(Name = "Nom Complet")]
        [Required(ErrorMessage = "Full Name is required")]
        public string NomComplet { get; set; }
        [Display(Name = "Biographie")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
        public List<Film> Films { get; set; }
    }
}
