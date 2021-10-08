using Movies.Data.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Data.Repository.IRepository
{
   public interface IUnitofWork : IDisposable
    {
        IGenreRepository Genre { get; }
        IMovieRepository Movie { get; }
        IOrderRepository Order { get; }
        IUserRepository User { get; }
        void Save();
    }
}
