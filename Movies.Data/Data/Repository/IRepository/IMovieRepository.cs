using Movies.Data.Repository.IRepository;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Data.Data.Repository.IRepository
{
   public interface IMovieRepository : IRepository<Movie>
    {
        void Update(Movie movie);
    }
}
