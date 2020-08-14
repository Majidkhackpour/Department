using EntityCache.Bussines;
using EntityCache.Core;
using Persistence.Entities;
using Persistence.Model;

namespace EntityCache.SqlServerPersistence
{
    public class ProductPersistenceRepository : GenericRepository<ProductBussines, Products>, IProductRepository
    {
        ModelContext db;
        public ProductPersistenceRepository(ModelContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
