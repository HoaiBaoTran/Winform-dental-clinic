namespace N19_ProjectForm.GUI.ReceptionistView
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
            btnPatientFiles = new Button();
            btnCreateBill = new Button();
            panelSidebar = new Panel();
            pnShowContent = new Panel();
            eclipseControl1 = new DAO.EclipseControl();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateAppointment
            // 
            btnCreateAppointment.Location = new Point(15, 109);
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
            btnDentistManagement.Location = new Point(15, 204);
            btnDentistManagement.Margin = new Padding(3, 4, 3, 4);
            btnDentistManagement.Name = "btnDentistManagement";
            btnDentistManagement.Size = new Size(170, 68);
            btnDentistManagement.TabIndex = 1;
            btnDentistManagement.Text = "Quản lí nha sĩ";
            btnDentistManagement.UseVisualStyleBackColor = true;
            btnDentistManagement.Click += btnPatientFile_Click;
            // 
            // btnPatientFiles
            // 
            btnPatientFiles.Location = new Point(15, 304);
            btnPatientFiles.Margin = new Padding(3, 4, 3, 4);
            btnPatientFiles.Name = "btnPatientFiles";
            btnPatientFiles.Size = new Size(170, 68);
            btnPatientFiles.TabIndex = 2;
            btnPatientFiles.Text = "Hồ sơ bệnh nhân";
            btnPatientFiles.UseVisualStyleBackColor = true;
            btnPatientFiles.Click += btnPatientFiles_Click;
            // 
            // btnCreateBill
            // 
            btnCreateBill.Location = new Point(15, 399);
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
            panelSidebar.Controls.Add(btnCreateAppointment);
            panelSidebar.Controls.Add(btnCreateBill);
            panelSidebar.Controls.Add(btnDentistManagement);
            panelSidebar.Controls.Add(btnPatientFiles);
            panelSidebar.Location = new Point(2, -1);
            panelSidebar.Margin = new Padding(3, 4, 3, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(202, 840);
            panelSidebar.TabIndex = 0;
            // 
            // pnShowContent
            // 
            pnShowContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnShowContent.BackColor = Color.White;
            pnShowContent.Location = new Point(210, 108);
            pnShowContent.Margin = new Padding(3, 4, 3, 4);
            pnShowContent.Name = "pnShowContent";
            pnShowContent.Size = new Size(1277, 731);
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
            ClientSize = new Size(1516, 841);
            Controls.Add(pnShowContent);
            Controls.Add(panelSidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Receptionist";
            Text = " ";
            Load += Receptionist_Load;
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnCreateAppointment;
        private System.Windows.Forms.Button btnDentistManagement;
        private System.Windows.Forms.Button btnPatientFiles;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel pnShowContent;
        private DAO.EclipseControl eclipseControl1;
    }
}
