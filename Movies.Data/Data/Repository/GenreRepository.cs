using Microsoft.AspNetCore.Mvc.Rendering;
using Movies.Data.Data.Repository.IRepository;
using Movies.Data.Repository;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movies.Data.Data.Repository
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        private readonly ApplicationDbContext _db;

        public GenreRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetDropDown()
        {
            return _db.Genres.Select(m => new SelectListItem()
            {
                Text = m.Title,
                Value = m.Id.ToString()
            });
        }

        public void Update(Genre genre)
        {
            var genrefrom = _db.Genres.FirstOrDefault(s => s.Id == genre.Id);
            genrefrom.Title = genre.Title;
            //postfrom.Content = post.Content;
            _db.SaveChanges();
        }
    }
}
