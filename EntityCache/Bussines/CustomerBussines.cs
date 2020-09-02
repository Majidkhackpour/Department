using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityCache.Assistence;
using Nito.AsyncEx;
using PacketParser.Interfaces;
using Services;

namespace EntityCache.Bussines
{
    public class CustomerBussines : ICustomers
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;
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
        public DateTime ExpireDate { get; set; } = DateTime.Now.AddYears(1);
        public Guid UserGuid { get; set; }
        public string UserName => UsersBussines.Get(UserGuid).Name;
        public string ExpireDateSh => Calendar.MiladiToShamsi(ExpireDate);



        public static async Task<CustomerBussines> GetAsync(Guid guid) => await UnitOfWork.Customer.GetAsync(guid);

        public static async Task<List<CustomerBussines>> GetAllAsync() => await UnitOfWork.Customer.GetAllAsync();

        public static List<CustomerBussines> GetAll() => AsyncContext.Run(GetAllAsync);

        public async Task<ReturnedSaveFuncInfo> SaveAsync(string tranName = "")
        {
            var res = new ReturnedSaveFuncInfo();
            var autoTran = string.IsNullOrEmpty(tranName);
            if (autoTran) tranName = Guid.NewGuid().ToString();
            try
            {
                if (autoTran)
                { //BeginTransaction
                }

                res.AddReturnedValue(await UnitOfWork.Customer.SaveAsync(this, tranName));
                res.ThrowExceptionIfError();
                if (autoTran)
                {
                    //CommitTransAction
                }
            }
            catch (Exception ex)
            {
                if (autoTran)
                {
                    //RollBackTransAction
                }
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }

        public async Task<ReturnedSaveFuncInfo> ChangeStatusAsync(bool status, string tranName = "")
        {
            var res = new ReturnedSaveFuncInfo();
            var autoTran = string.IsNullOrEmpty(tranName);
            if (autoTran) tranName = Guid.NewGuid().ToString();
            try
            {
                if (autoTran)
                { //BeginTransaction
                }


                res.AddReturnedValue(await UnitOfWork.Customer.ChangeStatusAsync(this, status, tranName));
                res.ThrowExceptionIfError();
                if (autoTran)
                {
                    //CommitTransAction
                }
            }
            catch (Exception ex)
            {
                if (autoTran)
                {
                    //RollBackTransAction
                }
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                res.AddReturnedValue(ex);
            }

            return res;
        }

        public static async Task<List<CustomerBussines>> GetAllAsync(string search, Guid userGuid)
        {
            try
            {
                if (string.IsNullOrEmpty(search))
                    search = "";
                var res = await GetAllAsync();
                if (userGuid != Guid.Empty) res = res.Where(q => q.UserGuid == userGuid).ToList();
                var searchItems = search.SplitString();
                if (searchItems?.Count > 0)
                    foreach (var item in searchItems)
                    {
                        if (!string.IsNullOrEmpty(item) && item.Trim() != "")
                        {
                            res = res.Where(x => x.Name.Contains(item) ||
                                                 x.CompanyName.Contains(item) ||
                                                 x.Tell1.Contains(item) ||
                                                 x.Tell2.Contains(item) ||
                                                 x.AppSerial.Contains(item) ||
                                                 x.Description.Contains(item))
                                ?.ToList();
                        }
                    }

                res = res?.OrderByDescending(o => o.CreateDate).ToList();
                return res;
            }
            catch (OperationCanceledException)
            {
                return null;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return new List<CustomerBussines>();
            }
        }

        public static List<CustomerBussines> GetAll(string search, Guid userGuid) =>
            AsyncContext.Run(() => GetAllAsync(search, userGuid));

        public static CustomerBussines Get(Guid guid) => AsyncContext.Run(() => GetAsync(guid));
    }
}
