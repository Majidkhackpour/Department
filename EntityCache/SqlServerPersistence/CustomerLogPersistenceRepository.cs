using EntityCache.Bussines;
using EntityCache.Core;
using Persistence.Entities;
using Persistence.Model;

namespace EntityCache.SqlServerPersistence
{
    public class CustomerLogPersistenceRepository : GenericRepository<CustomerLogBussines, CustomerLog>, ICustomerLogRepository
    {
        private ModelContext db;
        public CustomerLogPersistenceRepository(ModelContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
