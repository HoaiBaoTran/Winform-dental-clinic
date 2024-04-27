namespace N19_DentalClinic.GUI.AdminView
{
    partial class AddServiceForBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServiceForBill));
            tbNote = new TextBox();
            label7 = new Label();
            tbQuantity = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnExit = new component.RJButton();
            btnAddService = new component.RJButton();
            label6 = new Label();
            cbPrice = new ComboBox();
            cbKindService = new ComboBox();
            cbServiceName = new ComboBox();
            cbServiceId = new ComboBox();
            btnFindCode = new component.RJButton();
            SuspendLayout();
            // 
            // tbNote
            // 
            tbNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNote.Font = new Font("Segoe UI", 14F);
            tbNote.Location = new Point(215, 381);
            tbNote.Name = "tbNote";
            tbNote.PlaceholderText = "Nhập ghi chú ";
            tbNote.Size = new Size(741, 39);
            tbNote.TabIndex = 85;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(21, 381);
            label7.Name = "label7";
            label7.Size = new Size(107, 37);
            label7.TabIndex = 84;
            label7.Text = "Ghi chú";
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Segoe UI", 14F);
            tbQuantity.Location = new Point(215, 234);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(238, 39);
            tbQuantity.TabIndex = 82;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(20, 157);
            label5.Name = "label5";
            label5.Size = new Size(149, 37);
            label5.TabIndex = 79;
            label5.Text = "Tên dịch vụ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(20, 232);
            label4.Name = "label4";
            label4.Size = new Size(124, 37);
            label4.TabIndex = 78;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(21, 306);
            label3.Name = "label3";
            label3.Size = new Size(159, 37);
            label3.TabIndex = 76;
            label3.Text = "Loại dịch vụ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(523, 232);
            label2.Name = "label2";
            label2.Size = new Size(109, 37);
            label2.TabIndex = 75;
            label2.Text = "Giá tiền";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(20, 83);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 74;
            label1.Text = "Mã dịch vụ";
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
            btnExit.Location = new Point(852, 478);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(6, 0, 6, 0);
            btnExit.Size = new Size(113, 63);
            btnExit.TabIndex = 72;
            btnExit.Text = "Hủy";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
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
            btnAddService.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnAddService.ForeColor = Color.Black;
            btnAddService.Image = (Image)resources.GetObject("btnAddService.Image");
            btnAddService.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddService.Location = new Point(647, 478);
            btnAddService.Name = "btnAddService";
            btnAddService.Padding = new Padding(6, 0, 6, 0);
            btnAddService.Size = new Size(177, 63);
            btnAddService.TabIndex = 70;
            btnAddService.Text = "Tạo mới";
            btnAddService.TextAlign = ContentAlignment.MiddleRight;
            btnAddService.TextColor = Color.Black;
            btnAddService.UseVisualStyleBackColor = false;
            btnAddService.Click += btnAddService_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label6.Location = new Point(17, 17);
            label6.Name = "label6";
            label6.Size = new Size(233, 46);
            label6.TabIndex = 69;
            label6.Text = "Thêm dịch vụ";
            // 
            // cbPrice
            // 
            cbPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbPrice.DropDownStyle = ComboBoxStyle.Simple;
            cbPrice.Enabled = false;
            cbPrice.Font = new Font("Segoe UI", 14F);
            cbPrice.FormattingEnabled = true;
            cbPrice.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbPrice.Location = new Point(659, 234);
            cbPrice.Name = "cbPrice";
            cbPrice.Size = new Size(297, 39);
            cbPrice.TabIndex = 89;
            // 
            // cbKindService
            // 
            cbKindService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbKindService.DropDownStyle = ComboBoxStyle.Simple;
            cbKindService.Enabled = false;
            cbKindService.Font = new Font("Segoe UI", 14F);
            cbKindService.FormattingEnabled = true;
            cbKindService.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbKindService.Location = new Point(215, 308);
            cbKindService.Name = "cbKindService";
            cbKindService.Size = new Size(248, 39);
            cbKindService.TabIndex = 88;
            // 
            // cbServiceName
            // 
            cbServiceName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbServiceName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServiceName.Font = new Font("Segoe UI", 14F);
            cbServiceName.FormattingEnabled = true;
            cbServiceName.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbServiceName.Location = new Point(215, 159);
            cbServiceName.Name = "cbServiceName";
            cbServiceName.Size = new Size(741, 39);
            cbServiceName.TabIndex = 87;
            // 
            // cbServiceId
            // 
            cbServiceId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbServiceId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServiceId.Font = new Font("Segoe UI", 14F);
            cbServiceId.FormattingEnabled = true;
            cbServiceId.Items.AddRange(new object[] { "Bệnh nhân đã đến", "Bệnh nhân chưa đến" });
            cbServiceId.Location = new Point(215, 85);
            cbServiceId.Name = "cbServiceId";
            cbServiceId.Size = new Size(741, 39);
            cbServiceId.TabIndex = 86;
            // 
            // btnFindCode
            // 
            btnFindCode.Anchor = AnchorStyles.Right;
            btnFindCode.BackColor = Color.FromArgb(7, 127, 250);
            btnFindCode.BackgroundColor = Color.FromArgb(7, 127, 250);
            btnFindCode.BackgroundImageLayout = ImageLayout.Zoom;
            btnFindCode.BorderColor = Color.PaleVioletRed;
            btnFindCode.BorderRadius = 0;
            btnFindCode.BorderSize = 0;
            btnFindCode.FlatAppearance.BorderSize = 0;
            btnFindCode.FlatStyle = FlatStyle.Flat;
            btnFindCode.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnFindCode.ForeColor = Color.White;
            btnFindCode.Image = (Image)resources.GetObject("btnFindCode.Image");
            btnFindCode.ImageAlign = ContentAlignment.MiddleLeft;
            btnFindCode.Location = new Point(21, 478);
            btnFindCode.Name = "btnFindCode";
            btnFindCode.Padding = new Padding(6, 0, 6, 0);
            btnFindCode.Size = new Size(259, 63);
            btnFindCode.TabIndex = 90;
            btnFindCode.Text = "Xem mã dịch vụ";
            btnFindCode.TextAlign = ContentAlignment.MiddleRight;
            btnFindCode.TextColor = Color.White;
            btnFindCode.UseVisualStyleBackColor = false;
            btnFindCode.Click += btnFindCode_Click;
            // 
            // AddServiceForBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(982, 559);
            Controls.Add(btnFindCode);
            Controls.Add(cbPrice);
            Controls.Add(cbKindService);
            Controls.Add(cbServiceName);
            Controls.Add(cbServiceId);
            Controls.Add(tbNote);
            Controls.Add(label7);
            Controls.Add(tbQuantity);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnAddService);
            Controls.Add(label6);
            Name = "AddServiceForBill";
            Text = "AddServiceForBill";
            Load += AddServiceForBill_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNote;
        private Label label7;
        private TextBox tbQuantity;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private component.RJButton btnExit;
        private component.RJButton btnAddService;
        private Label label6;
        private ComboBox cbPrice;
        private ComboBox cbKindService;
        private ComboBox cbServiceName;
        private ComboBox cbServiceId;
        private component.RJButton btnFindCode;
    }
}