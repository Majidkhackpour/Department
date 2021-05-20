namespace DepartmentDal.Classes
{
    public class OrderReportBussines
    {
        public string CompanyName { get; set; }
        public string CompanyTell { get; set; }
        public string DateSh { get; set; }
        public string Time { get; set; }
        public string ContractCode { get; set; }
        public string  CustomerName { get; set; }
        public string CustomerTell { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerSerialNumber { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductDiscount { get; set; }
        public decimal ProductTotal { get; set; }
        public decimal OrderSum { get; set; }
        public decimal OdrerDiscount { get; set; }
        public decimal OrderTotal { get; set; }
        public string OrderTotalName { get; set; }
        public string OrderUserName { get; set; }
    }
}
