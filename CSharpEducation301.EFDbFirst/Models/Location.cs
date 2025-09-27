namespace CSharpEducation301.EFDbFirst.Models;
public partial class Location
{
    public int LocationId { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public byte? Capacity { get; set; }
    public decimal? Price { get; set; }
    public string? DayNight { get; set; }
    public int? GuideId { get; set; }
    public virtual Guide? Guide { get; set; }
}