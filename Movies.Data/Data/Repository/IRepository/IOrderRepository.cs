﻿using Movies.Data.Repository.IRepository;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Data.Data.Repository.IRepository
{
  public  interface IOrderRepository:IRepository<Order>
    {
        void Update(Order Order);
    }
}
