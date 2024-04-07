namespace N19_DentalClinic.controller.receptionist
{
    partial class ManageBillForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnCreateBill = new component.RJButton();
            btnManageDentist = new component.RJButton();
            btnPatientProfile = new component.RJButton();
            btnBookAppointment = new component.RJButton();
            label5 = new Label();
            roundPictureBox1 = new component.RoundPictureBox();
            label4 = new Label();
            lbRole = new Label();
            lbRoleText = new Label();
            label3 = new Label();
            lbName = new Label();
            panel2 = new Panel();
            btnExit = new component.RJButton();
            label2 = new Label();
            btnSearch = new component.RJButton();
            tbSearch = new TextBox();
            label6 = new Label();
            roundPictureBox2 = new component.RoundPictureBox();
            btnAddDentist = new component.RJButton();
            roundPictureBox3 = new component.RoundPictureBox();
            btnReload = new component.RJButton();
            dataGridView = new DataGridView();
            billIdCol = new DataGridViewTextBoxColumn();
            dateCol = new DataGridViewTextBoxColumn();
            paymentTimeCol = new DataGridViewTextBoxColumn();
            totalPriceCol = new DataGridViewTextBoxColumn();
            patientIdCol = new DataGridViewTextBoxColumn();
            patientNameCol = new DataGridViewTextBoxColumn();
            serviceAndMedicine = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 56, 134);
            panel1.Controls.Add(btnCreateBill);
            panel1.Controls.Add(btnManageDentist);
            panel1.Controls.Add(btnPatientProfile);
            panel1.Controls.Add(btnBookAppointment);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(roundPictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lbRole);
            panel1.Controls.Add(lbRoleText);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbName);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1000);
            panel1.TabIndex = 4;
            // 
            // btnCreateBill
            // 
            btnCreateBill.BackColor = Color.FromArgb(219, 175, 9);
            btnCreateBill.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnCreateBill.BorderColor = Color.PaleVioletRed;
            btnCreateBill.BorderRadius = 10;
            btnCreateBill.BorderSize = 0;
            btnCreateBill.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnCreateBill.FlatAppearance.BorderSize = 0;
            btnCreateBill.FlatStyle = FlatStyle.Flat;
            btnCreateBill.Font = new Font("Segoe UI", 12F);
            btnCreateBill.ForeColor = Color.Black;
            btnCreateBill.Location = new Point(14, 620);
            btnCreateBill.Name = "btnCreateBill";
            btnCreateBill.Size = new Size(218, 66);
            btnCreateBill.TabIndex = 12;
            btnCreateBill.Text = "Tạo hóa đơn";
            btnCreateBill.TextColor = Color.Black;
            btnCreateBill.UseVisualStyleBackColor = false;
            // 
            // btnManageDentist
            // 
            btnManageDentist.BackColor = Color.FromArgb(9, 24, 219);
            btnManageDentist.BackgroundColor = Color.FromArgb(9, 24, 219);
            btnManageDentist.BorderColor = Color.PaleVioletRed;
            btnManageDentist.BorderRadius = 10;
            btnManageDentist.BorderSize = 0;
            btnManageDentist.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnManageDentist.FlatAppearance.BorderSize = 0;
            btnManageDentist.FlatStyle = FlatStyle.Flat;
            btnManageDentist.Font = new Font("Segoe UI", 12F);
            btnManageDentist.ForeColor = Color.White;
            btnManageDentist.Location = new Point(12, 540);
            btnManageDentist.Name = "btnManageDentist";
            btnManageDentist.Size = new Size(218, 66);
            btnManageDentist.TabIndex = 11;
            btnManageDentist.Text = "Quản lý nha sĩ";
            btnManageDentist.TextColor = Color.White;
            btnManageDentist.UseVisualStyleBackColor = false;
            btnManageDentist.Click += btnManageDentist_Click;
            // 
            // btnPatientProfile
            // 
            btnPatientProfile.BackColor = Color.FromArgb(9, 24, 219);
            btnPatientProfile.BackgroundColor = Color.FromArgb(9, 24, 219);
            btnPatientProfile.BorderColor = Color.PaleVioletRed;
            btnPatientProfile.BorderRadius = 10;
            btnPatientProfile.BorderSize = 0;
            btnPatientProfile.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnPatientProfile.FlatAppearance.BorderSize = 0;
            btnPatientProfile.FlatStyle = FlatStyle.Flat;
            btnPatientProfile.Font = new Font("Segoe UI", 12F);
            btnPatientProfile.ForeColor = Color.White;
            btnPatientProfile.Location = new Point(14, 460);
            btnPatientProfile.Name = "btnPatientProfile";
            btnPatientProfile.Size = new Size(218, 66);
            btnPatientProfile.TabIndex = 10;
            btnPatientProfile.Text = "Hồ sơ bệnh nhân";
            btnPatientProfile.TextColor = Color.White;
            btnPatientProfile.UseVisualStyleBackColor = false;
            btnPatientProfile.Click += btnPatientProfile_Click;
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.BackColor = Color.FromArgb(9, 24, 219);
            btnBookAppointment.BackgroundColor = Color.FromArgb(9, 24, 219);
            btnBookAppointment.BorderColor = Color.PaleVioletRed;
            btnBookAppointment.BorderRadius = 10;
            btnBookAppointment.BorderSize = 0;
            btnBookAppointment.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnBookAppointment.FlatAppearance.BorderSize = 0;
            btnBookAppointment.FlatStyle = FlatStyle.Flat;
            btnBookAppointment.Font = new Font("Segoe UI", 12F);
            btnBookAppointment.ForeColor = Color.White;
            btnBookAppointment.Location = new Point(14, 380);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new Size(218, 66);
            btnBookAppointment.TabIndex = 9;
            btnBookAppointment.Text = "Đặt lịch hẹn";
            btnBookAppointment.TextColor = Color.White;
            btnBookAppointment.UseVisualStyleBackColor = false;
            btnBookAppointment.Click += btnBookAppointment_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 320);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 7;
            label5.Text = "Chức năng";
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            roundPictureBox1.Image = Properties.Resources.luffy;
            roundPictureBox1.Location = new Point(45, 27);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(154, 145);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 4;
            roundPictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(12, 309);
            label4.Name = "label4";
            label4.Size = new Size(220, 1);
            label4.TabIndex = 6;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Segoe UI", 12F);
            lbRole.ForeColor = Color.White;
            lbRole.Location = new Point(133, 268);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(66, 28);
            lbRole.TabIndex = 5;
            lbRole.Text = "Nha sĩ";
            // 
            // lbRoleText
            // 
            lbRoleText.AutoSize = true;
            lbRoleText.Font = new Font("Segoe UI", 12F);
            lbRoleText.ForeColor = Color.White;
            lbRoleText.Location = new Point(54, 268);
            lbRoleText.Name = "lbRoleText";
            lbRoleText.Size = new Size(73, 28);
            lbRoleText.TabIndex = 4;
            lbRoleText.Text = "Vai trò:";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(12, 252);
            label3.Name = "label3";
            label3.Size = new Size(220, 1);
            label3.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 18F);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(30, 200);
            lbName.Name = "lbName";
            lbName.Size = new Size(200, 41);
            lbName.TabIndex = 3;
            lbName.Text = "Trần Hoài Bảo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 56, 134);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(242, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1468, 125);
            panel2.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.MediumSlateBlue;
            btnExit.BackgroundColor = Color.MediumSlateBlue;
            btnExit.BackgroundImage = Properties.Resources.icon_exit;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.BorderColor = Color.PaleVioletRed;
            btnExit.BorderRadius = 0;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1337, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(85, 87);
            btnExit.TabIndex = 4;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(5, 124);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(219, 175, 9);
            btnSearch.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnSearch.BackgroundImage = Properties.Resources.search_icon;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 5;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(577, 219);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 48);
            btnSearch.TabIndex = 20;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.Location = new Point(278, 219);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm hóa đơn";
            tbSearch.Size = new Size(293, 34);
            tbSearch.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(278, 162);
            label6.Name = "label6";
            label6.Size = new Size(285, 41);
            label6.TabIndex = 18;
            label6.Text = "Danh sách hóa đơn";
            // 
            // roundPictureBox2
            // 
            roundPictureBox2.BackColor = Color.FromArgb(56, 92, 67);
            roundPictureBox2.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(1372, 168);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(39, 41);
            roundPictureBox2.TabIndex = 22;
            roundPictureBox2.TabStop = false;
            // 
            // btnAddDentist
            // 
            btnAddDentist.BackColor = Color.FromArgb(18, 219, 78);
            btnAddDentist.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnAddDentist.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddDentist.BorderColor = Color.PaleVioletRed;
            btnAddDentist.BorderRadius = 5;
            btnAddDentist.BorderSize = 0;
            btnAddDentist.FlatAppearance.BorderSize = 0;
            btnAddDentist.FlatStyle = FlatStyle.Flat;
            btnAddDentist.Font = new Font("Segoe UI", 11F);
            btnAddDentist.ForeColor = Color.Black;
            btnAddDentist.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddDentist.Location = new Point(1365, 162);
            btnAddDentist.Name = "btnAddDentist";
            btnAddDentist.Size = new Size(182, 56);
            btnAddDentist.TabIndex = 21;
            btnAddDentist.Text = "Thêm hóa đơn";
            btnAddDentist.TextAlign = ContentAlignment.MiddleRight;
            btnAddDentist.TextColor = Color.Black;
            btnAddDentist.UseVisualStyleBackColor = false;
            // 
            // roundPictureBox3
            // 
            roundPictureBox3.BackColor = Color.FromArgb(219, 175, 9);
            roundPictureBox3.BackgroundImage = Properties.Resources.reload_icon;
            roundPictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox3.Location = new Point(1563, 170);
            roundPictureBox3.Name = "roundPictureBox3";
            roundPictureBox3.Size = new Size(39, 41);
            roundPictureBox3.TabIndex = 24;
            roundPictureBox3.TabStop = false;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.FromArgb(50, 56, 134);
            btnReload.BackgroundColor = Color.FromArgb(50, 56, 134);
            btnReload.BackgroundImageLayout = ImageLayout.Zoom;
            btnReload.BorderColor = Color.PaleVioletRed;
            btnReload.BorderRadius = 5;
            btnReload.BorderSize = 0;
            btnReload.FlatAppearance.BorderSize = 0;
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.Font = new Font("Segoe UI", 11F);
            btnReload.ForeColor = Color.White;
            btnReload.ImageAlign = ContentAlignment.MiddleLeft;
            btnReload.Location = new Point(1553, 163);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(117, 56);
            btnReload.TabIndex = 23;
            btnReload.Text = "Tải lại";
            btnReload.TextAlign = ContentAlignment.MiddleRight;
            btnReload.TextColor = Color.White;
            btnReload.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { billIdCol, dateCol, paymentTimeCol, totalPriceCol, patientIdCol, patientNameCol, serviceAndMedicine });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(256, 294);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1414, 615);
            dataGridView.TabIndex = 25;
            // 
            // billIdCol
            // 
            billIdCol.HeaderText = "Mã hóa đơn";
            billIdCol.MinimumWidth = 6;
            billIdCol.Name = "billIdCol";
            billIdCol.Width = 150;
            // 
            // dateCol
            // 
            dateCol.HeaderText = "Ngày lập";
            dateCol.MinimumWidth = 6;
            dateCol.Name = "dateCol";
            dateCol.Width = 230;
            // 
            // paymentTimeCol
            // 
            paymentTimeCol.HeaderText = "Thời gian thanh toán";
            paymentTimeCol.MinimumWidth = 6;
            paymentTimeCol.Name = "paymentTimeCol";
            paymentTimeCol.Width = 150;
            // 
            // totalPriceCol
            // 
            totalPriceCol.HeaderText = "Tổng tiền";
            totalPriceCol.MinimumWidth = 6;
            totalPriceCol.Name = "totalPriceCol";
            totalPriceCol.Width = 230;
            // 
            // patientIdCol
            // 
            patientIdCol.HeaderText = "Mã bệnh nhân";
            patientIdCol.MinimumWidth = 6;
            patientIdCol.Name = "patientIdCol";
            patientIdCol.Width = 125;
            // 
            // patientNameCol
            // 
            patientNameCol.HeaderText = "Tên bệnh nhân";
            patientNameCol.MinimumWidth = 6;
            patientNameCol.Name = "patientNameCol";
            patientNameCol.Width = 225;
            // 
            // serviceAndMedicine
            // 
            serviceAndMedicine.HeaderText = "Dịch vụ và đơn thuốc";
            serviceAndMedicine.MinimumWidth = 6;
            serviceAndMedicine.Name = "serviceAndMedicine";
            serviceAndMedicine.Width = 150;
            // 
            // ManageBillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1682, 953);
            Controls.Add(dataGridView);
            Controls.Add(roundPictureBox3);
            Controls.Add(btnReload);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnAddDentist);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageBillForm";
            Text = "ManageBillForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private component.RJButton btnCreateBill;
        private component.RJButton btnManageDentist;
        private component.RJButton btnPatientProfile;
        private component.RJButton btnBookAppointment;
        private Label label5;
        private component.RoundPictureBox roundPictureBox1;
        private Label label4;
        private Label lbRole;
        private Label lbRoleText;
        private Label label3;
        private Label lbName;
        private Panel panel2;
        private component.RJButton btnExit;
        private Label label2;
        private component.RJButton btnSearch;
        private TextBox tbSearch;
        private Label label6;
        private component.RoundPictureBox roundPictureBox2;
        private component.RJButton btnAddDentist;
        private component.RoundPictureBox roundPictureBox3;
        private component.RJButton btnReload;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn billIdCol;
        private DataGridViewTextBoxColumn dateCol;
        private DataGridViewTextBoxColumn paymentTimeCol;
        private DataGridViewTextBoxColumn totalPriceCol;
        private DataGridViewTextBoxColumn patientIdCol;
        private DataGridViewTextBoxColumn patientNameCol;
        private DataGridViewTextBoxColumn serviceAndMedicine;
    }
}