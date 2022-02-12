using Cinema.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Nom is required")]
        public string Nom { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Display(Name = "Prix")]
        [Required(ErrorMessage = "Prix is required")]
        public double Price { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Image is required")]
        public string ImageUrl { get; set; }
        [Display(Name = "Date début")]
        [Required(ErrorMessage = "Date Début is required")]
        public DateTime DateDebut { get; set; }
        [Display(Name = "Date fin")]
        [Required(ErrorMessage = "Date fin is required")]
        public DateTime Datefin { get; set; }
        public CategorieFilm CategorieFilm { get; set; }
        public List<Acteur_Film> Acteur_Films { get; set; }
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinemaa Cinema { get; set; }
        public int ProducteurId { get; set; }
        [ForeignKey("ProducteurId")]
        public Producteur Producteur { get; set; }
    }
}
