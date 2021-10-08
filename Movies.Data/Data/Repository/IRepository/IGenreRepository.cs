using Microsoft.AspNetCore.Mvc.Rendering;
using Movies.Data.Repository.IRepository;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Data.Data.Repository.IRepository
{
  public  interface IGenreRepository : IRepository<Genre>
    {
        IEnumerable<SelectListItem> GetDropDown();
        void Update(Genre genre);
    }
}
