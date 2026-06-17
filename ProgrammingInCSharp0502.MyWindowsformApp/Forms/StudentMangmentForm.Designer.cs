namespace ProgrammingInCSharp0502.MyWindowsformApp
{
    partial class StudentMangmentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameTextBox = new TextBox();
            label1 = new Label();
            registerStudentButton = new Button();
            label2 = new Label();
            phonNumberTextBox = new TextBox();
            label3 = new Label();
            nationalCodeTextBox = new TextBox();
            label4 = new Label();
            lastNameTextBox = new TextBox();
            studentDataGridView = new DataGridView();
            updateIdentityButton = new Button();
            registerOnCoursebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(106, 29);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(165, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 32);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "نام";
            // 
            // registerStudentButton
            // 
            registerStudentButton.Location = new Point(40, 165);
            registerStudentButton.Name = "registerStudentButton";
            registerStudentButton.Size = new Size(231, 39);
            registerStudentButton.TabIndex = 2;
            registerStudentButton.Text = "ثبت نام دانشجو";
            registerStudentButton.UseVisualStyleBackColor = true;
            registerStudentButton.Click += registerStudentButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 139);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "تلفن همراه";
            // 
            // phonNumberTextBox
            // 
            phonNumberTextBox.Location = new Point(106, 136);
            phonNumberTextBox.Name = "phonNumberTextBox";
            phonNumberTextBox.Size = new Size(165, 23);
            phonNumberTextBox.TabIndex = 3;
            phonNumberTextBox.Text = "09129564205";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 107);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "کدملی";
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(106, 104);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(165, 23);
            nationalCodeTextBox.TabIndex = 2;
            nationalCodeTextBox.Text = "1111111111";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 68);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 8;
            label4.Text = "نام خانوادگی";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(106, 65);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(165, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // studentDataGridView
            // 
            studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGridView.Location = new Point(309, 29);
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.Size = new Size(479, 399);
            studentDataGridView.TabIndex = 9;
            studentDataGridView.CellClick += studentDataGridView_CellClick;
            // 
            // updateIdentityButton
            // 
            updateIdentityButton.Location = new Point(40, 210);
            updateIdentityButton.Name = "updateIdentityButton";
            updateIdentityButton.Size = new Size(231, 39);
            updateIdentityButton.TabIndex = 10;
            updateIdentityButton.Text = "ویرایش اطلاعات هویتی";
            updateIdentityButton.UseVisualStyleBackColor = true;
            updateIdentityButton.Click += updateIdentityButton_Click;
            // 
            // registerOnCoursebutton
            // 
            registerOnCoursebutton.Location = new Point(40, 255);
            registerOnCoursebutton.Name = "registerOnCoursebutton";
            registerOnCoursebutton.Size = new Size(231, 39);
            registerOnCoursebutton.TabIndex = 11;
            registerOnCoursebutton.Text = "ثبت نام دوره";
            registerOnCoursebutton.UseVisualStyleBackColor = true;
            registerOnCoursebutton.Click += registerOnCoursebutton_Click;
            // 
            // StudentMangmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registerOnCoursebutton);
            Controls.Add(updateIdentityButton);
            Controls.Add(studentDataGridView);
            Controls.Add(label4);
            Controls.Add(lastNameTextBox);
            Controls.Add(label3);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(label2);
            Controls.Add(phonNumberTextBox);
            Controls.Add(registerStudentButton);
            Controls.Add(label1);
            Controls.Add(firstNameTextBox);
            Name = "StudentMangmentForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private Label label1;
        private Button registerStudentButton;
        private Label label2;
        private TextBox phonNumberTextBox;
        private Label label3;
        private TextBox nationalCodeTextBox;
        private Label label4;
        private TextBox lastNameTextBox;
        private DataGridView studentDataGridView;
        private Button updateIdentityButton;
        private Button registerOnCoursebutton;
    }
}
