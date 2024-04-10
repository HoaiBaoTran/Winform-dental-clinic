namespace N19_ProjectForm.GUI.DentistView
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
            this.pnSidebar = new System.Windows.Forms.Panel();
            this.btnPrescription = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnPatientFiles = new System.Windows.Forms.Button();
            this.pnShowContent = new System.Windows.Forms.Panel();
            this.pnSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSidebar
            // 
            this.pnSidebar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnSidebar.Controls.Add(this.btnPrescription);
            this.pnSidebar.Controls.Add(this.btnCalendar);
            this.pnSidebar.Controls.Add(this.btnPatientFiles);
            this.pnSidebar.Location = new System.Drawing.Point(2, 0);
            this.pnSidebar.Name = "pnSidebar";
            this.pnSidebar.Size = new System.Drawing.Size(235, 668);
            this.pnSidebar.TabIndex = 2;
            // 
            // btnPrescription
            // 
            this.btnPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrescription.Location = new System.Drawing.Point(10, 463);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(207, 54);
            this.btnPrescription.TabIndex = 3;
            this.btnPrescription.Text = "Toa Thuốc";
            this.btnPrescription.UseVisualStyleBackColor = true;
            this.btnPrescription.Click += new System.EventHandler(this.btnPrescription_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.Location = new System.Drawing.Point(10, 376);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(207, 54);
            this.btnCalendar.TabIndex = 1;
            this.btnCalendar.Text = "Lịch làm việc";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnPatientFiles
            // 
            this.btnPatientFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientFiles.Location = new System.Drawing.Point(10, 288);
            this.btnPatientFiles.Name = "btnPatientFiles";
            this.btnPatientFiles.Size = new System.Drawing.Size(207, 54);
            this.btnPatientFiles.TabIndex = 2;
            this.btnPatientFiles.Text = "Hồ sơ bệnh nhân";
            this.btnPatientFiles.UseVisualStyleBackColor = true;
            this.btnPatientFiles.Click += new System.EventHandler(this.btnPatientFiles_Click);
            // 
            // pnShowContent
            // 
            this.pnShowContent.BackColor = System.Drawing.Color.White;
            this.pnShowContent.Location = new System.Drawing.Point(243, 83);
            this.pnShowContent.Name = "pnShowContent";
            this.pnShowContent.Size = new System.Drawing.Size(1353, 585);
            this.pnShowContent.TabIndex = 3;
            // 
            // Dentist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 673);
            this.Controls.Add(this.pnShowContent);
            this.Controls.Add(this.pnSidebar);
            this.Name = "Dentist";
            this.Text = "Dentist";
            this.Load += new System.EventHandler(this.Dentist_Load);
            this.pnSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSidebar;
        private System.Windows.Forms.Button btnPrescription;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnPatientFiles;
        private System.Windows.Forms.Panel pnShowContent;
    }
}