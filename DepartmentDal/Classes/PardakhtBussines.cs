using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Nito.AsyncEx;
using Services;
using Servicess.Interfaces.Building;

namespace DepartmentDal.Classes
{
    public class PardakhtBussines:IPardakht
    {
        private List<CustomerBussines> listCust;

        public Guid Guid { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;
        public Guid Payer { get; set; }
        public string PayerName
        {
            get
            {
                if (listCust == null) listCust = AsyncContext.Run(CustomerBussines.GetAllAsync);
                return listCust.FirstOrDefault(q => q.Guid == Payer)?.Name;
            }
        }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string DateSh => Calendar.MiladiToShamsi(CreateDate);
        public string Description { get; set; }
        public decimal NaqdPrice { get; set; }
        public Guid NaqdSafeBoxGuid { get; set; }
        public Guid BankSafeBoxGuid { get; set; }
        public decimal BankPrice { get; set; }
        public string FishNo { get; set; }
        public decimal Check { get; set; }
        public string CheckNo { get; set; }
        public string SarResid { get; set; }
        public string BankName { get; set; }
        public decimal TotalPrice => NaqdPrice + BankPrice + Check;
        public Guid UserGuid { get; set; }




        public static async Task<ReturnedSaveFuncInfo> SaveAsync(PardakhtBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Utilities.WebApi + "/api/Pardakht/SaveAsync", content);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }
        public static async Task<PardakhtBussines> GetAsync(Guid guid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/Pardakht_Get/" + guid);
                    var user = res.FromJson<PardakhtBussines>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static async Task<List<PardakhtBussines>> GetAllAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/Pardakht_GetAll");
                    var user = res.FromJson<List<PardakhtBussines>>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static PardakhtBussines Get(Guid guid) => AsyncContext.Run(() => GetAsync(guid));
        public static async Task<ReturnedSaveFuncInfo> RemoveAsync(PardakhtBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Utilities.WebApi + "/api/Pardakht/SaveAsync", content);
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
