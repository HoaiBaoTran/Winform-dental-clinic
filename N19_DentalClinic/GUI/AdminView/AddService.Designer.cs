namespace N19_DentalClinic.GUI.AdminView
{
    partial class AddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddService));
            label5 = new Label();
            label4 = new Label();
            tbKindService = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnExit = new component.RJButton();
            btnAddService = new component.RJButton();
            label6 = new Label();
            tbServiceId = new TextBox();
            tbServiceName = new TextBox();
            tbCalUnit = new TextBox();
            tbPrice = new TextBox();
            tbNote = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(25, 163);
            label5.Name = "label5";
            label5.Size = new Size(149, 37);
            label5.TabIndex = 59;
            label5.Text = "Tên dịch vụ";
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
            // tbKindService
            // 
            tbKindService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbKindService.Font = new Font("Segoe UI", 14F);
            tbKindService.Location = new Point(220, 312);
            tbKindService.Name = "tbKindService";
            tbKindService.PlaceholderText = "Nhập loại dịch vụ";
            tbKindService.Size = new Size(741, 39);
            tbKindService.TabIndex = 57;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(26, 312);
            label3.Name = "label3";
            label3.Size = new Size(159, 37);
            label3.TabIndex = 56;
            label3.Text = "Loại dịch vụ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(528, 238);
            label2.Name = "label2";
            label2.Size = new Size(109, 37);
            label2.TabIndex = 55;
            label2.Text = "Giá tiền";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(25, 89);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 53;
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
            btnExit.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(841, 484);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(6, 0, 6, 0);
            btnExit.Size = new Size(129, 63);
            btnExit.TabIndex = 51;
            btnExit.Text = "Hủy";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
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
            btnAddService.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddService.ForeColor = Color.Black;
            btnAddService.Image = (Image)resources.GetObject("btnAddService.Image");
            btnAddService.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddService.Location = new Point(661, 484);
            btnAddService.Name = "btnAddService";
            btnAddService.Padding = new Padding(6, 0, 6, 0);
            btnAddService.Size = new Size(159, 63);
            btnAddService.TabIndex = 49;
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
            label6.Location = new Point(22, 23);
            label6.Name = "label6";
            label6.Size = new Size(233, 46);
            label6.TabIndex = 48;
            label6.Text = "Thêm dịch vụ";
            // 
            // tbServiceId
            // 
            tbServiceId.Font = new Font("Segoe UI", 14F);
            tbServiceId.Location = new Point(220, 91);
            tbServiceId.Name = "tbServiceId";
            tbServiceId.Size = new Size(741, 39);
            tbServiceId.TabIndex = 63;
            // 
            // tbServiceName
            // 
            tbServiceName.Font = new Font("Segoe UI", 14F);
            tbServiceName.Location = new Point(220, 165);
            tbServiceName.Name = "tbServiceName";
            tbServiceName.Size = new Size(741, 39);
            tbServiceName.TabIndex = 64;
            // 
            // tbCalUnit
            // 
            tbCalUnit.Font = new Font("Segoe UI", 14F);
            tbCalUnit.Location = new Point(220, 238);
            tbCalUnit.Name = "tbCalUnit";
            tbCalUnit.Size = new Size(238, 39);
            tbCalUnit.TabIndex = 65;
            // 
            // tbPrice
            // 
            tbPrice.Font = new Font("Segoe UI", 14F);
            tbPrice.Location = new Point(643, 236);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(318, 39);
            tbPrice.TabIndex = 66;
            // 
            // tbNote
            // 
            tbNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNote.Font = new Font("Segoe UI", 14F);
            tbNote.Location = new Point(220, 389);
            tbNote.Name = "tbNote";
            tbNote.PlaceholderText = "Nhập ghi chú ";
            tbNote.Size = new Size(741, 39);
            tbNote.TabIndex = 68;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(26, 387);
            label7.Name = "label7";
            label7.Size = new Size(107, 37);
            label7.TabIndex = 67;
            label7.Text = "Ghi chú";
            // 
            // AddService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(982, 559);
            Controls.Add(tbNote);
            Controls.Add(label7);
            Controls.Add(tbPrice);
            Controls.Add(tbCalUnit);
            Controls.Add(tbServiceName);
            Controls.Add(tbServiceId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbKindService);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnAddService);
            Controls.Add(label6);
            Name = "AddService";
            Load += AddService_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbQuantity;
        private ComboBox cbCalUnit;
        private Label label5;
        private Label label4;
        private TextBox tbKindService;
        private Label label3;
        private Label label2;
        private Label label1;
        private component.RJButton btnExit;
        private component.RJButton btnAddService;
        private Label label6;
        private TextBox tbServiceId;
        private TextBox tbServiceName;
        private TextBox tbCalUnit;
        private TextBox tbPrice;
        private TextBox tbNote;
        private Label label7;
    }
}