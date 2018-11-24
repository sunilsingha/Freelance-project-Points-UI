using System;

namespace PointsUI.Classes
{
    class PointsTransaction : AuditTransaction
    {
        public DateTime TransactionDate { get; set; }
        public string VoucherNo { get; set; }
        public double Kgs { get; set; }
        public double AsianLitres { get; set; }
        public double ApolloLitres { get; set; }
        public int ContractorId { get; set; }
        public string ContractorName { get;  set; }
        public string SupervisorName { get; set; }
        public string ContractorPhoneNumber { get; set; }
        public string ContractorNo { get; set; }
        public string Status { get; set; }
        public double Points { get; set; }

        

    }

    class PointsTable
    {
        public int ContractorId { get; set; }
        public string ContractorNo { get; set; }
        public string PhoneNo { get; set; }
        public string ContractorName { get; set; }
        public int TotalAsiaLitres { get; set; }
        public int TotalAppoloLitres { get; set; }
        public int TotalKgs { get; set; }
        public int Points { get; set; }
        public int InPoints { get; set; }
    }
}
