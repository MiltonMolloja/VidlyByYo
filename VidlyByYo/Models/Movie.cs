using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidlyByYo.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name ="Nombre")]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genero")]
        public byte GenreId { get; set; }

        [Display(Name = "Fecha de Lanzamiento")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Añadido el Dia")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Stock")]
        public byte NumberInStock { get; set; }

    }
}