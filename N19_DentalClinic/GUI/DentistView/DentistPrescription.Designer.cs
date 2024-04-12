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
            btnAddAppointment = new component.RJButton();
            label1 = new Label();
            tbPatientID = new TextBox();
            label2 = new Label();
            tbPatientName = new TextBox();
            dataPrescription = new DataGridView();
            btnAddMedicine = new Button();
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
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.Location = new Point(12, 82);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm toa thuốc";
            tbSearch.Size = new Size(293, 34);
            tbSearch.TabIndex = 16;
            // 
            // label6
            // 
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
            roundPictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            roundPictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundPictureBox2.BackColor = Color.White;
            roundPictureBox2.BackgroundImage = Properties.Resources.save_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(924, 71);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(39, 41);
            roundPictureBox2.TabIndex = 91;
            roundPictureBox2.TabStop = false;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            btnAddAppointment.Location = new Point(917, 62);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(96, 56);
            btnAddAppointment.TabIndex = 90;
            btnAddAppointment.Text = "Lưu";
            btnAddAppointment.TextAlign = ContentAlignment.MiddleRight;
            btnAddAppointment.TextColor = Color.Black;
            btnAddAppointment.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 148);
            label1.Name = "label1";
            label1.Size = new Size(220, 41);
            label1.TabIndex = 94;
            label1.Text = "Mã bệnh nhân";
            // 
            // tbPatientID
            // 
            tbPatientID.Font = new Font("Segoe UI", 12F);
            tbPatientID.Location = new Point(250, 155);
            tbPatientID.Name = "tbPatientID";
            tbPatientID.PlaceholderText = "Mã bệnh nhân";
            tbPatientID.Size = new Size(293, 34);
            tbPatientID.TabIndex = 95;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(776, 148);
            label2.Name = "label2";
            label2.Size = new Size(224, 41);
            label2.TabIndex = 96;
            label2.Text = "Tên bệnh nhân";
            // 
            // tbPatientName
            // 
            tbPatientName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbPatientName.Font = new Font("Segoe UI", 12F);
            tbPatientName.Location = new Point(1006, 148);
            tbPatientName.Name = "tbPatientName";
            tbPatientName.PlaceholderText = "Tên bệnh nhân";
            tbPatientName.Size = new Size(293, 34);
            tbPatientName.TabIndex = 97;
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
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // DentistPrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 800);
            Controls.Add(btnAddMedicine);
            Controls.Add(dataPrescription);
            Controls.Add(tbPatientName);
            Controls.Add(label2);
            Controls.Add(tbPatientID);
            Controls.Add(label1);
            Controls.Add(roundPictureBox3);
            Controls.Add(btnBack);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnAddAppointment);
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
        private component.RJButton btnAddAppointment;
        private Label label1;
        private TextBox tbPatientID;
        private Label label2;
        private TextBox tbPatientName;
        private DataGridView dataPrescription;
        private Button btnAddMedicine;
    }
}