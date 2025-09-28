using CSharpEducation301.EFDbFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpEducation301.EFDbFirst;
public partial class FormStatistics : Form
{
    public FormStatistics()
    {
        InitializeComponent();
    }

    private void FormStatistics_Load(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            #region Toplam Lokasyon Sayısı
            lblLocationCount.Text = context.Locations.Count().ToString();
            #endregion
            #region Toplam Kapasite
            lblTotalCapacity.Text = context.Locations.Sum(l => l.Capacity).ToString();
            #endregion
            #region Toplam Rehber Sayısı
            lblTotalGuide.Text = context.Guides.Count().ToString();
            #endregion
            #region Ortalama Lokasyon Kapasitesi
            lblAvgLocationCapacity.Text = context.Locations.Average(l => (int?)l.Capacity)?.ToString("0.00");
            #endregion
            #region Ortalama Tur Fyatı
            lblAvgTourPrice.Text = context.Locations.Average(l => (decimal?)l.Price)?.ToString("0.00")+"₺";
            #endregion
            #region Eklenen Son Ülke
            int lastCountryId = context.Locations.Max(l => l.LocationId);
            lblLastCountry.Text = context.Locations.Where(l => l.LocationId == lastCountryId).Select(l => l.Country).FirstOrDefault();
            #endregion
            #region Milano Tur Kapasitesi
            lblMilanoTourCapacity.Text = context.Locations.Where(l => l.City == "Milano").Select(l => l.Capacity).FirstOrDefault().ToString();
            #endregion
            #region Türkiye Ortalama Tur Sayısı
            lblTurkiyeAvgCapacity.Text = context.Locations.Where(l => l.Country == "Türkiye").Average(l => l.Capacity).ToString();
            #endregion
            #region Antalya Tur Rehberi
            int? antalyaGuideId = context.Locations.Where(l => l.City == "Antalya").Select(l => l.GuideId).FirstOrDefault();
            lblAntalyaTourGuide.Text = context.Guides.Where(g => g.GuideId == antalyaGuideId).Select(g => g.FirstName + " " + g.LastName).FirstOrDefault();
            #endregion
            #region En Yüksek Kapasiteli Tur
            int? maxCapacity = context.Locations.Max(l => l.Capacity);
            lblMaxCapacityWithTour.Text = context.Locations.Where(l => l.Capacity == maxCapacity).Select(l => l.City).FirstOrDefault();
            #endregion
            #region En Pahalı Tur
            decimal? maxPrice = context.Locations.Max(l => l.Price);
            lblMostExpensiveTour.Text = context.Locations.Where(l => l.Price == maxPrice).Select(l => l.City).FirstOrDefault();
            #endregion
            #region En Fazla Görev Alan
            var topGuide = context.Locations.GroupBy(l => l.GuideId).Select(g => new
            {
                Id = g.Key,
                TourCount = g.Count()
            }).OrderByDescending(x => x.TourCount).FirstOrDefault();
            lblMaxTourPerson.Text = context.Guides.Where(g => g.GuideId == topGuide.Id).Select(g => g.FirstName + ' ' + g.LastName).FirstOrDefault();
            #endregion
        }
    }
}