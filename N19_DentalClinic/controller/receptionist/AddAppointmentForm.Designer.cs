namespace N19_DentalClinic.controller.receptionist
{
    partial class AddAppointmentForm
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
            label6 = new Label();
            roundPictureBox3 = new component.RoundPictureBox();
            btnExit = new component.RJButton();
            roundPictureBox2 = new component.RoundPictureBox();
            btnAddAppointment = new component.RJButton();
            label1 = new Label();
            tbSignal = new TextBox();
            label2 = new Label();
            cbStatus = new ComboBox();
            datePicker = new DateTimePicker();
            timePicker = new DateTimePicker();
            label3 = new Label();
            cbPatient = new ComboBox();
            label4 = new Label();
            tbPatientId = new TextBox();
            btnSearch = new component.RJButton();
            btnPatientList = new component.RJButton();
            label5 = new Label();
            tbPatientName = new TextBox();
            label7 = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            label8 = new Label();
            tbPatientPhoneNumber = new TextBox();
            label9 = new Label();
            tbPatientAddress = new TextBox();
            label10 = new Label();
            tbEmail = new TextBox();
            label11 = new Label();
            comboBox1 = new ComboBox();
            label12 = new Label();
            tbDentistId = new TextBox();
            rjButton1 = new component.RJButton();
            btnDentistList = new component.RJButton();
            label13 = new Label();
            tbDentistName = new TextBox();
            label14 = new Label();
            tbDentistPhoneNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label6.Location = new Point(22, 26);
            label6.Name = "label6";
            label6.Size = new Size(387, 46);
            label6.TabIndex = 4;
            label6.Text = "Đặt lịch hẹn bệnh nhân";
            // 
            // roundPictureBox3
            // 
            roundPictureBox3.BackColor = Color.White;
            roundPictureBox3.BackgroundImage = Properties.Resources.back_icon;
            roundPictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox3.Location = new Point(1132, 31);
            roundPictureBox3.Name = "roundPictureBox3";
            roundPictureBox3.Size = new Size(39, 41);
            roundPictureBox3.TabIndex = 28;
            roundPictureBox3.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkGray;
            btnExit.BackgroundColor = Color.DarkGray;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.BorderColor = Color.PaleVioletRed;
            btnExit.BorderRadius = 5;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 11F);
            btnExit.ForeColor = Color.White;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1122, 22);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 56);
            btnExit.TabIndex = 27;
            btnExit.Text = "Hủy";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // roundPictureBox2
            // 
            roundPictureBox2.BackColor = Color.FromArgb(56, 92, 67);
            roundPictureBox2.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(984, 31);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(39, 41);
            roundPictureBox2.TabIndex = 26;
            roundPictureBox2.TabStop = false;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.BackColor = Color.FromArgb(18, 219, 78);
            btnAddAppointment.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnAddAppointment.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddAppointment.BorderColor = Color.PaleVioletRed;
            btnAddAppointment.BorderRadius = 5;
            btnAddAppointment.BorderSize = 0;
            btnAddAppointment.FlatAppearance.BorderSize = 0;
            btnAddAppointment.FlatStyle = FlatStyle.Flat;
            btnAddAppointment.Font = new Font("Segoe UI", 11F);
            btnAddAppointment.ForeColor = Color.Black;
            btnAddAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddAppointment.Location = new Point(973, 22);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(138, 56);
            btnAddAppointment.TabIndex = 25;
            btnAddAppointment.Text = "Tạo mới";
            btnAddAppointment.TextAlign = ContentAlignment.MiddleRight;
            btnAddAppointment.TextColor = Color.Black;
            btnAddAppointment.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(22, 100);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 29;
            label1.Text = "Triệu chứng";
            // 
            // tbSignal
            // 
            tbSignal.Font = new Font("Segoe UI", 14F);
            tbSignal.Location = new Point(192, 100);
            tbSignal.Name = "tbSignal";
            tbSignal.PlaceholderText = "Nhập triệu chứng";
            tbSignal.Size = new Size(1032, 39);
            tbSignal.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(22, 180);
            label2.Name = "label2";
            label2.Size = new Size(135, 37);
            label2.TabIndex = 31;
            label2.Text = "Trạng thái";
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Segoe UI", 14F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbStatus.Location = new Point(192, 180);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(312, 39);
            cbStatus.TabIndex = 32;
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "dd/MM/yyyy";
            datePicker.Font = new Font("Segoe UI", 14F);
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(510, 180);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(251, 39);
            datePicker.TabIndex = 33;
            // 
            // timePicker
            // 
            timePicker.Font = new Font("Segoe UI", 14F);
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(767, 180);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(245, 39);
            timePicker.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(22, 260);
            label3.Name = "label3";
            label3.Size = new Size(142, 37);
            label3.TabIndex = 35;
            label3.Text = "Bệnh nhân";
            // 
            // cbPatient
            // 
            cbPatient.Font = new Font("Segoe UI", 14F);
            cbPatient.FormattingEnabled = true;
            cbPatient.Items.AddRange(new object[] { "Bệnh nhân cũ", "Bệnh nhân mới" });
            cbPatient.Location = new Point(192, 260);
            cbPatient.Name = "cbPatient";
            cbPatient.Size = new Size(251, 39);
            cbPatient.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(444, 260);
            label4.Name = "label4";
            label4.Size = new Size(188, 37);
            label4.TabIndex = 37;
            label4.Text = "Mã bệnh nhân";
            // 
            // tbPatientId
            // 
            tbPatientId.Font = new Font("Segoe UI", 14F);
            tbPatientId.Location = new Point(638, 260);
            tbPatientId.Name = "tbPatientId";
            tbPatientId.PlaceholderText = "Nhập mã bệnh nhân";
            tbPatientId.Size = new Size(252, 39);
            tbPatientId.TabIndex = 38;
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
            btnSearch.Location = new Point(896, 260);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(48, 39);
            btnSearch.TabIndex = 39;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnPatientList
            // 
            btnPatientList.BackColor = Color.FromArgb(18, 219, 78);
            btnPatientList.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnPatientList.BorderColor = Color.PaleVioletRed;
            btnPatientList.BorderRadius = 10;
            btnPatientList.BorderSize = 0;
            btnPatientList.FlatAppearance.BorderSize = 0;
            btnPatientList.FlatStyle = FlatStyle.Flat;
            btnPatientList.Font = new Font("Segoe UI", 14F);
            btnPatientList.ForeColor = Color.Black;
            btnPatientList.Location = new Point(950, 260);
            btnPatientList.Name = "btnPatientList";
            btnPatientList.Size = new Size(274, 40);
            btnPatientList.TabIndex = 40;
            btnPatientList.Text = "Danh sách bệnh nhân";
            btnPatientList.TextColor = Color.Black;
            btnPatientList.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(22, 340);
            label5.Name = "label5";
            label5.Size = new Size(97, 37);
            label5.TabIndex = 41;
            label5.Text = "Họ tên";
            // 
            // tbPatientName
            // 
            tbPatientName.Font = new Font("Segoe UI", 14F);
            tbPatientName.Location = new Point(192, 340);
            tbPatientName.Name = "tbPatientName";
            tbPatientName.PlaceholderText = "Nhập tên bệnh nhân";
            tbPatientName.Size = new Size(345, 39);
            tbPatientName.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(572, 340);
            label7.Name = "label7";
            label7.Size = new Size(119, 37);
            label7.TabIndex = 43;
            label7.Text = "Giới tính";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI", 14F);
            rbMale.Location = new Point(703, 340);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(86, 36);
            rbMale.TabIndex = 44;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 14F);
            rbFemale.Location = new Point(802, 340);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(67, 36);
            rbFemale.TabIndex = 45;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(871, 340);
            label8.Name = "label8";
            label8.Size = new Size(64, 37);
            label8.TabIndex = 46;
            label8.Text = "SĐT";
            // 
            // tbPatientPhoneNumber
            // 
            tbPatientPhoneNumber.Font = new Font("Segoe UI", 14F);
            tbPatientPhoneNumber.Location = new Point(941, 340);
            tbPatientPhoneNumber.Name = "tbPatientPhoneNumber";
            tbPatientPhoneNumber.PlaceholderText = "Nhập số điện thoại";
            tbPatientPhoneNumber.Size = new Size(283, 39);
            tbPatientPhoneNumber.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(22, 420);
            label9.Name = "label9";
            label9.Size = new Size(98, 37);
            label9.TabIndex = 48;
            label9.Text = "Địa chỉ";
            // 
            // tbPatientAddress
            // 
            tbPatientAddress.Font = new Font("Segoe UI", 14F);
            tbPatientAddress.Location = new Point(201, 420);
            tbPatientAddress.Name = "tbPatientAddress";
            tbPatientAddress.PlaceholderText = "Nhập địa chỉ";
            tbPatientAddress.Size = new Size(586, 39);
            tbPatientAddress.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F);
            label10.Location = new Point(787, 420);
            label10.Name = "label10";
            label10.Size = new Size(82, 37);
            label10.TabIndex = 50;
            label10.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 14F);
            tbEmail.Location = new Point(871, 420);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Nhập địa chỉ email";
            tbEmail.Size = new Size(353, 39);
            tbEmail.TabIndex = 51;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F);
            label11.Location = new Point(22, 500);
            label11.Name = "label11";
            label11.Size = new Size(78, 37);
            label11.TabIndex = 52;
            label11.Text = "Khoa";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bệnh nhân cũ", "Bệnh nhân mới" });
            comboBox1.Location = new Point(192, 500);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 39);
            comboBox1.TabIndex = 53;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F);
            label12.Location = new Point(449, 498);
            label12.Name = "label12";
            label12.Size = new Size(131, 37);
            label12.TabIndex = 54;
            label12.Text = "Mã nha sĩ";
            // 
            // tbDentistId
            // 
            tbDentistId.Font = new Font("Segoe UI", 14F);
            tbDentistId.Location = new Point(586, 502);
            tbDentistId.Name = "tbDentistId";
            tbDentistId.PlaceholderText = "Nhập mã nha sĩ";
            tbDentistId.Size = new Size(306, 39);
            tbDentistId.TabIndex = 55;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(219, 175, 9);
            rjButton1.BackgroundColor = Color.FromArgb(219, 175, 9);
            rjButton1.BackgroundImage = Properties.Resources.search_icon;
            rjButton1.BackgroundImageLayout = ImageLayout.Zoom;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 5;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(898, 498);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(48, 43);
            rjButton1.TabIndex = 56;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // btnDentistList
            // 
            btnDentistList.BackColor = Color.FromArgb(18, 219, 78);
            btnDentistList.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnDentistList.BorderColor = Color.PaleVioletRed;
            btnDentistList.BorderRadius = 10;
            btnDentistList.BorderSize = 0;
            btnDentistList.FlatAppearance.BorderSize = 0;
            btnDentistList.FlatStyle = FlatStyle.Flat;
            btnDentistList.Font = new Font("Segoe UI", 14F);
            btnDentistList.ForeColor = Color.Black;
            btnDentistList.Location = new Point(950, 500);
            btnDentistList.Name = "btnDentistList";
            btnDentistList.Size = new Size(274, 40);
            btnDentistList.TabIndex = 57;
            btnDentistList.Text = "Danh sách nha sĩ";
            btnDentistList.TextColor = Color.Black;
            btnDentistList.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F);
            label13.Location = new Point(22, 580);
            label13.Name = "label13";
            label13.Size = new Size(133, 37);
            label13.TabIndex = 58;
            label13.Text = "Tên nha sĩ";
            // 
            // tbDentistName
            // 
            tbDentistName.Font = new Font("Segoe UI", 14F);
            tbDentistName.Location = new Point(191, 580);
            tbDentistName.Name = "tbDentistName";
            tbDentistName.PlaceholderText = "Nhập tên nha sĩ";
            tbDentistName.Size = new Size(346, 39);
            tbDentistName.TabIndex = 59;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16F);
            label14.Location = new Point(554, 580);
            label14.Name = "label14";
            label14.Size = new Size(64, 37);
            label14.TabIndex = 60;
            label14.Text = "SĐT";
            // 
            // tbDentistPhoneNumber
            // 
            tbDentistPhoneNumber.Font = new Font("Segoe UI", 14F);
            tbDentistPhoneNumber.Location = new Point(638, 578);
            tbDentistPhoneNumber.Name = "tbDentistPhoneNumber";
            tbDentistPhoneNumber.PlaceholderText = "Nhập số điện thoại";
            tbDentistPhoneNumber.Size = new Size(283, 39);
            tbDentistPhoneNumber.TabIndex = 61;
            // 
            // AddAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1282, 653);
            Controls.Add(tbDentistPhoneNumber);
            Controls.Add(label14);
            Controls.Add(tbDentistName);
            Controls.Add(label13);
            Controls.Add(btnDentistList);
            Controls.Add(rjButton1);
            Controls.Add(tbDentistId);
            Controls.Add(label12);
            Controls.Add(comboBox1);
            Controls.Add(label11);
            Controls.Add(tbEmail);
            Controls.Add(label10);
            Controls.Add(tbPatientAddress);
            Controls.Add(label9);
            Controls.Add(tbPatientPhoneNumber);
            Controls.Add(label8);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(label7);
            Controls.Add(tbPatientName);
            Controls.Add(label5);
            Controls.Add(btnPatientList);
            Controls.Add(btnSearch);
            Controls.Add(tbPatientId);
            Controls.Add(label4);
            Controls.Add(cbPatient);
            Controls.Add(label3);
            Controls.Add(timePicker);
            Controls.Add(datePicker);
            Controls.Add(cbStatus);
            Controls.Add(label2);
            Controls.Add(tbSignal);
            Controls.Add(label1);
            Controls.Add(roundPictureBox3);
            Controls.Add(btnExit);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnAddAppointment);
            Controls.Add(label6);
            Name = "AddAppointmentForm";
            Text = "AddAppointmentForm";
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private component.RoundPictureBox roundPictureBox3;
        private component.RJButton btnExit;
        private component.RoundPictureBox roundPictureBox2;
        private component.RJButton btnAddAppointment;
        private Label label1;
        private TextBox tbSignal;
        private Label label2;
        private ComboBox cbStatus;
        private DateTimePicker datePicker;
        private DateTimePicker timePicker;
        private Label label3;
        private ComboBox cbPatient;
        private Label label4;
        private TextBox tbPatientId;
        private component.RJButton btnSearch;
        private component.RJButton btnPatientList;
        private Label label5;
        private TextBox tbPatientName;
        private Label label7;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label label8;
        private TextBox tbPatientPhoneNumber;
        private Label label9;
        private TextBox tbPatientAddress;
        private Label label10;
        private TextBox tbEmail;
        private Label label11;
        private ComboBox comboBox1;
        private Label label12;
        private TextBox tbDentistId;
        private component.RJButton rjButton1;
        private component.RJButton btnDentistList;
        private Label label13;
        private TextBox tbDentistName;
        private Label label14;
        private TextBox tbDentistPhoneNumber;
    }
}