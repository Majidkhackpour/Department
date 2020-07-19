using EntityCache.Core;
using EntityCache.SqlServerPersistence;
using Persistence.Model;

namespace EntityCache.Assistence
{
    public static class UnitOfWork
    {
        private static readonly ModelContext db = new ModelContext();
        private static IUsersRepository _usersRepository;
        public static void Dispose()
        {
            db?.Dispose();
        }
        public static void Set_Save()
        {
            db.SaveChanges();
        }

        public static IUsersRepository Users => _usersRepository ??
                                                (_usersRepository =
                                                    new UsersPersistenceRepository(db));
    }
}
