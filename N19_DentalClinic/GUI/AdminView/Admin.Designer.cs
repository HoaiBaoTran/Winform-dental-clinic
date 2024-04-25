namespace N19_DentalClinic.GUI.AdminView
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            pnSidebar = new Panel();
            btnPatFile = new Button();
            btnManageBill = new Button();
            label2 = new Label();
            btnManageAss = new Button();
            btnManageDentist = new Button();
            btnManageRecep = new Button();
            label1 = new Label();
            btnMaterialManagement = new Button();
            btnServiceManagement = new Button();
            btnStatistics = new Button();
            pnShowContent = new Panel();
            backToLogin = new component.RJButton();
            label3 = new Label();
            lbNameAdmin = new Label();
            pnSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnSidebar
            // 
            pnSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnSidebar.BackColor = SystemColors.AppWorkspace;
            pnSidebar.Controls.Add(btnPatFile);
            pnSidebar.Controls.Add(btnManageBill);
            pnSidebar.Controls.Add(label2);
            pnSidebar.Controls.Add(btnManageAss);
            pnSidebar.Controls.Add(btnManageDentist);
            pnSidebar.Controls.Add(btnManageRecep);
            pnSidebar.Controls.Add(label1);
            pnSidebar.Controls.Add(btnMaterialManagement);
            pnSidebar.Controls.Add(btnServiceManagement);
            pnSidebar.Controls.Add(btnStatistics);
            pnSidebar.Location = new Point(2, 13);
            pnSidebar.Margin = new Padding(3, 4, 3, 4);
            pnSidebar.Name = "pnSidebar";
            pnSidebar.Size = new Size(235, 1023);
            pnSidebar.TabIndex = 1;
            // 
            // btnPatFile
            // 
            btnPatFile.FlatStyle = FlatStyle.Flat;
            btnPatFile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPatFile.Location = new Point(11, 630);
            btnPatFile.Margin = new Padding(3, 4, 3, 4);
            btnPatFile.Name = "btnPatFile";
            btnPatFile.Size = new Size(207, 72);
            btnPatFile.TabIndex = 7;
            btnPatFile.Text = "Hồ sơ bệnh nhân";
            btnPatFile.UseVisualStyleBackColor = true;
            btnPatFile.Click += btnPatFile_Click;
            // 
            // btnManageBill
            // 
            btnManageBill.FlatStyle = FlatStyle.Flat;
            btnManageBill.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageBill.Location = new Point(11, 540);
            btnManageBill.Margin = new Padding(3, 4, 3, 4);
            btnManageBill.Name = "btnManageBill";
            btnManageBill.Size = new Size(207, 68);
            btnManageBill.TabIndex = 22;
            btnManageBill.Text = "Quản lí hóa đơn";
            btnManageBill.UseVisualStyleBackColor = true;
            btnManageBill.Click += btnManageBill_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 16);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 0;
            label2.Text = "Quản lí";
            // 
            // btnManageAss
            // 
            btnManageAss.FlatStyle = FlatStyle.Flat;
            btnManageAss.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageAss.Image = (Image)resources.GetObject("btnManageAss.Image");
            btnManageAss.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageAss.Location = new Point(11, 226);
            btnManageAss.Margin = new Padding(3, 4, 3, 4);
            btnManageAss.Name = "btnManageAss";
            btnManageAss.Padding = new Padding(16, 0, 16, 0);
            btnManageAss.Size = new Size(207, 60);
            btnManageAss.TabIndex = 6;
            btnManageAss.Text = "Phụ tá";
            btnManageAss.TextAlign = ContentAlignment.MiddleRight;
            btnManageAss.UseVisualStyleBackColor = true;
            btnManageAss.Click += btnManageAss_Click;
            // 
            // btnManageDentist
            // 
            btnManageDentist.FlatStyle = FlatStyle.Flat;
            btnManageDentist.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageDentist.Image = (Image)resources.GetObject("btnManageDentist.Image");
            btnManageDentist.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageDentist.Location = new Point(11, 148);
            btnManageDentist.Margin = new Padding(3, 4, 3, 4);
            btnManageDentist.Name = "btnManageDentist";
            btnManageDentist.Padding = new Padding(16, 0, 16, 0);
            btnManageDentist.Size = new Size(207, 60);
            btnManageDentist.TabIndex = 5;
            btnManageDentist.Text = "Nha sĩ";
            btnManageDentist.TextAlign = ContentAlignment.MiddleRight;
            btnManageDentist.UseVisualStyleBackColor = true;
            btnManageDentist.Click += btnManageDentist_Click;
            // 
            // btnManageRecep
            // 
            btnManageRecep.FlatStyle = FlatStyle.Flat;
            btnManageRecep.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageRecep.Image = (Image)resources.GetObject("btnManageRecep.Image");
            btnManageRecep.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageRecep.Location = new Point(11, 68);
            btnManageRecep.Margin = new Padding(3, 4, 3, 4);
            btnManageRecep.Name = "btnManageRecep";
            btnManageRecep.Padding = new Padding(16, 0, 16, 0);
            btnManageRecep.Size = new Size(207, 60);
            btnManageRecep.TabIndex = 4;
            btnManageRecep.Text = "Lễ tân";
            btnManageRecep.TextAlign = ContentAlignment.MiddleRight;
            btnManageRecep.UseVisualStyleBackColor = true;
            btnManageRecep.Click += btnManageRecep_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 320);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "Chức Năng";
            // 
            // btnMaterialManagement
            // 
            btnMaterialManagement.FlatStyle = FlatStyle.Flat;
            btnMaterialManagement.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaterialManagement.Location = new Point(11, 450);
            btnMaterialManagement.Margin = new Padding(3, 4, 3, 4);
            btnMaterialManagement.Name = "btnMaterialManagement";
            btnMaterialManagement.Size = new Size(207, 68);
            btnMaterialManagement.TabIndex = 0;
            btnMaterialManagement.Text = "Quản lí vật liệu ";
            btnMaterialManagement.UseVisualStyleBackColor = true;
            btnMaterialManagement.Click += btnMaterialManagement_Click;
            // 
            // btnServiceManagement
            // 
            btnServiceManagement.FlatStyle = FlatStyle.Flat;
            btnServiceManagement.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServiceManagement.Location = new Point(10, 360);
            btnServiceManagement.Margin = new Padding(3, 4, 3, 4);
            btnServiceManagement.Name = "btnServiceManagement";
            btnServiceManagement.Size = new Size(207, 68);
            btnServiceManagement.TabIndex = 1;
            btnServiceManagement.Text = "Quản lí dịch vụ";
            btnServiceManagement.UseVisualStyleBackColor = true;
            btnServiceManagement.Click += btnServiceManagement_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatistics.Location = new Point(11, 720);
            btnStatistics.Margin = new Padding(3, 4, 3, 4);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(207, 68);
            btnStatistics.TabIndex = 2;
            btnStatistics.Text = "Thống kê";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // pnShowContent
            // 
            pnShowContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnShowContent.BackColor = Color.White;
            pnShowContent.Location = new Point(246, 81);
            pnShowContent.Margin = new Padding(6, 8, 6, 8);
            pnShowContent.Name = "pnShowContent";
            pnShowContent.Size = new Size(1421, 865);
            pnShowContent.TabIndex = 2;
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
            backToLogin.Location = new Point(1600, 6);
            backToLogin.Name = "backToLogin";
            backToLogin.Size = new Size(67, 64);
            backToLogin.TabIndex = 12;
            backToLogin.TextColor = Color.White;
            backToLogin.UseVisualStyleBackColor = false;
            backToLogin.Click += backToLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(243, 22);
            label3.Name = "label3";
            label3.Size = new Size(118, 41);
            label3.TabIndex = 14;
            label3.Text = "Họ Tên:";
            // 
            // lbNameAdmin
            // 
            lbNameAdmin.AutoSize = true;
            lbNameAdmin.Font = new Font("Segoe UI", 18F);
            lbNameAdmin.ForeColor = Color.White;
            lbNameAdmin.Location = new Point(382, 22);
            lbNameAdmin.Name = "lbNameAdmin";
            lbNameAdmin.Size = new Size(270, 41);
            lbNameAdmin.TabIndex = 13;
            lbNameAdmin.Text = "Quản Lí Toàn Năng";
            lbNameAdmin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1682, 953);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(lbNameAdmin);
            Controls.Add(backToLogin);
            Controls.Add(pnShowContent);
            Controls.Add(pnSidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            pnSidebar.ResumeLayout(false);
            pnSidebar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnSidebar;
        private System.Windows.Forms.Button btnMaterialManagement;
        private System.Windows.Forms.Button btnServiceManagement;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Panel pnShowContent;
        private System.Windows.Forms.Button btnManageAss;
        private System.Windows.Forms.Button btnManageDentist;
        private System.Windows.Forms.Button btnManageRecep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Button btnManageBill;
        private Button btnPatFile;
        private component.RJButton backToLogin;
        private Label label3;
        private Label lbNameAdmin;
    }
}