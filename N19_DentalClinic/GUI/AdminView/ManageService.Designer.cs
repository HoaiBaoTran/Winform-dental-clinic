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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAddService = new Button();
            btnSearch = new component.RJButton();
            tbSearch = new TextBox();
            label6 = new Label();
            dataService = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataService).BeginInit();
            SuspendLayout();
            // 
            // btnAddService
            // 
            btnAddService.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddService.BackColor = Color.FromArgb(18, 219, 78);
            btnAddService.Font = new Font("Microsoft Sans Serif", 12F);
            btnAddService.Image = (Image)resources.GetObject("btnAddService.Image");
            btnAddService.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddService.Location = new Point(1005, 91);
            btnAddService.Margin = new Padding(3, 4, 3, 4);
            btnAddService.Name = "btnAddService";
            btnAddService.Padding = new Padding(6, 0, 6, 0);
            btnAddService.Size = new Size(188, 57);
            btnAddService.TabIndex = 111;
            btnAddService.Text = "Thêm dịch vụ";
            btnAddService.TextAlign = ContentAlignment.MiddleRight;
            btnAddService.UseVisualStyleBackColor = false;
            btnAddService.Click += btnAddService_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.BackgroundColor = Color.White;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 5;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(340, 91);
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
            tbSearch.Location = new Point(23, 91);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm dịch vụ";
            tbSearch.Size = new Size(293, 43);
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
            dataService.Location = new Point(23, 165);
            dataService.Name = "dataService";
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
            dataService.TabIndex = 112;
            dataService.MouseClick += dataService_MouseClick;
            // 
            // ManageService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 800);
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
    }
}