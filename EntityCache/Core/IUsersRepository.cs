﻿using System;
using System.Threading.Tasks;
using EntityCache.Bussines;

namespace EntityCache.Core
{
    public interface IUsersRepository : IRepository<UsersBussines>
    {
        Task<bool> CheckUserNameAsync(Guid guid, string userName);
        Task<UsersBussines> GetAsync(string userName);
    }
}
