namespace N19_DentalClinic.controller.receptionist
{
    partial class ManagePatientProfileForm
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
            label6 = new Label();
            btnAddDentist = new component.RJButton();
            roundPictureBox2 = new component.RoundPictureBox();
            dataGridView = new DataGridView();
            patientIdCol = new DataGridViewTextBoxColumn();
            patientNameCol = new DataGridViewTextBoxColumn();
            dobCol = new DataGridViewTextBoxColumn();
            patientAddressCol = new DataGridViewTextBoxColumn();
            phoneNumberCol = new DataGridViewTextBoxColumn();
            patientEmailCol = new DataGridViewTextBoxColumn();
            patientGender = new DataGridViewTextBoxColumn();
            patientHistoryCol = new DataGridViewTextBoxColumn();
            dentistNameCol = new DataGridViewTextBoxColumn();
            tbSearch = new TextBox();
            btnSearch = new component.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
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
            panel1.TabIndex = 2;
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
            btnPatientProfile.BackColor = Color.FromArgb(219, 175, 9);
            btnPatientProfile.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnPatientProfile.BorderColor = Color.PaleVioletRed;
            btnPatientProfile.BorderRadius = 10;
            btnPatientProfile.BorderSize = 0;
            btnPatientProfile.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnPatientProfile.FlatAppearance.BorderSize = 0;
            btnPatientProfile.FlatStyle = FlatStyle.Flat;
            btnPatientProfile.Font = new Font("Segoe UI", 12F);
            btnPatientProfile.ForeColor = Color.Black;
            btnPatientProfile.Location = new Point(14, 460);
            btnPatientProfile.Name = "btnPatientProfile";
            btnPatientProfile.Size = new Size(218, 66);
            btnPatientProfile.TabIndex = 10;
            btnPatientProfile.Text = "Hồ sơ bệnh nhân";
            btnPatientProfile.TextColor = Color.Black;
            btnPatientProfile.UseVisualStyleBackColor = false;
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
            panel2.Location = new Point(248, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1468, 125);
            panel2.TabIndex = 3;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(294, 150);
            label6.Name = "label6";
            label6.Size = new Size(256, 41);
            label6.TabIndex = 4;
            label6.Text = "Hồ sơ bệnh nhân";
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
            btnAddDentist.Location = new Point(1459, 141);
            btnAddDentist.Name = "btnAddDentist";
            btnAddDentist.Size = new Size(211, 56);
            btnAddDentist.TabIndex = 10;
            btnAddDentist.Text = "Thêm bệnh nhân";
            btnAddDentist.TextAlign = ContentAlignment.MiddleRight;
            btnAddDentist.TextColor = Color.Black;
            btnAddDentist.UseVisualStyleBackColor = false;
            // 
            // roundPictureBox2
            // 
            roundPictureBox2.BackColor = Color.FromArgb(56, 92, 67);
            roundPictureBox2.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(1469, 150);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(39, 41);
            roundPictureBox2.TabIndex = 11;
            roundPictureBox2.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { patientIdCol, patientNameCol, dobCol, patientAddressCol, phoneNumberCol, patientEmailCol, patientGender, patientHistoryCol, dentistNameCol });
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
            dataGridView.Location = new Point(256, 309);
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
            dataGridView.TabIndex = 12;
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
            // patientHistoryCol
            // 
            patientHistoryCol.HeaderText = "Lịch sử khám";
            patientHistoryCol.MinimumWidth = 6;
            patientHistoryCol.Name = "patientHistoryCol";
            patientHistoryCol.Width = 125;
            // 
            // dentistNameCol
            // 
            dentistNameCol.HeaderText = "Nha sĩ chăm sóc";
            dentistNameCol.MinimumWidth = 6;
            dentistNameCol.Name = "dentistNameCol";
            dentistNameCol.Width = 150;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.Location = new Point(294, 205);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm bệnh nhân";
            tbSearch.Size = new Size(293, 34);
            tbSearch.TabIndex = 13;
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
            btnSearch.Location = new Point(593, 205);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 48);
            btnSearch.TabIndex = 14;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // ManagePatientProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1682, 953);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(dataGridView);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnAddDentist);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManagePatientProfileForm";
            Text = "ManagePatientProfileForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).EndInit();
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
        private Label label6;
        private component.RJButton btnAddDentist;
        private component.RoundPictureBox roundPictureBox2;
        private DataGridView dataGridView;
        private TextBox tbSearch;
        private component.RJButton btnSearch;
        private DataGridViewTextBoxColumn patientIdCol;
        private DataGridViewTextBoxColumn patientNameCol;
        private DataGridViewTextBoxColumn dobCol;
        private DataGridViewTextBoxColumn patientAddressCol;
        private DataGridViewTextBoxColumn phoneNumberCol;
        private DataGridViewTextBoxColumn patientEmailCol;
        private DataGridViewTextBoxColumn patientGender;
        private DataGridViewTextBoxColumn patientHistoryCol;
        private DataGridViewTextBoxColumn dentistNameCol;
    }
}