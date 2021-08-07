using Services;
using Servicess.Interfaces.Department;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Nito.AsyncEx;

namespace DepartmentDal.Classes
{
    public class ProductBussines : IProduct
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public decimal BckUpPrice { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;
        public bool Status { get; set; }
        public bool IsChecked { get; set; }

        public static async Task<ProductBussines> GetAsync(Guid guid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Services.Utilities.WebApi + "/Products_Get/" + guid);
                    var user = res.FromJson<ProductBussines>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static async Task<List<ProductBussines>> GetAllAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Services.Utilities.WebApi + "/Products_GetAll");
                    var user = res.FromJson<List<ProductBussines>>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static List<ProductBussines> GetAll() => AsyncContext.Run(GetAllAsync);
        public static ProductBussines Get(Guid guid) => AsyncContext.Run(() => GetAsync(guid));
        public static async Task<string> NextCodeAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Services.Utilities.WebApi + "/Products_NextCode");
                    var user = res.FromJson<string>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static string NextCode() => AsyncContext.Run(NextCodeAsync);
        public static async Task<ReturnedSaveFuncInfo> SaveAsync(ProductBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Services.Utilities.WebApi + "/api/Product/SaveAsync", content);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }
        public static ReturnedSaveFuncInfo Save(ProductBussines cls) => AsyncContext.Run(() => SaveAsync(cls));
    }
}
