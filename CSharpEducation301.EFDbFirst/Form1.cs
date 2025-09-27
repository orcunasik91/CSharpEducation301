using CSharpEducation301.EFDbFirst.Models;

namespace CSharpEducation301.EFDbFirst;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnGetList_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            var result = context.Guides.ToList();
            dataGridView1.DataSource = result;
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            Guide guide = new();
            guide.FirstName = txtName.Text;
            guide.LastName = txtSurname.Text;
            context.Guides.Add(guide);
            context.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Eklendi!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            int guideId = int.Parse(txtId.Text);
            var guide = context.Guides.Find(guideId);
            context.Guides.Remove(guide);
            context.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Silindi!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            int guideId = int.Parse(txtId.Text);
            var updatedGuide = context.Guides.Find(guideId);
            updatedGuide.FirstName = txtName.Text;
            updatedGuide.LastName = txtSurname.Text;
            context.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Güncellendi!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnGetById_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            int guideId = int.Parse(txtId.Text);
            var guide = context.Guides.Where(g => g.GuideId == guideId).ToList();
            dataGridView1.DataSource = guide;
        }
    }
}