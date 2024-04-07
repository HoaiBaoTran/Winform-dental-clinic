namespace N19_DentalClinic.controller.receptionist
{
    partial class AddPatientProfileForm
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
            label1 = new Label();
            tbPatientId = new TextBox();
            label10 = new Label();
            tbEmail = new TextBox();
            label7 = new Label();
            tbPatientName = new TextBox();
            label8 = new Label();
            cbGender = new ComboBox();
            label9 = new Label();
            dateTimePicker = new DateTimePicker();
            label11 = new Label();
            tbAddress = new TextBox();
            label12 = new Label();
            tbPhoneNumber = new TextBox();
            roundPictureBox3 = new component.RoundPictureBox();
            btnBack = new component.RJButton();
            roundPictureBox2 = new component.RoundPictureBox();
            btnAddPatient = new component.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).BeginInit();
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
            btnSearch.Location = new Point(610, 201);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 40);
            btnSearch.TabIndex = 17;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.Location = new Point(294, 201);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm bệnh nhân";
            tbSearch.Size = new Size(293, 34);
            tbSearch.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(294, 150);
            label6.Name = "label6";
            label6.Size = new Size(256, 41);
            label6.TabIndex = 15;
            label6.Text = "Hồ sơ bệnh nhân";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(300, 280);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 38;
            label1.Text = "Mã bệnh nhân";
            // 
            // tbPatientId
            // 
            tbPatientId.Font = new Font("Segoe UI", 14F);
            tbPatientId.Location = new Point(500, 280);
            tbPatientId.Name = "tbPatientId";
            tbPatientId.PlaceholderText = "Nhập mã bệnh nhân";
            tbPatientId.Size = new Size(481, 39);
            tbPatientId.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F);
            label10.Location = new Point(1105, 280);
            label10.Name = "label10";
            label10.Size = new Size(82, 37);
            label10.TabIndex = 51;
            label10.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 14F);
            tbEmail.Location = new Point(1243, 280);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Nhập địa chỉ email";
            tbEmail.Size = new Size(421, 39);
            tbEmail.TabIndex = 52;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(300, 365);
            label7.Name = "label7";
            label7.Size = new Size(131, 37);
            label7.TabIndex = 53;
            label7.Text = "Họ và tên";
            // 
            // tbPatientName
            // 
            tbPatientName.Font = new Font("Segoe UI", 14F);
            tbPatientName.Location = new Point(500, 363);
            tbPatientName.Name = "tbPatientName";
            tbPatientName.PlaceholderText = "Nhập họ và tên bệnh nhân";
            tbPatientName.Size = new Size(481, 39);
            tbPatientName.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(1105, 365);
            label8.Name = "label8";
            label8.Size = new Size(119, 37);
            label8.TabIndex = 55;
            label8.Text = "Giới tính";
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 14F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGender.Location = new Point(1243, 363);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(163, 39);
            cbGender.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(300, 445);
            label9.Name = "label9";
            label9.Size = new Size(135, 37);
            label9.TabIndex = 57;
            label9.Text = "Ngày sinh";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(500, 445);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(174, 39);
            dateTimePicker.TabIndex = 58;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F);
            label11.Location = new Point(300, 525);
            label11.Name = "label11";
            label11.Size = new Size(98, 37);
            label11.TabIndex = 59;
            label11.Text = "Địa chỉ";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI", 14F);
            tbAddress.Location = new Point(500, 527);
            tbAddress.Name = "tbAddress";
            tbAddress.PlaceholderText = "Nhập địa chỉ";
            tbAddress.Size = new Size(906, 39);
            tbAddress.TabIndex = 60;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F);
            label12.Location = new Point(300, 605);
            label12.Name = "label12";
            label12.Size = new Size(174, 37);
            label12.TabIndex = 61;
            label12.Text = "Số điện thoại";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Segoe UI", 14F);
            tbPhoneNumber.Location = new Point(500, 607);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.PlaceholderText = "Nhập số điện thoại";
            tbPhoneNumber.Size = new Size(481, 39);
            tbPhoneNumber.TabIndex = 62;
            // 
            // roundPictureBox3
            // 
            roundPictureBox3.BackColor = Color.White;
            roundPictureBox3.BackgroundImage = Properties.Resources.back_icon;
            roundPictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox3.Location = new Point(1578, 156);
            roundPictureBox3.Name = "roundPictureBox3";
            roundPictureBox3.Size = new Size(39, 41);
            roundPictureBox3.TabIndex = 66;
            roundPictureBox3.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkGray;
            btnBack.BackgroundColor = Color.DarkGray;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.BorderColor = Color.PaleVioletRed;
            btnBack.BorderRadius = 5;
            btnBack.BorderSize = 0;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 11F);
            btnBack.ForeColor = Color.White;
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(1568, 147);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 56);
            btnBack.TabIndex = 65;
            btnBack.Text = "Hủy";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextColor = Color.White;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // roundPictureBox2
            // 
            roundPictureBox2.BackColor = Color.FromArgb(56, 92, 67);
            roundPictureBox2.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(1430, 156);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(39, 41);
            roundPictureBox2.TabIndex = 64;
            roundPictureBox2.TabStop = false;
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = Color.FromArgb(18, 219, 78);
            btnAddPatient.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnAddPatient.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddPatient.BorderColor = Color.PaleVioletRed;
            btnAddPatient.BorderRadius = 5;
            btnAddPatient.BorderSize = 0;
            btnAddPatient.FlatAppearance.BorderSize = 0;
            btnAddPatient.FlatStyle = FlatStyle.Flat;
            btnAddPatient.Font = new Font("Segoe UI", 11F);
            btnAddPatient.ForeColor = Color.Black;
            btnAddPatient.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddPatient.Location = new Point(1419, 147);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(138, 56);
            btnAddPatient.TabIndex = 63;
            btnAddPatient.Text = "Tạo mới";
            btnAddPatient.TextAlign = ContentAlignment.MiddleRight;
            btnAddPatient.TextColor = Color.Black;
            btnAddPatient.UseVisualStyleBackColor = false;
            // 
            // AddPatientProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1682, 953);
            Controls.Add(roundPictureBox3);
            Controls.Add(btnBack);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnAddPatient);
            Controls.Add(tbPhoneNumber);
            Controls.Add(label12);
            Controls.Add(tbAddress);
            Controls.Add(label11);
            Controls.Add(dateTimePicker);
            Controls.Add(label9);
            Controls.Add(cbGender);
            Controls.Add(label8);
            Controls.Add(tbPatientName);
            Controls.Add(label7);
            Controls.Add(tbEmail);
            Controls.Add(label10);
            Controls.Add(tbPatientId);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddPatientProfileForm";
            Text = "AddPatientProfileForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).EndInit();
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
        private Label label1;
        private TextBox tbPatientId;
        private Label label10;
        private TextBox tbEmail;
        private Label label7;
        private TextBox tbPatientName;
        private Label label8;
        private ComboBox cbGender;
        private Label label9;
        private DateTimePicker dateTimePicker;
        private Label label11;
        private TextBox tbAddress;
        private Label label12;
        private TextBox tbPhoneNumber;
        private component.RoundPictureBox roundPictureBox3;
        private component.RJButton btnBack;
        private component.RoundPictureBox roundPictureBox2;
        private component.RJButton btnAddPatient;
    }
}