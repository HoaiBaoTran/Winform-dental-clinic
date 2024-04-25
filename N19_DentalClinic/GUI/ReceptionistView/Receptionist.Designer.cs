namespace N19_DentalClinic.GUI.ReceptionistView
{
    partial class Receptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
            btnCreateAppointment = new Button();
            btnDentistManagement = new Button();
            btnPatientProfile = new Button();
            btnCreateBill = new Button();
            panelSidebar = new Panel();
            label5 = new Label();
            roundPictureBox1 = new component.RoundPictureBox();
            label4 = new Label();
            lbRole = new Label();
            lbRoleText = new Label();
            label3 = new Label();
            lbNameReceptionist = new Label();
            pnShowContent = new Panel();
            eclipseControl1 = new DAO.EclipseControl();
            label1 = new Label();
            backToLogin = new component.RJButton();
            btnAssisstantManagement = new Button();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCreateAppointment
            // 
            btnCreateAppointment.Location = new Point(15, 313);
            btnCreateAppointment.Margin = new Padding(3, 4, 3, 4);
            btnCreateAppointment.Name = "btnCreateAppointment";
            btnCreateAppointment.Size = new Size(170, 68);
            btnCreateAppointment.TabIndex = 0;
            btnCreateAppointment.Text = "Đặt lịch hẹn ";
            btnCreateAppointment.UseVisualStyleBackColor = true;
            btnCreateAppointment.Click += btnCreateAppointment_Click;
            // 
            // btnDentistManagement
            // 
            btnDentistManagement.Location = new Point(15, 408);
            btnDentistManagement.Margin = new Padding(3, 4, 3, 4);
            btnDentistManagement.Name = "btnDentistManagement";
            btnDentistManagement.Size = new Size(170, 68);
            btnDentistManagement.TabIndex = 1;
            btnDentistManagement.Text = "Quản lí nha sĩ";
            btnDentistManagement.UseVisualStyleBackColor = true;
            btnDentistManagement.Click += btnDentistManagement_Click;
            // 
            // btnPatientProfile
            // 
            btnPatientProfile.Location = new Point(15, 576);
            btnPatientProfile.Margin = new Padding(3, 4, 3, 4);
            btnPatientProfile.Name = "btnPatientProfile";
            btnPatientProfile.Size = new Size(170, 68);
            btnPatientProfile.TabIndex = 2;
            btnPatientProfile.Text = "Hồ sơ bệnh nhân";
            btnPatientProfile.UseVisualStyleBackColor = true;
            btnPatientProfile.Click += btnPatientProfile_Click;
            // 
            // btnCreateBill
            // 
            btnCreateBill.Location = new Point(15, 671);
            btnCreateBill.Margin = new Padding(3, 4, 3, 4);
            btnCreateBill.Name = "btnCreateBill";
            btnCreateBill.Size = new Size(170, 68);
            btnCreateBill.TabIndex = 3;
            btnCreateBill.Text = "Tạo hóa đơn";
            btnCreateBill.UseVisualStyleBackColor = true;
            btnCreateBill.Click += btnCreateBill_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = SystemColors.AppWorkspace;
            panelSidebar.Controls.Add(btnAssisstantManagement);
            panelSidebar.Controls.Add(label5);
            panelSidebar.Controls.Add(roundPictureBox1);
            panelSidebar.Controls.Add(label4);
            panelSidebar.Controls.Add(lbRole);
            panelSidebar.Controls.Add(lbRoleText);
            panelSidebar.Controls.Add(label3);
            panelSidebar.Controls.Add(btnCreateAppointment);
            panelSidebar.Controls.Add(btnCreateBill);
            panelSidebar.Controls.Add(btnDentistManagement);
            panelSidebar.Controls.Add(btnPatientProfile);
            panelSidebar.Location = new Point(2, -1);
            panelSidebar.Margin = new Padding(3, 4, 3, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(210, 840);
            panelSidebar.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 275);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 14;
            label5.Text = "Chức năng";
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.Image = Properties.Resources.luffy;
            roundPictureBox1.Location = new Point(31, 26);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(154, 145);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 10;
            roundPictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(-2, 264);
            label4.Name = "label4";
            label4.Size = new Size(220, 1);
            label4.TabIndex = 13;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Segoe UI", 12F);
            lbRole.ForeColor = Color.White;
            lbRole.Location = new Point(108, 223);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(64, 28);
            lbRole.TabIndex = 12;
            lbRole.Text = "Lễ tân";
            // 
            // lbRoleText
            // 
            lbRoleText.AutoSize = true;
            lbRoleText.Font = new Font("Segoe UI", 12F);
            lbRoleText.ForeColor = Color.White;
            lbRoleText.Location = new Point(29, 223);
            lbRoleText.Name = "lbRoleText";
            lbRoleText.Size = new Size(73, 28);
            lbRoleText.TabIndex = 11;
            lbRoleText.Text = "Vai trò:";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(-2, 207);
            label3.Name = "label3";
            label3.Size = new Size(220, 1);
            label3.TabIndex = 8;
            // 
            // lbNameReceptionist
            // 
            lbNameReceptionist.AutoSize = true;
            lbNameReceptionist.Font = new Font("Segoe UI", 18F);
            lbNameReceptionist.ForeColor = Color.White;
            lbNameReceptionist.Location = new Point(357, 25);
            lbNameReceptionist.Name = "lbNameReceptionist";
            lbNameReceptionist.Size = new Size(182, 41);
            lbNameReceptionist.TabIndex = 9;
            lbNameReceptionist.Text = "Lễ Tân Trang";
            lbNameReceptionist.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnShowContent
            // 
            pnShowContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnShowContent.BackColor = Color.White;
            pnShowContent.Location = new Point(218, 114);
            pnShowContent.Margin = new Padding(3, 4, 3, 4);
            pnShowContent.Name = "pnShowContent";
            pnShowContent.Size = new Size(1435, 837);
            pnShowContent.TabIndex = 1;
            // 
            // eclipseControl1
            // 
            eclipseControl1.CornerRadius = 32;
            eclipseControl1.TargetControl = panelSidebar;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(218, 25);
            label1.Name = "label1";
            label1.Size = new Size(118, 41);
            label1.TabIndex = 10;
            label1.Text = "Họ Tên:";
            // 
            // backToLogin
            // 
            backToLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            backToLogin.BackColor = Color.FromArgb(165, 85, 80);
            backToLogin.BackgroundColor = Color.FromArgb(165, 85, 80);
            backToLogin.BorderColor = Color.PaleVioletRed;
            backToLogin.BorderRadius = 0;
            backToLogin.BorderSize = 0;
            backToLogin.FlatAppearance.BorderSize = 0;
            backToLogin.FlatStyle = FlatStyle.Flat;
            backToLogin.ForeColor = Color.White;
            backToLogin.Image = (Image)resources.GetObject("backToLogin.Image");
            backToLogin.Location = new Point(1586, 19);
            backToLogin.Name = "backToLogin";
            backToLogin.Size = new Size(67, 67);
            backToLogin.TabIndex = 11;
            backToLogin.TextColor = Color.White;
            backToLogin.UseVisualStyleBackColor = false;
            backToLogin.Click += backToLogin_Click;
            // 
            // btnAssisstantManagement
            // 
            btnAssisstantManagement.Location = new Point(15, 491);
            btnAssisstantManagement.Margin = new Padding(3, 4, 3, 4);
            btnAssisstantManagement.Name = "btnAssisstantManagement";
            btnAssisstantManagement.Size = new Size(170, 68);
            btnAssisstantManagement.TabIndex = 15;
            btnAssisstantManagement.Text = "Quản lí phụ tá";
            btnAssisstantManagement.UseVisualStyleBackColor = true;
            btnAssisstantManagement.Click += btnAssisstantManagement_Click;
            // 
            // Receptionist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1682, 953);
            ControlBox = false;
            Controls.Add(backToLogin);
            Controls.Add(label1);
            Controls.Add(pnShowContent);
            Controls.Add(panelSidebar);
            Controls.Add(lbNameReceptionist);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Receptionist";
            Text = " ";
            Load += Receptionist_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnCreateAppointment;
        private System.Windows.Forms.Button btnDentistManagement;
        private System.Windows.Forms.Button btnPatientProfile;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel pnShowContent;
        private DAO.EclipseControl eclipseControl1;
        private Label label5;
        private N19_DentalClinic.component.RoundPictureBox roundPictureBox1;
        private Label label4;
        private Label lbRole;
        private Label lbRoleText;
        private Label label3;
        private Label lbNameReceptionist;
        private Label label1;
        private component.RJButton backToLogin;
        private Button btnAssisstantManagement;
    }
}
