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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppointmentForm));
            label6 = new Label();
            btnExit = new component.RJButton();
            btnAddAppointment = new component.RJButton();
            label1 = new Label();
            tbSignal = new TextBox();
            label2 = new Label();
            cbStatus = new ComboBox();
            HMSPicker = new DateTimePicker();
            label3 = new Label();
            cbPatient = new ComboBox();
            label4 = new Label();
            tbPatientId = new TextBox();
            btnSearchPatId = new component.RJButton();
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
            cbFaculty = new ComboBox();
            label12 = new Label();
            tbDentistId = new TextBox();
            btnSearchDenId = new component.RJButton();
            btnDentistList = new component.RJButton();
            label13 = new Label();
            tbDentistName = new TextBox();
            label14 = new Label();
            tbDentistPhoneNumber = new TextBox();
            txtDay = new TextBox();
            btnChooseDay = new Button();
            btnAssisstantList = new component.RJButton();
            btnSearchAssiID = new component.RJButton();
            tbAssissId = new TextBox();
            label15 = new Label();
            tbAsissPhone = new TextBox();
            label16 = new Label();
            tbAssissName = new TextBox();
            label17 = new Label();
            rtbNote = new RichTextBox();
            label19 = new Label();
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
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(80, 101, 122);
            btnExit.BackgroundColor = Color.FromArgb(80, 101, 122);
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.BorderColor = Color.PaleVioletRed;
            btnExit.BorderRadius = 5;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1147, 22);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(6, 0, 6, 0);
            btnExit.Size = new Size(113, 56);
            btnExit.TabIndex = 27;
            btnExit.Text = "Hủy";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
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
            btnAddAppointment.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAppointment.ForeColor = Color.Black;
            btnAddAppointment.Image = (Image)resources.GetObject("btnAddAppointment.Image");
            btnAddAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddAppointment.Location = new Point(959, 22);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Padding = new Padding(6, 0, 6, 0);
            btnAddAppointment.Size = new Size(162, 56);
            btnAddAppointment.TabIndex = 25;
            btnAddAppointment.Text = "Tạo mới";
            btnAddAppointment.TextAlign = ContentAlignment.MiddleRight;
            btnAddAppointment.TextColor = Color.Black;
            btnAddAppointment.UseVisualStyleBackColor = false;
            btnAddAppointment.Click += btnAddAppointment_Click;
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
            tbSignal.Location = new Point(190, 100);
            tbSignal.Name = "tbSignal";
            tbSignal.PlaceholderText = "Nhập triệu chứng";
            tbSignal.Size = new Size(1070, 39);
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
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 14F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Bệnh nhân chưa đến", "Bệnh nhân đã đến", "Cuộc hẹn kết thúc" });
            cbStatus.Location = new Point(190, 180);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(312, 39);
            cbStatus.TabIndex = 32;
            // 
            // HMSPicker
            // 
            HMSPicker.CustomFormat = "hh:mm:ss";
            HMSPicker.Font = new Font("Segoe UI", 14F);
            HMSPicker.Format = DateTimePickerFormat.Custom;
            HMSPicker.Location = new Point(926, 180);
            HMSPicker.Name = "HMSPicker";
            HMSPicker.ShowUpDown = true;
            HMSPicker.Size = new Size(185, 39);
            HMSPicker.TabIndex = 34;
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
            cbPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPatient.Font = new Font("Segoe UI", 14F);
            cbPatient.FormattingEnabled = true;
            cbPatient.Items.AddRange(new object[] { "Bệnh nhân cũ", "Bệnh nhân mới" });
            cbPatient.Location = new Point(190, 260);
            cbPatient.Name = "cbPatient";
            cbPatient.Size = new Size(251, 39);
            cbPatient.TabIndex = 36;
            cbPatient.SelectionChangeCommitted += cbPatient_SelectionChangeCommitted;
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
            tbPatientId.ReadOnly = true;
            tbPatientId.Size = new Size(252, 39);
            tbPatientId.TabIndex = 38;
            tbPatientId.TextChanged += tbPatientId_TextChanged;
            // 
            // btnSearchPatId
            // 
            btnSearchPatId.BackColor = Color.FromArgb(219, 175, 9);
            btnSearchPatId.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnSearchPatId.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchPatId.BorderColor = Color.PaleVioletRed;
            btnSearchPatId.BorderRadius = 5;
            btnSearchPatId.BorderSize = 0;
            btnSearchPatId.FlatAppearance.BorderSize = 0;
            btnSearchPatId.FlatStyle = FlatStyle.Flat;
            btnSearchPatId.ForeColor = Color.White;
            btnSearchPatId.Image = (Image)resources.GetObject("btnSearchPatId.Image");
            btnSearchPatId.Location = new Point(905, 255);
            btnSearchPatId.Name = "btnSearchPatId";
            btnSearchPatId.Size = new Size(55, 55);
            btnSearchPatId.TabIndex = 39;
            btnSearchPatId.TextColor = Color.White;
            btnSearchPatId.UseVisualStyleBackColor = false;
            btnSearchPatId.Click += btnSearchPatId_Click;
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
            btnPatientList.Location = new Point(986, 255);
            btnPatientList.Name = "btnPatientList";
            btnPatientList.Size = new Size(274, 51);
            btnPatientList.TabIndex = 40;
            btnPatientList.Text = "Danh sách bệnh nhân";
            btnPatientList.TextColor = Color.Black;
            btnPatientList.UseVisualStyleBackColor = false;
            btnPatientList.Click += btnPatientList_Click;
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
            tbPatientName.Location = new Point(190, 340);
            tbPatientName.Name = "tbPatientName";
            tbPatientName.PlaceholderText = "Tên bệnh nhân";
            tbPatientName.ReadOnly = true;
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
            rbMale.Enabled = false;
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
            rbFemale.Enabled = false;
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
            label8.Location = new Point(896, 339);
            label8.Name = "label8";
            label8.Size = new Size(64, 37);
            label8.TabIndex = 46;
            label8.Text = "SĐT";
            // 
            // tbPatientPhoneNumber
            // 
            tbPatientPhoneNumber.Font = new Font("Segoe UI", 14F);
            tbPatientPhoneNumber.Location = new Point(977, 340);
            tbPatientPhoneNumber.Name = "tbPatientPhoneNumber";
            tbPatientPhoneNumber.PlaceholderText = "Số điện thoại";
            tbPatientPhoneNumber.ReadOnly = true;
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
            tbPatientAddress.Location = new Point(190, 420);
            tbPatientAddress.Name = "tbPatientAddress";
            tbPatientAddress.PlaceholderText = "Địa chỉ";
            tbPatientAddress.ReadOnly = true;
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
            tbEmail.PlaceholderText = "Email";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(389, 39);
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
            // cbFaculty
            // 
            cbFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFaculty.Font = new Font("Segoe UI", 14F);
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Location = new Point(190, 500);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(251, 39);
            cbFaculty.TabIndex = 53;
            cbFaculty.SelectedIndexChanged += cbFaculty_SelectedIndexChanged;
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
            tbDentistId.ReadOnly = true;
            tbDentistId.Size = new Size(306, 39);
            tbDentistId.TabIndex = 55;
            tbDentistId.TextChanged += tbDentistId_TextChanged;
            // 
            // btnSearchDenId
            // 
            btnSearchDenId.BackColor = Color.FromArgb(219, 175, 9);
            btnSearchDenId.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnSearchDenId.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchDenId.BorderColor = Color.PaleVioletRed;
            btnSearchDenId.BorderRadius = 5;
            btnSearchDenId.BorderSize = 0;
            btnSearchDenId.FlatAppearance.BorderSize = 0;
            btnSearchDenId.FlatStyle = FlatStyle.Flat;
            btnSearchDenId.ForeColor = Color.White;
            btnSearchDenId.Image = (Image)resources.GetObject("btnSearchDenId.Image");
            btnSearchDenId.Location = new Point(905, 495);
            btnSearchDenId.Name = "btnSearchDenId";
            btnSearchDenId.Size = new Size(55, 55);
            btnSearchDenId.TabIndex = 56;
            btnSearchDenId.TextColor = Color.White;
            btnSearchDenId.UseVisualStyleBackColor = false;
            btnSearchDenId.Click += btnSearchDenId_Click;
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
            btnDentistList.Location = new Point(986, 493);
            btnDentistList.Name = "btnDentistList";
            btnDentistList.Size = new Size(274, 50);
            btnDentistList.TabIndex = 57;
            btnDentistList.Text = "Danh sách nha sĩ";
            btnDentistList.TextColor = Color.Black;
            btnDentistList.UseVisualStyleBackColor = false;
            btnDentistList.Click += btnDentistList_Click;
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
            tbDentistName.Location = new Point(190, 580);
            tbDentistName.Name = "tbDentistName";
            tbDentistName.PlaceholderText = "Tên nha sĩ";
            tbDentistName.ReadOnly = true;
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
            tbDentistPhoneNumber.PlaceholderText = "Số điện thoại";
            tbDentistPhoneNumber.ReadOnly = true;
            tbDentistPhoneNumber.Size = new Size(283, 39);
            tbDentistPhoneNumber.TabIndex = 61;
            // 
            // txtDay
            // 
            txtDay.Font = new Font("Segoe UI", 13.8F);
            txtDay.Location = new Point(508, 180);
            txtDay.Name = "txtDay";
            txtDay.ReadOnly = true;
            txtDay.Size = new Size(321, 38);
            txtDay.TabIndex = 62;
            // 
            // btnChooseDay
            // 
            btnChooseDay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChooseDay.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnChooseDay.Image = (Image)resources.GetObject("btnChooseDay.Image");
            btnChooseDay.ImageAlign = ContentAlignment.MiddleRight;
            btnChooseDay.Location = new Point(847, 177);
            btnChooseDay.Margin = new Padding(3, 4, 3, 4);
            btnChooseDay.Name = "btnChooseDay";
            btnChooseDay.Padding = new Padding(4, 0, 4, 0);
            btnChooseDay.RightToLeft = RightToLeft.No;
            btnChooseDay.Size = new Size(55, 48);
            btnChooseDay.TabIndex = 63;
            btnChooseDay.TextAlign = ContentAlignment.MiddleLeft;
            btnChooseDay.UseVisualStyleBackColor = true;
            btnChooseDay.Click += btnChooseDay_Click;
            // 
            // btnAssisstantList
            // 
            btnAssisstantList.BackColor = Color.FromArgb(18, 219, 78);
            btnAssisstantList.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnAssisstantList.BorderColor = Color.PaleVioletRed;
            btnAssisstantList.BorderRadius = 10;
            btnAssisstantList.BorderSize = 0;
            btnAssisstantList.FlatAppearance.BorderSize = 0;
            btnAssisstantList.FlatStyle = FlatStyle.Flat;
            btnAssisstantList.Font = new Font("Segoe UI", 14F);
            btnAssisstantList.ForeColor = Color.Black;
            btnAssisstantList.Location = new Point(638, 644);
            btnAssisstantList.Name = "btnAssisstantList";
            btnAssisstantList.Size = new Size(274, 50);
            btnAssisstantList.TabIndex = 67;
            btnAssisstantList.Text = "Danh sách phụ tá";
            btnAssisstantList.TextColor = Color.Black;
            btnAssisstantList.UseVisualStyleBackColor = false;
            // 
            // btnSearchAssiID
            // 
            btnSearchAssiID.BackColor = Color.FromArgb(219, 175, 9);
            btnSearchAssiID.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnSearchAssiID.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchAssiID.BorderColor = Color.PaleVioletRed;
            btnSearchAssiID.BorderRadius = 5;
            btnSearchAssiID.BorderSize = 0;
            btnSearchAssiID.FlatAppearance.BorderSize = 0;
            btnSearchAssiID.FlatStyle = FlatStyle.Flat;
            btnSearchAssiID.ForeColor = Color.White;
            btnSearchAssiID.Image = (Image)resources.GetObject("btnSearchAssiID.Image");
            btnSearchAssiID.Location = new Point(563, 644);
            btnSearchAssiID.Name = "btnSearchAssiID";
            btnSearchAssiID.Size = new Size(55, 55);
            btnSearchAssiID.TabIndex = 66;
            btnSearchAssiID.TextColor = Color.White;
            btnSearchAssiID.UseVisualStyleBackColor = false;
            btnSearchAssiID.Click += btnSearchAssiID_Click;
            // 
            // tbAssissId
            // 
            tbAssissId.Font = new Font("Segoe UI", 14F);
            tbAssissId.Location = new Point(190, 651);
            tbAssissId.Name = "tbAssissId";
            tbAssissId.PlaceholderText = "Mã phụ tá";
            tbAssissId.Size = new Size(345, 39);
            tbAssissId.TabIndex = 65;
            tbAssissId.TextChanged += tbAssissId_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 16F);
            label15.Location = new Point(24, 647);
            label15.Name = "label15";
            label15.Size = new Size(138, 37);
            label15.TabIndex = 64;
            label15.Text = "Mã phụ tá";
            // 
            // tbAsissPhone
            // 
            tbAsissPhone.Font = new Font("Segoe UI", 14F);
            tbAsissPhone.Location = new Point(638, 710);
            tbAsissPhone.Name = "tbAsissPhone";
            tbAsissPhone.PlaceholderText = "Số điện thoại";
            tbAsissPhone.ReadOnly = true;
            tbAsissPhone.Size = new Size(283, 39);
            tbAsissPhone.TabIndex = 71;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 16F);
            label16.Location = new Point(554, 712);
            label16.Name = "label16";
            label16.Size = new Size(64, 37);
            label16.TabIndex = 70;
            label16.Text = "SĐT";
            // 
            // tbAssissName
            // 
            tbAssissName.Font = new Font("Segoe UI", 14F);
            tbAssissName.Location = new Point(190, 712);
            tbAssissName.Name = "tbAssissName";
            tbAssissName.PlaceholderText = "Tên phụ tá";
            tbAssissName.ReadOnly = true;
            tbAssissName.Size = new Size(346, 39);
            tbAssissName.TabIndex = 69;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 16F);
            label17.Location = new Point(22, 712);
            label17.Name = "label17";
            label17.Size = new Size(133, 37);
            label17.TabIndex = 68;
            label17.Text = "Tên nha sĩ";
            // 
            // rtbNote
            // 
            rtbNote.Location = new Point(949, 617);
            rtbNote.Name = "rtbNote";
            rtbNote.Size = new Size(311, 136);
            rtbNote.TabIndex = 72;
            rtbNote.Text = "";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 16F);
            label19.Location = new Point(949, 565);
            label19.Name = "label19";
            label19.Size = new Size(107, 37);
            label19.TabIndex = 74;
            label19.Text = "Ghi chú";
            // 
            // AddAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1282, 767);
            ControlBox = false;
            Controls.Add(label19);
            Controls.Add(rtbNote);
            Controls.Add(tbAsissPhone);
            Controls.Add(label16);
            Controls.Add(tbAssissName);
            Controls.Add(label17);
            Controls.Add(btnAssisstantList);
            Controls.Add(btnSearchAssiID);
            Controls.Add(tbAssissId);
            Controls.Add(label15);
            Controls.Add(btnChooseDay);
            Controls.Add(txtDay);
            Controls.Add(tbDentistPhoneNumber);
            Controls.Add(label14);
            Controls.Add(tbDentistName);
            Controls.Add(label13);
            Controls.Add(btnDentistList);
            Controls.Add(btnSearchDenId);
            Controls.Add(tbDentistId);
            Controls.Add(label12);
            Controls.Add(cbFaculty);
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
            Controls.Add(btnSearchPatId);
            Controls.Add(tbPatientId);
            Controls.Add(label4);
            Controls.Add(cbPatient);
            Controls.Add(label3);
            Controls.Add(HMSPicker);
            Controls.Add(cbStatus);
            Controls.Add(label2);
            Controls.Add(tbSignal);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnAddAppointment);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAppointmentForm";
            Text = "AddAppointmentForm";
            Load += AddAppointmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private component.RJButton btnExit;
        private component.RJButton btnAddAppointment;
        private Label label1;
        private TextBox tbSignal;
        private Label label2;
        private ComboBox cbStatus;
        private DateTimePicker HMSPicker;
        private Label label3;
        private ComboBox cbPatient;
        private Label label4;
        private TextBox tbPatientId;
        private component.RJButton btnSearchPatId;
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
        private ComboBox cbFaculty;
        private Label label12;
        private TextBox tbDentistId;
        private component.RJButton btnSearchDenId;
        private component.RJButton btnDentistList;
        private Label label13;
        private TextBox tbDentistName;
        private Label label14;
        private TextBox tbDentistPhoneNumber;
        private TextBox txtDay;
        private Button btnChooseDay;
        private component.RJButton btnAssisstantList;
        private component.RJButton btnSearchAssiID;
        private TextBox tbAssissId;
        private Label label15;
        private TextBox tbAsissPhone;
        private Label label16;
        private TextBox tbAssissName;
        private Label label17;
        private RichTextBox rtbNote;
        private Label label19;
    }
}