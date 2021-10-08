using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Models.ViewModels
{
   public class GenreVM
    {
        public Genre Genre { get; set; }
        public IFormFile File { get; set; }
    }
}
