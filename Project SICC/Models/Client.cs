using System.ComponentModel.DataAnnotations;

namespace Project_SICC.Models
{
    public class Client
    {
        [Key]
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string PESEL { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string CompanyType { get; set; } = string.Empty;
        public decimal Revenue { get; set; }
        public decimal Tax { get; set; }
    }
}