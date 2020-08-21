using System;
using System.Linq;
using System.Threading.Tasks;
using EntityCache.Bussines;
using EntityCache.Core;
using Persistence.Entities;
using Persistence.Model;
using Services;

namespace EntityCache.SqlServerPersistence
{
    public class ProductPersistenceRepository : GenericRepository<ProductBussines, Products>, IProductRepository
    {
        ModelContext db;
        public ProductPersistenceRepository(ModelContext _db) : base(_db)
        {
            db = _db;
        }

        public async Task<string> NextCodeAsync()
        {
            var str = "";
            try
            {
                var all =await GetAllAsync();
                if (all.Count <= 0)
                {
                    str = "1001";
                    return str;
                }

                var code = all.ToList()?.Max(q => long.Parse(q.Code)) ?? 0;
                str = (code + 1).ToString();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }

            return str;
        }
    }
}
