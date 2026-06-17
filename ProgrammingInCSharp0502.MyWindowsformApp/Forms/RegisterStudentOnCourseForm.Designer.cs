namespace ProgrammingInCSharp0502.MyWindowsformApp.Forms
{
    partial class RegisterStudentOnCourseForm
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
            studentDataGridView = new DataGridView();
            label1 = new Label();
            fullNameTextBox = new TextBox();
            label2 = new Label();
            studentCodeTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // studentDataGridView
            // 
            studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGridView.Location = new Point(12, 203);
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.Size = new Size(320, 235);
            studentDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 1;
            label1.Text = "نام و نام خوانوادگی دانشجو";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Enabled = false;
            fullNameTextBox.Location = new Point(166, 9);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(166, 23);
            fullNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 43);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "کد دانشجویی";
            // 
            // studentCodeTextBox
            // 
            studentCodeTextBox.Enabled = false;
            studentCodeTextBox.Location = new Point(166, 40);
            studentCodeTextBox.Name = "studentCodeTextBox";
            studentCodeTextBox.Size = new Size(166, 23);
            studentCodeTextBox.TabIndex = 4;
            // 
            // RegisterStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(studentCodeTextBox);
            Controls.Add(label2);
            Controls.Add(fullNameTextBox);
            Controls.Add(label1);
            Controls.Add(studentDataGridView);
            Name = "RegisterStudentForm";
            Text = "RegisterStudentForm";
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView studentDataGridView;
        private Label label1;
        private TextBox fullNameTextBox;
        private Label label2;
        private TextBox studentCodeTextBox;
    }
}