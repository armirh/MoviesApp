using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Movies.Models
{
   public class Order
    {
        [Key]
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Created { get; set; }

        public virtual ApplicationUser User { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }
    }
}
