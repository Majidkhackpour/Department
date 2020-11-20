using Services;
using Servicess.Interfaces.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Nito.AsyncEx;

namespace DepartmentDal.Classes
{
    public class SmsLogBussines : ISmsLog
    {
        private List<UserBussines> listUsers;
        public DateTime Date { get; set; }
        public Guid UserGuid { get; set; }
        public string Sender { get; set; }
        public string Reciver { get; set; }
        public string Message { get; set; }
        public decimal Cost { get; set; }
        public long MessageId { get; set; }
        public string StatusText { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
        public string UserName
        {
            get
            {
                if (listUsers == null) listUsers = AsyncContext.Run(UserBussines.GetAllAsync);
                return listUsers.FirstOrDefault(q => q.Guid == UserGuid)?.Name;
            }
        }

        public static async Task<SmsLogBussines> GetAsync(Guid guid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/SmsLog_Get/" + guid);
                    var user = res.FromJson<SmsLogBussines>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static async Task<SmsLogBussines> GetAsync(long messageId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/SmsLog_GetByMessageId/" + messageId);
                    var user = res.FromJson<SmsLogBussines>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static SmsLogBussines Get(Guid guid) => AsyncContext.Run(() => GetAsync(guid));
        public static async Task<ReturnedSaveFuncInfo> SaveAsync(SmsLogBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Utilities.WebApi + "/api/SmsLog/SaveAsync", content);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }
        public static async Task<List<SmsLogBussines>> GetAllAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/SmsLog_GetAll");
                    var user = res.FromJson<List<SmsLogBussines>>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
    }
}
