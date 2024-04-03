namespace N19_DentalClinic
{
    partial class SignupForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbName = new TextBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            tbPhoneNumber = new TextBox();
            btnSignup = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(454, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(343, 54);
            label1.TabIndex = 2;
            label1.Text = "Đăng ký tài khoản";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(42, 188);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 54);
            label2.TabIndex = 3;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(38, 302);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 54);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F);
            label4.Location = new Point(38, 421);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(190, 54);
            label4.TabIndex = 5;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F);
            label5.Location = new Point(38, 541);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(347, 54);
            label5.TabIndex = 6;
            label5.Text = "Nhập lại mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F);
            label6.Location = new Point(42, 658);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(257, 54);
            label6.TabIndex = 7;
            label6.Text = "Số điện thoại";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 20F);
            tbName.Location = new Point(402, 191);
            tbName.Margin = new Padding(2);
            tbName.Name = "tbName";
            tbName.Size = new Size(645, 52);
            tbName.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 20F);
            tbEmail.Location = new Point(402, 302);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(645, 52);
            tbEmail.TabIndex = 9;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 20F);
            tbPassword.Location = new Point(402, 421);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(645, 52);
            tbPassword.TabIndex = 10;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Font = new Font("Segoe UI", 20F);
            tbConfirmPassword.Location = new Point(402, 546);
            tbConfirmPassword.Margin = new Padding(2);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '*';
            tbConfirmPassword.Size = new Size(645, 52);
            tbConfirmPassword.TabIndex = 11;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Segoe UI", 20F);
            tbPhoneNumber.Location = new Point(402, 662);
            tbPhoneNumber.Margin = new Padding(2);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(645, 52);
            tbPhoneNumber.TabIndex = 12;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.DeepSkyBlue;
            btnSignup.Font = new Font("Segoe UI", 20F);
            btnSignup.Location = new Point(464, 791);
            btnSignup.Margin = new Padding(2);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(216, 55);
            btnSignup.TabIndex = 13;
            btnSignup.Text = "Đăng ký";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Pink;
            btnBack.Font = new Font("Segoe UI", 20F);
            btnBack.Location = new Point(10, 10);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(216, 55);
            btnBack.TabIndex = 14;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 903);
            Controls.Add(btnBack);
            Controls.Add(btnSignup);
            Controls.Add(tbPhoneNumber);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(tbName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "SignupForm";
            Text = "Signup Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbName;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private TextBox tbConfirmPassword;
        private TextBox tbPhoneNumber;
        private Button btnSignup;
        private Button btnBack;
    }
}