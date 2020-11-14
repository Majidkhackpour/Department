using Servicess.Interfaces.Department;
using System;

namespace DepartmentDal.Classes
{
    public class OrderDetailBussines : IOrderDetail
    {
        public Guid OrderGuid { get; set; }
        public Guid PrdGuid { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
    }
}
