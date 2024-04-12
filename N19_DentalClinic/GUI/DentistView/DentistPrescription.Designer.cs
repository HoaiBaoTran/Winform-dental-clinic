namespace N19_DentalClinic.GUI.DentistView
{
    partial class DentistPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DentistPrescription));
            btnSearch = new component.RJButton();
            tbSearch = new TextBox();
            label6 = new Label();
            roundPictureBox3 = new component.RoundPictureBox();
            btnBack = new component.RJButton();
            roundPictureBox2 = new component.RoundPictureBox();
            btnCreatePrescription = new component.RJButton();
            dataPrescription = new DataGridView();
            btnAddMedicine = new Button();
            cbPatientName = new ComboBox();
            label8 = new Label();
            cbPatientId = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataPrescription).BeginInit();
            SuspendLayout();
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
            btnSearch.Location = new Point(311, 82);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 34);
            btnSearch.TabIndex = 17;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.Location = new Point(12, 82);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm toa thuốc";
            tbSearch.Size = new Size(293, 34);
            tbSearch.TabIndex = 16;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 27);
            label6.Name = "label6";
            label6.Size = new Size(155, 41);
            label6.TabIndex = 15;
            label6.Text = "Toa thuốc";
            // 
            // roundPictureBox3
            // 
            roundPictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            roundPictureBox3.BackColor = Color.White;
            roundPictureBox3.BackgroundImage = Properties.Resources.back_icon;
            roundPictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox3.Location = new Point(1207, 69);
            roundPictureBox3.Name = "roundPictureBox3";
            roundPictureBox3.Size = new Size(39, 41);
            roundPictureBox3.TabIndex = 93;
            roundPictureBox3.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            btnBack.Location = new Point(1197, 60);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 56);
            btnBack.TabIndex = 92;
            btnBack.Text = "Hủy";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextColor = Color.White;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // roundPictureBox2
            // 
            roundPictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            roundPictureBox2.BackColor = Color.White;
            roundPictureBox2.BackgroundImage = Properties.Resources.save_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(832, 69);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(39, 41);
            roundPictureBox2.TabIndex = 91;
            roundPictureBox2.TabStop = false;
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
            btnCreatePrescription.Location = new Point(822, 62);
            btnCreatePrescription.Name = "btnCreatePrescription";
            btnCreatePrescription.Size = new Size(191, 56);
            btnCreatePrescription.TabIndex = 90;
            btnCreatePrescription.Text = "Tạo đơn thuốc";
            btnCreatePrescription.TextAlign = ContentAlignment.MiddleRight;
            btnCreatePrescription.TextColor = Color.Black;
            btnCreatePrescription.UseVisualStyleBackColor = false;
            btnCreatePrescription.Click += btnCreatePrescription_Click;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataPrescription.DefaultCellStyle = dataGridViewCellStyle1;
            dataPrescription.GridColor = Color.White;
            dataPrescription.Location = new Point(7, 215);
            dataPrescription.Name = "dataPrescription";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataPrescription.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataPrescription.RowHeadersWidth = 51;
            dataPrescription.Size = new Size(1292, 574);
            dataPrescription.TabIndex = 98;
            dataPrescription.MouseClick += dataPrescription_MouseClick;
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddMedicine.Enabled = false;
            btnAddMedicine.Font = new Font("Microsoft Sans Serif", 12F);
            btnAddMedicine.Image = (Image)resources.GetObject("btnAddMedicine.Image");
            btnAddMedicine.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMedicine.Location = new Point(1028, 59);
            btnAddMedicine.Margin = new Padding(3, 4, 3, 4);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Size = new Size(163, 57);
            btnAddMedicine.TabIndex = 99;
            btnAddMedicine.Text = "Thêm thuốc";
            btnAddMedicine.TextAlign = ContentAlignment.MiddleRight;
            btnAddMedicine.UseVisualStyleBackColor = true;
            btnAddMedicine.Click += btnAddMedicine_Click;
            // 
            // cbPatientName
            // 
            cbPatientName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbPatientName.Font = new Font("Segoe UI", 14F);
            cbPatientName.FormattingEnabled = true;
            cbPatientName.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbPatientName.Location = new Point(819, 154);
            cbPatientName.Name = "cbPatientName";
            cbPatientName.Size = new Size(480, 39);
            cbPatientName.TabIndex = 103;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label8.Location = new Point(610, 152);
            label8.Name = "label8";
            label8.Size = new Size(203, 37);
            label8.TabIndex = 102;
            label8.Text = "Tên bệnh nhân";
            // 
            // cbPatientId
            // 
            cbPatientId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cbPatientId.Font = new Font("Segoe UI", 14F);
            cbPatientId.FormattingEnabled = true;
            cbPatientId.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbPatientId.Location = new Point(220, 150);
            cbPatientId.Name = "cbPatientId";
            cbPatientId.Size = new Size(289, 39);
            cbPatientId.TabIndex = 101;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.Location = new Point(15, 152);
            label7.Name = "label7";
            label7.Size = new Size(199, 37);
            label7.TabIndex = 100;
            label7.Text = "Mã bệnh nhân";
            // 
            // DentistPrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 800);
            Controls.Add(cbPatientName);
            Controls.Add(label8);
            Controls.Add(cbPatientId);
            Controls.Add(label7);
            Controls.Add(btnAddMedicine);
            Controls.Add(dataPrescription);
            Controls.Add(roundPictureBox3);
            Controls.Add(btnBack);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnCreatePrescription);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DentistPrescription";
            Text = "DentistPrescription";
            Load += DentistPrescription_Load;
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataPrescription).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private component.RJButton btnSearch;
        private TextBox tbSearch;
        private Label label6;
        private component.RoundPictureBox roundPictureBox3;
        private component.RJButton btnBack;
        private component.RoundPictureBox roundPictureBox2;
        private component.RJButton btnCreatePrescription;
        private DataGridView dataPrescription;
        private Button btnAddMedicine;
        private ComboBox cbPatientName;
        private Label label8;
        private ComboBox cbPatientId;
        private Label label7;
    }
}