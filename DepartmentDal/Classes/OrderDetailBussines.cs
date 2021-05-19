using Servicess.Interfaces.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using Nito.AsyncEx;

namespace DepartmentDal.Classes
{
    public class OrderDetailBussines : IOrderDetail
    {
        private List<ProductBussines> listPrd;

        public Guid OrderGuid { get; set; }
        public Guid PrdGuid { get; set; }
        public int Count { get; set; }

        public string ProductName
        {
            get
            {
                if (listPrd == null) listPrd = AsyncContext.Run(ProductBussines.GetAllAsync);
                return listPrd.FirstOrDefault(q => q.Guid == PrdGuid)?.Name;
            }
        }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
    }
}
