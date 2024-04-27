namespace N19_DentalClinic.GUI.DentistView
{
    partial class AddMedicineRow
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
            roundPictureBox3 = new component.RoundPictureBox();
            btnExit = new component.RJButton();
            roundPictureBox2 = new component.RoundPictureBox();
            btnAddMedicine = new component.RJButton();
            label6 = new Label();
            label1 = new Label();
            cbMedicineName = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            tbNote = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbMedicineId = new ComboBox();
            cbCalUnit = new ComboBox();
            cbQuantity = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // roundPictureBox3
            // 
            roundPictureBox3.Anchor = AnchorStyles.Right;
            roundPictureBox3.BackColor = Color.White;
            roundPictureBox3.BackgroundImage = Properties.Resources.back_icon;
            roundPictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox3.Location = new Point(853, 396);
            roundPictureBox3.Name = "roundPictureBox3";
            roundPictureBox3.Size = new Size(39, 45);
            roundPictureBox3.TabIndex = 33;
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
            btnExit.Location = new Point(849, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 63);
            btnExit.TabIndex = 32;
            btnExit.Text = "Hủy";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // roundPictureBox2
            // 
            roundPictureBox2.Anchor = AnchorStyles.Right;
            roundPictureBox2.BackColor = Color.FromArgb(56, 92, 67);
            roundPictureBox2.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(693, 394);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(39, 47);
            roundPictureBox2.TabIndex = 31;
            roundPictureBox2.TabStop = false;
            roundPictureBox2.Click += roundPictureBox2_Click;
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
            btnAddMedicine.Font = new Font("Segoe UI", 12F);
            btnAddMedicine.ForeColor = Color.Black;
            btnAddMedicine.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMedicine.Location = new Point(684, 387);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Size = new Size(138, 63);
            btnAddMedicine.TabIndex = 30;
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
            label6.Location = new Point(12, 24);
            label6.Name = "label6";
            label6.Size = new Size(209, 46);
            label6.TabIndex = 29;
            label6.Text = "Thêm thuốc";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(15, 90);
            label1.Name = "label1";
            label1.Size = new Size(131, 37);
            label1.TabIndex = 34;
            label1.Text = "Tên thuốc";
            // 
            // cbMedicineName
            // 
            cbMedicineName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbMedicineName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedicineName.Font = new Font("Segoe UI", 14F);
            cbMedicineName.FormattingEnabled = true;
            cbMedicineName.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbMedicineName.Location = new Point(210, 90);
            cbMedicineName.Name = "cbMedicineName";
            cbMedicineName.Size = new Size(741, 39);
            cbMedicineName.TabIndex = 35;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(573, 235);
            label2.Name = "label2";
            label2.Size = new Size(124, 37);
            label2.TabIndex = 36;
            label2.Text = "Số lượng";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(16, 313);
            label3.Name = "label3";
            label3.Size = new Size(107, 37);
            label3.TabIndex = 40;
            label3.Text = "Ghi chú";
            // 
            // tbNote
            // 
            tbNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNote.Font = new Font("Segoe UI", 14F);
            tbNote.Location = new Point(210, 313);
            tbNote.Name = "tbNote";
            tbNote.PlaceholderText = "Nhập ghi chú (bao nhiêu viên 1 ngày)";
            tbNote.Size = new Size(741, 39);
            tbNote.TabIndex = 41;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(15, 239);
            label4.Name = "label4";
            label4.Size = new Size(147, 37);
            label4.TabIndex = 42;
            label4.Text = "Đơn vị tính";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(15, 164);
            label5.Name = "label5";
            label5.Size = new Size(129, 37);
            label5.TabIndex = 44;
            label5.Text = "Mã thuốc";
            // 
            // cbMedicineId
            // 
            cbMedicineId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbMedicineId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedicineId.Font = new Font("Segoe UI", 14F);
            cbMedicineId.FormattingEnabled = true;
            cbMedicineId.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbMedicineId.Location = new Point(210, 164);
            cbMedicineId.Name = "cbMedicineId";
            cbMedicineId.Size = new Size(741, 39);
            cbMedicineId.TabIndex = 45;
            // 
            // cbCalUnit
            // 
            cbCalUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbCalUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCalUnit.Font = new Font("Segoe UI", 14F);
            cbCalUnit.FormattingEnabled = true;
            cbCalUnit.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbCalUnit.Location = new Point(210, 237);
            cbCalUnit.Name = "cbCalUnit";
            cbCalUnit.Size = new Size(248, 39);
            cbCalUnit.TabIndex = 46;
            // 
            // cbQuantity
            // 
            cbQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbQuantity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQuantity.Font = new Font("Segoe UI", 14F);
            cbQuantity.FormattingEnabled = true;
            cbQuantity.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbQuantity.Location = new Point(703, 239);
            cbQuantity.Name = "cbQuantity";
            cbQuantity.Size = new Size(248, 39);
            cbQuantity.TabIndex = 47;
            // 
            // AddMedicineRow
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
            Controls.Add(roundPictureBox3);
            Controls.Add(btnExit);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnAddMedicine);
            Controls.Add(label6);
            Name = "AddMedicineRow";
            Text = "AddMedicineRow";
            Load += AddMedicineRow_Load;
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private component.RoundPictureBox roundPictureBox3;
        private component.RJButton btnExit;
        private component.RoundPictureBox roundPictureBox2;
        private component.RJButton btnAddMedicine;
        private Label label6;
        private Label label1;
        private ComboBox cbMedicineName;
        private Label label2;
        private Label label3;
        private TextBox tbNote;
        private Label label4;
        private Label label5;
        private ComboBox cbMedicineId;
        private ComboBox cbCalUnit;
        private ComboBox cbQuantity;
    }
}