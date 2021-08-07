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
    public class ReceptionBussines 
    {
        private List<CustomerBussines> listCust;
        private List<UserBussines> listUsers;
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;
        public string DateSh => Calendar.MiladiToShamsi(CreateDate);
        public bool Status { get; set; } = true;
        public Guid Receptor { get; set; }
        public string ReceptorName
        {
            get
            {
                if (listCust == null) listCust = AsyncContext.Run(CustomerBussines.GetAllAsync);
                return listCust.FirstOrDefault(q => q.Guid == Receptor)?.Name;
            }
        }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public decimal NaqdPrice { get; set; }
        public Guid NaqdSafeBoxGuid { get; set; }
        public decimal BankPrice { get; set; }
        public Guid BankSafeBoxGuid { get; set; }
        public string FishNo { get; set; }
        public decimal Check { get; set; }
        public string CheckNo { get; set; }
        public string SarResid { get; set; }
        public string BankName { get; set; }
        public decimal TotalPrice => NaqdPrice + BankPrice + Check;
        public Guid UserGuid { get; set; }
        public string UserName
        {
            get
            {
                if (listUsers == null) listUsers = AsyncContext.Run(UserBussines.GetAllAsync);
                return listUsers.FirstOrDefault(q => q.Guid == UserGuid)?.Name;
            }
        }




        public static async Task<ReturnedSaveFuncInfo> SaveAsync(ReceptionBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Services.Utilities.WebApi + "/api/Reception/SaveAsync", content);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }
        public static ReturnedSaveFuncInfo Save(ReceptionBussines cls) => AsyncContext.Run(() => SaveAsync(cls));
        public static async Task<ReceptionBussines> GetAsync(Guid guid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Services.Utilities.WebApi + "/Reception_Get/" + guid);
                    var user = res.FromJson<ReceptionBussines>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static async Task<List<ReceptionBussines>> GetAllAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Services.Utilities.WebApi + "/Reception_GetAll");
                    var user = res.FromJson<List<ReceptionBussines>>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static List<ReceptionBussines> GetAll() => AsyncContext.Run(GetAllAsync);
        public static ReceptionBussines Get(Guid guid) => AsyncContext.Run(() => GetAsync(guid));
        public static async Task<ReturnedSaveFuncInfo> RemoveAsync(ReceptionBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Services.Utilities.WebApi + "/api/Reception/SaveAsync", content);
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
