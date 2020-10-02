using Services;
using Servicess.Interfaces.Department;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DepartmentDal.Classes
{
    public class UserBussines : IUsers
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool IsBlock { get; set; }
        public EnUserType Type { get; set; }
        public string TypeName => Type.GetDisplay();
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }

        public static async Task<UserBussines> GetAsync(Guid guid)
        {
            throw new NotImplementedException();
        }
        public static async Task<UserBussines> GetAsync(string userName)
        {
            throw new NotImplementedException();
        }
        public static UserBussines Get(Guid guid)
        {
            throw new NotImplementedException();
        }
        public static async Task<List<UserBussines>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public static List<UserBussines> GetAll(string search)
        {
            throw new NotImplementedException();
        }
        public static List<UserBussines> GetAll()
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
        public static async Task<bool> CheckUserNameAsync(Guid guid,string userName)
        {
            throw new NotImplementedException();
        }
    }
}
