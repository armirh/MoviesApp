using Movies.Data.Data.Repository.IRepository;
using Movies.Data.Repository;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Data.Data.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Order Order)
        {
            throw new NotImplementedException();
        }
    }
}
