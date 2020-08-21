using System;
using EntityCache.Bussines;

namespace Department.Users
{
    public static class CurentUser
    {
        public static UsersBussines CurrentUser { get; set; }
        public static DateTime LastVorrod { get; set; }
    }
}
