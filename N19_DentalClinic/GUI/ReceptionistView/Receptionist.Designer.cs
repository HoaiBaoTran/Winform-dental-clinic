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
            this.btnCreateAppointment = new System.Windows.Forms.Button();
            this.btnDentistManagement = new System.Windows.Forms.Button();
            this.btnPatientFiles = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnShowContent = new System.Windows.Forms.Panel();
            this.eclipseControl1 = new N19_ProjectForm.DAO.EclipseControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateAppointment
            // 
            this.btnCreateAppointment.Location = new System.Drawing.Point(15, 87);
            this.btnCreateAppointment.Name = "btnCreateAppointment";
            this.btnCreateAppointment.Size = new System.Drawing.Size(170, 54);
            this.btnCreateAppointment.TabIndex = 0;
            this.btnCreateAppointment.Text = "Đặt lịch hẹn ";
            this.btnCreateAppointment.UseVisualStyleBackColor = true;
            // 
            // btnDentistManagement
            // 
            this.btnDentistManagement.Location = new System.Drawing.Point(15, 163);
            this.btnDentistManagement.Name = "btnDentistManagement";
            this.btnDentistManagement.Size = new System.Drawing.Size(170, 54);
            this.btnDentistManagement.TabIndex = 1;
            this.btnDentistManagement.Text = "Quản lí nha sĩ";
            this.btnDentistManagement.UseVisualStyleBackColor = true;
            this.btnDentistManagement.Click += new System.EventHandler(this.btnPatientFile_Click);
            // 
            // btnPatientFiles
            // 
            this.btnPatientFiles.Location = new System.Drawing.Point(15, 243);
            this.btnPatientFiles.Name = "btnPatientFiles";
            this.btnPatientFiles.Size = new System.Drawing.Size(170, 54);
            this.btnPatientFiles.TabIndex = 2;
            this.btnPatientFiles.Text = "Hồ sơ bệnh nhân";
            this.btnPatientFiles.UseVisualStyleBackColor = true;
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.Location = new System.Drawing.Point(15, 319);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(170, 54);
            this.btnCreateBill.TabIndex = 3;
            this.btnCreateBill.Text = "Tạo hóa đơn";
            this.btnCreateBill.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnCreateAppointment);
            this.panel1.Controls.Add(this.btnCreateBill);
            this.panel1.Controls.Add(this.btnDentistManagement);
            this.panel1.Controls.Add(this.btnPatientFiles);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 672);
            this.panel1.TabIndex = 0;
            // 
            // pnShowContent
            // 
            this.pnShowContent.BackColor = System.Drawing.Color.White;
            this.pnShowContent.Location = new System.Drawing.Point(210, 86);
            this.pnShowContent.Name = "pnShowContent";
            this.pnShowContent.Size = new System.Drawing.Size(1301, 585);
            this.pnShowContent.TabIndex = 1;
            // 
            // eclipseControl1
            // 
            this.eclipseControl1.CornerRadius = 32;
            this.eclipseControl1.TargetControl = this.panel1;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1516, 673);
            this.Controls.Add(this.pnShowContent);
            this.Controls.Add(this.panel1);
            this.Name = "Receptionist";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Receptionist_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateAppointment;
        private System.Windows.Forms.Button btnDentistManagement;
        private System.Windows.Forms.Button btnPatientFiles;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnShowContent;
        private DAO.EclipseControl eclipseControl1;
    }
}
