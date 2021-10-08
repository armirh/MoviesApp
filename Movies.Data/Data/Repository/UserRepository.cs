using Movies.Data.Data.Repository.IRepository;
using Movies.Data.Repository;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Data.Data.Repository
{
   public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
