using Movies.Data.Data.Repository.IRepository;
using Movies.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Data.Data.Repository
{
   public class UnitofWork : IUnitofWork
    {
        private readonly ApplicationDbContext _db;
        public UnitofWork(ApplicationDbContext db)
        {

            _db = db;
            Genre = new GenreRepository(_db);
            Movie = new MovieRepository(_db);
            Order = new OrderRepository(_db);
           
            
            User = new UserRepository(_db);
        }
        public IGenreRepository Genre { get; private set; }
        public IMovieRepository Movie { get; private set; }
        public IOrderRepository Order { get; private set; }
       
        public IUserRepository User { get; private set; }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
