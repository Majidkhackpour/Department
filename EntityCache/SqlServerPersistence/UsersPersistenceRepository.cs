using EntityCache.Bussines;
using EntityCache.Core;
using Persistence.Entities;
using Persistence.Model;

namespace EntityCache.SqlServerPersistence
{
    public class UsersPersistenceRepository : GenericRepository<UsersBussines, Users>, IUsersRepository
    {
        private ModelContext db;
        public UsersPersistenceRepository(ModelContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
