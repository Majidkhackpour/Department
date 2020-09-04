using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EntityCache.Assistence;
using Nito.AsyncEx;
using PacketParser.Interfaces;
using Services;

namespace EntityCache.Bussines
{
    public class CustomerLogBussines : ICustomerLog
    {
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;
        public DateTime Date { get; set; } = DateTime.Now;
        public string DateSh => Calendar.MiladiToShamsi(Date);
        public string Time => Date.ToShortTimeString();
        public Guid CustomerGuid { get; set; }
        public string SideName { get; set; }
        public string Description { get; set; }


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

                res.AddReturnedValue(await UnitOfWork.CustomerLog.SaveAsync(this, tranName));
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

        public static async Task<List<CustomerLogBussines>> GetAllAsync(Guid cusGuid) =>
            await UnitOfWork.CustomerLog.GetAllAsync(cusGuid);

        public static List<CustomerLogBussines> GetAll(Guid cusGuid) => AsyncContext.Run(() => GetAllAsync(cusGuid));
    }
}
