namespace N19_DentalClinic.controller
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            pictureBox1 = new PictureBox();
            tbEmail = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(419, 90);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 20F);
            tbEmail.Location = new Point(356, 624);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(645, 52);
            tbEmail.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LimeGreen;
            btnLogin.Font = new Font("Segoe UI", 20F);
            btnLogin.Location = new Point(430, 789);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(296, 55);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Gửi mã xác nhận";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(11, 620);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(315, 54);
            label3.TabIndex = 10;
            label3.Text = "Email đã đăng kí";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Pink;
            btnBack.Font = new Font("Segoe UI", 20F);
            btnBack.Location = new Point(11, 11);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(216, 55);
            btnBack.TabIndex = 15;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 903);
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(tbEmail);
            Controls.Add(pictureBox1);
            Name = "ForgotPasswordForm";
            Text = "ForgotPasswordForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbEmail;
        private Button btnLogin;
        private Label label3;
        private Button btnBack;
    }
}