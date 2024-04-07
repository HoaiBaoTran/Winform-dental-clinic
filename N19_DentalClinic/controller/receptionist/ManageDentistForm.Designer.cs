namespace N19_DentalClinic.controller.receptionist
{
    partial class ManageDentistForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            dataGridView = new DataGridView();
            dentistIdCol = new DataGridViewTextBoxColumn();
            patientNameCol = new DataGridViewTextBoxColumn();
            dobCol = new DataGridViewTextBoxColumn();
            patientAddressCol = new DataGridViewTextBoxColumn();
            phoneNumberCol = new DataGridViewTextBoxColumn();
            patientEmailCol = new DataGridViewTextBoxColumn();
            patientGender = new DataGridViewTextBoxColumn();
            dentistDetailCol = new DataGridViewTextBoxColumn();
            dentistAppointmentCol = new DataGridViewTextBoxColumn();
            roundPictureBox2 = new component.RoundPictureBox();
            btnAddDentist = new component.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
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
            panel1.TabIndex = 3;
            // 
            // btnCreateBill
            // 
            btnCreateBill.BackColor = Color.FromArgb(9, 24, 219);
            btnCreateBill.BackgroundColor = Color.FromArgb(9, 24, 219);
            btnCreateBill.BorderColor = Color.PaleVioletRed;
            btnCreateBill.BorderRadius = 10;
            btnCreateBill.BorderSize = 0;
            btnCreateBill.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnCreateBill.FlatAppearance.BorderSize = 0;
            btnCreateBill.FlatStyle = FlatStyle.Flat;
            btnCreateBill.Font = new Font("Segoe UI", 12F);
            btnCreateBill.ForeColor = Color.White;
            btnCreateBill.Location = new Point(14, 620);
            btnCreateBill.Name = "btnCreateBill";
            btnCreateBill.Size = new Size(218, 66);
            btnCreateBill.TabIndex = 12;
            btnCreateBill.Text = "Tạo hóa đơn";
            btnCreateBill.TextColor = Color.White;
            btnCreateBill.UseVisualStyleBackColor = false;
            btnCreateBill.Click += btnCreateBill_Click;
            // 
            // btnManageDentist
            // 
            btnManageDentist.BackColor = Color.FromArgb(219, 175, 9);
            btnManageDentist.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnManageDentist.BorderColor = Color.PaleVioletRed;
            btnManageDentist.BorderRadius = 10;
            btnManageDentist.BorderSize = 0;
            btnManageDentist.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnManageDentist.FlatAppearance.BorderSize = 0;
            btnManageDentist.FlatStyle = FlatStyle.Flat;
            btnManageDentist.Font = new Font("Segoe UI", 12F);
            btnManageDentist.ForeColor = Color.Black;
            btnManageDentist.Location = new Point(12, 540);
            btnManageDentist.Name = "btnManageDentist";
            btnManageDentist.Size = new Size(218, 66);
            btnManageDentist.TabIndex = 11;
            btnManageDentist.Text = "Quản lý nha sĩ";
            btnManageDentist.TextColor = Color.Black;
            btnManageDentist.UseVisualStyleBackColor = false;
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
            panel2.TabIndex = 4;
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
            btnSearch.Location = new Point(581, 226);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 48);
            btnSearch.TabIndex = 17;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.Location = new Point(282, 226);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm nha sĩ";
            tbSearch.Size = new Size(293, 34);
            tbSearch.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(282, 169);
            label6.Name = "label6";
            label6.Size = new Size(251, 41);
            label6.TabIndex = 15;
            label6.Text = "Danh sách nha sĩ";
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { dentistIdCol, patientNameCol, dobCol, patientAddressCol, phoneNumberCol, patientEmailCol, patientGender, dentistDetailCol, dentistAppointmentCol });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(282, 326);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1414, 615);
            dataGridView.TabIndex = 18;
            // 
            // dentistIdCol
            // 
            dentistIdCol.HeaderText = "Mã nha sĩ";
            dentistIdCol.MinimumWidth = 6;
            dentistIdCol.Name = "dentistIdCol";
            dentistIdCol.Width = 150;
            // 
            // patientNameCol
            // 
            patientNameCol.HeaderText = "Họ tên";
            patientNameCol.MinimumWidth = 6;
            patientNameCol.Name = "patientNameCol";
            patientNameCol.Width = 230;
            // 
            // dobCol
            // 
            dobCol.HeaderText = "Ngày sinh";
            dobCol.MinimumWidth = 6;
            dobCol.Name = "dobCol";
            dobCol.Width = 125;
            // 
            // patientAddressCol
            // 
            patientAddressCol.HeaderText = "Địa chỉ";
            patientAddressCol.MinimumWidth = 6;
            patientAddressCol.Name = "patientAddressCol";
            patientAddressCol.Width = 230;
            // 
            // phoneNumberCol
            // 
            phoneNumberCol.HeaderText = "Số điện thoại";
            phoneNumberCol.MinimumWidth = 6;
            phoneNumberCol.Name = "phoneNumberCol";
            phoneNumberCol.Width = 125;
            // 
            // patientEmailCol
            // 
            patientEmailCol.HeaderText = "Email";
            patientEmailCol.MinimumWidth = 6;
            patientEmailCol.Name = "patientEmailCol";
            patientEmailCol.Width = 150;
            // 
            // patientGender
            // 
            patientGender.HeaderText = "Giới tính";
            patientGender.MinimumWidth = 6;
            patientGender.Name = "patientGender";
            patientGender.Width = 75;
            // 
            // dentistDetailCol
            // 
            dentistDetailCol.HeaderText = "Thông tin chi tiết";
            dentistDetailCol.MinimumWidth = 6;
            dentistDetailCol.Name = "dentistDetailCol";
            dentistDetailCol.Width = 125;
            // 
            // dentistAppointmentCol
            // 
            dentistAppointmentCol.HeaderText = "Xem lịch hẹn";
            dentistAppointmentCol.MinimumWidth = 6;
            dentistAppointmentCol.Name = "dentistAppointmentCol";
            dentistAppointmentCol.Width = 125;
            // 
            // roundPictureBox2
            // 
            roundPictureBox2.BackColor = Color.FromArgb(56, 92, 67);
            roundPictureBox2.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(1512, 163);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(39, 41);
            roundPictureBox2.TabIndex = 20;
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
            btnAddDentist.Location = new Point(1502, 154);
            btnAddDentist.Name = "btnAddDentist";
            btnAddDentist.Size = new Size(168, 56);
            btnAddDentist.TabIndex = 19;
            btnAddDentist.Text = "Thêm nha sĩ";
            btnAddDentist.TextAlign = ContentAlignment.MiddleRight;
            btnAddDentist.TextColor = Color.Black;
            btnAddDentist.UseVisualStyleBackColor = false;
            // 
            // ManageDentistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1682, 953);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnAddDentist);
            Controls.Add(dataGridView);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageDentistForm";
            Text = "ManageDentistForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).EndInit();
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
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn dentistIdCol;
        private DataGridViewTextBoxColumn patientNameCol;
        private DataGridViewTextBoxColumn dobCol;
        private DataGridViewTextBoxColumn patientAddressCol;
        private DataGridViewTextBoxColumn phoneNumberCol;
        private DataGridViewTextBoxColumn patientEmailCol;
        private DataGridViewTextBoxColumn patientGender;
        private DataGridViewTextBoxColumn dentistDetailCol;
        private DataGridViewTextBoxColumn dentistAppointmentCol;
        private component.RoundPictureBox roundPictureBox2;
        private component.RJButton btnAddDentist;
    }
}