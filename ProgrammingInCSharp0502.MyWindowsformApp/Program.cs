using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProgrammingInCSharp0502.Business.Businesses;
using ProgrammingInCSharp0502.Business.Data;
using ProgrammingInCSharp0502.Business.Interfaces;
using ProgrammingInCSharp0502.MyWindowsformApp.Forms;

namespace ProgrammingInCSharp0502.MyWindowsformApp;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    ///  Composition Root: every layer is wired here with the DI container.
    ///  Database-First ONLY -> single CoreDbContext on the EF Core InMemory provider.
    /// </summary>
    [STAThread]
    static async Task Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var services = new ServiceCollection();

        //----- Database-First: one DbContext on the EF InMemory provider (no real SqlServer, no migrations) -----
        services.AddDbContext<CoreDbContext>(options =>
            options.UseInMemoryDatabase("ProgrammingInCSharp0502Db"));

        //----- Business layer -----
        services.AddTransient<ICourseBusiness, CourseDatabaseFirstBusiness>();
        services.AddTransient<IStudentBusiness, StudentBusiness>();

        //----- Presentation layer (Forms) -----
        services.AddTransient<LoginForm>();
        services.AddTransient<LayoutForm>();
        services.AddTransient<StudentMangmentForm>();
        services.AddTransient<RegisterStudentOnCourseForm>();
        services.AddTransient<CourseForm>();

        using ServiceProvider serviceProvider = services.BuildServiceProvider();

        //----- Setup database at startup (make sure the in-memory store exists) -----
        await SetupDatabasesAsync(serviceProvider);

        Application.Run(serviceProvider.GetRequiredService<LoginForm>());
    }

    /// <summary>
    /// Creates the in-memory database store at application startup.
    /// Runs on a background thread so nothing blocks the UI.
    /// The result of the connection is shown under the login button (health check).
    /// </summary>
    private static async Task SetupDatabasesAsync(ServiceProvider serviceProvider)
    {
        await Task.Run(() =>
        {
            //Resolve inside a scope -> disposing the scope disposes only its own
            //scoped CoreDbContext, never the shared instance other forms use.
            using (var scope = serviceProvider.CreateScope())
            {
                var coreDbContext = scope.ServiceProvider.GetRequiredService<CoreDbContext>();
                coreDbContext.Database.EnsureCreated();
            }
        });
    }
}
