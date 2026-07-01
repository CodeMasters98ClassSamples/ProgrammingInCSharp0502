using ProgrammingInCSharp0502.Business;
using ProgrammingInCSharp0502.Domain;
using ProgrammingInCSharp0502.MyWindowsformApp.Forms;

namespace ProgrammingInCSharp0502.MyWindowsformApp
{
    public partial class StudentMangmentForm : Form
    {
        //Global Vaibale
        // Hold Data => File (csv, json, xml , txt, ..) , Database (SQL , NoSQL) => Sql server, MySql , Mongo
        // Collection => Array , List , Dic
        // Data Application => Database , Cache , Queue

        // Garbage Collector => 12
        // Files => 15

        //Pattern -> Resuing Code

        List<Student> students = new List<Student>();
        Student targetStudent = null;
        StudentBusiness studentBusiness = new();

        public StudentMangmentForm()
        {
            InitializeComponent();

            students = studentBusiness.GetStudents();

            RefreshForm();
            ResetForm();
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

                students.Add(s);
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
            studentDataGridView.DataSource = null;
            studentDataGridView.Refresh();
            studentDataGridView.DataSource = students;
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
