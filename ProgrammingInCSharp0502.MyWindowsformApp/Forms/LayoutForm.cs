namespace ProgrammingInCSharp0502.MyWindowsformApp.Forms;

public partial class LayoutForm : Form
{
    public LayoutForm()
    {
        InitializeComponent();
    }

    private void مدیریتدانشجویانToolStripMenuItem_Click(object sender, EventArgs e)
    {
        StudentMangmentForm form1 = new StudentMangmentForm();
        form1.ShowDialog();
    }

    private void ثبتنامToolStripMenuItem_Click(object sender, EventArgs e)
    {
        RegisterStudentOnCourseForm regForm = new RegisterStudentOnCourseForm();
        regForm.ShowDialog();
    }
}
