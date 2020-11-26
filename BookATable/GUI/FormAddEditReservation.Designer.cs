namespace BookATable.GUI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormAddEditReservation
    {
        private IContainer components = null;

        private Label label1;
        private Label label3;
        private TextBox textBoxComment;
        private Button buttonSave;
        private Button buttonCancel;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown NumPeopleUpDown;
        private ComboBox cmbRestaurants;
        private Label label2;
        private Label label4;
        private BindingSource bindingSourceRestaurant;
        private Label label5;
        private ComboBox cmbUsers;
        private BindingSource bindingSourceUser;

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
            this.label1 = new Label();
            this.label3 = new Label();
            this.textBoxComment = new TextBox();
            this.buttonSave = new Button();
            this.buttonCancel = new Button();
            this.dateTimePicker1 = new DateTimePicker();
            this.NumPeopleUpDown = new NumericUpDown();
            this.cmbRestaurants = new ComboBox();
            this.label2 = new Label();
            this.label4 = new Label();
            this.bindingSourceRestaurant = new BindingSource(this.components);
            this.label5 = new Label();
            this.cmbUsers = new ComboBox();
            this.bindingSourceUser = new BindingSource(this.components);
            ((ISupportInitialize)(this.NumPeopleUpDown)).BeginInit();
            ((ISupportInitialize)(this.bindingSourceRestaurant)).BeginInit();
            ((ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date and time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(44, 179);
            this.label3.Name = "label3";
            this.label3.Size = new Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comments";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new Point(106, 117);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new Size(191, 132);
            this.textBoxComment.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = DialogResult.OK;
            this.buttonSave.Location = new Point(116, 271);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new Point(222, 271);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new Point(106, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new Size(191, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // NumPeopleUpDown
            // 
            this.NumPeopleUpDown.Location = new Point(106, 93);
            this.NumPeopleUpDown.Margin = new Padding(2);
            this.NumPeopleUpDown.Name = "NumPeopleUpDown";
            this.NumPeopleUpDown.Size = new Size(80, 20);
            this.NumPeopleUpDown.TabIndex = 12;
            // 
            // cmbRestaurants
            // 
            this.cmbRestaurants.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRestaurants.FormattingEnabled = true;
            this.cmbRestaurants.Location = new Point(106, 67);
            this.cmbRestaurants.Name = "cmbRestaurants";
            this.cmbRestaurants.Size = new Size(191, 21);
            this.cmbRestaurants.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of people";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(41, 70);
            this.label4.Name = "label4";
            this.label4.Size = new Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Restaurant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(71, 43);
            this.label5.Name = "label5";
            this.label5.Size = new Size(29, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "User";
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new Point(106, 40);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new Size(191, 21);
            this.cmbUsers.TabIndex = 15;
            // 
            // FormAddEditReservation
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(314, 306);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRestaurants);
            this.Controls.Add(this.NumPeopleUpDown);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "FormAddEditReservation";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Reservation";
            this.Load += new EventHandler(this.FormAddEditReservation_Load);
            ((ISupportInitialize)(this.NumPeopleUpDown)).EndInit();
            ((ISupportInitialize)(this.bindingSourceRestaurant)).EndInit();
            ((ISupportInitialize)(this.bindingSourceUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}