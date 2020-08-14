using EntityCache.Bussines;
using EntityCache.Core;
using Persistence.Entities;
using Persistence.Model;

namespace EntityCache.SqlServerPersistence
{
    public class PanelLineNumberPersistenceRepository : GenericRepository<PanelLineNumberBussines, PanelLineNumbers>, IPanelLineNumberRepository
    {
        private ModelContext db;
        public PanelLineNumberPersistenceRepository(ModelContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
