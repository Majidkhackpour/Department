using Servicess.Interfaces.Department;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Nito.AsyncEx;
using Services;

namespace DepartmentDal.Classes
{
    public class OrderBussines : IOrder
    {
        private List<CustomerBussines> listCust;
        private List<UserBussines> listUsers;
        public static event Func<OrderDetailBussines, Task> OnDetailsChanged;
        public static void RaiseEvent(OrderDetailBussines det)
        {
            var handler = OnDetailsChanged;
            if (handler != null)
                OnDetailsChanged(det);
        }
        public DateTime Date { get; set; } = DateTime.Now;
        public string DateSh => Calendar.MiladiToShamsi(Date);
        public Guid CustomerGuid { get; set; }
        public CustomerBussines Customer
        {
            get
            {
                if (listCust == null) listCust = AsyncContext.Run(CustomerBussines.GetAllAsync);
                return listCust.FirstOrDefault(q => q.Guid == CustomerGuid);
            }
        }
        public string CustomerName => Customer?.Name;
        public Guid UserGuid { get; set; }
        public string ContractCode { get; set; }
        public decimal Sum { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;
        public bool Status { get; set; }
        public UserBussines User
        {
            get
            {
                if (listUsers == null) listUsers = AsyncContext.Run(UserBussines.GetAllAsync);
                return listUsers.FirstOrDefault(q => q.Guid == UserGuid);
            }
        }
        public string UserName => User?.Name;
        public List<OrderDetailBussines> DetList { get; set; }




        public static async Task<ReturnedSaveFuncInfo> SaveAsync(OrderBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Utilities.WebApi + "/api/Order/SaveAsync", content);
                    foreach (var item in cls.DetList) await SaveDetAsync(item);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }
        private static async Task<ReturnedSaveFuncInfo> SaveDetAsync(OrderDetailBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Utilities.WebApi + "/api/OrderDetail/SaveAsync", content);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }
        public static ReturnedSaveFuncInfo Save(OrderBussines cls) => AsyncContext.Run(() => SaveAsync(cls));
        public static async Task<OrderBussines> GetAsync(Guid guid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/Order_Get/" + guid);
                    var user = res.FromJson<OrderBussines>();
                    user.DetList = await GetAllDetsAsync(guid);
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static async Task<List<OrderDetailBussines>> GetAllDetsAsync(Guid orderGuid)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/OrderDetail_GetAll/" + orderGuid);
                    var user = res.FromJson<List<OrderDetailBussines>>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static async Task<List<OrderBussines>> GetAllAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/Order_GetAll");
                    var user = res.FromJson<List<OrderBussines>>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static List<OrderBussines> GetAll() => AsyncContext.Run(GetAllAsync);
        public static OrderBussines Get(Guid guid) => AsyncContext.Run(() => GetAsync(guid));
        public static async Task<ReturnedSaveFuncInfo> RemoveAsync(OrderBussines cls)
        {
            var res = new ReturnedSaveFuncInfo();
            try
            {
                using (var client = new HttpClient())
                {
                    var json = Json.ToStringJson(cls);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Utilities.WebApi + "/api/Order/SaveAsync", content);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }
        public static async Task<string> NextCodeAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/Order_NextCode");
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
    }
}
