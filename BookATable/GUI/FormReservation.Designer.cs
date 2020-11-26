namespace BookATable.GUI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormReservation
    {
        private IContainer components = null;

        private BindingSource bindingSourceReserve;
        private ToolStripButton AddButton;
        private ToolStripButton EditButton;
        private ToolStripButton DeleteButton;
        private ToolStrip toolStrip1;
        private DataGridView dataGridViewReserve;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormReservation));
            this.bindingSourceReserve = new BindingSource(this.components);
            this.AddButton = new ToolStripButton();
            this.EditButton = new ToolStripButton();
            this.DeleteButton = new ToolStripButton();
            this.toolStrip1 = new ToolStrip();
            this.dataGridViewReserve = new DataGridView();
            ((ISupportInitialize)(this.bindingSourceReserve)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((ISupportInitialize)(this.dataGridViewReserve)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceReserve
            // 
            this.bindingSourceReserve.CurrentChanged += new EventHandler(this.bindingSourceReserve_CurrentChanged);
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new ToolStripItem[] {
            this.AddButton,
            this.EditButton,
            this.DeleteButton});
            this.toolStrip1.Location = new Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridViewReserve
            // 
            this.dataGridViewReserve.AllowUserToAddRows = false;
            this.dataGridViewReserve.AllowUserToDeleteRows = false;
            this.dataGridViewReserve.AllowUserToOrderColumns = true;
            this.dataGridViewReserve.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.dataGridViewReserve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewReserve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReserve.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewReserve.Location = new Point(0, 28);
            this.dataGridViewReserve.MultiSelect = false;
            this.dataGridViewReserve.Name = "dataGridViewReserve";
            this.dataGridViewReserve.ReadOnly = true;
            this.dataGridViewReserve.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReserve.Size = new Size(784, 333);
            this.dataGridViewReserve.TabIndex = 1;
            this.dataGridViewReserve.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewReserve_CellDoubleClick);
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.AppWorkspace;
            this.ClientSize = new Size(784, 361);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewReserve);
            this.Name = "FormReservation";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Manage Reservations";
            ((ISupportInitialize)(this.bindingSourceReserve)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((ISupportInitialize)(this.dataGridViewReserve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}