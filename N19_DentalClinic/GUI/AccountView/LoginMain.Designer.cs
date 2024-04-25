namespace N19_DentalClinic.GUI.AccountView
{
    partial class LoginMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMain));
            pnBackLogin = new Panel();
            rdAdmin = new RadioButton();
            rdReceptionist = new RadioButton();
            rdDentist = new RadioButton();
            label8 = new Label();
            lbForgotPass = new Label();
            btnToRegister = new component.RJButton();
            btnLogin = new component.RJButton();
            txtNamePassword = new TextBox();
            txtAccountName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rjButton1 = new component.RJButton();
            pnBackLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnBackLogin
            // 
            pnBackLogin.BackColor = Color.Transparent;
            pnBackLogin.Controls.Add(rdAdmin);
            pnBackLogin.Controls.Add(rdReceptionist);
            pnBackLogin.Controls.Add(rdDentist);
            pnBackLogin.Controls.Add(label8);
            pnBackLogin.Controls.Add(lbForgotPass);
            pnBackLogin.Controls.Add(btnToRegister);
            pnBackLogin.Controls.Add(btnLogin);
            pnBackLogin.Controls.Add(txtNamePassword);
            pnBackLogin.Controls.Add(txtAccountName);
            pnBackLogin.Controls.Add(label3);
            pnBackLogin.Controls.Add(label2);
            pnBackLogin.Controls.Add(label1);
            pnBackLogin.Location = new Point(360, 68);
            pnBackLogin.Name = "pnBackLogin";
            pnBackLogin.Size = new Size(539, 502);
            pnBackLogin.TabIndex = 0;
            // 
            // rdAdmin
            // 
            rdAdmin.AutoSize = true;
            rdAdmin.BackColor = Color.Transparent;
            rdAdmin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdAdmin.Location = new Point(165, 301);
            rdAdmin.Name = "rdAdmin";
            rdAdmin.Size = new Size(100, 29);
            rdAdmin.TabIndex = 20;
            rdAdmin.TabStop = true;
            rdAdmin.Text = "Quản lí ";
            rdAdmin.UseVisualStyleBackColor = false;
            // 
            // rdReceptionist
            // 
            rdReceptionist.AutoSize = true;
            rdReceptionist.BackColor = Color.Transparent;
            rdReceptionist.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdReceptionist.Location = new Point(287, 301);
            rdReceptionist.Name = "rdReceptionist";
            rdReceptionist.Size = new Size(87, 29);
            rdReceptionist.TabIndex = 18;
            rdReceptionist.TabStop = true;
            rdReceptionist.Text = "Lễ tân";
            rdReceptionist.UseVisualStyleBackColor = false;
            // 
            // rdDentist
            // 
            rdDentist.AutoSize = true;
            rdDentist.BackColor = Color.Transparent;
            rdDentist.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdDentist.Location = new Point(391, 301);
            rdDentist.Name = "rdDentist";
            rdDentist.Size = new Size(88, 29);
            rdDentist.TabIndex = 17;
            rdDentist.TabStop = true;
            rdDentist.Text = "Nha sĩ";
            rdDentist.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(55, 301);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 19;
            label8.Text = "Vai trò:";
            // 
            // lbForgotPass
            // 
            lbForgotPass.AutoSize = true;
            lbForgotPass.BackColor = Color.Transparent;
            lbForgotPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbForgotPass.Location = new Point(325, 255);
            lbForgotPass.Name = "lbForgotPass";
            lbForgotPass.Size = new Size(171, 25);
            lbForgotPass.TabIndex = 9;
            lbForgotPass.Text = "Quên mật khẩu?";
            lbForgotPass.Click += lbForgotPass_Click;
            // 
            // btnToRegister
            // 
            btnToRegister.BackColor = Color.FromArgb(9, 24, 219);
            btnToRegister.BackgroundColor = Color.FromArgb(9, 24, 219);
            btnToRegister.BorderColor = Color.PaleVioletRed;
            btnToRegister.BorderRadius = 12;
            btnToRegister.BorderSize = 0;
            btnToRegister.FlatAppearance.BorderSize = 0;
            btnToRegister.FlatStyle = FlatStyle.Flat;
            btnToRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToRegister.ForeColor = Color.White;
            btnToRegister.Location = new Point(55, 417);
            btnToRegister.Name = "btnToRegister";
            btnToRegister.Size = new Size(441, 50);
            btnToRegister.TabIndex = 8;
            btnToRegister.Text = "Đăng kí";
            btnToRegister.TextColor = Color.White;
            btnToRegister.UseVisualStyleBackColor = false;
            btnToRegister.Click += btnToRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(9, 24, 219);
            btnLogin.BackgroundColor = Color.FromArgb(9, 24, 219);
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 12;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(55, 349);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(441, 50);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Đăng nhập";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtNamePassword
            // 
            txtNamePassword.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamePassword.Location = new Point(55, 194);
            txtNamePassword.Name = "txtNamePassword";
            txtNamePassword.Size = new Size(441, 38);
            txtNamePassword.TabIndex = 6;
            // 
            // txtAccountName
            // 
            txtAccountName.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAccountName.Location = new Point(55, 115);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(441, 38);
            txtAccountName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 166);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 77);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 16);
            label1.Name = "label1";
            label1.Size = new Size(230, 46);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(9, 24, 219);
            rjButton1.BackgroundColor = Color.FromArgb(9, 24, 219);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Image = (Image)resources.GetObject("rjButton1.Image");
            rjButton1.Location = new Point(1133, 24);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(67, 60);
            rjButton1.TabIndex = 1;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // LoginMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1226, 651);
            Controls.Add(rjButton1);
            Controls.Add(pnBackLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginMain";
            Text = "Login";
            Load += Login_Load;
            MouseDown += LoginMain_MouseDown;
            MouseMove += LoginMain_MouseMove;
            MouseUp += LoginMain_MouseUp;
            pnBackLogin.ResumeLayout(false);
            pnBackLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBackLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNamePassword;
        private TextBox txtAccountName;
        private component.RJButton rjButton2;
        private component.RJButton btnToRegister;
        private component.RJButton btnLogin;
        private Label lbForgotPass;
        private RadioButton rdAdmin;
        private RadioButton rdReceptionist;
        private RadioButton rdDentist;
        private Label label8;
        private component.RJButton rjButton1;
    }
}