using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EntityCache.Bussines;

namespace EntityCache.Core
{
    public interface ICustomerLogRepository : IRepository<CustomerLogBussines>
    {
        Task<List<CustomerLogBussines>> GetAllAsync(Guid cusGuid);
    }
}
