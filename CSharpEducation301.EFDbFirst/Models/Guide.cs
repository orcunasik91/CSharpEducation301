namespace CSharpEducation301.EFDbFirst.Models;
public partial class Guide
{
    public int GuideId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}