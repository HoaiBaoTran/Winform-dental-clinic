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
            roundPictureBox1 = new component.RoundPictureBox();
            label3 = new Label();
            lbName = new Label();
            label2 = new Label();
            btnManageAss = new Button();
            btnManageDentist = new Button();
            btnManageRecep = new Button();
            label1 = new Label();
            btnMaterialManagement = new Button();
            btnWorkCalendar = new Button();
            btnServiceManagement = new Button();
            btnStatistics = new Button();
            pnShowContent = new Panel();
            pnSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnSidebar
            // 
            pnSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnSidebar.BackColor = SystemColors.AppWorkspace;
            pnSidebar.Controls.Add(roundPictureBox1);
            pnSidebar.Controls.Add(label3);
            pnSidebar.Controls.Add(lbName);
            pnSidebar.Controls.Add(label2);
            pnSidebar.Controls.Add(btnManageAss);
            pnSidebar.Controls.Add(btnManageDentist);
            pnSidebar.Controls.Add(btnManageRecep);
            pnSidebar.Controls.Add(label1);
            pnSidebar.Controls.Add(btnMaterialManagement);
            pnSidebar.Controls.Add(btnWorkCalendar);
            pnSidebar.Controls.Add(btnServiceManagement);
            pnSidebar.Controls.Add(btnStatistics);
            pnSidebar.Location = new Point(2, -1);
            pnSidebar.Margin = new Padding(3, 4, 3, 4);
            pnSidebar.Name = "pnSidebar";
            pnSidebar.Size = new Size(235, 952);
            pnSidebar.TabIndex = 1;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.Image = Properties.Resources.luffy;
            roundPictureBox1.Location = new Point(42, 19);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(154, 145);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 22;
            roundPictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(9, 244);
            label3.Name = "label3";
            label3.Size = new Size(220, 1);
            label3.TabIndex = 20;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 18F);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(27, 192);
            lbName.Name = "lbName";
            lbName.Size = new Size(200, 41);
            lbName.TabIndex = 21;
            lbName.Text = "Trần Hoài Bảo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(4, 263);
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
            btnManageAss.Location = new Point(10, 465);
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
            btnManageDentist.Location = new Point(10, 387);
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
            btnManageRecep.Location = new Point(10, 307);
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
            label1.Location = new Point(3, 559);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "Chức Năng";
            // 
            // btnMaterialManagement
            // 
            btnMaterialManagement.FlatStyle = FlatStyle.Flat;
            btnMaterialManagement.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaterialManagement.Location = new Point(10, 695);
            btnMaterialManagement.Margin = new Padding(3, 4, 3, 4);
            btnMaterialManagement.Name = "btnMaterialManagement";
            btnMaterialManagement.Size = new Size(207, 68);
            btnMaterialManagement.TabIndex = 0;
            btnMaterialManagement.Text = "Quản lí vật liệu ";
            btnMaterialManagement.UseVisualStyleBackColor = true;
            btnMaterialManagement.Click += btnMaterialManagement_Click;
            // 
            // btnWorkCalendar
            // 
            btnWorkCalendar.FlatStyle = FlatStyle.Flat;
            btnWorkCalendar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWorkCalendar.Location = new Point(9, 873);
            btnWorkCalendar.Margin = new Padding(3, 4, 3, 4);
            btnWorkCalendar.Name = "btnWorkCalendar";
            btnWorkCalendar.Size = new Size(207, 68);
            btnWorkCalendar.TabIndex = 3;
            btnWorkCalendar.Text = "Xếp lịch làm việc";
            btnWorkCalendar.UseVisualStyleBackColor = true;
            btnWorkCalendar.Click += btnWorkCalendar_Click;
            // 
            // btnServiceManagement
            // 
            btnServiceManagement.FlatStyle = FlatStyle.Flat;
            btnServiceManagement.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServiceManagement.Location = new Point(9, 607);
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
            btnStatistics.Location = new Point(10, 787);
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
            pnShowContent.Location = new Point(246, 143);
            pnShowContent.Margin = new Padding(6, 8, 6, 8);
            pnShowContent.Name = "pnShowContent";
            pnShowContent.Size = new Size(1421, 803);
            pnShowContent.TabIndex = 2;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1682, 953);
            Controls.Add(pnShowContent);
            Controls.Add(pnSidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            pnSidebar.ResumeLayout(false);
            pnSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnSidebar;
        private System.Windows.Forms.Button btnMaterialManagement;
        private System.Windows.Forms.Button btnWorkCalendar;
        private System.Windows.Forms.Button btnServiceManagement;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Panel pnShowContent;
        private System.Windows.Forms.Button btnManageAss;
        private System.Windows.Forms.Button btnManageDentist;
        private System.Windows.Forms.Button btnManageRecep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private component.RoundPictureBox roundPictureBox1;
        private Label label3;
        private Label lbName;
    }
}