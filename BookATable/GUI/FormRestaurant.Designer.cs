namespace BookATable.GUI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormRestaurant
    {

        private IContainer components = null;

        private ToolStrip toolStrip1;
        private ToolStripButton AddButton;
        private ToolStripButton DeleteButton;
        private DataGridView dataGridViewRestaurant;
        private BindingSource bindingSourceRestaurant;
        private ToolStripButton EditButton;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormRestaurant));
            this.toolStrip1 = new ToolStrip();
            this.AddButton = new ToolStripButton();
            this.EditButton = new ToolStripButton();
            this.DeleteButton = new ToolStripButton();
            this.dataGridViewRestaurant = new DataGridView();
            this.bindingSourceRestaurant = new BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((ISupportInitialize)(this.dataGridViewRestaurant)).BeginInit();
            ((ISupportInitialize)(this.bindingSourceRestaurant)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = SystemColors.Control;
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
            this.EditButton.ForeColor = SystemColors.ControlText;
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
            // dataGridViewRestaurant
            // 
            this.dataGridViewRestaurant.AllowUserToAddRows = false;
            this.dataGridViewRestaurant.AllowUserToDeleteRows = false;
            this.dataGridViewRestaurant.AllowUserToOrderColumns = true;
            this.dataGridViewRestaurant.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.dataGridViewRestaurant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRestaurant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestaurant.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRestaurant.Location = new Point(0, 28);
            this.dataGridViewRestaurant.Name = "dataGridViewRestaurant";
            this.dataGridViewRestaurant.ReadOnly = true;
            this.dataGridViewRestaurant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRestaurant.Size = new Size(784, 330);
            this.dataGridViewRestaurant.TabIndex = 2;
            this.dataGridViewRestaurant.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewRestaurant_CellDoubleClick);
            // 
            // bindingSourceRestaurant
            // 
            this.bindingSourceRestaurant.CurrentChanged += new EventHandler(this.bindingSourceRestaurant_CurrentChanged);
            // 
            // FormRestaurant
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(784, 361);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewRestaurant);
            this.Name = "FormRestaurant";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Manage Restaurants";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((ISupportInitialize)(this.dataGridViewRestaurant)).EndInit();
            ((ISupportInitialize)(this.bindingSourceRestaurant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}