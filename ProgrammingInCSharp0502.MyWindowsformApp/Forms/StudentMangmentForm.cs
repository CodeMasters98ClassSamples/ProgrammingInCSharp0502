using ProgrammingInCSharp0502.Business.Interfaces;
using ProgrammingInCSharp0502.Domain;
using ProgrammingInCSharp0502.MyWindowsformApp.Forms;

namespace ProgrammingInCSharp0502.MyWindowsformApp
{
    public partial class StudentMangmentForm : Form
    {
        //Presentation layer:
        //data access goes through the business layer only (IStudentBusiness),
        //which is injected by the DI container (Database-First -> EF InMemory)

        //Declare delegate
        //[access modifier] delegate [return type] [delegate name]([parameters])
        public delegate void ReloadData(List<Student> myUsers);

        // Declare the event.
        public event ReloadData ReloadDataEvent;

        private readonly IStudentBusiness _studentBusiness;
        private List<Student> students = new List<Student>();
        private Student targetStudent;

        public StudentMangmentForm(IStudentBusiness studentBusiness)
        {
            _studentBusiness = studentBusiness;

            InitializeComponent();

            ReloadDataEvent += FillDataGrid;
            ReloadDataEvent.Invoke(_studentBusiness.GetAll());

            ResetForm();

            var x = new Student();
        }

        private void FillDataGrid(List<Student> students)
        {
            //Keep the loaded list so a row click can find the target student
            this.students = students;

            studentDataGridView.DataSource = null;
            studentDataGridView.DataSource = students;
            studentDataGridView.Refresh();

            ResetForm();
        }

        private void RefreshForm()
        {
            ReloadDataEvent.Invoke(_studentBusiness.GetAll());
        }

        private void ResetForm()
        {
            targetStudent = null;
            firstNameTextBox.Text = null;
            lastNameTextBox.Text = null;
        }

        private void registerStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = Student.RegisterUser(firstName: firstNameTextBox.Text,
                    lastName: lastNameTextBox.Text,
                    nationalCode: nationalCodeTextBox.Text,
                    phone: phonNumberTextBox.Text);

                _studentBusiness.Add(s);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا");
            }
        }

        private void studentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row clicks
            if (e.RowIndex >= 0)
            {
                // Get the current row
                var row = studentDataGridView.Rows[e.RowIndex];
                var code = row.Cells["Code"].Value?.ToString();

                Clipboard.SetDataObject(code);

                targetStudent = students.FirstOrDefault(s => s.Code == code);
                if (targetStudent is null)
                    return;

                firstNameTextBox.Text = targetStudent.FirstName;
                lastNameTextBox.Text = targetStudent.LastName;
            }
        }

        private void updateIdentityButton_Click(object sender, EventArgs e)
        {
            if (targetStudent is null)
            {
                MessageBox.Show("لطفا ابتدا دانشجویی را انتخاب نمایید.");
                return;
            }

            try
            {
                targetStudent.UpdateFirstName(firstNameTextBox.Text);
                targetStudent.UpdateLastName(lastNameTextBox.Text);

                _studentBusiness.Update(targetStudent);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا");
            }
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            if (targetStudent is null)
            {
                MessageBox.Show("لطفا ابتدا دانشجویی را انتخاب نمایید.");
                return;
            }

            _studentBusiness.Delete(targetStudent);
            RefreshForm();
        }

        private void registerOnCoursebutton_Click(object sender, EventArgs e)
        {
            if (targetStudent is null)
            {
                MessageBox.Show("لطفا ابتدا دانشجویی را انتخاب نمایید.");
                return;
            }

            RegisterStudentOnCourseForm regForm = new(fullname: targetStudent.FullName, code: targetStudent.Code);
            regForm.Show();
        }
    }
}
