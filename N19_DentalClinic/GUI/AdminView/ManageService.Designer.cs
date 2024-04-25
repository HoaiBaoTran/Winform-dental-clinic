namespace N19_DentalClinic.GUI.AdminView
{
    partial class ManageService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageService));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnAddService = new Button();
            btnSearch = new component.RJButton();
            tbSearch = new TextBox();
            label6 = new Label();
            dataService = new DataGridView();
            cbKindSearch = new ComboBox();
            label1 = new Label();
            cbKindService = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataService).BeginInit();
            SuspendLayout();
            // 
            // btnAddService
            // 
            btnAddService.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddService.BackColor = Color.FromArgb(18, 219, 78);
            btnAddService.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddService.Image = (Image)resources.GetObject("btnAddService.Image");
            btnAddService.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddService.Location = new Point(946, 9);
            btnAddService.Margin = new Padding(3, 4, 3, 4);
            btnAddService.Name = "btnAddService";
            btnAddService.Padding = new Padding(6, 0, 6, 0);
            btnAddService.Size = new Size(236, 57);
            btnAddService.TabIndex = 111;
            btnAddService.Text = "Thêm dịch vụ";
            btnAddService.TextAlign = ContentAlignment.MiddleRight;
            btnAddService.UseVisualStyleBackColor = false;
            btnAddService.Click += btnAddService_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(219, 175, 9);
            btnSearch.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 5;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(510, 91);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 55);
            btnSearch.TabIndex = 106;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(272, 91);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm dịch vụ";
            tbSearch.Size = new Size(232, 43);
            tbSearch.TabIndex = 105;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 9);
            label6.Name = "label6";
            label6.Size = new Size(294, 46);
            label6.TabIndex = 104;
            label6.Text = "Quản lý dịch vụ";
            // 
            // dataService
            // 
            dataService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataService.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataService.BackgroundColor = Color.White;
            dataService.BorderStyle = BorderStyle.None;
            dataService.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(4);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataService.DefaultCellStyle = dataGridViewCellStyle5;
            dataService.EnableHeadersVisualStyles = false;
            dataService.GridColor = Color.White;
            dataService.Location = new Point(23, 165);
            dataService.Name = "dataService";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new Padding(4);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataService.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataService.RowHeadersWidth = 51;
            dataService.Size = new Size(1170, 623);
            dataService.TabIndex = 112;
            dataService.MouseClick += dataService_MouseClick;
            // 
            // cbKindSearch
            // 
            cbKindSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKindSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKindSearch.FormattingEnabled = true;
            cbKindSearch.Items.AddRange(new object[] { "Mã dịch vụ", "Tên dịch vụ" });
            cbKindSearch.Location = new Point(23, 95);
            cbKindSearch.Margin = new Padding(3, 4, 3, 4);
            cbKindSearch.Name = "cbKindSearch";
            cbKindSearch.Size = new Size(232, 39);
            cbKindSearch.TabIndex = 113;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(591, 101);
            label1.Name = "label1";
            label1.Size = new Size(140, 29);
            label1.TabIndex = 114;
            label1.Text = "Loại dịch vụ";
            label1.Click += label1_Click;
            // 
            // cbKindService
            // 
            cbKindService.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbKindService.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKindService.FormattingEnabled = true;
            cbKindService.Location = new Point(749, 95);
            cbKindService.Margin = new Padding(3, 4, 3, 4);
            cbKindService.Name = "cbKindService";
            cbKindService.Size = new Size(433, 39);
            cbKindService.TabIndex = 115;
            cbKindService.SelectedIndexChanged += cbKindService_SelectedIndexChanged;
            // 
            // ManageService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 800);
            Controls.Add(cbKindService);
            Controls.Add(label1);
            Controls.Add(cbKindSearch);
            Controls.Add(dataService);
            Controls.Add(btnAddService);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageService";
            Text = "ManageService";
            Load += ManageService_Load;
            ((System.ComponentModel.ISupportInitialize)dataService).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbPatientName;
        private Label label8;
        private ComboBox cbPatientId;
        private Label label7;
        private Button btnAddService;
        private component.RoundPictureBox roundPictureBox3;
        private component.RJButton btnBack;
        private component.RJButton btnSearch;
        private TextBox tbSearch;
        private Label label6;
        private DataGridView dataService;
        private ComboBox cbKindSearch;
        private Label label1;
        private ComboBox cbKindService;
    }
}