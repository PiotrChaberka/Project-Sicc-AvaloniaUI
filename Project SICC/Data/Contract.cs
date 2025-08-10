using System;

namespace Project_SICC.Data
{
    public class Contract
    {
        public int ID { get; set; }
        public int ContractorID { get; set; } // Foreign key to Contractor
        public string ContractNumber { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Value { get; set; }

        // Navigation property to Contractor
        public Contractor Contractor { get; set; } = null!;
    }
}