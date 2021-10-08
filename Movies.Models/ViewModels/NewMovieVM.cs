using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Models.ViewModels
{
   public class NewMovieVM
    {
        public Movie Movie { get; set; }
        public IFormFile File { get; set; }
        public IEnumerable<SelectListItem> GetGenres { get; set; }
    }
}
