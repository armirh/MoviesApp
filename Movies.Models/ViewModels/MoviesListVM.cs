using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Models.ViewModels
{
   public class MoviesListVM
    {
        public Genre Genre { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
