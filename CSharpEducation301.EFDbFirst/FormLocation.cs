using CSharpEducation301.EFDbFirst.Models;

namespace CSharpEducation301.EFDbFirst;

public partial class FormLocation : Form
{
    public FormLocation()
    {
        InitializeComponent();
    }

    private void btnGetList_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            var result = context.Locations.ToList();
            dataGridView1.DataSource = result;
        }
    }

    private void FormLocation_Load(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            var result = context.Guides.Select(g => new
            {
                FullName = g.FirstName + " " + g.LastName,
                g.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = result;
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            Location location = new();
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Capacity = byte.Parse(nudCapacity.Value.ToString());
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtStatus.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            context.Locations.Add(location);
            context.SaveChanges();
            MessageBox.Show("Lokasyon Başarıyla Eklendi!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            int locationId = int.Parse(txtId.Text);
            var location = context.Locations.Find(locationId);
            context.Locations.Remove(location);
            context.SaveChanges();
            MessageBox.Show("Lokasyon Başarıyla Silindi!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            int locationId = int.Parse(txtId.Text);
            var updatedLocation = context.Locations.Find(locationId);
            updatedLocation.City = txtCity.Text;
            updatedLocation.Country = txtCountry.Text;
            updatedLocation.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updatedLocation.Price = decimal.Parse(txtPrice.Text);
            updatedLocation.DayNight = txtStatus.Text;
            updatedLocation.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            context.SaveChanges();
            MessageBox.Show("Lokasyon Başarıyla Güncellendi!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnGetById_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            int locationId = int.Parse(txtId.Text);
            var location = context.Locations.Where(l => l.LocationId == locationId).ToList();
            dataGridView1.DataSource = location;
        }
    }
}