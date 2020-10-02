using Servicess.Interfaces.Department;
using System;

namespace DepartmentDal.Classes
{
    public class OrderDetailBussines : IOrderDetail
    {
        public Guid PrdGuid { get; set; }
        public decimal Price { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
    }
}
