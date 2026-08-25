using ProgrammingInCSharp0502.Business.Businesses;
using ProgrammingInCSharp0502.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingInCSharp0502.MyWindowsformApp.Forms
{
    public partial class CourseForm : Form
    {
        private readonly CategoryBusiness _categoryBusiness;
        private readonly CourseBusiness _courseBusiness;

        public delegate void ReloadData(List<Course> courses);


        public event ReloadData ReloadDataEvent;
        public CourseForm(CategoryBusiness categoryBusiness, CourseBusiness courseBusiness)
        {
            InitializeComponent();
            _categoryBusiness = categoryBusiness;
            _courseBusiness = courseBusiness;


            ReloadDataEvent += FillDataGrid;
            ReloadDataEvent.Invoke(_courseBusiness.GetAll());

            var categories = _categoryBusiness.GetAll();
            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Title";
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void FillDataGrid(List<Course> courses)
        {
            coursedataGridView1.DataSource = null;
            coursedataGridView1.DataSource = courses;
            coursedataGridView1.Refresh();

            ResetForm();

            MessageBox.Show("Record Updated successfully");

        }
        private void ResetForm()
        {
            titleTextBox.Text = null;
            descriptionTextBox.Text = null;
            hourtextBox.Text = null;
            onSitetextBox.Text = null;
            onlinetextBox.Text = null;
            priceTextBox.Text = null;
           // categoryComboBox.SelectedIndex = 0;
        }

        private void RefreshForm()
        {
            ReloadDataEvent.Invoke(_courseBusiness.GetAll());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Course course = new Course
            {
                Title = titleTextBox.Text,
                Description = descriptionTextBox.Text,
                Hour = int.Parse(hourtextBox.Text),
                OnSiteSize = int.Parse(onSitetextBox.Text),
                RemoteSize = int.Parse(onlinetextBox.Text),
                Price = decimal.Parse(priceTextBox.Text)
            };

            _courseBusiness.Add(course);
            RefreshForm();
            ResetForm();
        }
    }
}
