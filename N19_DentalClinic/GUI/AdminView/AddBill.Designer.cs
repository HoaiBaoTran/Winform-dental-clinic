namespace N19_DentalClinic.GUI.AdminView
{
    partial class AddBill
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
            datePicker = new DateTimePicker();
            tbBillId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            roundPictureBox3 = new component.RoundPictureBox();
            btnExit = new component.RJButton();
            roundPictureBox2 = new component.RoundPictureBox();
            btnAddMaterial = new component.RJButton();
            label6 = new Label();
            timePicker = new DateTimePicker();
            label10 = new Label();
            cbPatientName = new ComboBox();
            cbPatientId = new ComboBox();
            dataService = new DataGridView();
            label2 = new Label();
            dataPrescription = new DataGridView();
            label7 = new Label();
            roundPictureBox1 = new component.RoundPictureBox();
            btnAddService = new component.RJButton();
            roundPictureBox4 = new component.RoundPictureBox();
            btnAddMedicine = new component.RJButton();
            label8 = new Label();
            lbPrice = new Label();
            roundPictureBox5 = new component.RoundPictureBox();
            btnCreatePrescription = new component.RJButton();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataPrescription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox5).BeginInit();
            SuspendLayout();
            // 
            // datePicker
            // 
            datePicker.CustomFormat = "dd/MM/yyyy";
            datePicker.Font = new Font("Segoe UI", 14F);
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(1402, 80);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(238, 39);
            datePicker.TabIndex = 103;
            // 
            // tbBillId
            // 
            tbBillId.Font = new Font("Segoe UI", 14F);
            tbBillId.Location = new Point(229, 80);
            tbBillId.Name = "tbBillId";
            tbBillId.Size = new Size(420, 39);
            tbBillId.TabIndex = 99;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(34, 152);
            label5.Name = "label5";
            label5.Size = new Size(188, 37);
            label5.TabIndex = 98;
            label5.Text = "Mã bệnh nhân";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(34, 227);
            label4.Name = "label4";
            label4.Size = new Size(190, 37);
            label4.TabIndex = 97;
            label4.Text = "Tên bệnh nhân";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(1132, 77);
            label3.Name = "label3";
            label3.Size = new Size(124, 37);
            label3.TabIndex = 96;
            label3.Text = "Ngày lập";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(34, 78);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 94;
            label1.Text = "Mã hóa đơn";
            // 
            // roundPictureBox3
            // 
            roundPictureBox3.Anchor = AnchorStyles.Right;
            roundPictureBox3.BackColor = Color.White;
            roundPictureBox3.BackgroundImage = Properties.Resources.back_icon;
            roundPictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox3.Location = new Point(1772, 887);
            roundPictureBox3.Name = "roundPictureBox3";
            roundPictureBox3.Size = new Size(39, 45);
            roundPictureBox3.TabIndex = 93;
            roundPictureBox3.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Right;
            btnExit.BackColor = Color.DarkGray;
            btnExit.BackgroundColor = Color.DarkGray;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.BorderColor = Color.PaleVioletRed;
            btnExit.BorderRadius = 0;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.ForeColor = Color.White;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1768, 878);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 63);
            btnExit.TabIndex = 92;
            btnExit.Text = "Hủy";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // roundPictureBox2
            // 
            roundPictureBox2.Anchor = AnchorStyles.Right;
            roundPictureBox2.BackColor = Color.FromArgb(56, 92, 67);
            roundPictureBox2.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(1608, 885);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(39, 47);
            roundPictureBox2.TabIndex = 91;
            roundPictureBox2.TabStop = false;
            // 
            // btnAddMaterial
            // 
            btnAddMaterial.Anchor = AnchorStyles.Right;
            btnAddMaterial.BackColor = Color.FromArgb(18, 219, 78);
            btnAddMaterial.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnAddMaterial.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddMaterial.BorderColor = Color.PaleVioletRed;
            btnAddMaterial.BorderRadius = 0;
            btnAddMaterial.BorderSize = 0;
            btnAddMaterial.FlatAppearance.BorderSize = 0;
            btnAddMaterial.FlatStyle = FlatStyle.Flat;
            btnAddMaterial.Font = new Font("Segoe UI", 12F);
            btnAddMaterial.ForeColor = Color.Black;
            btnAddMaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMaterial.Location = new Point(1593, 878);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Size = new Size(148, 63);
            btnAddMaterial.TabIndex = 90;
            btnAddMaterial.Text = "Tạo mới";
            btnAddMaterial.TextAlign = ContentAlignment.MiddleRight;
            btnAddMaterial.TextColor = Color.Black;
            btnAddMaterial.UseVisualStyleBackColor = false;
            btnAddMaterial.Click += btnAddMaterial_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label6.Location = new Point(31, 12);
            label6.Name = "label6";
            label6.Size = new Size(250, 46);
            label6.TabIndex = 89;
            label6.Text = "Thêm hóa đơn";
            // 
            // timePicker
            // 
            timePicker.CustomFormat = "dd/MM/yyyy";
            timePicker.Font = new Font("Segoe UI", 14F);
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(1402, 150);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(238, 39);
            timePicker.TabIndex = 110;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F);
            label10.Location = new Point(1132, 152);
            label10.Name = "label10";
            label10.Size = new Size(172, 37);
            label10.TabIndex = 111;
            label10.Text = "Thời gian lập";
            // 
            // cbPatientName
            // 
            cbPatientName.Font = new Font("Segoe UI", 14F);
            cbPatientName.FormattingEnabled = true;
            cbPatientName.Items.AddRange(new object[] { "Chữa răng", "Nội nha", "Nha chu", "Nhổ răng", "Răng trẻ em", "Kháng sinh", "Giảm đau", "Kháng viêm" });
            cbPatientName.Location = new Point(230, 227);
            cbPatientName.Name = "cbPatientName";
            cbPatientName.Size = new Size(419, 39);
            cbPatientName.TabIndex = 113;
            // 
            // cbPatientId
            // 
            cbPatientId.Font = new Font("Segoe UI", 14F);
            cbPatientId.FormattingEnabled = true;
            cbPatientId.Items.AddRange(new object[] { "Cố định", "Tiêu hao" });
            cbPatientId.Location = new Point(229, 150);
            cbPatientId.Name = "cbPatientId";
            cbPatientId.Size = new Size(420, 39);
            cbPatientId.TabIndex = 112;
            // 
            // dataService
            // 
            dataService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataService.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataService.BackgroundColor = Color.White;
            dataService.BorderStyle = BorderStyle.None;
            dataService.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataService.DefaultCellStyle = dataGridViewCellStyle1;
            dataService.GridColor = Color.White;
            dataService.Location = new Point(12, 360);
            dataService.Name = "dataService";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataService.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataService.RowHeadersWidth = 51;
            dataService.Size = new Size(900, 500);
            dataService.TabIndex = 126;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(54, 307);
            label2.Name = "label2";
            label2.Size = new Size(112, 37);
            label2.TabIndex = 127;
            label2.Text = "Dịch vụ";
            // 
            // dataPrescription
            // 
            dataPrescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataPrescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataPrescription.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataPrescription.BackgroundColor = Color.White;
            dataPrescription.BorderStyle = BorderStyle.None;
            dataPrescription.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataPrescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataPrescription.DefaultCellStyle = dataGridViewCellStyle3;
            dataPrescription.GridColor = Color.White;
            dataPrescription.Location = new Point(993, 360);
            dataPrescription.Name = "dataPrescription";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataPrescription.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataPrescription.RowHeadersWidth = 51;
            dataPrescription.Size = new Size(877, 500);
            dataPrescription.TabIndex = 128;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.Location = new Point(1065, 307);
            label7.Name = "label7";
            label7.Size = new Size(143, 37);
            label7.TabIndex = 129;
            label7.Text = "Toa thuốc";
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.Anchor = AnchorStyles.Right;
            roundPictureBox1.BackColor = Color.FromArgb(56, 92, 67);
            roundPictureBox1.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox1.Location = new Point(737, 298);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(39, 47);
            roundPictureBox1.TabIndex = 131;
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
            // 
            // btnAddService
            // 
            btnAddService.Anchor = AnchorStyles.Right;
            btnAddService.BackColor = Color.FromArgb(18, 219, 78);
            btnAddService.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnAddService.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddService.BorderColor = Color.PaleVioletRed;
            btnAddService.BorderRadius = 0;
            btnAddService.BorderSize = 0;
            btnAddService.FlatAppearance.BorderSize = 0;
            btnAddService.FlatStyle = FlatStyle.Flat;
            btnAddService.Font = new Font("Segoe UI", 12F);
            btnAddService.ForeColor = Color.Black;
            btnAddService.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddService.Location = new Point(721, 291);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(191, 63);
            btnAddService.TabIndex = 130;
            btnAddService.Text = "Thêm dịch vụ";
            btnAddService.TextAlign = ContentAlignment.MiddleRight;
            btnAddService.TextColor = Color.Black;
            btnAddService.UseVisualStyleBackColor = false;
            btnAddService.Click += btnAddService_Click;
            // 
            // roundPictureBox4
            // 
            roundPictureBox4.Anchor = AnchorStyles.Right;
            roundPictureBox4.BackColor = Color.FromArgb(18, 219, 78);
            roundPictureBox4.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox4.Enabled = false;
            roundPictureBox4.Location = new Point(1711, 297);
            roundPictureBox4.Name = "roundPictureBox4";
            roundPictureBox4.Size = new Size(39, 47);
            roundPictureBox4.TabIndex = 133;
            roundPictureBox4.TabStop = false;
            roundPictureBox4.Click += roundPictureBox4_Click;
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Anchor = AnchorStyles.Right;
            btnAddMedicine.BackColor = Color.White;
            btnAddMedicine.BackgroundColor = Color.White;
            btnAddMedicine.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddMedicine.BorderColor = Color.PaleVioletRed;
            btnAddMedicine.BorderRadius = 0;
            btnAddMedicine.BorderSize = 0;
            btnAddMedicine.Enabled = false;
            btnAddMedicine.FlatAppearance.BorderSize = 0;
            btnAddMedicine.FlatStyle = FlatStyle.Flat;
            btnAddMedicine.Font = new Font("Segoe UI", 12F);
            btnAddMedicine.ForeColor = Color.Black;
            btnAddMedicine.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMedicine.Location = new Point(1702, 291);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Size = new Size(168, 63);
            btnAddMedicine.TabIndex = 132;
            btnAddMedicine.Text = "Thêm thuốc";
            btnAddMedicine.TextAlign = ContentAlignment.MiddleRight;
            btnAddMedicine.TextColor = Color.Black;
            btnAddMedicine.UseVisualStyleBackColor = false;
            btnAddMedicine.Click += btnAddMedicine_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label8.Location = new Point(34, 887);
            label8.Name = "label8";
            label8.Size = new Size(174, 46);
            label8.TabIndex = 134;
            label8.Text = "Tổng tiền";
            // 
            // lbPrice
            // 
            lbPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbPrice.Location = new Point(350, 887);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(178, 46);
            lbPrice.TabIndex = 135;
            lbPrice.Text = "5,000,000";
            // 
            // roundPictureBox5
            // 
            roundPictureBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            roundPictureBox5.BackColor = Color.White;
            roundPictureBox5.BackgroundImage = Properties.Resources.save_icon;
            roundPictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox5.Location = new Point(1506, 302);
            roundPictureBox5.Name = "roundPictureBox5";
            roundPictureBox5.Size = new Size(39, 41);
            roundPictureBox5.TabIndex = 137;
            roundPictureBox5.TabStop = false;
            roundPictureBox5.Click += roundPictureBox5_Click;
            // 
            // btnCreatePrescription
            // 
            btnCreatePrescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreatePrescription.BackColor = Color.FromArgb(18, 219, 78);
            btnCreatePrescription.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnCreatePrescription.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreatePrescription.BorderColor = Color.PaleVioletRed;
            btnCreatePrescription.BorderRadius = 5;
            btnCreatePrescription.BorderSize = 0;
            btnCreatePrescription.FlatAppearance.BorderSize = 0;
            btnCreatePrescription.FlatStyle = FlatStyle.Flat;
            btnCreatePrescription.Font = new Font("Segoe UI", 11F);
            btnCreatePrescription.ForeColor = Color.Black;
            btnCreatePrescription.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreatePrescription.Location = new Point(1496, 291);
            btnCreatePrescription.Name = "btnCreatePrescription";
            btnCreatePrescription.Size = new Size(191, 63);
            btnCreatePrescription.TabIndex = 136;
            btnCreatePrescription.Text = "Tạo đơn thuốc";
            btnCreatePrescription.TextAlign = ContentAlignment.MiddleRight;
            btnCreatePrescription.TextColor = Color.Black;
            btnCreatePrescription.UseVisualStyleBackColor = false;
            btnCreatePrescription.Click += btnCreatePrescription_Click;
            // 
            // AddBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1882, 953);
            Controls.Add(roundPictureBox5);
            Controls.Add(btnCreatePrescription);
            Controls.Add(lbPrice);
            Controls.Add(label8);
            Controls.Add(roundPictureBox4);
            Controls.Add(btnAddMedicine);
            Controls.Add(roundPictureBox1);
            Controls.Add(btnAddService);
            Controls.Add(label7);
            Controls.Add(dataPrescription);
            Controls.Add(label2);
            Controls.Add(dataService);
            Controls.Add(cbPatientName);
            Controls.Add(cbPatientId);
            Controls.Add(label10);
            Controls.Add(timePicker);
            Controls.Add(datePicker);
            Controls.Add(tbBillId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(roundPictureBox3);
            Controls.Add(btnExit);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnAddMaterial);
            Controls.Add(label6);
            Name = "AddBill";
            Text = "AddBill";
            Load += AddBill_Load;
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataService).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataPrescription).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker datePicker;
        private TextBox tbBillId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private component.RoundPictureBox roundPictureBox3;
        private component.RJButton btnExit;
        private component.RoundPictureBox roundPictureBox2;
        private component.RJButton btnAddMaterial;
        private Label label6;
        private DateTimePicker timePicker;
        private Label label10;
        private ComboBox cbPatientName;
        private ComboBox cbPatientId;
        private DataGridView dataService;
        private Label label2;
        private DataGridView dataPrescription;
        private Label label7;
        private component.RoundPictureBox roundPictureBox1;
        private component.RJButton btnAddService;
        private component.RoundPictureBox roundPictureBox4;
        private component.RJButton btnAddMedicine;
        private Label label8;
        private Label lbPrice;
        private component.RoundPictureBox roundPictureBox5;
        private component.RJButton btnCreatePrescription;
    }
}