namespace Project_SICC.Data;

public class Client
{
    public int Id { get; set; } // Primary Key
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string PESEL { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string CompanyType { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
    public decimal Tax { get; set; }
}