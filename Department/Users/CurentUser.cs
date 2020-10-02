using DepartmentDal.Classes;
using System;

namespace Department.Users
{
    public static class CurentUser
    {
        public static UserBussines CurrentUser { get; set; }
        public static DateTime LastVorrod { get; set; }
    }
}
