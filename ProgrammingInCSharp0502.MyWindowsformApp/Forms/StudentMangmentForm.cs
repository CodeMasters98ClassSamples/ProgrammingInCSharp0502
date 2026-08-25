using Microsoft.VisualBasic.ApplicationServices;
using ProgrammingInCSharp0502.Business;
using ProgrammingInCSharp0502.Business.Businesses;
using ProgrammingInCSharp0502.Domain;
using ProgrammingInCSharp0502.MyWindowsformApp.Forms;

namespace ProgrammingInCSharp0502.MyWindowsformApp
{
    public partial class StudentMangmentForm : Form
    {
        List<Student> students = new List<Student>();
        Student targetStudent = null;

        private readonly StudentBusiness _studentBusiness;


        public delegate void ReloadData(List<Student> myUsers);


        public event ReloadData ReloadDataEvent;


        public StudentMangmentForm(StudentBusiness studentBusiness)
        {
            InitializeComponent();
            _studentBusiness = studentBusiness;

            ReloadDataEvent += FillDataGrid;
            ReloadDataEvent.Invoke(studentBusiness.GetAll());

            RefreshForm();
            ResetForm();
        }

        private void FillDataGrid(List<Student> students)
        {
            studentDataGridView.DataSource = null;
            studentDataGridView.DataSource = students;
            studentDataGridView.Refresh();

            ResetForm();

            MessageBox.Show("Record Updated successfully");

        }


        private void registerStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Student student = new Student(firstName: firstNameTextBox.Text, lastName: lastNameTextBox.Text, nationalCode: nationalCodeTextBox.Text, phone: phonNumberTextBox.Text);
                //student.RegisterUser(firstName: firstNameTextBox.Text, lastName: lastNameTextBox.Text, nationalCode: nationalCodeTextBox.Text, phone: phonNumberTextBox.Text);
                //Student student = new Student();
                Student s = Student.RegisterUser(firstName: firstNameTextBox.Text,
                    lastName: lastNameTextBox.Text,
                    nationalCode: nationalCodeTextBox.Text,
                    phone: phonNumberTextBox.Text);

                _studentBusiness.Add(s);
                RefreshForm();
                ResetForm();
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

                // Access the ID from the row's data
                var id = int.Parse(row.Cells["Id"].Value.ToString() ?? "0");
                var code = row.Cells["Code"].Value;

                Clipboard.SetDataObject(code);

                //targetStudent = students

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Code == code)
                    {
                        targetStudent = students[i];
                        firstNameTextBox.Text = targetStudent.FirstName;
                        lastNameTextBox.Text = targetStudent.LastName;
                    }
                }

                // Display or use the ID
                MessageBox.Show($"Row ID: {id} & Code {code} Copied!");
            }
        }

        private void ResetForm()
        {
            firstNameTextBox.Text = null;
            lastNameTextBox.Text = null;
        }

        private void RefreshForm()
        {
            ReloadDataEvent.Invoke(_studentBusiness.GetAll());
        }

        private void updateIdentityButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(targetStudent.FirstName))
            {
                MessageBox.Show("لطفا ابتدا شخصی را انتخاب نمایید.");
                return;
            }

            targetStudent.UpdateFirstName(firstNameTextBox.Text);
            targetStudent.UpdateLastName(lastNameTextBox.Text);
            RefreshForm();
        }

        private void registerOnCoursebutton_Click(object sender, EventArgs e)
        {
            if (targetStudent is null)
            {
                MessageBox.Show("لطفا ابتدا دانشجویی را انتخاب نمایید.");
                return;
            }

            RegisterStudentOnCourseForm regForm = new(fullname: targetStudent.FullName ,code: targetStudent.Code);
            regForm.Show();

        }
    }
}
