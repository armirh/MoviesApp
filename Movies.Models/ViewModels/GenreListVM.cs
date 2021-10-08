using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Models.ViewModels
{
   public class GenreListVM
    {
        public IEnumerable<Genre> Genres { get; set; }
    }
}
