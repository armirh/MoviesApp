using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Models.ViewModels
{
   public class OrderListVM
    {
        public IEnumerable<Order> Orders { get; set; }
    }
}
