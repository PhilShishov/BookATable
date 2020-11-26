namespace BookATable.GUI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormUser
    {
        private IContainer components = null;

        private DataGridView dataGridViewUsers;
        private BindingSource bindingSourceUsers;
        private ToolStrip toolStrip1;
        private ToolStripButton AddButton;
        private ToolStripButton EditButton;
        private ToolStripButton DeleteButton;

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
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormUser));
            this.dataGridViewUsers = new DataGridView();
            this.bindingSourceUsers = new BindingSource(this.components);
            this.toolStrip1 = new ToolStrip();
            this.AddButton = new ToolStripButton();
            this.EditButton = new ToolStripButton();
            this.DeleteButton = new ToolStripButton();
            ((ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            this.dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = DockStyle.Fill;
            this.dataGridViewUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewUsers.Location = new Point(0, 25);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new Size(784, 336);
            this.dataGridViewUsers.TabIndex = 1;
            this.dataGridViewUsers.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewUsers_CellDoubleClick);
            // 
            // bindingSourceUsers
            // 
            this.bindingSourceUsers.CurrentChanged += new EventHandler(this.bindingSourceUsers_CurrentChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new ToolStripItem[] {
            this.AddButton,
            this.EditButton,
            this.DeleteButton});
            this.toolStrip1.Location = new Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.AddButton.Image = ((Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new Size(33, 22);
            this.AddButton.Text = "Add";
            this.AddButton.Click += new EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.EditButton.Image = ((Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new Size(31, 22);
            this.EditButton.Text = "Edit";
            this.EditButton.Click += new EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.DeleteButton.Image = ((Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new Size(44, 22);
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new EventHandler(this.DeleteButton_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(784, 361);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormUsers";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            ((ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}