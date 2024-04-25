namespace N19_DentalClinic.GUI.AccountView
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
            pnGetPass = new Panel();
            rdAdmin = new RadioButton();
            rdReceptionist = new RadioButton();
            rdDentist = new RadioButton();
            btnConfirmCode = new Button();
            txtCode = new TextBox();
            label3 = new Label();
            btnGiveCode = new Button();
            txtEmail = new TextBox();
            label2 = new Label();
            label8 = new Label();
            label1 = new Label();
            btnBack = new component.RJButton();
            pnGetPass.SuspendLayout();
            SuspendLayout();
            // 
            // pnGetPass
            // 
            pnGetPass.BackColor = Color.Transparent;
            pnGetPass.Controls.Add(rdAdmin);
            pnGetPass.Controls.Add(rdReceptionist);
            pnGetPass.Controls.Add(rdDentist);
            pnGetPass.Controls.Add(btnConfirmCode);
            pnGetPass.Controls.Add(txtCode);
            pnGetPass.Controls.Add(label3);
            pnGetPass.Controls.Add(btnGiveCode);
            pnGetPass.Controls.Add(txtEmail);
            pnGetPass.Controls.Add(label2);
            pnGetPass.Controls.Add(label8);
            pnGetPass.Controls.Add(label1);
            pnGetPass.Location = new Point(262, 21);
            pnGetPass.Name = "pnGetPass";
            pnGetPass.Size = new Size(539, 533);
            pnGetPass.TabIndex = 1;
            // 
            // rdAdmin
            // 
            rdAdmin.AutoSize = true;
            rdAdmin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdAdmin.Location = new Point(156, 139);
            rdAdmin.Name = "rdAdmin";
            rdAdmin.Size = new Size(95, 29);
            rdAdmin.TabIndex = 29;
            rdAdmin.TabStop = true;
            rdAdmin.Text = "Quản lí";
            rdAdmin.UseVisualStyleBackColor = true;
            // 
            // rdReceptionist
            // 
            rdReceptionist.AutoSize = true;
            rdReceptionist.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdReceptionist.Location = new Point(277, 139);
            rdReceptionist.Name = "rdReceptionist";
            rdReceptionist.Size = new Size(87, 29);
            rdReceptionist.TabIndex = 28;
            rdReceptionist.TabStop = true;
            rdReceptionist.Text = "Lễ tân";
            rdReceptionist.UseVisualStyleBackColor = true;
            // 
            // rdDentist
            // 
            rdDentist.AutoSize = true;
            rdDentist.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdDentist.Location = new Point(392, 139);
            rdDentist.Name = "rdDentist";
            rdDentist.Size = new Size(88, 29);
            rdDentist.TabIndex = 27;
            rdDentist.TabStop = true;
            rdDentist.Text = "Nha sĩ";
            rdDentist.UseVisualStyleBackColor = true;
            // 
            // btnConfirmCode
            // 
            btnConfirmCode.BackColor = Color.LimeGreen;
            btnConfirmCode.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmCode.Location = new Point(345, 457);
            btnConfirmCode.Margin = new Padding(2);
            btnConfirmCode.Name = "btnConfirmCode";
            btnConfirmCode.Size = new Size(151, 44);
            btnConfirmCode.TabIndex = 26;
            btnConfirmCode.Text = "Xác nhận";
            btnConfirmCode.UseVisualStyleBackColor = false;
            btnConfirmCode.Click += btnConfirmCode_Click;
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(52, 398);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(441, 38);
            txtCode.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 355);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 24;
            label3.Text = "Mã xác nhận";
            // 
            // btnGiveCode
            // 
            btnGiveCode.BackColor = Color.LimeGreen;
            btnGiveCode.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGiveCode.Location = new Point(306, 307);
            btnGiveCode.Margin = new Padding(2);
            btnGiveCode.Name = "btnGiveCode";
            btnGiveCode.Size = new Size(190, 44);
            btnGiveCode.TabIndex = 23;
            btnGiveCode.Text = "Gửi mã xác nhận";
            btnGiveCode.UseVisualStyleBackColor = false;
            btnGiveCode.Click += btnGiveCode_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(52, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(441, 38);
            txtEmail.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 202);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 21;
            label2.Text = "Email đã đăng kí";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(55, 139);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 19;
            label8.Text = "Vai trò:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 49);
            label1.Name = "label1";
            label1.Size = new Size(270, 46);
            label1.TabIndex = 0;
            label1.Text = "Lấy mật khẩu";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(50, 56, 134);
            btnBack.BackgroundColor = Color.FromArgb(50, 56, 134);
            btnBack.BorderColor = Color.PaleVioletRed;
            btnBack.BorderRadius = 0;
            btnBack.BorderSize = 0;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 54);
            btnBack.TabIndex = 4;
            btnBack.TextColor = Color.White;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 582);
            Controls.Add(btnBack);
            Controls.Add(pnGetPass);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordForm";
            Text = "ForgotPasswordForm";
            Load += ForgotPasswordForm_Load;
            MouseDown += ForgotPasswordForm_MouseDown;
            MouseMove += ForgotPasswordForm_MouseMove;
            MouseUp += ForgotPasswordForm_MouseUp;
            pnGetPass.ResumeLayout(false);
            pnGetPass.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnGetPass;
        private Label label8;
        private Label label1;
        private Button btnGiveCode;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private TextBox txtCode;
        private Button btnConfirmCode;
        private RadioButton rdDentist;
        private RadioButton rdAdmin;
        private RadioButton rdReceptionist;
        private component.RJButton btnBack;
    }
}