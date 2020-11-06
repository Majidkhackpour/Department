using Services;
using Servicess.Interfaces.Department;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DepartmentDal.Classes
{
    public class SafeBoxBussines : ISafeBox
    {
        public string Name { get; set; }
        public EnSafeBox Type { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }



        public static async Task<SafeBoxBussines> GetAsync(Guid guid)
        {
            throw new NotImplementedException();
        }
        public static async Task<List<SafeBoxBussines>> GetAllAsync(string search)
        {
            throw new NotImplementedException();
        }
        public static SafeBoxBussines Get(Guid guid)
        {
            throw new NotImplementedException();
        }
        public async Task<ReturnedSaveFuncInfo> SaveAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<ReturnedSaveFuncInfo> ChangeStatusAsync(bool status)
        {
            throw new NotImplementedException();
        }
    }
}
