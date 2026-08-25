namespace ProgrammingInCSharp0502.MyWindowsformApp.Forms
{
    partial class CourseForm
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
            Label titleLabel;
            titleTextBox = new TextBox();
            priceTextBox = new TextBox();
            priceLabel = new Label();
            onSitetextBox = new TextBox();
            label3 = new Label();
            hourtextBox = new TextBox();
            label4 = new Label();
            descriptionLabel = new Label();
            descriptionTextBox = new TextBox();
            onlinetextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            categoryComboBox = new ComboBox();
            saveButton = new Button();
            coursedataGridView1 = new DataGridView();
            titleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)coursedataGridView1).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(29, 32);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(55, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "عنوان";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(137, 32);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(275, 31);
            titleTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(582, 35);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(275, 31);
            priceTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(461, 35);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(55, 25);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "قیمت";
            priceLabel.Click += label2_Click;
            // 
            // onSitetextBox
            // 
            onSitetextBox.Location = new Point(582, 152);
            onSitetextBox.Name = "onSitetextBox";
            onSitetextBox.Size = new Size(275, 31);
            onSitetextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 155);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 4;
            label3.Text = "تعداد حضوری";
            // 
            // hourtextBox
            // 
            hourtextBox.Location = new Point(582, 87);
            hourtextBox.Name = "hourtextBox";
            hourtextBox.Size = new Size(275, 31);
            hourtextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 90);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 6;
            label4.Text = "زمان دوره";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(29, 93);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(84, 25);
            descriptionLabel.TabIndex = 8;
            descriptionLabel.Text = "توضیحات";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(137, 90);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(275, 90);
            descriptionTextBox.TabIndex = 9;
            // 
            // onlinetextBox
            // 
            onlinetextBox.Location = new Point(582, 211);
            onlinetextBox.Name = "onlinetextBox";
            onlinetextBox.Size = new Size(275, 31);
            onlinetextBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(461, 214);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 10;
            label1.Text = "تعداد انلاین";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 270);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 12;
            label2.Text = "دسته بندی";
            label2.Click += label2_Click_1;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(582, 270);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(275, 33);
            categoryComboBox.TabIndex = 13;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(424, 384);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 14;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // coursedataGridView1
            // 
            coursedataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursedataGridView1.Location = new Point(29, 474);
            coursedataGridView1.Name = "coursedataGridView1";
            coursedataGridView1.RowHeadersWidth = 62;
            coursedataGridView1.Size = new Size(981, 379);
            coursedataGridView1.TabIndex = 15;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 893);
            Controls.Add(coursedataGridView1);
            Controls.Add(saveButton);
            Controls.Add(categoryComboBox);
            Controls.Add(label2);
            Controls.Add(onlinetextBox);
            Controls.Add(label1);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(hourtextBox);
            Controls.Add(label4);
            Controls.Add(onSitetextBox);
            Controls.Add(label3);
            Controls.Add(priceTextBox);
            Controls.Add(priceLabel);
            Controls.Add(titleTextBox);
            Controls.Add(titleLabel);
            Name = "CourseForm";
            Text = "Course";
            ((System.ComponentModel.ISupportInitialize)coursedataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox titleTextBox;
        private TextBox priceTextBox;
        private Label priceLabel;
        private TextBox onSitetextBox;
        private Label label3;
        private TextBox hourtextBox;
        private Label label4;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private TextBox onlinetextBox;
        private Label label1;
        private Label label2;
        private ComboBox categoryComboBox;
        private Button saveButton;
        private DataGridView coursedataGridView1;
    }
}