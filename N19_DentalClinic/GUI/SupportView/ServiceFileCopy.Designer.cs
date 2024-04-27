namespace N19_DentalClinic.GUI.SupportView
{
    partial class ServiceFileCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceFileCopy));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cbKindService = new ComboBox();
            label1 = new Label();
            cbKindSearch = new ComboBox();
            btnSearch = new component.RJButton();
            tbSearch = new TextBox();
            label6 = new Label();
            dataService = new DataGridView();
            btnExit = new component.RJButton();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataService).BeginInit();
            SuspendLayout();
            // 
            // cbKindService
            // 
            cbKindService.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbKindService.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKindService.FormattingEnabled = true;
            cbKindService.Location = new Point(749, 99);
            cbKindService.Margin = new Padding(3, 4, 3, 4);
            cbKindService.Name = "cbKindService";
            cbKindService.Size = new Size(433, 39);
            cbKindService.TabIndex = 121;
            cbKindService.SelectedIndexChanged += cbKindService_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(581, 105);
            label1.Name = "label1";
            label1.Size = new Size(140, 29);
            label1.TabIndex = 120;
            label1.Text = "Loại dịch vụ";
            // 
            // cbKindSearch
            // 
            cbKindSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKindSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKindSearch.FormattingEnabled = true;
            cbKindSearch.Items.AddRange(new object[] { "Mã dịch vụ", "Tên dịch vụ" });
            cbKindSearch.Location = new Point(13, 99);
            cbKindSearch.Margin = new Padding(3, 4, 3, 4);
            cbKindSearch.Name = "cbKindSearch";
            cbKindSearch.Size = new Size(232, 39);
            cbKindSearch.TabIndex = 119;
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
            btnSearch.Location = new Point(500, 95);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 55);
            btnSearch.TabIndex = 118;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(262, 95);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm dịch vụ";
            tbSearch.Size = new Size(232, 43);
            tbSearch.TabIndex = 117;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 13);
            label6.Name = "label6";
            label6.Size = new Size(294, 46);
            label6.TabIndex = 116;
            label6.Text = "Quản lý dịch vụ";
            // 
            // dataService
            // 
            dataService.AllowUserToAddRows = false;
            dataService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataService.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataService.BackgroundColor = Color.White;
            dataService.BorderStyle = BorderStyle.None;
            dataService.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataService.DefaultCellStyle = dataGridViewCellStyle2;
            dataService.EnableHeadersVisualStyles = false;
            dataService.GridColor = Color.White;
            dataService.Location = new Point(12, 156);
            dataService.Name = "dataService";
            dataService.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataService.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataService.RowHeadersWidth = 51;
            dataService.Size = new Size(1170, 623);
            dataService.TabIndex = 122;
            dataService.MouseClick += dataService_MouseClick;
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
            btnExit.Location = new Point(1040, 10);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(6, 0, 6, 0);
            btnExit.Size = new Size(142, 63);
            btnExit.TabIndex = 123;
            btnExit.Text = "Trở về";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.TextColor = Color.White;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(125, 124, 143);
            btnRefresh.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(866, 10);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(6, 0, 6, 0);
            btnRefresh.Size = new Size(153, 66);
            btnRefresh.TabIndex = 124;
            btnRefresh.Text = "Tải lại";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ServiceFileCopy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 800);
            Controls.Add(btnRefresh);
            Controls.Add(btnExit);
            Controls.Add(dataService);
            Controls.Add(cbKindService);
            Controls.Add(label1);
            Controls.Add(cbKindSearch);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServiceFileCopy";
            Text = "ServiceFileCopy";
            Load += ServiceFileCopy_Load;
            ((System.ComponentModel.ISupportInitialize)dataService).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbKindService;
        private Label label1;
        private ComboBox cbKindSearch;
        private component.RJButton btnSearch;
        private TextBox tbSearch;
        private Label label6;
        private DataGridView dataService;
        private component.RJButton btnExit;
        private Button btnRefresh;
    }
}