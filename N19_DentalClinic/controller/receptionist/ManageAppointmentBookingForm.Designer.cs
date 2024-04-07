namespace N19_DentalClinic.controller.receptionist
{
    partial class ManageAppointmentBookingForm
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
            label1 = new Label();
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
            btnLeftArrow = new component.RJButton();
            rjButton1 = new component.RJButton();
            lbDate = new Label();
            label7 = new Label();
            dateTimePicker = new DateTimePicker();
            btnAddAppointment = new component.RJButton();
            roundPictureBox2 = new component.RoundPictureBox();
            dataGridView = new DataGridView();
            appointmentDateCol = new DataGridViewTextBoxColumn();
            appointmentTimeCol = new DataGridViewTextBoxColumn();
            patientNameCol = new DataGridViewTextBoxColumn();
            dentistNameCol = new DataGridViewTextBoxColumn();
            statusCol = new DataGridViewTextBoxColumn();
            noteCol = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(551, 170);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
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
            panel1.Size = new Size(250, 1112);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            btnBookAppointment.BackColor = Color.FromArgb(219, 175, 9);
            btnBookAppointment.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnBookAppointment.BorderColor = Color.PaleVioletRed;
            btnBookAppointment.BorderRadius = 10;
            btnBookAppointment.BorderSize = 0;
            btnBookAppointment.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnBookAppointment.FlatAppearance.BorderSize = 0;
            btnBookAppointment.FlatStyle = FlatStyle.Flat;
            btnBookAppointment.Font = new Font("Segoe UI", 12F);
            btnBookAppointment.ForeColor = Color.Black;
            btnBookAppointment.Location = new Point(14, 380);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new Size(218, 66);
            btnBookAppointment.TabIndex = 9;
            btnBookAppointment.Text = "Đặt lịch hẹn";
            btnBookAppointment.TextColor = Color.Black;
            btnBookAppointment.UseVisualStyleBackColor = false;
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
            panel2.TabIndex = 2;
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
            label6.Location = new Point(283, 153);
            label6.Name = "label6";
            label6.Size = new Size(134, 41);
            label6.TabIndex = 3;
            label6.Text = "Lịch hẹn";
            // 
            // btnLeftArrow
            // 
            btnLeftArrow.BackColor = Color.FromArgb(18, 219, 78);
            btnLeftArrow.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnLeftArrow.BackgroundImage = Properties.Resources.left_arrow_icon;
            btnLeftArrow.BackgroundImageLayout = ImageLayout.Zoom;
            btnLeftArrow.BorderColor = Color.Empty;
            btnLeftArrow.BorderRadius = 30;
            btnLeftArrow.BorderSize = 0;
            btnLeftArrow.FlatAppearance.BorderSize = 0;
            btnLeftArrow.FlatStyle = FlatStyle.Flat;
            btnLeftArrow.ForeColor = Color.White;
            btnLeftArrow.Location = new Point(283, 214);
            btnLeftArrow.Name = "btnLeftArrow";
            btnLeftArrow.Size = new Size(58, 55);
            btnLeftArrow.TabIndex = 4;
            btnLeftArrow.TextColor = Color.White;
            btnLeftArrow.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(18, 219, 78);
            rjButton1.BackgroundColor = Color.FromArgb(18, 219, 78);
            rjButton1.BackgroundImage = Properties.Resources.right_arrow_icon;
            rjButton1.BackgroundImageLayout = ImageLayout.Zoom;
            rjButton1.BorderColor = Color.Empty;
            rjButton1.BorderRadius = 30;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(359, 214);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(58, 55);
            rjButton1.TabIndex = 5;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // lbDate
            // 
            lbDate.BackColor = Color.FromArgb(9, 24, 219);
            lbDate.ForeColor = Color.White;
            lbDate.Location = new Point(450, 214);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(125, 55);
            lbDate.TabIndex = 6;
            lbDate.Text = "Hôm nay";
            lbDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(1209, 222);
            label7.Name = "label7";
            label7.Size = new Size(189, 32);
            label7.TabIndex = 7;
            label7.Text = "Chọn thời gian:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(1436, 216);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(181, 39);
            dateTimePicker.TabIndex = 8;
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
            btnAddAppointment.Location = new Point(1436, 153);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(181, 50);
            btnAddAppointment.TabIndex = 9;
            btnAddAppointment.Text = "Thêm lịch hẹn";
            btnAddAppointment.TextAlign = ContentAlignment.MiddleRight;
            btnAddAppointment.TextColor = Color.Black;
            btnAddAppointment.UseVisualStyleBackColor = false;
            btnAddAppointment.Click += btnAddAppointment_Click;
            // 
            // roundPictureBox2
            // 
            roundPictureBox2.BackColor = Color.FromArgb(56, 92, 67);
            roundPictureBox2.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(1447, 161);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(35, 33);
            roundPictureBox2.TabIndex = 10;
            roundPictureBox2.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { appointmentDateCol, appointmentTimeCol, patientNameCol, dentistNameCol, statusCol, noteCol });
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
            dataGridView.Location = new Point(320, 338);
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
            dataGridView.Size = new Size(1325, 615);
            dataGridView.TabIndex = 11;
            // 
            // appointmentDateCol
            // 
            appointmentDateCol.HeaderText = "Ngày hẹn";
            appointmentDateCol.MinimumWidth = 6;
            appointmentDateCol.Name = "appointmentDateCol";
            appointmentDateCol.Width = 125;
            // 
            // appointmentTimeCol
            // 
            appointmentTimeCol.HeaderText = "Giờ hẹn";
            appointmentTimeCol.MinimumWidth = 6;
            appointmentTimeCol.Name = "appointmentTimeCol";
            appointmentTimeCol.Width = 125;
            // 
            // patientNameCol
            // 
            patientNameCol.HeaderText = "Tên bệnh nhân";
            patientNameCol.MinimumWidth = 6;
            patientNameCol.Name = "patientNameCol";
            patientNameCol.Width = 230;
            // 
            // dentistNameCol
            // 
            dentistNameCol.HeaderText = "Tên bác sĩ";
            dentistNameCol.MinimumWidth = 6;
            dentistNameCol.Name = "dentistNameCol";
            dentistNameCol.Width = 230;
            // 
            // statusCol
            // 
            statusCol.HeaderText = "Trạng thái";
            statusCol.MinimumWidth = 6;
            statusCol.Name = "statusCol";
            statusCol.Width = 225;
            // 
            // noteCol
            // 
            noteCol.HeaderText = "Ghi chú";
            noteCol.MinimumWidth = 6;
            noteCol.Name = "noteCol";
            noteCol.Width = 125;
            // 
            // ManageAppointmentBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1682, 953);
            Controls.Add(dataGridView);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnAddAppointment);
            Controls.Add(dateTimePicker);
            Controls.Add(label7);
            Controls.Add(lbDate);
            Controls.Add(rjButton1);
            Controls.Add(btnLeftArrow);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ManageAppointmentBookingForm";
            Text = "ManageAppointmentBookingForm";
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

        private Label label1;
        private Panel panel1;
        private Label lbName;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbRole;
        private Label lbRoleText;
        private Label label5;
        private component.RoundPictureBox roundPictureBox1;
        private component.RJButton btnBookAppointment;
        private component.RJButton btnCreateBill;
        private component.RJButton btnManageDentist;
        private component.RJButton btnPatientProfile;
        private Label label6;
        private component.RJButton btnLeftArrow;
        private component.RJButton rjButton1;
        private Label lbDate;
        private Label label7;
        private DateTimePicker dateTimePicker;
        private component.RJButton btnAddAppointment;
        private component.RoundPictureBox roundPictureBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn appointmentDateCol;
        private DataGridViewTextBoxColumn appointmentTimeCol;
        private DataGridViewTextBoxColumn patientNameCol;
        private DataGridViewTextBoxColumn dentistNameCol;
        private DataGridViewTextBoxColumn statusCol;
        private DataGridViewTextBoxColumn noteCol;
        private component.RJButton btnExit;
    }


}