namespace N19_DentalClinic.GUI.DentistView
{
    partial class Dentist
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
            pnSidebar = new Panel();
            lbRoleText = new Label();
            roundPictureBox1 = new component.RoundPictureBox();
            label4 = new Label();
            lbRole = new Label();
            label3 = new Label();
            lbName = new Label();
            btnPrescription = new Button();
            btnCalendar = new Button();
            btnPatientProfile = new Button();
            pnShowContent = new Panel();
            pnSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnSidebar
            // 
            pnSidebar.BackColor = SystemColors.AppWorkspace;
            pnSidebar.Controls.Add(lbRoleText);
            pnSidebar.Controls.Add(roundPictureBox1);
            pnSidebar.Controls.Add(label4);
            pnSidebar.Controls.Add(lbRole);
            pnSidebar.Controls.Add(label3);
            pnSidebar.Controls.Add(lbName);
            pnSidebar.Controls.Add(btnPrescription);
            pnSidebar.Controls.Add(btnCalendar);
            pnSidebar.Controls.Add(btnPatientProfile);
            pnSidebar.Location = new Point(2, 0);
            pnSidebar.Margin = new Padding(3, 4, 3, 4);
            pnSidebar.Name = "pnSidebar";
            pnSidebar.Size = new Size(235, 953);
            pnSidebar.TabIndex = 2;
            // 
            // lbRoleText
            // 
            lbRoleText.AutoSize = true;
            lbRoleText.Font = new Font("Segoe UI", 12F);
            lbRoleText.ForeColor = Color.White;
            lbRoleText.Location = new Point(39, 286);
            lbRoleText.Name = "lbRoleText";
            lbRoleText.Size = new Size(73, 28);
            lbRoleText.TabIndex = 19;
            lbRoleText.Text = "Vai trò:";
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.Image = Properties.Resources.luffy;
            roundPictureBox1.Location = new Point(39, 45);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(154, 145);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 16;
            roundPictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(6, 327);
            label4.Name = "label4";
            label4.Size = new Size(220, 1);
            label4.TabIndex = 18;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Segoe UI", 12F);
            lbRole.ForeColor = Color.White;
            lbRole.Location = new Point(118, 286);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(66, 28);
            lbRole.TabIndex = 17;
            lbRole.Text = "Nha sĩ";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(6, 270);
            label3.Name = "label3";
            label3.Size = new Size(220, 1);
            label3.TabIndex = 14;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 18F);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(24, 218);
            lbName.Name = "lbName";
            lbName.Size = new Size(200, 41);
            lbName.TabIndex = 15;
            lbName.Text = "Trần Hoài Bảo";
            // 
            // btnPrescription
            // 
            btnPrescription.FlatStyle = FlatStyle.Flat;
            btnPrescription.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrescription.Location = new Point(10, 597);
            btnPrescription.Margin = new Padding(3, 4, 3, 4);
            btnPrescription.Name = "btnPrescription";
            btnPrescription.Size = new Size(207, 68);
            btnPrescription.TabIndex = 3;
            btnPrescription.Text = "Toa Thuốc";
            btnPrescription.UseVisualStyleBackColor = true;
            btnPrescription.Click += btnPrescription_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalendar.Location = new Point(10, 488);
            btnCalendar.Margin = new Padding(3, 4, 3, 4);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(207, 68);
            btnCalendar.TabIndex = 1;
            btnCalendar.Text = "Lịch làm việc";
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnPatientProfile
            // 
            btnPatientProfile.FlatStyle = FlatStyle.Flat;
            btnPatientProfile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPatientProfile.Location = new Point(10, 378);
            btnPatientProfile.Margin = new Padding(3, 4, 3, 4);
            btnPatientProfile.Name = "btnPatientProfile";
            btnPatientProfile.Size = new Size(207, 68);
            btnPatientProfile.TabIndex = 2;
            btnPatientProfile.Text = "Hồ sơ bệnh nhân";
            btnPatientProfile.UseVisualStyleBackColor = true;
            btnPatientProfile.Click += btnPatientProfile_Click;
            // 
            // pnShowContent
            // 
            pnShowContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnShowContent.BackColor = Color.White;
            pnShowContent.Location = new Point(243, 133);
            pnShowContent.Margin = new Padding(3, 4, 3, 4);
            pnShowContent.Name = "pnShowContent";
            pnShowContent.Size = new Size(1418, 807);
            pnShowContent.TabIndex = 3;
            // 
            // Dentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1682, 953);
            Controls.Add(pnShowContent);
            Controls.Add(pnSidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dentist";
            Text = "Dentist";
            Load += Dentist_Load;
            pnSidebar.ResumeLayout(false);
            pnSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnSidebar;
        private System.Windows.Forms.Button btnPrescription;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnPatientProfile;
        private System.Windows.Forms.Panel pnShowContent;
        private N19_DentalClinic.component.RoundPictureBox roundPictureBox1;
        private Label label4;
        private Label lbRole;
        private Label label3;
        private Label lbName;
        private Label lbRoleText;
    }
}