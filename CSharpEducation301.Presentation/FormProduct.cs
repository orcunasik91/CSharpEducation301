using CSharpEducation301.Business.Abstracts;
using CSharpEducation301.Entities.Concrete;

namespace CSharpEducation301.Presentation;
public partial class FormProduct : Form
{
    private readonly IProductService productService;
    private readonly ICategoryService categoryService;
    public FormProduct(IProductService _productService, ICategoryService _categoryService)
    {
        productService = _productService;
        categoryService = _categoryService;
        InitializeComponent();
    }

    private void btnList_Click(object sender, EventArgs e)
    {
        var result = productService.GetProductsWithCategory();
        dataGridView1.DataSource = result;
        dataGridView1.Columns["CategoryId"].Visible = false;
        dataGridView1.Columns["Category"].Visible = false;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Product product = new();
        product.ProductName = txtProductName.Text;
        product.Price = Convert.ToDecimal(txtPrice.Text);
        product.Stock = int.Parse(nudStock.Value.ToString());
        product.Description = txtDescription.Text;
        product.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
        productService.Insert(product);
        MessageBox.Show("Ürün Oluşturuldu!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void FormProduct_Load(object sender, EventArgs e)
    {
        var result = categoryService.GetAll().Select(c => new
        {
            c.CategoryName,
            c.CategoryId
        }).ToList();
        cmbCategory.DisplayMember = "CategoryName";
        cmbCategory.ValueMember = "CategoryId";
        cmbCategory.DataSource = result;
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        int productId = Convert.ToInt32(txtProductId.Text);
        var updateProduct = productService.GetById(productId);
        updateProduct.ProductName = txtProductName.Text;
        updateProduct.Price = Convert.ToDecimal(txtPrice.Text);
        updateProduct.Stock = int.Parse(nudStock.Value.ToString());
        updateProduct.Description = txtDescription.Text;
        updateProduct.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
        productService.Update(updateProduct);
        MessageBox.Show("Ürün Güncellendi!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        int productId = Convert.ToInt32(txtProductId.Text);
        var product = productService.GetById(productId);
        productService.Delete(product);
        MessageBox.Show("Ürün Kaldırıldı!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnGetById_Click(object sender, EventArgs e)
    {
        int productId = Convert.ToInt32(txtProductId.Text);
        var result = productService.GetProductsWithCategory().Where(p => p.ProductId == productId).ToList();
        dataGridView1.DataSource = result;
    }
}