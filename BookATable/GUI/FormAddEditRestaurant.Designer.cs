namespace BookATable.GUI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormAddEditRestaurant
    {
        private IContainer components = null;

        private Label label1;
        private TextBox textBoxRestaurantName;
        private Label label2;
        private TextBox textBoxAddress;
        private Label label3;
        private TextBox textBoxPhone;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonSave;
        private Button buttonCancel;
        private NumericUpDown numUpDownCapacity;
        private DateTimePicker dateTimePickerOpen;
        private DateTimePicker dateTimePickerClose;

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
            this.label1 = new Label();
            this.textBoxRestaurantName = new TextBox();
            this.label2 = new Label();
            this.textBoxAddress = new TextBox();
            this.label3 = new Label();
            this.textBoxPhone = new TextBox();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.buttonSave = new Button();
            this.buttonCancel = new Button();
            this.numUpDownCapacity = new NumericUpDown();
            this.dateTimePickerOpen = new DateTimePicker();
            this.dateTimePickerClose = new DateTimePicker();
            ((ISupportInitialize)(this.numUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxRestaurantName
            // 
            this.textBoxRestaurantName.Location = new Point(81, 6);
            this.textBoxRestaurantName.Name = "textBoxRestaurantName";
            this.textBoxRestaurantName.Size = new Size(193, 20);
            this.textBoxRestaurantName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(30, 47);
            this.label2.Name = "label2";
            this.label2.Size = new Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new Point(81, 32);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(193, 41);
            this.textBoxAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(37, 82);
            this.label3.Name = "label3";
            this.label3.Size = new Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new Point(81, 79);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new Size(193, 20);
            this.textBoxPhone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(27, 105);
            this.label4.Name = "label4";
            this.label4.Size = new Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(16, 131);
            this.label5.Name = "label5";
            this.label5.Size = new Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Open Hour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(16, 155);
            this.label6.Name = "label6";
            this.label6.Size = new Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Close Hour";
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = DialogResult.OK;
            this.buttonSave.Location = new Point(97, 186);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new Point(199, 186);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // numUpDownCapacity
            // 
            this.numUpDownCapacity.Location = new Point(81, 104);
            this.numUpDownCapacity.Margin = new Padding(2);
            this.numUpDownCapacity.Name = "numUpDownCapacity";
            this.numUpDownCapacity.Size = new Size(70, 20);
            this.numUpDownCapacity.TabIndex = 14;
            // 
            // dateTimePickerOpen
            // 
            this.dateTimePickerOpen.CustomFormat = "HH:mm";
            this.dateTimePickerOpen.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerOpen.Location = new Point(81, 128);
            this.dateTimePickerOpen.Margin = new Padding(2);
            this.dateTimePickerOpen.Name = "dateTimePickerOpen";
            this.dateTimePickerOpen.ShowUpDown = true;
            this.dateTimePickerOpen.Size = new Size(193, 20);
            this.dateTimePickerOpen.TabIndex = 15;
            // 
            // dateTimePickerClose
            // 
            this.dateTimePickerClose.CustomFormat = "HH:mm";
            this.dateTimePickerClose.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerClose.Location = new Point(81, 152);
            this.dateTimePickerClose.Margin = new Padding(2);
            this.dateTimePickerClose.Name = "dateTimePickerClose";
            this.dateTimePickerClose.ShowUpDown = true;
            this.dateTimePickerClose.Size = new Size(193, 20);
            this.dateTimePickerClose.TabIndex = 16;
            // 
            // FormAddEditRestaurant
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(297, 222);
            this.Controls.Add(this.dateTimePickerClose);
            this.Controls.Add(this.dateTimePickerOpen);
            this.Controls.Add(this.numUpDownCapacity);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRestaurantName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddEditRestaurant";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Restaurant";
            this.Load += new EventHandler(this.FormAddEditRestaurant_Load);
            ((ISupportInitialize)(this.numUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}