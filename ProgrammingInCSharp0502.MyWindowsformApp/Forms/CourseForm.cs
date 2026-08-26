using ProgrammingInCSharp0502.Business.Interfaces;
using ProgrammingInCSharp0502.Domain;

namespace ProgrammingInCSharp0502.MyWindowsformApp.Forms
{
    /// <summary>
    /// Presentation layer.
    /// The business service (Database-First) is injected by the DI container
    /// -> the form never creates its dependencies itself.
    /// </summary>
    public partial class CourseForm : Form
    {
        private readonly ICourseBusiness _courseBusiness;

        private Course targetCourse;

        public CourseForm(ICourseBusiness courseBusiness)
        {
            _courseBusiness = courseBusiness;

            InitializeComponent();

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            try
            {
                courseDataGridView.DataSource = null;
                courseDataGridView.DataSource = _courseBusiness.GetAll();
                courseDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا");
            }
        }

        private void ResetForm()
        {
            targetCourse = null;
            titleTextBox.Text = null;
            descriptionTextBox.Text = null;
            priceNumericUpDown.Value = 0;
            hourNumericUpDown.Value = 0;
            onSiteSizeNumericUpDown.Value = 0;
            remoteSizeNumericUpDown.Value = 0;
        }

        private Course ReadForm()
        {
            if (string.IsNullOrEmpty(titleTextBox.Text))
                throw new Exception(message: "عنوان دوره را وارد نمایید.");

            return new Course
            {
                Title = titleTextBox.Text,
                Description = descriptionTextBox.Text,
                Price = priceNumericUpDown.Value,
                Hour = (int)hourNumericUpDown.Value,
                OnSiteSize = (int)onSiteSizeNumericUpDown.Value,
                RemoteSize = (int)remoteSizeNumericUpDown.Value
            };
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                _courseBusiness.Add(ReadForm());
                RefreshGrid();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (targetCourse is null)
            {
                MessageBox.Show("لطفا ابتدا دوره ای را انتخاب نمایید.");
                return;
            }

            try
            {
                var updated = ReadForm();
                targetCourse.Title = updated.Title;
                targetCourse.Description = updated.Description;
                targetCourse.Price = updated.Price;
                targetCourse.Hour = updated.Hour;
                targetCourse.OnSiteSize = updated.OnSiteSize;
                targetCourse.RemoteSize = updated.RemoteSize;

                _courseBusiness.Update(targetCourse);
                RefreshGrid();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (targetCourse is null)
            {
                MessageBox.Show("لطفا ابتدا دوره ای را انتخاب نمایید.");
                return;
            }

            _courseBusiness.Delete(targetCourse);
            RefreshGrid();
            ResetForm();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void courseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row clicks
            if (e.RowIndex >= 0)
            {
                var row = courseDataGridView.Rows[e.RowIndex];
                var id = short.Parse(row.Cells["Id"].Value?.ToString() ?? "0");

                targetCourse = _courseBusiness.GetById(id);
                if (targetCourse is null)
                    return;

                titleTextBox.Text = targetCourse.Title;
                descriptionTextBox.Text = targetCourse.Description;
                priceNumericUpDown.Value = targetCourse.Price;
                hourNumericUpDown.Value = targetCourse.Hour;
                onSiteSizeNumericUpDown.Value = targetCourse.OnSiteSize;
                remoteSizeNumericUpDown.Value = targetCourse.RemoteSize;
            }
        }
    }
}
