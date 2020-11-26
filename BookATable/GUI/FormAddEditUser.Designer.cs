namespace BookATable.GUI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormAddEditUser
    {
        private IContainer components = null;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxPhone;
        private CheckBox checkBoxIsAdmin;
        private Button buttonSave;
        private Button buttonCancel;

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
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.textBoxName = new TextBox();
            this.textBoxEmail = new TextBox();
            this.textBoxPassword = new TextBox();
            this.textBoxPhone = new TextBox();
            this.checkBoxIsAdmin = new CheckBox();
            this.buttonSave = new Button();
            this.buttonCancel = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(47, 41);
            this.label2.Name = "label2";
            this.label2.Size = new Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(41, 93);
            this.label4.Name = "label4";
            this.label4.Size = new Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new Point(85, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(168, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new Point(85, 38);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new Size(168, 20);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new Point(85, 64);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new Size(168, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new Point(85, 90);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new Size(168, 20);
            this.textBoxPhone.TabIndex = 7;
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.CheckAlign = ContentAlignment.MiddleRight;
            this.checkBoxIsAdmin.Location = new Point(14, 116);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new Size(86, 17);
            this.checkBoxIsAdmin.TabIndex = 8;
            this.checkBoxIsAdmin.Text = "Administrator";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = DialogResult.OK;
            this.buttonSave.Location = new Point(85, 140);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = DialogResult.Cancel;
            this.buttonCancel.Location = new Point(178, 140);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddEditUser
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new Size(271, 176);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxIsAdmin);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEditUser";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Add/Edit User";
            this.Load += new EventHandler(this.FormAddEditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}