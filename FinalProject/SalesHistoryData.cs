using System.Collections.Generic;

namespace FinalProject
{
    public static class SalesHistoryData
    {
        private static List<SalesRecord> salesRecords = new List<SalesRecord>();

        public static void Add(SalesRecord record)
        {
            salesRecords.Add(record);
        }

        public static IEnumerable<SalesRecord> GetRecords()
        {
            return salesRecords;
        }
    }

    public class SalesRecord
    {
        public string Date { get; set; }
        public string Orders { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Payment { get; set; }
        public decimal Change { get; set; }
    }
}
