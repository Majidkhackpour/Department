using Services;
using Servicess.Interfaces.Department;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DepartmentDal.Classes
{
    public class ProductBussines : IProduct
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public decimal BckUpPrice { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }

        public static async Task<ProductBussines> GetAsync(Guid guid)
        {
            throw new NotImplementedException();
        }
        public static async Task<List<ProductBussines>> GetAllAsync(string search)
        {
            throw new NotImplementedException();
        }
        public static ProductBussines Get(Guid guid)
        {
            throw new NotImplementedException();
        }
        public static string NextCode()
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
