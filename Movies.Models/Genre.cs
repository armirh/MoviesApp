using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Models
{
   public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

       // [Required]
        public string ImagePath { get; set; }

       // public DateTime Created { get; set; }

        public virtual IEnumerable<Movie> Movies { get; set; }
    }
}
