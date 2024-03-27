namespace N19_DentalClinic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbPassword = new TextBox();
            btnLogin = new Button();
            btnSignup = new Button();
            pictureBox1 = new PictureBox();
            labelText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 20F);
            tbEmail.Location = new Point(432, 601);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(805, 61);
            tbEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(60, 595);
            label1.Name = "label1";
            label1.Size = new Size(141, 65);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(60, 735);
            label2.Name = "label2";
            label2.Size = new Size(226, 65);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 20F);
            tbPassword.Location = new Point(432, 741);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(805, 61);
            tbPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LimeGreen;
            btnLogin.Font = new Font("Segoe UI", 20F);
            btnLogin.Location = new Point(504, 897);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(270, 69);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.DeepSkyBlue;
            btnSignup.Font = new Font("Segoe UI", 20F);
            btnSignup.Location = new Point(855, 897);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(270, 69);
            btnSignup.TabIndex = 5;
            btnSignup.Text = "Đăng ký";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(520, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(516, 516);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 24F);
            labelText.Location = new Point(60, 895);
            labelText.Name = "labelText";
            labelText.Size = new Size(141, 65);
            labelText.TabIndex = 7;
            labelText.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 1144);
            Controls.Add(labelText);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbEmail);
            Name = "Form1";
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmail;
        private Label label1;
        private Label label2;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button btnSignup;
        private PictureBox pictureBox1;
        private Label labelText;
    }
}
