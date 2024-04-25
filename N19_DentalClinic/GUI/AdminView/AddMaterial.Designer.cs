namespace N19_DentalClinic.GUI.AdminView
{
    partial class AddMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMaterial));
            tbCalUnit = new TextBox();
            tbMaterialName = new TextBox();
            tbMaterialId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnExit = new component.RJButton();
            btnAddMaterial = new component.RJButton();
            label6 = new Label();
            cbType = new ComboBox();
            dateTimePicker = new DateTimePicker();
            cbFunction = new ComboBox();
            label7 = new Label();
            tbQuantity = new TextBox();
            label8 = new Label();
            tbPrice = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // tbCalUnit
            // 
            tbCalUnit.Font = new Font("Segoe UI", 14F);
            tbCalUnit.Location = new Point(220, 238);
            tbCalUnit.Name = "tbCalUnit";
            tbCalUnit.Size = new Size(238, 39);
            tbCalUnit.TabIndex = 80;
            // 
            // tbMaterialName
            // 
            tbMaterialName.Font = new Font("Segoe UI", 14F);
            tbMaterialName.Location = new Point(220, 165);
            tbMaterialName.Name = "tbMaterialName";
            tbMaterialName.Size = new Size(741, 39);
            tbMaterialName.TabIndex = 79;
            // 
            // tbMaterialId
            // 
            tbMaterialId.Font = new Font("Segoe UI", 14F);
            tbMaterialId.Location = new Point(220, 91);
            tbMaterialId.Name = "tbMaterialId";
            tbMaterialId.Size = new Size(741, 39);
            tbMaterialId.TabIndex = 78;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(25, 163);
            label5.Name = "label5";
            label5.Size = new Size(150, 37);
            label5.TabIndex = 77;
            label5.Text = "Tên vật liệu";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(25, 238);
            label4.Name = "label4";
            label4.Size = new Size(147, 37);
            label4.TabIndex = 76;
            label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(28, 373);
            label3.Name = "label3";
            label3.Size = new Size(176, 37);
            label3.TabIndex = 74;
            label3.Text = "Ngày hết hạn";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(545, 236);
            label2.Name = "label2";
            label2.Size = new Size(127, 37);
            label2.TabIndex = 73;
            label2.Text = "Phân loại";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(25, 89);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 72;
            label1.Text = "Mã vật liệu";
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
            btnExit.Location = new Point(838, 470);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(6, 0, 6, 0);
            btnExit.Size = new Size(123, 63);
            btnExit.TabIndex = 70;
            btnExit.Text = "Hủy";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
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
            btnAddMaterial.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddMaterial.ForeColor = Color.Black;
            btnAddMaterial.Image = (Image)resources.GetObject("btnAddMaterial.Image");
            btnAddMaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMaterial.Location = new Point(674, 470);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Padding = new Padding(6, 0, 6, 0);
            btnAddMaterial.Size = new Size(158, 63);
            btnAddMaterial.TabIndex = 68;
            btnAddMaterial.Text = "Tạo mới";
            btnAddMaterial.TextAlign = ContentAlignment.MiddleRight;
            btnAddMaterial.TextColor = Color.Black;
            btnAddMaterial.UseVisualStyleBackColor = false;
            btnAddMaterial.Click += btnAddService_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label6.Location = new Point(22, 23);
            label6.Name = "label6";
            label6.Size = new Size(235, 46);
            label6.TabIndex = 67;
            label6.Text = "Thêm vật liệu";
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.Font = new Font("Segoe UI", 14F);
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Cố định", "Tiêu hao" });
            cbType.Location = new Point(699, 238);
            cbType.Name = "cbType";
            cbType.Size = new Size(262, 39);
            cbType.TabIndex = 81;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            cbType.SelectedValueChanged += cbType_SelectedValueChanged;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(226, 373);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(238, 39);
            dateTimePicker.TabIndex = 82;
            // 
            // cbFunction
            // 
            cbFunction.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFunction.Enabled = false;
            cbFunction.Font = new Font("Segoe UI", 14F);
            cbFunction.FormattingEnabled = true;
            cbFunction.Items.AddRange(new object[] { "Chữa răng", "Nội nha", "Nha chu", "Nhổ răng", "Răng trẻ em", "Kháng sinh", "Giảm đau", "Kháng viêm" });
            cbFunction.Location = new Point(701, 309);
            cbFunction.Name = "cbFunction";
            cbFunction.Size = new Size(260, 39);
            cbFunction.TabIndex = 84;
            cbFunction.SelectedIndexChanged += cbFunction_SelectedIndexChanged;
            cbFunction.MouseClick += cbFunction_MouseClick;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(545, 306);
            label7.Name = "label7";
            label7.Size = new Size(150, 37);
            label7.TabIndex = 83;
            label7.Text = "Công dụng";
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Segoe UI", 14F);
            tbQuantity.Location = new Point(223, 306);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(238, 39);
            tbQuantity.TabIndex = 86;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(28, 306);
            label8.Name = "label8";
            label8.Size = new Size(124, 37);
            label8.TabIndex = 85;
            label8.Text = "Số lượng";
            // 
            // tbPrice
            // 
            tbPrice.Font = new Font("Segoe UI", 14F);
            tbPrice.Location = new Point(701, 375);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(260, 39);
            tbPrice.TabIndex = 88;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(545, 373);
            label9.Name = "label9";
            label9.Size = new Size(109, 37);
            label9.TabIndex = 87;
            label9.Text = "Giá tiền";
            // 
            // AddMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(982, 545);
            Controls.Add(tbPrice);
            Controls.Add(label9);
            Controls.Add(tbQuantity);
            Controls.Add(label8);
            Controls.Add(cbFunction);
            Controls.Add(label7);
            Controls.Add(dateTimePicker);
            Controls.Add(cbType);
            Controls.Add(tbCalUnit);
            Controls.Add(tbMaterialName);
            Controls.Add(tbMaterialId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnAddMaterial);
            Controls.Add(label6);
            Name = "AddMaterial";
            Text = "AddMaterial";
            Load += AddMaterial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbCalUnit;
        private TextBox tbMaterialName;
        private TextBox tbMaterialId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private component.RJButton btnExit;
        private component.RJButton btnAddMaterial;
        private Label label6;
        private ComboBox cbType;
        private DateTimePicker dateTimePicker;
        private ComboBox cbFunction;
        private Label label7;
        private TextBox tbQuantity;
        private Label label8;
        private TextBox tbPrice;
        private Label label9;
    }
}