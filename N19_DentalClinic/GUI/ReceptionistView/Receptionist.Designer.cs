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
            btnCreateAppointment = new Button();
            btnDentistManagement = new Button();
            btnPatientProfile = new Button();
            btnCreateBill = new Button();
            panelSidebar = new Panel();
            label5 = new Label();
            roundPictureBox1 = new N19_DentalClinic.component.RoundPictureBox();
            label4 = new Label();
            lbRole = new Label();
            lbRoleText = new Label();
            label3 = new Label();
            lbName = new Label();
            pnShowContent = new Panel();
            eclipseControl1 = new DAO.EclipseControl();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCreateAppointment
            // 
            btnCreateAppointment.Location = new Point(15, 357);
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
            btnDentistManagement.Location = new Point(15, 452);
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
            btnPatientProfile.Location = new Point(15, 552);
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
            btnCreateBill.Location = new Point(15, 647);
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
            panelSidebar.Controls.Add(label5);
            panelSidebar.Controls.Add(roundPictureBox1);
            panelSidebar.Controls.Add(label4);
            panelSidebar.Controls.Add(lbRole);
            panelSidebar.Controls.Add(lbRoleText);
            panelSidebar.Controls.Add(label3);
            panelSidebar.Controls.Add(lbName);
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
            label5.Location = new Point(0, 319);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 14;
            label5.Text = "Chức năng";
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.Image = N19_DentalClinic.Properties.Resources.luffy;
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
            label4.Location = new Point(-2, 308);
            label4.Name = "label4";
            label4.Size = new Size(220, 1);
            label4.TabIndex = 13;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Segoe UI", 12F);
            lbRole.ForeColor = Color.White;
            lbRole.Location = new Point(119, 267);
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
            lbRoleText.Location = new Point(40, 267);
            lbRoleText.Name = "lbRoleText";
            lbRoleText.Size = new Size(73, 28);
            lbRoleText.TabIndex = 11;
            lbRoleText.Text = "Vai trò:";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(-2, 251);
            label3.Name = "label3";
            label3.Size = new Size(220, 1);
            label3.TabIndex = 8;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 18F);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(16, 199);
            lbName.Name = "lbName";
            lbName.Size = new Size(200, 41);
            lbName.TabIndex = 9;
            lbName.Text = "Trần Hoài Bảo";
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
            // Receptionist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1682, 953);
            Controls.Add(pnShowContent);
            Controls.Add(panelSidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Receptionist";
            Text = " ";
            Load += Receptionist_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ResumeLayout(false);
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
        private Label lbName;
    }
}
