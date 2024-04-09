namespace N19_DentalClinic.controller.receptionist
{
    partial class PatientHistoryForm
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
            dataGridView = new DataGridView();
            btnExit = new component.RJButton();
            label6 = new Label();
            label2 = new Label();
            panel2 = new Panel();
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
            tbSearchPatientId = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            rjButton1 = new component.RJButton();
            btnLeftArrow = new component.RJButton();
            btnDate = new component.RJButton();
            label8 = new Label();
            cbType = new ComboBox();
            label9 = new Label();
            dateTimePicker = new DateTimePicker();
            timeAppointmentCol = new DataGridViewTextBoxColumn();
            receptionistNameCol = new DataGridViewTextBoxColumn();
            assisstanceCol = new DataGridViewTextBoxColumn();
            dentistNameCol = new DataGridViewTextBoxColumn();
            patientSignalCol = new DataGridViewTextBoxColumn();
            patientStatusCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { timeAppointmentCol, receptionistNameCol, assisstanceCol, dentistNameCol, patientSignalCol, patientStatusCol });
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
            dataGridView.Location = new Point(253, 356);
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
            dataGridView.Size = new Size(1414, 544);
            dataGridView.TabIndex = 20;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(277, 126);
            label6.Name = "label6";
            label6.Size = new Size(201, 41);
            label6.TabIndex = 17;
            label6.Text = "Lịch sử khám";
            label6.TextAlign = ContentAlignment.MiddleLeft;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 56, 134);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(231, -24);
            panel2.Name = "panel2";
            panel2.Size = new Size(1468, 125);
            panel2.TabIndex = 16;
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
            // tbSearchPatientId
            // 
            tbSearchPatientId.Font = new Font("Segoe UI", 12F);
            tbSearchPatientId.Location = new Point(471, 216);
            tbSearchPatientId.Name = "tbSearchPatientId";
            tbSearchPatientId.PlaceholderText = "Mã bệnh nhân";
            tbSearchPatientId.Size = new Size(293, 34);
            tbSearchPatientId.TabIndex = 21;
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
            panel1.Location = new Point(-17, -24);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1000);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(277, 218);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 22;
            label1.Text = "Mã bệnh nhân";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(1017, 218);
            label7.Name = "label7";
            label7.Size = new Size(175, 32);
            label7.TabIndex = 23;
            label7.Text = "Tên bệnh nhân";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(1220, 218);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tên bệnh nhân";
            textBox1.Size = new Size(293, 34);
            textBox1.TabIndex = 24;
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
            rjButton1.Location = new Point(351, 269);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(58, 55);
            rjButton1.TabIndex = 26;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
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
            btnLeftArrow.Location = new Point(277, 268);
            btnLeftArrow.Name = "btnLeftArrow";
            btnLeftArrow.Size = new Size(58, 55);
            btnLeftArrow.TabIndex = 25;
            btnLeftArrow.TextColor = Color.White;
            btnLeftArrow.UseVisualStyleBackColor = false;
            // 
            // btnDate
            // 
            btnDate.BackColor = Color.FromArgb(18, 219, 78);
            btnDate.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnDate.BackgroundImageLayout = ImageLayout.Zoom;
            btnDate.BorderColor = Color.PaleVioletRed;
            btnDate.BorderRadius = 15;
            btnDate.BorderSize = 0;
            btnDate.FlatAppearance.BorderSize = 0;
            btnDate.FlatStyle = FlatStyle.Flat;
            btnDate.Font = new Font("Segoe UI", 11F);
            btnDate.ForeColor = Color.Black;
            btnDate.ImageAlign = ContentAlignment.MiddleLeft;
            btnDate.Location = new Point(450, 269);
            btnDate.Name = "btnDate";
            btnDate.Size = new Size(135, 56);
            btnDate.TabIndex = 27;
            btnDate.Text = "Hôm nay";
            btnDate.TextColor = Color.Black;
            btnDate.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.Location = new Point(653, 285);
            label8.Name = "label8";
            label8.Size = new Size(116, 32);
            label8.TabIndex = 28;
            label8.Text = "Xếp theo";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbType
            // 
            cbType.BackColor = Color.FromArgb(18, 219, 78);
            cbType.Font = new Font("Segoe UI", 14F);
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Ngày", "Tuần", "Tháng", "Quý", "Năm" });
            cbType.Location = new Point(775, 283);
            cbType.Name = "cbType";
            cbType.Size = new Size(204, 39);
            cbType.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.Location = new Point(1017, 285);
            label9.Name = "label9";
            label9.Size = new Size(182, 32);
            label9.TabIndex = 30;
            label9.Text = "Chọn thời gian";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(1220, 284);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(174, 39);
            dateTimePicker.TabIndex = 59;
            // 
            // timeAppointmentCol
            // 
            timeAppointmentCol.HeaderText = "Giờ hẹn";
            timeAppointmentCol.MinimumWidth = 6;
            timeAppointmentCol.Name = "timeAppointmentCol";
            timeAppointmentCol.Width = 125;
            // 
            // receptionistNameCol
            // 
            receptionistNameCol.HeaderText = "Lễ tân";
            receptionistNameCol.MinimumWidth = 6;
            receptionistNameCol.Name = "receptionistNameCol";
            receptionistNameCol.Width = 230;
            // 
            // assisstanceCol
            // 
            assisstanceCol.HeaderText = "Phụ tá";
            assisstanceCol.MinimumWidth = 6;
            assisstanceCol.Name = "assisstanceCol";
            assisstanceCol.Width = 230;
            // 
            // dentistNameCol
            // 
            dentistNameCol.HeaderText = "Nha sĩ chăm sóc";
            dentistNameCol.MinimumWidth = 6;
            dentistNameCol.Name = "dentistNameCol";
            dentistNameCol.Width = 230;
            // 
            // patientSignalCol
            // 
            patientSignalCol.HeaderText = "Triệu chứng bệnh nhân";
            patientSignalCol.MinimumWidth = 6;
            patientSignalCol.Name = "patientSignalCol";
            patientSignalCol.Width = 280;
            // 
            // patientStatusCol
            // 
            patientStatusCol.HeaderText = "Trạng thái";
            patientStatusCol.MinimumWidth = 6;
            patientStatusCol.Name = "patientStatusCol";
            patientStatusCol.Width = 250;
            // 
            // PatientHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1682, 953);
            Controls.Add(dateTimePicker);
            Controls.Add(label9);
            Controls.Add(cbType);
            Controls.Add(label8);
            Controls.Add(btnDate);
            Controls.Add(rjButton1);
            Controls.Add(btnLeftArrow);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(tbSearchPatientId);
            Controls.Add(panel1);
            Name = "PatientHistory";
            Text = "PatientHistory";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView;
        private component.RJButton btnExit;
        private Label label6;
        private Label label2;
        private Panel panel2;
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
        private TextBox tbSearchPatientId;
        private Panel panel1;
        private Label label1;
        private Label label7;
        private TextBox textBox1;
        private component.RJButton rjButton1;
        private component.RJButton btnLeftArrow;
        private component.RJButton btnDate;
        private Label label8;
        private ComboBox cbType;
        private Label label9;
        private DataGridViewTextBoxColumn timeAppointmentCol;
        private DataGridViewTextBoxColumn receptionistNameCol;
        private DataGridViewTextBoxColumn assisstanceCol;
        private DataGridViewTextBoxColumn dentistNameCol;
        private DataGridViewTextBoxColumn patientSignalCol;
        private DataGridViewTextBoxColumn patientStatusCol;
        private DateTimePicker dateTimePicker;
    }
}