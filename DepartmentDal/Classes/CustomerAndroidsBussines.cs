using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Nito.AsyncEx;
using Services;
using Services.Interfaces.Department;

namespace DepartmentDal.Classes
{
    public class CustomerAndroidsBussines : IAndroids
    {
        public Guid Guid { get; set; }
        public Guid CustomerGuid { get; set; }
        public string IMEI { get; set; }
        public string Name { get; set; }


        public static async Task<List<CustomerAndroidsBussines>> GetAllAsync(Guid cusGuid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/CusAndroid_GetAll/" + cusGuid);
                    var user = res.FromJson<List<CustomerAndroidsBussines>>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static async Task<CustomerAndroidsBussines> GetAsync(Guid guid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/CusAndroid_Get/" + guid);
                    var user = res.FromJson<CustomerAndroidsBussines>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static List<CustomerAndroidsBussines> GetAll(Guid cusGuid) => AsyncContext.Run(() => GetAllAsync(cusGuid));
        public static CustomerAndroidsBussines Get(Guid guid) => AsyncContext.Run(() => GetAsync(guid));
        public static async Task<ReturnedSaveFuncInfo> SaveAsync(CustomerAndroidsBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Utilities.WebApi + "/api/CustomerAndroid/SaveAsync", content);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }
    }
}
