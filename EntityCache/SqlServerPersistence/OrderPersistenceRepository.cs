using EntityCache.Bussines;
using EntityCache.Core;
using Persistence.Entities;
using Persistence.Model;

namespace EntityCache.SqlServerPersistence
{
    public class OrderPersistenceRepository : GenericRepository<OrderBussines, Order>, IOrderRepository
    {
        private ModelContext db;
        public OrderPersistenceRepository(ModelContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
