namespace N19_DentalClinic.GUI.AdminView
{
    partial class AddPrescriptionForBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrescriptionForBill));
            cbQuantity = new ComboBox();
            cbCalUnit = new ComboBox();
            cbMedicineId = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            tbNote = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cbMedicineName = new ComboBox();
            label1 = new Label();
            btnExit = new component.RJButton();
            btnAddMedicine = new component.RJButton();
            label6 = new Label();
            SuspendLayout();
            // 
            // cbQuantity
            // 
            cbQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbQuantity.DropDownStyle = ComboBoxStyle.Simple;
            cbQuantity.Font = new Font("Segoe UI", 14F);
            cbQuantity.FormattingEnabled = true;
            cbQuantity.Location = new Point(713, 238);
            cbQuantity.Name = "cbQuantity";
            cbQuantity.Size = new Size(248, 39);
            cbQuantity.TabIndex = 62;
            // 
            // cbCalUnit
            // 
            cbCalUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbCalUnit.DropDownStyle = ComboBoxStyle.Simple;
            cbCalUnit.Enabled = false;
            cbCalUnit.Font = new Font("Segoe UI", 14F);
            cbCalUnit.FormattingEnabled = true;
            cbCalUnit.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbCalUnit.Location = new Point(220, 236);
            cbCalUnit.Name = "cbCalUnit";
            cbCalUnit.Size = new Size(248, 39);
            cbCalUnit.TabIndex = 61;
            // 
            // cbMedicineId
            // 
            cbMedicineId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbMedicineId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedicineId.Font = new Font("Segoe UI", 14F);
            cbMedicineId.FormattingEnabled = true;
            cbMedicineId.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbMedicineId.Location = new Point(220, 163);
            cbMedicineId.Name = "cbMedicineId";
            cbMedicineId.Size = new Size(741, 39);
            cbMedicineId.TabIndex = 60;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(25, 163);
            label5.Name = "label5";
            label5.Size = new Size(129, 37);
            label5.TabIndex = 59;
            label5.Text = "Mã thuốc";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(25, 238);
            label4.Name = "label4";
            label4.Size = new Size(147, 37);
            label4.TabIndex = 58;
            label4.Text = "Đơn vị tính";
            // 
            // tbNote
            // 
            tbNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNote.Font = new Font("Segoe UI", 14F);
            tbNote.Location = new Point(220, 312);
            tbNote.Name = "tbNote";
            tbNote.PlaceholderText = "Nhập ghi chú (bao nhiêu viên 1 ngày)";
            tbNote.Size = new Size(741, 39);
            tbNote.TabIndex = 57;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(26, 312);
            label3.Name = "label3";
            label3.Size = new Size(107, 37);
            label3.TabIndex = 56;
            label3.Text = "Ghi chú";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(583, 234);
            label2.Name = "label2";
            label2.Size = new Size(124, 37);
            label2.TabIndex = 55;
            label2.Text = "Số lượng";
            // 
            // cbMedicineName
            // 
            cbMedicineName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbMedicineName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedicineName.Font = new Font("Segoe UI", 14F);
            cbMedicineName.FormattingEnabled = true;
            cbMedicineName.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbMedicineName.Location = new Point(220, 89);
            cbMedicineName.Name = "cbMedicineName";
            cbMedicineName.Size = new Size(741, 39);
            cbMedicineName.TabIndex = 54;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(25, 89);
            label1.Name = "label1";
            label1.Size = new Size(131, 37);
            label1.TabIndex = 53;
            label1.Text = "Tên thuốc";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(80, 101, 122);
            btnExit.BackgroundColor = Color.FromArgb(80, 101, 122);
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.BorderColor = Color.PaleVioletRed;
            btnExit.BorderRadius = 0;
            btnExit.BorderSize = 0;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(845, 386);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(6, 0, 6, 0);
            btnExit.Size = new Size(116, 63);
            btnExit.TabIndex = 51;
            btnExit.Text = "Hủy";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Anchor = AnchorStyles.Right;
            btnAddMedicine.BackColor = Color.FromArgb(18, 219, 78);
            btnAddMedicine.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnAddMedicine.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddMedicine.BorderColor = Color.PaleVioletRed;
            btnAddMedicine.BorderRadius = 0;
            btnAddMedicine.BorderSize = 0;
            btnAddMedicine.FlatAppearance.BorderSize = 0;
            btnAddMedicine.FlatStyle = FlatStyle.Flat;
            btnAddMedicine.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnAddMedicine.ForeColor = Color.Black;
            btnAddMedicine.Image = (Image)resources.GetObject("btnAddMedicine.Image");
            btnAddMedicine.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMedicine.Location = new Point(648, 386);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Padding = new Padding(6, 0, 6, 0);
            btnAddMedicine.Size = new Size(162, 63);
            btnAddMedicine.TabIndex = 49;
            btnAddMedicine.Text = "Tạo mới";
            btnAddMedicine.TextAlign = ContentAlignment.MiddleRight;
            btnAddMedicine.TextColor = Color.Black;
            btnAddMedicine.UseVisualStyleBackColor = false;
            btnAddMedicine.Click += btnAddMedicine_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label6.Location = new Point(22, 23);
            label6.Name = "label6";
            label6.Size = new Size(209, 46);
            label6.TabIndex = 48;
            label6.Text = "Thêm thuốc";
            // 
            // AddPrescriptionForBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(982, 473);
            Controls.Add(cbQuantity);
            Controls.Add(cbCalUnit);
            Controls.Add(cbMedicineId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbNote);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbMedicineName);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnAddMedicine);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPrescriptionForBill";
            Text = "AddPrescriptionForBill";
            Load += AddPrescriptionForBill_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbQuantity;
        private ComboBox cbCalUnit;
        private ComboBox cbMedicineId;
        private Label label5;
        private Label label4;
        private TextBox tbNote;
        private Label label3;
        private Label label2;
        private ComboBox cbMedicineName;
        private Label label1;
        private component.RJButton btnExit;
        private component.RJButton btnAddMedicine;
        private Label label6;
    }
}