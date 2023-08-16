﻿using Core.DataAccess.Concrete.EF;
using Entities.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EF.Abstract
{
    public class OrderRepositoryBase : EfEntityRepositoryBase<Order>
    {
        public OrderRepositoryBase(DbContext db) : base(db)
        {
        }
    }
}
