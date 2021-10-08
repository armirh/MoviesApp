using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Models.ViewModels
{
   public class OrderVM
    {
        public Order Order { get; set; }
        public Movie Movie { get; set; }

        public string Tax { get; set; }
    }
}
