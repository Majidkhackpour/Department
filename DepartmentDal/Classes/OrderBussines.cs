﻿using Servicess.Interfaces.Department;
using System;

namespace DepartmentDal.Classes
{
    public class OrderBussines : IOrder
    {
        public DateTime Date { get; set; }
        public Guid CustomerGuid { get; set; }
        public Guid UserGuid { get; set; }
        public string ContractCode { get; set; }
        public string Version { get; set; }
        public int LearningCount { get; set; }
        public decimal Sum { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public Guid Guid { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
    }
}