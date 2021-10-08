using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Movies.Models
{
   public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
       // [Required]
        public string ImagePath { get; set; }

        public int Duration { get; set; }

        public int Year { get; set; }

        public double Rating { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public DateTime Created { get; set; }
        public double Price { get; set; }
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
    }
}
