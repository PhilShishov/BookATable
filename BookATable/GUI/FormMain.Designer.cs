namespace BookATable.GUI
{
    partial class FormMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.usersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurantsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersMenuItem,
            this.restaurantsMenuItem,
            this.reservationsMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // usersMenuItem
            // 
            this.usersMenuItem.Name = "usersMenuItem";
            this.usersMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersMenuItem.Text = "Users";
            this.usersMenuItem.Click += new System.EventHandler(this.usersMenuItem_Click);
            // 
            // restaurantsMenuItem
            // 
            this.restaurantsMenuItem.Name = "restaurantsMenuItem";
            this.restaurantsMenuItem.Size = new System.Drawing.Size(80, 20);
            this.restaurantsMenuItem.Text = "Restaurants";
            this.restaurantsMenuItem.Click += new System.EventHandler(this.restaurantsMenuItem_Click);
            // 
            // reservationsMenuItem
            // 
            this.reservationsMenuItem.Name = "reservationsMenuItem";
            this.reservationsMenuItem.Size = new System.Drawing.Size(85, 20);
            this.reservationsMenuItem.Text = "Reservations";
            this.reservationsMenuItem.Click += new System.EventHandler(this.reservationsMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book a Table";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem usersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurantsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsMenuItem;
    }
}