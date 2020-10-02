using Services;
using Servicess.Interfaces.Department;
using System;

namespace DepartmentDal.Classes
{
    public class UserLogBussines : IUserLog
    {
        public DateTime Date { get; set; }
        public Guid UserGuid { get; set; }
        public EnLogType Type { get; set; }
        public string Description { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
    }
}
