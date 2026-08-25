using ProgrammingInCSharp0502.Business;
using ProgrammingInCSharp0502.Business.Businesses;
using ProgrammingInCSharp0502.DataAccess.Data;

namespace ProgrammingInCSharp0502.MyWindowsformApp.Forms;

public partial class LayoutForm : Form
{
    public LayoutForm()
    {
        InitializeComponent();
    }

    private void مدیریتدانشجویانToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //StudentMangmentForm form1 = new StudentMangmentForm();
        //form1.ShowDialog();
        var context = new CoreDbContext();
        var studentBusiness = new StudentBusiness(context);
        StudentMangmentForm form1 = new StudentMangmentForm(studentBusiness);
        form1.ShowDialog();
    }

    private void ثبتنامToolStripMenuItem_Click(object sender, EventArgs e)
    {
        RegisterStudentOnCourseForm regForm = new RegisterStudentOnCourseForm();
        regForm.ShowDialog();
    }

    private void اضافهکردندستهبندیدورههاToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //CategoryForm categoryForm = new CategoryForm();
        //categoryForm.ShowDialog();
        var context = new CoreDbContext();
        var categoryBusiness = new CategoryBusiness(context);
        CategoryForm categoryForm = new CategoryForm(categoryBusiness);
        categoryForm.ShowDialog();
    }

    private void اضافهکردندورهجدیدToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //Course courseForm = new Course();
        //courseForm.ShowDialog();
        var context = new CoreDbContext();
        var categoryBusiness = new CategoryBusiness(context);
        var courseBusiness = new CourseBusiness(context);
        CourseForm courseForm = new CourseForm(categoryBusiness, courseBusiness);
        courseForm.ShowDialog();
    }
}
