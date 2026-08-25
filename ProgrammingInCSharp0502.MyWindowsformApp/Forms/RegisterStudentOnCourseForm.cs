using Newtonsoft.Json;
using ProgrammingInCSharp0502.Domain;


namespace ProgrammingInCSharp0502.MyWindowsformApp.Forms
{
    //Compile Time
    public partial class RegisterStudentOnCourseForm : Form
    {

        //Prevent Using new instance!
        //testability
        List<Student> students = new List<Student>();

        public RegisterStudentOnCourseForm()
        {
            //try
            //{
            //    fullNameTextBox.Text = "";
            //    studentCodeTextBox.Text = "";

            //    string jsonDataStr = string.Empty;
            //    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "StudentsData.json");
            //    string ext = Path.GetExtension(filePath);

            //    //Application 
            //    if (string.IsNullOrEmpty(ext) || ext.ToLower() != "json".ToLower())
            //    {
            //        //Exception
            //    }

            //    if (File.Exists(filePath))
            //    {
            //        jsonDataStr = File.ReadAllText(filePath);

            //        if (!string.IsNullOrEmpty(jsonDataStr))
            //        {
            //            students = JsonConvert.DeserializeObject<List<Student>>(jsonDataStr);
            //            RefreshForm();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    //General Message
            //    //Log => Database , Rabbit 
            //    throw;
            //}
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
