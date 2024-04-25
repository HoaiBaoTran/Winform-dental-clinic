namespace N19_DentalClinic.GUI.AccountView
{
    partial class RegisterMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterMain));
            pnBackLogin = new Panel();
            cbFaculty = new ComboBox();
            lbFaculty = new Label();
            btnToRegister = new component.RJButton();
            lbToLoginForm = new Label();
            rdReceptionist = new RadioButton();
            rdDentist = new RadioButton();
            label8 = new Label();
            txtPhoneNumber = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtNameUser = new TextBox();
            label5 = new Label();
            txtConfirmPass = new TextBox();
            label4 = new Label();
            txtPass = new TextBox();
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
            pnBackLogin.Controls.Add(cbFaculty);
            pnBackLogin.Controls.Add(lbFaculty);
            pnBackLogin.Controls.Add(btnToRegister);
            pnBackLogin.Controls.Add(lbToLoginForm);
            pnBackLogin.Controls.Add(rdReceptionist);
            pnBackLogin.Controls.Add(rdDentist);
            pnBackLogin.Controls.Add(label8);
            pnBackLogin.Controls.Add(txtPhoneNumber);
            pnBackLogin.Controls.Add(label7);
            pnBackLogin.Controls.Add(txtEmail);
            pnBackLogin.Controls.Add(label6);
            pnBackLogin.Controls.Add(txtNameUser);
            pnBackLogin.Controls.Add(label5);
            pnBackLogin.Controls.Add(txtConfirmPass);
            pnBackLogin.Controls.Add(label4);
            pnBackLogin.Controls.Add(txtPass);
            pnBackLogin.Controls.Add(txtAccountName);
            pnBackLogin.Controls.Add(label3);
            pnBackLogin.Controls.Add(label2);
            pnBackLogin.Controls.Add(label1);
            pnBackLogin.Location = new Point(353, 22);
            pnBackLogin.Name = "pnBackLogin";
            pnBackLogin.Size = new Size(539, 795);
            pnBackLogin.TabIndex = 0;
            // 
            // cbFaculty
            // 
            cbFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFaculty.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Location = new Point(192, 636);
            cbFaculty.Margin = new Padding(3, 4, 3, 4);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(304, 37);
            cbFaculty.TabIndex = 18;
            // 
            // lbFaculty
            // 
            lbFaculty.AutoSize = true;
            lbFaculty.BackColor = Color.Transparent;
            lbFaculty.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFaculty.Location = new Point(87, 639);
            lbFaculty.Name = "lbFaculty";
            lbFaculty.Size = new Size(69, 29);
            lbFaculty.TabIndex = 17;
            lbFaculty.Text = "Khoa";
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
            btnToRegister.Location = new Point(55, 691);
            btnToRegister.Name = "btnToRegister";
            btnToRegister.Size = new Size(441, 50);
            btnToRegister.TabIndex = 8;
            btnToRegister.Text = "Đăng kí";
            btnToRegister.TextColor = Color.White;
            btnToRegister.UseVisualStyleBackColor = false;
            btnToRegister.Click += btnToRegister_Click;
            // 
            // lbToLoginForm
            // 
            lbToLoginForm.AutoSize = true;
            lbToLoginForm.BackColor = Color.Transparent;
            lbToLoginForm.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbToLoginForm.ForeColor = Color.FromArgb(9, 24, 219);
            lbToLoginForm.Location = new Point(175, 764);
            lbToLoginForm.Name = "lbToLoginForm";
            lbToLoginForm.Size = new Size(203, 20);
            lbToLoginForm.TabIndex = 9;
            lbToLoginForm.Text = "Trở về trang đăng nhập";
            lbToLoginForm.Click += lbToLoginForm_Click;
            // 
            // rdReceptionist
            // 
            rdReceptionist.AutoSize = true;
            rdReceptionist.BackColor = Color.Transparent;
            rdReceptionist.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdReceptionist.Location = new Point(350, 587);
            rdReceptionist.Name = "rdReceptionist";
            rdReceptionist.Size = new Size(87, 29);
            rdReceptionist.TabIndex = 7;
            rdReceptionist.TabStop = true;
            rdReceptionist.Text = "Lễ tân";
            rdReceptionist.UseVisualStyleBackColor = false;
            // 
            // rdDentist
            // 
            rdDentist.AutoSize = true;
            rdDentist.BackColor = Color.Transparent;
            rdDentist.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdDentist.Location = new Point(192, 587);
            rdDentist.Name = "rdDentist";
            rdDentist.Size = new Size(88, 29);
            rdDentist.TabIndex = 6;
            rdDentist.TabStop = true;
            rdDentist.Text = "Nha sĩ";
            rdDentist.UseVisualStyleBackColor = false;
            rdDentist.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(55, 589);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 16;
            label8.Text = "Vai trò:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(55, 533);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(441, 38);
            txtPhoneNumber.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(55, 505);
            label7.Name = "label7";
            label7.Size = new Size(139, 25);
            label7.TabIndex = 14;
            label7.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(55, 450);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(441, 38);
            txtEmail.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(55, 422);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // txtNameUser
            // 
            txtNameUser.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameUser.Location = new Point(55, 367);
            txtNameUser.Name = "txtNameUser";
            txtNameUser.Size = new Size(441, 38);
            txtNameUser.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 339);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 10;
            label5.Text = "Họ tên";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPass.Location = new Point(55, 284);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(441, 38);
            txtConfirmPass.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 256);
            label4.Name = "label4";
            label4.Size = new Size(185, 25);
            label4.TabIndex = 8;
            label4.Text = "Nhập lại mật khẩu";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(55, 194);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(441, 38);
            txtPass.TabIndex = 1;
            // 
            // txtAccountName
            // 
            txtAccountName.AcceptsReturn = true;
            txtAccountName.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAccountName.Location = new Point(55, 115);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(441, 38);
            txtAccountName.TabIndex = 0;
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
            label1.Location = new Point(210, 21);
            label1.Name = "label1";
            label1.Size = new Size(168, 46);
            label1.TabIndex = 0;
            label1.Text = "Đăng Kí";
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
            rjButton1.Location = new Point(1131, 22);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(67, 60);
            rjButton1.TabIndex = 19;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // RegisterMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1226, 850);
            Controls.Add(rjButton1);
            Controls.Add(pnBackLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterMain";
            Text = "Login";
            Load += Login_Load;
            MouseDown += RegisterMain_MouseDown;
            MouseMove += RegisterMain_MouseMove;
            MouseUp += RegisterMain_MouseUp;
            pnBackLogin.ResumeLayout(false);
            pnBackLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBackLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPass;
        private TextBox txtAccountName;
        private component.RJButton rjButton2;
        private RadioButton rdReceptionist;
        private RadioButton rdDentist;
        private Label label8;
        private TextBox txtPhoneNumber;
        private Label label7;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtNameUser;
        private Label label5;
        private TextBox txtConfirmPass;
        private Label label4;
        private Label lbToLoginForm;
        private component.RJButton btnToRegister;
        private ComboBox cbFaculty;
        private Label lbFaculty;
        private component.RJButton rjButton1;
    }
}