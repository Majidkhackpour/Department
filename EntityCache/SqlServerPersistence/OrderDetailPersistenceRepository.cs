using EntityCache.Bussines;
using EntityCache.Core;
using Persistence.Entities;
using Persistence.Model;

namespace EntityCache.SqlServerPersistence
{
    public class OrderDetailPersistenceRepository : GenericRepository<OrderDetailBussines, OrderDetail>, IOrderDetailRepository
    {
        private ModelContext db;
        public OrderDetailPersistenceRepository(ModelContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
