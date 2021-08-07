using Services;
using Servicess.Interfaces.Department;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Nito.AsyncEx;

namespace DepartmentDal.Classes
{
    public class UserLogBussines : IUserLog
    {
        public DateTime Date { get; set; }
        public string DateSh => Calendar.MiladiToShamsi(Date);
        public Guid UserGuid { get; set; }
        public EnLogType Type { get; set; }
        public string TypeName => Type.GetDisplay();
        public string Description { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }

        public static async Task<List<UserLogBussines>> GetAllAsync(Guid userGuid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var req = Services.Utilities.WebApi + "/UserLog_GetAll/" + userGuid ;
                    var res = await client.GetStringAsync(req);
                    var user = res.FromJson<List<UserLogBussines>>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static List<UserLogBussines> GetAll(Guid userGuid) => AsyncContext.Run(() => GetAllAsync(userGuid));

    }
}
