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
    public class CustomerBussines : ICustomers
    {
        private List<UserBussines> listUsers;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string NationalCode { get; set; }
        public string AppSerial { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Tell1 { get; set; }
        public string Tell2 { get; set; }
        public string Tell3 { get; set; }
        public string Tell4 { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime ExpireDate { get; set; } = DateTime.Now;
        public string ExpireDateSh => Calendar.MiladiToShamsi(ExpireDate);
        public Guid UserGuid { get; set; }
        public decimal Account { get; set; }
        public string AccountFlag
        {
            get
            {
                if (Account < 0) return "بستانکار";
                if (Account > 0) return "بدهکار";
                return "بی حساب";
            }
        }
        public string UserName_
        {
            get
            {
                if (listUsers == null) listUsers = AsyncContext.Run(UserBussines.GetAllAsync);
                return listUsers.FirstOrDefault(q => q.Guid == UserGuid)?.Name;
            }
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SiteUrl { get; set; }
        public string HardSerial { get; set; }
        public string LkSerial { get; set; }
        public bool isBlock { get; set; }
        public bool isWebServiceBlock { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;
        public bool Status { get; set; }

        public static async Task<CustomerBussines> GetAsync(Guid guid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/Customer_Get/" + guid);
                    var user = res.FromJson<CustomerBussines>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static async Task<CustomerBussines> GetAsync(string name)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/Customer_GetByName/" + name);
                    var user = res.FromJson<CustomerBussines>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static async Task<CustomerBussines> GetByImeiAsync(string imei)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/Customer_GetByImie/" + imei);
                    var user = res.FromJson<CustomerBussines>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static CustomerBussines GetByImei(string imei) => AsyncContext.Run(() => GetByImeiAsync(imei));
        public static CustomerBussines Get(Guid guid) => AsyncContext.Run(() => GetAsync(guid));
        public static CustomerBussines Get(string name) => AsyncContext.Run(() => GetAsync(name));
        public static async Task<List<CustomerBussines>> GetAllAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/Customer_GetAll");
                    var user = res.FromJson<List<CustomerBussines>>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static List<CustomerBussines> GetAll() => AsyncContext.Run(GetAllAsync);
        public static async Task<ReturnedSaveFuncInfo> SaveAsync(CustomerBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Utilities.WebApi + "/api/Customers/SaveAsync", content);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }
        public static ReturnedSaveFuncInfo Save(CustomerBussines cls) => AsyncContext.Run(() => SaveAsync(cls));
    }
}
