using EntityCache.Bussines;
using EntityCache.Core;
using Persistence.Entities;
using Persistence.Model;

namespace EntityCache.SqlServerPersistence
{
    public class SmsLogPersistenceRepository : GenericRepository<SmsLogBussines, SmsLog>, ISmsLogRepository
    {
        private ModelContext db;
        public SmsLogPersistenceRepository(ModelContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
