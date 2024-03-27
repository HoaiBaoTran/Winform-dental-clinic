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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 20F);
            tbEmail.Location = new Point(346, 481);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(645, 52);
            tbEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(48, 476);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 54);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(48, 588);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 54);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 20F);
            tbPassword.Location = new Point(346, 593);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(645, 52);
            tbPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LimeGreen;
            btnLogin.Font = new Font("Segoe UI", 20F);
            btnLogin.Location = new Point(403, 718);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 55);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.DeepSkyBlue;
            btnSignup.Font = new Font("Segoe UI", 20F);
            btnSignup.Location = new Point(684, 718);
            btnSignup.Margin = new Padding(2);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(216, 55);
            btnSignup.TabIndex = 5;
            btnSignup.Text = "Đăng ký";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(416, 27);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 903);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbEmail);
            Margin = new Padding(2);
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
    }
}
