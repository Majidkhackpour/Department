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
    public class SafeBoxBussines : ISafeBox
    {
        public string Name { get; set; }
        public EnSafeBox Type { get; set; }
        public string TypeName => Type.GetDisplay();
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;
        public bool Status { get; set; }



        public static async Task<SafeBoxBussines> GetAsync(Guid guid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Services.Utilities.WebApi + "/SafeBox_Get/" + guid);
                    var user = res.FromJson<SafeBoxBussines>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static async Task<List<SafeBoxBussines>> GetAllAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Services.Utilities.WebApi + "/SafeBox_GetAll");
                    var user = res.FromJson<List<SafeBoxBussines>>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static List<SafeBoxBussines> GetAll() => AsyncContext.Run(GetAllAsync);
        public static SafeBoxBussines Get(Guid guid) => AsyncContext.Run(() => GetAsync(guid));
        public static async Task<ReturnedSaveFuncInfo> SaveAsync(SafeBoxBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Services.Utilities.WebApi + "/api/SafeBox/SaveAsync", content);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }
        public static async Task<ReturnedSaveFuncInfo> ChangeStatusAsync(SafeBoxBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Services.Utilities.WebApi + "/api/SafeBox/SaveAsync", content);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }
        public static List<SafeBoxBussines> GetAllBank() =>
            (AsyncContext.Run(GetAllAsync))?.Where(q => q.Type == EnSafeBox.Bank)?.ToList();
        public static List<SafeBoxBussines> GetAllSandouq() =>
            (AsyncContext.Run(GetAllAsync))?.Where(q => q.Type == EnSafeBox.Sandouq)?.ToList();
        public static async Task<SafeBoxBussines> GetAsync(string name)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Services.Utilities.WebApi + "/SafeBox_GetByName/" + name);
                    var user = res.FromJson<SafeBoxBussines>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static SafeBoxBussines Get(string name) => AsyncContext.Run(() => GetAsync(name));
    }
}
