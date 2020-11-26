namespace BookATable.GUI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class FormLogin
    {
        private IContainer components = null;

        private Label label1;
        private Label label2;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonExit;

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
            this.textBoxEmail = new TextBox();
            this.textBoxPassword = new TextBox();
            this.buttonLogin = new Button();
            this.buttonExit = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new Point(91, 12);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new Size(264, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new Point(91, 38);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new Size(264, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new Point(199, 64);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new EventHandler(this.buttonLogin_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = DialogResult.Cancel;
            this.buttonExit.Location = new Point(280, 64);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new Size(370, 97);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login - Book a Table";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}