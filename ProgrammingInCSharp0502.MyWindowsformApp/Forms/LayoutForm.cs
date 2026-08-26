namespace ProgrammingInCSharp0502.MyWindowsformApp.Forms;

using Microsoft.Extensions.DependencyInjection;

public partial class LayoutForm : Form
{
    //Resolved from the DI container
    private readonly IServiceProvider _serviceProvider;

    public LayoutForm(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        InitializeComponent();
    }

    private void مدیریتدانشجویانToolStripMenuItem_Click(object sender, EventArgs e)
    {
        StudentMangmentForm form1 = _serviceProvider.GetRequiredService<StudentMangmentForm>();
        form1.ShowDialog();
    }

    private void مدیریتدورههاToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CourseForm courseForm = _serviceProvider.GetRequiredService<CourseForm>();
        courseForm.ShowDialog();
    }

    private void ثبتنامToolStripMenuItem_Click(object sender, EventArgs e)
    {
        RegisterStudentOnCourseForm regForm = new RegisterStudentOnCourseForm();
        regForm.ShowDialog();
    }
}
