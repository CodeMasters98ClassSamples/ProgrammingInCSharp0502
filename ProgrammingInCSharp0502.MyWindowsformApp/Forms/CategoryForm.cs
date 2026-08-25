using ProgrammingInCSharp0502.Business;
using ProgrammingInCSharp0502.Business.Businesses;
using ProgrammingInCSharp0502.Domain;

namespace ProgrammingInCSharp0502.MyWindowsformApp.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryBusiness _categoryBusiness;

        public delegate void ReloadData(List<Category> categories);


        public event ReloadData ReloadDataEvent;
        public CategoryForm(CategoryBusiness categoryBusiness)
        {
            InitializeComponent();
            _categoryBusiness = categoryBusiness;


            ReloadDataEvent += FillDataGrid;
            ReloadDataEvent.Invoke(_categoryBusiness.GetAll());

            RefreshForm();
            ResetForm();
        }

        private void FillDataGrid(List<Category> categories)
        {
            categoryDataGridView.DataSource = null;
            categoryDataGridView.DataSource = categories;
            categoryDataGridView.Refresh();

            ResetForm();

            MessageBox.Show("Record Updated successfully");

        }
        private void ResetForm()
        {
            titleTextBox.Text = null;
            descriptionTextBox.Text = null;
        }

        private void RefreshForm()
        {
            ReloadDataEvent.Invoke(_categoryBusiness.GetAll());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                Title = titleTextBox.Text,
                Description = descriptionTextBox.Text
            };

            _categoryBusiness.Add(category);
            RefreshForm();
            ResetForm();
        }
    }
}
