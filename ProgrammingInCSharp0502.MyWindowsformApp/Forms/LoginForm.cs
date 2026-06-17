using Newtonsoft.Json;
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
        List<AdminLogin> logins = null;
        public LoginForm()
        {
            InitializeComponent();
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
            for (int i = 0; i < logins.Count; i++)
                if (logins[i].Username.Trim().ToLower() == username.Trim().ToLower() && logins[i].Password.Trim() == password.Trim())
                    successLogin = true;

            if (successLogin)
            {
                LayoutForm layout = new LayoutForm();
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
