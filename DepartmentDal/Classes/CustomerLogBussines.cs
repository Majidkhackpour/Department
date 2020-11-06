using Services;
using Servicess.Interfaces.Department;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DepartmentDal.Classes
{
    public class CustomerLogBussines : ICustomerLog
    {
        public DateTime Date { get; set; }
        public Guid CustomerGuid { get; set; }
        public string SideName { get; set; }
        public string Description { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }

        public static async Task<List<CustomerLogBussines>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public static async Task<List<CustomerLogBussines>> GetAllAsync(Guid cusGuid)
        {
            throw new NotImplementedException();
        }
        public async Task<ReturnedSaveFuncInfo> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
