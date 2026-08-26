namespace ProgrammingInCSharp0502.MyWindowsformApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lgonButton = new Button();
            dbStatusLabel = new Label();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(84, 32);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(169, 23);
            userNameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(84, 72);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(169, 23);
            passwordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "نام کاربری: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 72);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "رمز عبور:";
            // 
            // lgonButton
            // 
            lgonButton.Location = new Point(16, 112);
            lgonButton.Name = "lgonButton";
            lgonButton.Size = new Size(237, 34);
            lgonButton.TabIndex = 4;
            lgonButton.Text = "ورود";
            lgonButton.UseVisualStyleBackColor = true;
            lgonButton.Click += lgonButton_Click;
            //
            // dbStatusLabel
            //
            dbStatusLabel.Location = new Point(16, 150);
            dbStatusLabel.Name = "dbStatusLabel";
            dbStatusLabel.Size = new Size(237, 18);
            dbStatusLabel.TabIndex = 5;
            dbStatusLabel.Text = "در حال بررسی اتصال دیتابیس ...";
            dbStatusLabel.ForeColor = Color.Orange;
            dbStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            //
            // LoginForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 185);
            Controls.Add(dbStatusLabel);
            Controls.Add(lgonButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private Button lgonButton;
        private Label dbStatusLabel;
    }
}