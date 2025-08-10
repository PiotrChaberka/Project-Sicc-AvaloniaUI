using System.Collections.Generic;
namespace Project_SICC.Data

{
    public class Contractor
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        
        // Navigation property to Contracts
        public List<Contract> Contracts { get; set; } = new();
    }
}