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
            labelText = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(568, 67);
            label1.Name = "label1";
            label1.Size = new Size(409, 65);
            label1.TabIndex = 2;
            label1.Text = "Đăng ký tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(52, 235);
            label2.Name = "label2";
            label2.Size = new Size(231, 65);
            label2.TabIndex = 3;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(47, 377);
            label3.Name = "label3";
            label3.Size = new Size(141, 65);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F);
            label4.Location = new Point(47, 526);
            label4.Name = "label4";
            label4.Size = new Size(226, 65);
            label4.TabIndex = 5;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F);
            label5.Location = new Point(47, 676);
            label5.Name = "label5";
            label5.Size = new Size(413, 65);
            label5.TabIndex = 6;
            label5.Text = "Nhập lại mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F);
            label6.Location = new Point(52, 822);
            label6.Name = "label6";
            label6.Size = new Size(307, 65);
            label6.TabIndex = 7;
            label6.Text = "Số điện thoại";
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 20F);
            tbName.Location = new Point(503, 239);
            tbName.Name = "tbName";
            tbName.Size = new Size(805, 61);
            tbName.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 20F);
            tbEmail.Location = new Point(503, 377);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(805, 61);
            tbEmail.TabIndex = 9;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 20F);
            tbPassword.Location = new Point(503, 526);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(805, 61);
            tbPassword.TabIndex = 10;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Font = new Font("Segoe UI", 20F);
            tbConfirmPassword.Location = new Point(503, 682);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(805, 61);
            tbConfirmPassword.TabIndex = 11;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Segoe UI", 20F);
            tbPhoneNumber.Location = new Point(503, 828);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(805, 61);
            tbPhoneNumber.TabIndex = 12;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.DeepSkyBlue;
            btnSignup.Font = new Font("Segoe UI", 20F);
            btnSignup.Location = new Point(580, 989);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(270, 69);
            btnSignup.TabIndex = 13;
            btnSignup.Text = "Đăng ký";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Pink;
            btnBack.Font = new Font("Segoe UI", 20F);
            btnBack.Location = new Point(13, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(270, 69);
            btnBack.TabIndex = 14;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 24F);
            labelText.Location = new Point(52, 129);
            labelText.Name = "labelText";
            labelText.Size = new Size(363, 65);
            labelText.TabIndex = 15;
            labelText.Text = "This is label text";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 1144);
            Controls.Add(labelText);
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
        private Label labelText;
    }
}