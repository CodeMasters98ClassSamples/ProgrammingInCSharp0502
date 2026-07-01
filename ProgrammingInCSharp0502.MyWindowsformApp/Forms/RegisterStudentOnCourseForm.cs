using Newtonsoft.Json;
using ProgrammingInCSharp0502.Domain;


namespace ProgrammingInCSharp0502.MyWindowsformApp.Forms
{
    public partial class RegisterStudentOnCourseForm : Form
    {
        List<Student> students = new List<Student>();

        public RegisterStudentOnCourseForm()
        {

            fullNameTextBox.Text = "";
            studentCodeTextBox.Text = "";

            string jsonDataStr = string.Empty;
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "StudentsData.json");
            if (File.Exists(filePath))
            {
                jsonDataStr = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(jsonDataStr))
                {
                    students = JsonConvert.DeserializeObject<List<Student>>(jsonDataStr);
                    RefreshForm();
                }
            }
        }

        public RegisterStudentOnCourseForm(string fullname, string code):base()
        {
            InitializeComponent();

            fullNameTextBox.Text = fullname;
            studentCodeTextBox.Text = code;
        }


        private void RefreshForm()
        {
            studentDataGridView.DataSource = null;
            studentDataGridView.Refresh();
            studentDataGridView.DataSource = students;
        }
    }
}
