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
    public class CustomerLogBussines : ICustomerLog
    {
        public DateTime Date { get; set; }
        public string DateSh => Calendar.MiladiToShamsi(Date);
        public string Time => Date.ToShortTimeString();
        public Guid CustomerGuid { get; set; }
        public EnCustomerLogType Side { get; set; }
        public string SideName => Side.GetDisplay();
        public string Description { get; set; }
        public Guid Parent { get; set; }
        public decimal Price { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }

        public static async Task<List<CustomerLogBussines>> GetAllAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Services.Utilities.WebApi + "/CustomerLog_GetAll");
                    var user = res.FromJson<List<CustomerLogBussines>>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static List<CustomerLogBussines> GetAll() => AsyncContext.Run(GetAllAsync);
        public static async Task<ReturnedSaveFuncInfo> SaveAsync(CustomerLogBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Services.Utilities.WebApi + "/api/CustomerLog/SaveAsync", content);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }
        public static async Task<CustomerLogBussines> GetLogAsync(Guid parentGuid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Services.Utilities.WebApi + "/CustomerLog_GetLog/" + parentGuid);
                    var user = res.FromJson<CustomerLogBussines>();
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
