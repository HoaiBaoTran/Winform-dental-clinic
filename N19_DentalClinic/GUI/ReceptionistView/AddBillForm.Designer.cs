namespace N19_DentalClinic.GUI.ReceptionistView
{
    partial class AddBillForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            medicineNameCol = new DataGridViewTextBoxColumn();
            totalPriceCol = new DataGridViewTextBoxColumn();
            quantityMedicineCol = new DataGridViewTextBoxColumn();
            unitMedicineCol = new DataGridViewTextBoxColumn();
            label13 = new Label();
            dataGridViewService = new DataGridView();
            serviceNameCol = new DataGridViewTextBoxColumn();
            totalPriceServiceCol = new DataGridViewTextBoxColumn();
            quantityServiceCol = new DataGridViewTextBoxColumn();
            unitServiceCol = new DataGridViewTextBoxColumn();
            label12 = new Label();
            roundPictureBox4 = new component.RoundPictureBox();
            btnBack = new component.RJButton();
            roundPictureBox5 = new component.RoundPictureBox();
            btnAddAppointment = new component.RJButton();
            tbTotalPrice = new TextBox();
            label11 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            timePicker = new DateTimePicker();
            label8 = new Label();
            dateTimePicker = new DateTimePicker();
            label7 = new Label();
            tbBillId = new TextBox();
            label1 = new Label();
            roundPictureBox3 = new component.RoundPictureBox();
            btnReload = new component.RJButton();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { medicineNameCol, totalPriceCol, quantityMedicineCol, unitMedicineCol });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(733, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(602, 414);
            dataGridView1.TabIndex = 119;
            // 
            // medicineNameCol
            // 
            medicineNameCol.HeaderText = "Tên thuốc";
            medicineNameCol.MinimumWidth = 6;
            medicineNameCol.Name = "medicineNameCol";
            medicineNameCol.Width = 150;
            // 
            // totalPriceCol
            // 
            totalPriceCol.HeaderText = "Giá tiền";
            totalPriceCol.MinimumWidth = 6;
            totalPriceCol.Name = "totalPriceCol";
            totalPriceCol.Width = 125;
            // 
            // quantityMedicineCol
            // 
            quantityMedicineCol.HeaderText = "Số lượng";
            quantityMedicineCol.MinimumWidth = 6;
            quantityMedicineCol.Name = "quantityMedicineCol";
            quantityMedicineCol.Width = 150;
            // 
            // unitMedicineCol
            // 
            unitMedicineCol.HeaderText = "Đơn vị tính";
            unitMedicineCol.MinimumWidth = 6;
            unitMedicineCol.Name = "unitMedicineCol";
            unitMedicineCol.Width = 125;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label13.Location = new Point(732, 215);
            label13.Name = "label13";
            label13.Size = new Size(150, 37);
            label13.TabIndex = 118;
            label13.Text = "Đơn thuốc";
            // 
            // dataGridViewService
            // 
            dataGridViewService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewService.BackgroundColor = Color.White;
            dataGridViewService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewService.Columns.AddRange(new DataGridViewColumn[] { serviceNameCol, totalPriceServiceCol, quantityServiceCol, unitServiceCol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewService.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewService.GridColor = Color.White;
            dataGridViewService.Location = new Point(12, 254);
            dataGridViewService.Name = "dataGridViewService";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewService.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewService.RowHeadersWidth = 51;
            dataGridViewService.Size = new Size(602, 414);
            dataGridViewService.TabIndex = 97;
            // 
            // serviceNameCol
            // 
            serviceNameCol.HeaderText = "Tên dịch vụ";
            serviceNameCol.MinimumWidth = 6;
            serviceNameCol.Name = "serviceNameCol";
            serviceNameCol.Width = 150;
            // 
            // totalPriceServiceCol
            // 
            totalPriceServiceCol.HeaderText = "Giá tiền";
            totalPriceServiceCol.MinimumWidth = 6;
            totalPriceServiceCol.Name = "totalPriceServiceCol";
            totalPriceServiceCol.Width = 125;
            // 
            // quantityServiceCol
            // 
            quantityServiceCol.HeaderText = "Số lượng";
            quantityServiceCol.MinimumWidth = 6;
            quantityServiceCol.Name = "quantityServiceCol";
            quantityServiceCol.Width = 150;
            // 
            // unitServiceCol
            // 
            unitServiceCol.HeaderText = "Đơn vị tính";
            unitServiceCol.MinimumWidth = 6;
            unitServiceCol.Name = "unitServiceCol";
            unitServiceCol.Width = 125;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label12.Location = new Point(12, 203);
            label12.Name = "label12";
            label12.Size = new Size(112, 37);
            label12.TabIndex = 117;
            label12.Text = "Dịch vụ";
            // 
            // roundPictureBox4
            // 
            roundPictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            roundPictureBox4.BackColor = Color.White;
            roundPictureBox4.BackgroundImage = Properties.Resources.back_icon;
            roundPictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox4.Location = new Point(1241, 694);
            roundPictureBox4.Name = "roundPictureBox4";
            roundPictureBox4.Size = new Size(39, 41);
            roundPictureBox4.TabIndex = 116;
            roundPictureBox4.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
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
            btnBack.Location = new Point(1231, 685);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 56);
            btnBack.TabIndex = 115;
            btnBack.Text = "Hủy";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextColor = Color.White;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // roundPictureBox5
            // 
            roundPictureBox5.Anchor = AnchorStyles.Right;
            roundPictureBox5.BackColor = Color.White;
            roundPictureBox5.BackgroundImage = Properties.Resources.save_icon;
            roundPictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox5.Location = new Point(1113, 694);
            roundPictureBox5.Name = "roundPictureBox5";
            roundPictureBox5.Size = new Size(39, 41);
            roundPictureBox5.TabIndex = 114;
            roundPictureBox5.TabStop = false;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Anchor = AnchorStyles.Right;
            btnAddAppointment.BackColor = Color.FromArgb(219, 175, 9);
            btnAddAppointment.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnAddAppointment.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddAppointment.BorderColor = Color.PaleVioletRed;
            btnAddAppointment.BorderRadius = 5;
            btnAddAppointment.BorderSize = 0;
            btnAddAppointment.FlatAppearance.BorderSize = 0;
            btnAddAppointment.FlatStyle = FlatStyle.Flat;
            btnAddAppointment.Font = new Font("Segoe UI", 11F);
            btnAddAppointment.ForeColor = Color.Black;
            btnAddAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddAppointment.Location = new Point(1106, 685);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(96, 56);
            btnAddAppointment.TabIndex = 113;
            btnAddAppointment.Text = "Lưu";
            btnAddAppointment.TextAlign = ContentAlignment.MiddleRight;
            btnAddAppointment.TextColor = Color.Black;
            btnAddAppointment.UseVisualStyleBackColor = false;
            // 
            // tbTotalPrice
            // 
            tbTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbTotalPrice.Font = new Font("Segoe UI", 16F);
            tbTotalPrice.Location = new Point(212, 704);
            tbTotalPrice.Name = "tbTotalPrice";
            tbTotalPrice.PlaceholderText = "Tổng tiền";
            tbTotalPrice.Size = new Size(402, 43);
            tbTotalPrice.TabIndex = 112;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label11.Location = new Point(12, 701);
            label11.Name = "label11";
            label11.Size = new Size(174, 46);
            label11.TabIndex = 111;
            label11.Text = "Tổng tiền";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(1032, 169);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nhập tên bệnh nhân";
            textBox2.Size = new Size(301, 39);
            textBox2.TabIndex = 110;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(732, 169);
            label10.Name = "label10";
            label10.Size = new Size(175, 32);
            label10.TabIndex = 109;
            label10.Text = "Tên bệnh nhân";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(1032, 89);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập mã bệnh nhân";
            textBox1.Size = new Size(301, 39);
            textBox1.TabIndex = 108;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(732, 89);
            label9.Name = "label9";
            label9.Size = new Size(171, 32);
            label9.TabIndex = 107;
            label9.Text = "Mã bệnh nhân";
            // 
            // timePicker
            // 
            timePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            timePicker.Font = new Font("Segoe UI", 14F);
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(1032, 9);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(245, 39);
            timePicker.TabIndex = 106;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(732, 9);
            label8.Name = "label8";
            label8.Size = new Size(238, 32);
            label8.TabIndex = 105;
            label8.Text = "Thời gian thanh toán";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(212, 89);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(232, 39);
            dateTimePicker.TabIndex = 104;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(12, 89);
            label7.Name = "label7";
            label7.Size = new Size(109, 32);
            label7.TabIndex = 103;
            label7.Text = "Ngày lập";
            // 
            // tbBillId
            // 
            tbBillId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbBillId.Font = new Font("Segoe UI", 14F);
            tbBillId.Location = new Point(212, 9);
            tbBillId.Name = "tbBillId";
            tbBillId.PlaceholderText = "Nhập mã hóa đơn";
            tbBillId.Size = new Size(378, 39);
            tbBillId.TabIndex = 102;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 101;
            label1.Text = "Mã hóa đơn";
            // 
            // roundPictureBox3
            // 
            roundPictureBox3.BackColor = Color.FromArgb(219, 175, 9);
            roundPictureBox3.BackgroundImage = Properties.Resources.reload_icon;
            roundPictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox3.Location = new Point(1181, -76);
            roundPictureBox3.Name = "roundPictureBox3";
            roundPictureBox3.Size = new Size(39, 41);
            roundPictureBox3.TabIndex = 100;
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
            btnReload.Location = new Point(1173, -82);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(117, 56);
            btnReload.TabIndex = 99;
            btnReload.Text = "Tải lại";
            btnReload.TextAlign = ContentAlignment.MiddleRight;
            btnReload.TextColor = Color.White;
            btnReload.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(-47, -74);
            label6.Name = "label6";
            label6.Size = new Size(194, 41);
            label6.TabIndex = 98;
            label6.Text = "Tạo hóa đơn";
            // 
            // AddBillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1357, 753);
            Controls.Add(dataGridView1);
            Controls.Add(label13);
            Controls.Add(dataGridViewService);
            Controls.Add(label12);
            Controls.Add(roundPictureBox4);
            Controls.Add(btnBack);
            Controls.Add(roundPictureBox5);
            Controls.Add(btnAddAppointment);
            Controls.Add(tbTotalPrice);
            Controls.Add(label11);
            Controls.Add(textBox2);
            Controls.Add(label10);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(timePicker);
            Controls.Add(label8);
            Controls.Add(dateTimePicker);
            Controls.Add(label7);
            Controls.Add(tbBillId);
            Controls.Add(label1);
            Controls.Add(roundPictureBox3);
            Controls.Add(btnReload);
            Controls.Add(label6);
            Name = "AddBillForm";
            Text = "AddNewBill";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewService).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn medicineNameCol;
        private DataGridViewTextBoxColumn totalPriceCol;
        private DataGridViewTextBoxColumn quantityMedicineCol;
        private DataGridViewTextBoxColumn unitMedicineCol;
        private Label label13;
        private DataGridView dataGridViewService;
        private DataGridViewTextBoxColumn serviceNameCol;
        private DataGridViewTextBoxColumn totalPriceServiceCol;
        private DataGridViewTextBoxColumn quantityServiceCol;
        private DataGridViewTextBoxColumn unitServiceCol;
        private Label label12;
        private component.RoundPictureBox roundPictureBox4;
        private component.RJButton btnBack;
        private component.RoundPictureBox roundPictureBox5;
        private component.RJButton btnAddAppointment;
        private TextBox tbTotalPrice;
        private Label label11;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox1;
        private Label label9;
        private DateTimePicker timePicker;
        private Label label8;
        private DateTimePicker dateTimePicker;
        private Label label7;
        private TextBox tbBillId;
        private Label label1;
        private component.RoundPictureBox roundPictureBox3;
        private component.RJButton btnReload;
        private Label label6;
    }
}