﻿using EntityCache.Bussines;
using EntityCache.Core;
using Persistence.Entities;
using Persistence.Model;

namespace EntityCache.SqlServerPersistence
{
    public class CustomerPersistenceRepository : GenericRepository<CustomerBussines, Customer>, ICustomerRepository
    {
        private ModelContext db;
        public CustomerPersistenceRepository(ModelContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
