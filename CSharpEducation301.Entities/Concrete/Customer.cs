namespace CSharpEducation301.Entities.Concrete;
public class Customer
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string District { get; set; }
    public string City { get; set; }
    public bool IsStatus { get; set; }
    public List<Order> Orders { get; set; }
}