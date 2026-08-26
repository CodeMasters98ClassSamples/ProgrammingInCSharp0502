using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;
using ProgrammingInCSharp0502.Business.Data;
using ProgrammingInCSharp0502.MyWindowsformApp.Dtos;
using ProgrammingInCSharp0502.MyWindowsformApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingInCSharp0502.MyWindowsformApp
{
    public partial class LoginForm : Form
    {
        //Resolved from the DI container
        private readonly IServiceProvider _serviceProvider;

        List<AdminLogin> logins = null;
        public LoginForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();

            //Check the database connection (setup already ran in Program.Main)
            Load += async (s, e) => await CheckDatabaseHealthAsync();
            string jsonDataStr = string.Empty;
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "AdminLogins.json");
            if (File.Exists(filePath))
            {
                jsonDataStr = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(jsonDataStr))
                {
                    logins = JsonConvert.DeserializeObject<List<AdminLogin>>(jsonDataStr);
                }
            }

        }

        /// <summary>
        /// Runs the connection health check off the UI thread and
        /// shows the result (green/red) under the login button.
        /// </summary>
        private async Task CheckDatabaseHealthAsync()
        {
            bool isHealthy = false;
            string message = string.Empty;

            await Task.Run(() =>
            {
                try
                {
                    //Database-First -> EF InMemory (health check on the single DbContext)
                    //IMPORTANT: resolve inside a scope. Disposing a context resolved from
                    //the root provider would kill the shared instance (ObjectDisposedException).
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var coreDbContext = scope.ServiceProvider.GetRequiredService<CoreDbContext>();
                        isHealthy = coreDbContext.Database.CanConnect();
                    }
                }
                catch (Exception ex)
                {
                    isHealthy = false;
                    message = ex.Message;
                }
            });

            if (isHealthy)
            {
                dbStatusLabel.Text = "✓ اتصال دیتابیس برقرار است";
                dbStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                dbStatusLabel.Text = string.IsNullOrEmpty(message)
                    ? "✗ اتصال دیتابیس برقرار نیست"
                    : $"✗ خطای اتصال دیتابیس: {message}";
                dbStatusLabel.ForeColor = Color.Red;
            }
        }

        private void lgonButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            bool successLogin = false;

            if (logins is null || logins.Count == 0)
            {
                MessageBox.Show("لطفا ابتدا فایل کانفیگ ورود ادمین ها را ایجاد نمایید.");
                return;
            }

            //Loop over
            //for (int i = 0; i < logins.Count; i++)
            //    if (logins[i].Username.Trim().ToLower() == username.Trim().ToLower() && logins[i].Password.Trim() == password.Trim())
            //        successLogin = true;

            if (logins.Any(x => x.Username == username.Trim().ToLower() && x.Password == password.Trim()))
                successLogin = true;

            if (successLogin)
            {
                LayoutForm layout = _serviceProvider.GetRequiredService<LayoutForm>();
                layout.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("لطفا نام کاربری یا رمز عبور را درست وارد نمایید.");
            }
        }
    }
}
