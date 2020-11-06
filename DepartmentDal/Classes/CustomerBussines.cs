using Services;
using Servicess.Interfaces.Department;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DepartmentDal.Classes
{
    public class CustomerBussines : ICustomers
    {
        public DateTime CreateDate { get; set; }
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
        public DateTime ExpireDate { get; set; }
        public string ExpireDateSh => Calendar.MiladiToShamsi(ExpireDate);
        public Guid UserGuid { get; set; }
        public decimal Account { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SiteUrl { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }

        public static async Task<CustomerBussines> GetAsync(Guid guid)
        {
            throw new NotImplementedException();
        }
        public static CustomerBussines Get(Guid guid)
        {
            throw new NotImplementedException();
        }
        public static async Task<List<CustomerBussines>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public static async Task<List<CustomerBussines>> GetAllAsync(string search,Guid userGuid)
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
