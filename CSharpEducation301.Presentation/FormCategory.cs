using CSharpEducation301.Business.Abstracts;
using CSharpEducation301.Entities.Concrete;

namespace CSharpEducation301.Presentation;
public partial class FormCategory : Form
{
    private readonly ICategoryService categoryService;

    public FormCategory(ICategoryService _categoryService)
    {
        categoryService = _categoryService;
        InitializeComponent();
    }

    private void btnList_Click(object sender, EventArgs e)
    {
        var result = categoryService.GetAll();
        dataGridView1.DataSource = result;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Category category = new();
        category.CategoryName = txtCategoryName.Text;
        category.CategoryStatus = rdbActive.Checked ? true : false;
        categoryService.Insert(category);
        MessageBox.Show("Kategori Oluşturuldu!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        int categoryId = Convert.ToInt32(txtCategoryId.Text);
        var category = categoryService.GetById(categoryId);
        categoryService.Delete(category);
        MessageBox.Show("Kategori Kaldırıldı!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        int categoryId = Convert.ToInt32(txtCategoryId.Text);
        var updateCategory = categoryService.GetById(categoryId);
        updateCategory.CategoryName = txtCategoryName.Text;
        updateCategory.CategoryStatus = rdbActive.Checked ? true : false;
        categoryService.Update(updateCategory);
        MessageBox.Show("Kategori Güncellendi!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnGetById_Click(object sender, EventArgs e)
    {
        int categoryId = Convert.ToInt32(txtCategoryId.Text);
        var result = categoryService.GetAll().Where(c => c.CategoryId == categoryId).ToList();
        dataGridView1.DataSource = result;
    }
}