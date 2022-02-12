using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Cinemaa
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Logo is required")]
        public string Logo { get; set; }
        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Nom is required")]
        public string Nom { get; set; }
        [Display(Name = "Decription")]
        [Required(ErrorMessage = "Decription is required")]
        public string Description { get; set; }
        public List<Film> Films { get; set; }
    }
}
