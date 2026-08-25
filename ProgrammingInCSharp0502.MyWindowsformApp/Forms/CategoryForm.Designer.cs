namespace ProgrammingInCSharp0502.MyWindowsformApp.Forms
{
    partial class CategoryForm
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
            titleLabel = new Label();
            descriptionLabel = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            saveButton = new Button();
            categoryDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(35, 42);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(55, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "عنوان";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 98);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(84, 25);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "توضیحات";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(109, 36);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(233, 31);
            titleTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(109, 98);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(233, 106);
            descriptionTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(109, 250);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 4;
            saveButton.Text = "ثبت";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // categoryDataGridView
            // 
            categoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryDataGridView.Location = new Point(497, 42);
            categoryDataGridView.Margin = new Padding(4, 5, 4, 5);
            categoryDataGridView.Name = "categoryDataGridView";
            categoryDataGridView.RowHeadersWidth = 62;
            categoryDataGridView.Size = new Size(420, 340);
            categoryDataGridView.TabIndex = 10;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 423);
            Controls.Add(categoryDataGridView);
            Controls.Add(saveButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Name = "Category";
            Text = "Category";
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label descriptionLabel;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Button saveButton;
        private DataGridView categoryDataGridView;
    }
}