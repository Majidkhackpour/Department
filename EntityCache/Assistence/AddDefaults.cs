using System.Threading.Tasks;
using Persistence.Model;
using Services;

namespace EntityCache.Assistence
{
    public class AddDefaults
    {
        public static async Task InsertDefaultDataAsync()
        {
            var dbContext = new ModelContext();
            var res = new ReturnedSaveFuncInfo();

            await dbContext.SaveChangesAsync();
            dbContext.Dispose();
        }
    }
}
