namespace N19_DentalClinic.GUI.AccountView
{
    partial class SetNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetNewPassword));
            pnBackLogin = new Panel();
            btnConfirm = new Button();
            txtConfirmNewPass = new TextBox();
            label3 = new Label();
            txtNewPass = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnBack = new component.RJButton();
            pnBackLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnBackLogin
            // 
            pnBackLogin.BackColor = Color.Transparent;
            pnBackLogin.Controls.Add(btnConfirm);
            pnBackLogin.Controls.Add(txtConfirmNewPass);
            pnBackLogin.Controls.Add(label3);
            pnBackLogin.Controls.Add(txtNewPass);
            pnBackLogin.Controls.Add(label2);
            pnBackLogin.Controls.Add(label1);
            pnBackLogin.Location = new Point(216, 59);
            pnBackLogin.Name = "pnBackLogin";
            pnBackLogin.Size = new Size(539, 409);
            pnBackLogin.TabIndex = 2;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.LimeGreen;
            btnConfirm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(345, 338);
            btnConfirm.Margin = new Padding(2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(151, 44);
            btnConfirm.TabIndex = 26;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtConfirmNewPass
            // 
            txtConfirmNewPass.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmNewPass.Location = new Point(55, 246);
            txtConfirmNewPass.Name = "txtConfirmNewPass";
            txtConfirmNewPass.Size = new Size(441, 38);
            txtConfirmNewPass.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 203);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 24;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPass.Location = new Point(55, 145);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(441, 38);
            txtNewPass.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 107);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 21;
            label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 20);
            label1.Name = "label1";
            label1.Size = new Size(323, 46);
            label1.TabIndex = 0;
            label1.Text = "Đặt lại mật khẩu";
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
            btnBack.TabIndex = 3;
            btnBack.TextColor = Color.White;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SetNewPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(963, 533);
            Controls.Add(btnBack);
            Controls.Add(pnBackLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SetNewPassword";
            Text = "SetNewPassword";
            Load += SetNewPassword_Load;
            MouseDown += SetNewPassword_MouseDown;
            MouseMove += SetNewPassword_MouseMove;
            MouseUp += SetNewPassword_MouseUp;
            pnBackLogin.ResumeLayout(false);
            pnBackLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBackLogin;
        private Button btnConfirm;
        private TextBox txtConfirmNewPass;
        private Label label3;
        private TextBox txtNewPass;
        private Label label2;
        private Label label1;
        private component.RJButton btnBack;
    }
}