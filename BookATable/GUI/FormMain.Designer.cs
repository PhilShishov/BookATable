namespace BookATable.GUI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormMain
    {       
        private IContainer components = null;

        private MenuStrip menuStripMain;
        private ToolStripMenuItem usersMenuItem;
        private ToolStripMenuItem restaurantsMenuItem;
        private ToolStripMenuItem reservationsMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStripMain = new MenuStrip();
            this.usersMenuItem = new ToolStripMenuItem();
            this.restaurantsMenuItem = new ToolStripMenuItem();
            this.reservationsMenuItem = new ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new ToolStripItem[] {
            this.usersMenuItem,
            this.restaurantsMenuItem,
            this.reservationsMenuItem});
            this.menuStripMain.Location = new Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new Size(784, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // usersMenuItem
            // 
            this.usersMenuItem.Name = "usersMenuItem";
            this.usersMenuItem.Size = new Size(47, 20);
            this.usersMenuItem.Text = "Users";
            this.usersMenuItem.Click += new EventHandler(this.usersMenuItem_Click);
            // 
            // restaurantsMenuItem
            // 
            this.restaurantsMenuItem.Name = "restaurantsMenuItem";
            this.restaurantsMenuItem.Size = new Size(80, 20);
            this.restaurantsMenuItem.Text = "Restaurants";
            this.restaurantsMenuItem.Click += new EventHandler(this.restaurantsMenuItem_Click);
            // 
            // reservationsMenuItem
            // 
            this.reservationsMenuItem.Name = "reservationsMenuItem";
            this.reservationsMenuItem.Size = new Size(85, 20);
            this.reservationsMenuItem.Text = "Reservations";
            this.reservationsMenuItem.Click += new EventHandler(this.reservationsMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(784, 562);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Book a Table";
            this.WindowState = FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}