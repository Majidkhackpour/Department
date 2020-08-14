using EntityCache.Bussines;
using EntityCache.Core;
using Persistence.Entities;
using Persistence.Model;

namespace EntityCache.SqlServerPersistence
{
    public class SafeBoxPersistenceRepository : GenericRepository<SafeBoxBussines, SafeBox>, ISafeBoxRepository
    {
        private ModelContext db;
        public SafeBoxPersistenceRepository(ModelContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
