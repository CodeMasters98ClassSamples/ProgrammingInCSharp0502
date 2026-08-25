namespace ProgrammingInCSharp0502.MyWindowsformApp.Forms
{
    partial class LayoutForm
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
            menuStrip1 = new MenuStrip();
            مدیریتدانشجویانToolStripMenuItem = new ToolStripMenuItem();
            ثبتنامToolStripMenuItem = new ToolStripMenuItem();
            مدیریتدورههاToolStripMenuItem = new ToolStripMenuItem();
            اضافهکردندستهبندیدورههاToolStripMenuItem = new ToolStripMenuItem();
            اضافهکردندورهجدیدToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { مدیریتدانشجویانToolStripMenuItem, مدیریتدورههاToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // مدیریتدانشجویانToolStripMenuItem
            // 
            مدیریتدانشجویانToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ثبتنامToolStripMenuItem });
            مدیریتدانشجویانToolStripMenuItem.Name = "مدیریتدانشجویانToolStripMenuItem";
            مدیریتدانشجویانToolStripMenuItem.Size = new Size(172, 29);
            مدیریتدانشجویانToolStripMenuItem.Text = "مدیریت دانشجویان";
            مدیریتدانشجویانToolStripMenuItem.Click += مدیریتدانشجویانToolStripMenuItem_Click;
            // 
            // ثبتنامToolStripMenuItem
            // 
            ثبتنامToolStripMenuItem.Name = "ثبتنامToolStripMenuItem";
            ثبتنامToolStripMenuItem.Size = new Size(170, 34);
            ثبتنامToolStripMenuItem.Text = "ثبت نام";
            ثبتنامToolStripMenuItem.Click += ثبتنامToolStripMenuItem_Click;
            // 
            // مدیریتدورههاToolStripMenuItem
            // 
            مدیریتدورههاToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { اضافهکردندستهبندیدورههاToolStripMenuItem, اضافهکردندورهجدیدToolStripMenuItem });
            مدیریتدورههاToolStripMenuItem.Name = "مدیریتدورههاToolStripMenuItem";
            مدیریتدورههاToolStripMenuItem.Size = new Size(147, 29);
            مدیریتدورههاToolStripMenuItem.Text = "مدیریت دوره ها";
            // 
            // اضافهکردندستهبندیدورههاToolStripMenuItem
            // 
            اضافهکردندستهبندیدورههاToolStripMenuItem.Name = "اضافهکردندستهبندیدورههاToolStripMenuItem";
            اضافهکردندستهبندیدورههاToolStripMenuItem.Size = new Size(345, 34);
            اضافهکردندستهبندیدورههاToolStripMenuItem.Text = "اضافه کردن دسته بندی دوره ها";
            اضافهکردندستهبندیدورههاToolStripMenuItem.Click += اضافهکردندستهبندیدورههاToolStripMenuItem_Click;
            // 
            // اضافهکردندورهجدیدToolStripMenuItem
            // 
            اضافهکردندورهجدیدToolStripMenuItem.Name = "اضافهکردندورهجدیدToolStripMenuItem";
            اضافهکردندورهجدیدToolStripMenuItem.Size = new Size(345, 34);
            اضافهکردندورهجدیدToolStripMenuItem.Text = "اضافه کردن دوره جدید";
            اضافهکردندورهجدیدToolStripMenuItem.Click += اضافهکردندورهجدیدToolStripMenuItem_Click;
            // 
            // LayoutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LayoutForm";
            Text = "LayoutForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem مدیریتدانشجویانToolStripMenuItem;
        private ToolStripMenuItem ثبتنامToolStripMenuItem;
        private ToolStripMenuItem مدیریتدورههاToolStripMenuItem;
        private ToolStripMenuItem اضافهکردندورهجدیدToolStripMenuItem;
        private ToolStripMenuItem اضافهکردندستهبندیدورههاToolStripMenuItem;
    }
}