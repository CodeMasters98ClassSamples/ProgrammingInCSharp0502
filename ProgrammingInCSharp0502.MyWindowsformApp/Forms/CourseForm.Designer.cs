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
        /// <param name="disposing">true if managed resources should be disposed, otherwise; false.</param>
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourLabel = new System.Windows.Forms.Label();
            this.hourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.onSiteSizeLabel = new System.Windows.Forms.Label();
            this.onSiteSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.remoteSizeLabel = new System.Windows.Forms.Label();
            this.remoteSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onSiteSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            this.SuspendLayout();
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 78);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 15);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            //
            // titleTextBox
            //
            this.titleTextBox.Location = new System.Drawing.Point(120, 75);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(220, 23);
            this.titleTextBox.TabIndex = 3;
            //
            // descriptionLabel
            //
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 107);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(73, 15);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description:";
            //
            // descriptionTextBox
            //
            this.descriptionTextBox.Location = new System.Drawing.Point(120, 104);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(220, 52);
            this.descriptionTextBox.TabIndex = 5;
            //
            // priceLabel
            //
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 172);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(36, 15);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price:";
            //
            // priceNumericUpDown
            //
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(120, 170);
            this.priceNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.priceNumericUpDown.TabIndex = 6;
            //
            // hourLabel
            //
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(12, 205);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(33, 15);
            this.hourLabel.TabIndex = 8;
            this.hourLabel.Text = "Hour:";
            //
            // hourNumericUpDown
            //
            this.hourNumericUpDown.Location = new System.Drawing.Point(120, 203);
            this.hourNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.hourNumericUpDown.Name = "hourNumericUpDown";
            this.hourNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.hourNumericUpDown.TabIndex = 9;
            //
            // onSiteSizeLabel
            //
            this.onSiteSizeLabel.AutoSize = true;
            this.onSiteSizeLabel.Location = new System.Drawing.Point(12, 238);
            this.onSiteSizeLabel.Name = "onSiteSizeLabel";
            this.onSiteSizeLabel.Size = new System.Drawing.Size(71, 15);
            this.onSiteSizeLabel.TabIndex = 10;
            this.onSiteSizeLabel.Text = "OnSite Size:";
            //
            // onSiteSizeNumericUpDown
            //
            this.onSiteSizeNumericUpDown.Location = new System.Drawing.Point(120, 236);
            this.onSiteSizeNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.onSiteSizeNumericUpDown.Name = "onSiteSizeNumericUpDown";
            this.onSiteSizeNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.onSiteSizeNumericUpDown.TabIndex = 11;
            //
            // remoteSizeLabel
            //
            this.remoteSizeLabel.AutoSize = true;
            this.remoteSizeLabel.Location = new System.Drawing.Point(12, 271);
            this.remoteSizeLabel.Name = "remoteSizeLabel";
            this.remoteSizeLabel.Size = new System.Drawing.Size(80, 15);
            this.remoteSizeLabel.TabIndex = 12;
            this.remoteSizeLabel.Text = "Remote Size:";
            //
            // remoteSizeNumericUpDown
            //
            this.remoteSizeNumericUpDown.Location = new System.Drawing.Point(120, 269);
            this.remoteSizeNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.remoteSizeNumericUpDown.Name = "remoteSizeNumericUpDown";
            this.remoteSizeNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.remoteSizeNumericUpDown.TabIndex = 13;
            //
            // addButton
            //
            this.addButton.Location = new System.Drawing.Point(360, 75);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 28);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            //
            // updateButton
            //
            this.updateButton.Location = new System.Drawing.Point(456, 75);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(90, 28);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            //
            // deleteButton
            //
            this.deleteButton.Location = new System.Drawing.Point(360, 109);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 28);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            //
            // newButton
            //
            this.newButton.Location = new System.Drawing.Point(456, 109);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(90, 28);
            this.newButton.TabIndex = 17;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            //
            // courseDataGridView
            //
            this.courseDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Location = new System.Drawing.Point(12, 310);
            this.courseDataGridView.MultiSelect = false;
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.ReadOnly = true;
            this.courseDataGridView.RowHeadersWidth = 51;
            this.courseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseDataGridView.Size = new System.Drawing.Size(860, 300);
            this.courseDataGridView.TabIndex = 18;
            this.courseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDataGridView_CellClick);
            //
            // CourseForm
            //
            this.ClientSize = new System.Drawing.Size(884, 622);
            this.Controls.Add(this.courseDataGridView);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.remoteSizeNumericUpDown);
            this.Controls.Add(this.remoteSizeLabel);
            this.Controls.Add(this.onSiteSizeNumericUpDown);
            this.Controls.Add(this.onSiteSizeLabel);
            this.Controls.Add(this.hourNumericUpDown);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "CourseForm";
            this.Text = "Course Management";
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onSiteSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.NumericUpDown hourNumericUpDown;
        private System.Windows.Forms.Label onSiteSizeLabel;
        private System.Windows.Forms.NumericUpDown onSiteSizeNumericUpDown;
        private System.Windows.Forms.Label remoteSizeLabel;
        private System.Windows.Forms.NumericUpDown remoteSizeNumericUpDown;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.DataGridView courseDataGridView;
    }
}
