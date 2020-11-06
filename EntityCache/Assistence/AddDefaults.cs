using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using EntityCache.Bussines;
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


            #region Users

            var allusers = await UsersBussines.GetAllAsync();
            if (allusers == null || allusers.Count <= 0)
            {
                var user = new UsersBussines()
                {
                    Guid = Guid.NewGuid(),
                    Name = "مجید خاکپور",
                    UserName = "Admin",
                    Email = "arad_enj@yahoo.com",
                    IsBlock = false,
                    Mobile = "9382420272",
                    Modified = DateTime.Now,
                    Status = true,
                    Type = EnUserType.Manager
                };
                var ue = new UTF8Encoding();
                var bytes = ue.GetBytes("9382420272");
                var md5 = new MD5CryptoServiceProvider();
                var hashBytes = md5.ComputeHash(bytes);
                user.Password = System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(hashBytes), "-", "")
                    .ToLower();
                res.AddReturnedValue(await user.SaveAsync());
                res.ThrowExceptionIfError();
            }
            #endregion


            await dbContext.SaveChangesAsync();
            dbContext.Dispose();
        }
    }
}
