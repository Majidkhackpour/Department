using Services;
using Servicess.Interfaces.Department;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DepartmentDal.Classes
{
    public class SmsLogBussines : ISmsLog
    {
        public DateTime Date { get; set; }
        public Guid UserGuid { get; set; }
        public string Sender { get; set; }
        public string Reciver { get; set; }
        public string Message { get; set; }
        public decimal Cost { get; set; }
        public long MessageId { get; set; }
        public string StatusText { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }

        public static async Task<SmsLogBussines> GetAsync(Guid guid)
        {
            throw new NotImplementedException();
        }
        public static async Task<SmsLogBussines> GetAsync(long messageId)
        {
            throw new NotImplementedException();
        }
        public static SmsLogBussines Get(Guid guid)
        {
            throw new NotImplementedException();
        }
        public static List<SmsLogBussines> GetAll()
        {
            throw new NotImplementedException();
        }
        public static List<SmsLogBussines> GetAll(string search, Guid userGuid)
        {
            throw new NotImplementedException();
        }
        public async Task<ReturnedSaveFuncInfo> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
