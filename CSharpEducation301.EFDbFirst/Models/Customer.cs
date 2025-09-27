namespace CSharpEducation301.EFDbFirst.Models;
public partial class Customer
{
    public int CustomerId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public decimal? Balance { get; set; }
}