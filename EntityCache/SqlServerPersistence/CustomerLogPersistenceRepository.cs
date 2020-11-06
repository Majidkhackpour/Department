using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityCache.Assistence;
using EntityCache.Bussines;
using EntityCache.Core;
using Persistence.Entities;
using Persistence.Model;
using Services;

namespace EntityCache.SqlServerPersistence
{
    public class CustomerLogPersistenceRepository : GenericRepository<CustomerLogBussines, CustomerLog>, ICustomerLogRepository
    {
        private ModelContext db;
        public CustomerLogPersistenceRepository(ModelContext _db) : base(_db)
        {
            db = _db;
        }

        public async Task<List<CustomerLogBussines>> GetAllAsync(Guid cusGuid)
        {
            try
            {
                var acc = db.CustomerLog.AsNoTracking().Where(q => q.CustomerGuid == cusGuid);
                var ret = Mappings.Default.Map<List<CustomerLogBussines>>(acc);
                return ret;
            }
            catch (Exception exception)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(exception);
                return null;
            }
        }
    }
}
