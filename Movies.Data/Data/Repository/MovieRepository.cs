using Movies.Data.Data.Repository.IRepository;
using Movies.Data.Repository;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movies.Data.Data.Repository
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        private readonly ApplicationDbContext _db;

        public MovieRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Movie movie)
        {
            var moviefrom = _db.Movies.FirstOrDefault(s => s.Id == movie.Id);
            moviefrom.Title = movie.Title;
            moviefrom.Year = movie.Year;
            moviefrom.Rating = movie.Rating;
            moviefrom.Director = movie.Director;
            moviefrom.Actors = movie.Actors;
            moviefrom.GenreId = movie.GenreId;
            moviefrom.Price = movie.Price;
            //postfrom.Content = post.Content;
            _db.SaveChanges();
        }
    }
}
