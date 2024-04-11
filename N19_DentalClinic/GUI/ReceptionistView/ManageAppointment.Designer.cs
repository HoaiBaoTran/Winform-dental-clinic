namespace N19_DentalClinic.GUI.ReceptionistView
{
    partial class ManageAppointment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView = new DataGridView();
            appointmentDateCol = new DataGridViewTextBoxColumn();
            appointmentTimeCol = new DataGridViewTextBoxColumn();
            patientNameCol = new DataGridViewTextBoxColumn();
            dentistNameCol = new DataGridViewTextBoxColumn();
            statusCol = new DataGridViewTextBoxColumn();
            noteCol = new DataGridViewTextBoxColumn();
            roundPictureBox2 = new component.RoundPictureBox();
            btnAddAppointment = new component.RJButton();
            dateTimePicker = new DateTimePicker();
            label7 = new Label();
            lbDate = new Label();
            rjButton1 = new component.RJButton();
            btnLeftArrow = new component.RJButton();
            label6 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
            SuspendLayout();
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
            dataGridView.Location = new Point(50, 203);
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
            dataGridView.Size = new Size(1202, 615);
            dataGridView.TabIndex = 21;
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
            // roundPictureBox2
            // 
            roundPictureBox2.BackColor = Color.FromArgb(56, 92, 67);
            roundPictureBox2.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(1082, 27);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(35, 33);
            roundPictureBox2.TabIndex = 20;
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
            btnAddAppointment.Location = new Point(1071, 19);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(181, 50);
            btnAddAppointment.TabIndex = 19;
            btnAddAppointment.Text = "Thêm lịch hẹn";
            btnAddAppointment.TextAlign = ContentAlignment.MiddleRight;
            btnAddAppointment.TextColor = Color.Black;
            btnAddAppointment.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(1071, 82);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(181, 39);
            dateTimePicker.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(844, 88);
            label7.Name = "label7";
            label7.Size = new Size(189, 32);
            label7.TabIndex = 17;
            label7.Text = "Chọn thời gian:";
            // 
            // lbDate
            // 
            lbDate.BackColor = Color.FromArgb(9, 24, 219);
            lbDate.ForeColor = Color.White;
            lbDate.Location = new Point(208, 80);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(125, 55);
            lbDate.TabIndex = 16;
            lbDate.Text = "Hôm nay";
            lbDate.TextAlign = ContentAlignment.MiddleCenter;
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
            rjButton1.Location = new Point(117, 80);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(58, 55);
            rjButton1.TabIndex = 15;
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
            btnLeftArrow.Location = new Point(41, 80);
            btnLeftArrow.Name = "btnLeftArrow";
            btnLeftArrow.Size = new Size(58, 55);
            btnLeftArrow.TabIndex = 14;
            btnLeftArrow.TextColor = Color.White;
            btnLeftArrow.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 19);
            label6.Name = "label6";
            label6.Size = new Size(134, 41);
            label6.TabIndex = 13;
            label6.Text = "Lịch hẹn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 12;
            // 
            // ManageAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 753);
            Controls.Add(dataGridView);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnAddAppointment);
            Controls.Add(dateTimePicker);
            Controls.Add(label7);
            Controls.Add(lbDate);
            Controls.Add(rjButton1);
            Controls.Add(btnLeftArrow);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageAppointment";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn appointmentDateCol;
        private DataGridViewTextBoxColumn appointmentTimeCol;
        private DataGridViewTextBoxColumn patientNameCol;
        private DataGridViewTextBoxColumn dentistNameCol;
        private DataGridViewTextBoxColumn statusCol;
        private DataGridViewTextBoxColumn noteCol;
        private component.RoundPictureBox roundPictureBox2;
        private component.RJButton btnAddAppointment;
        private DateTimePicker dateTimePicker;
        private Label label7;
        private Label lbDate;
        private component.RJButton rjButton1;
        private component.RJButton btnLeftArrow;
        private Label label6;
        private Label label1;
    }
}
