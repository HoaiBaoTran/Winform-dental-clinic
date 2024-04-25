namespace N19_DentalClinic.GUI.AdminView
{
    partial class ManageBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBill));
            dataBill = new DataGridView();
            btnSearch = new component.RJButton();
            tbSearch = new TextBox();
            label6 = new Label();
            btnAddBill = new Button();
            ((System.ComponentModel.ISupportInitialize)dataBill).BeginInit();
            SuspendLayout();
            // 
            // dataBill
            // 
            dataBill.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataBill.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataBill.BackgroundColor = Color.White;
            dataBill.BorderStyle = BorderStyle.None;
            dataBill.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataBill.DefaultCellStyle = dataGridViewCellStyle1;
            dataBill.GridColor = Color.White;
            dataBill.Location = new Point(25, 151);
            dataBill.Name = "dataBill";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataBill.RowHeadersWidth = 51;
            dataBill.Size = new Size(1158, 639);
            dataBill.TabIndex = 125;
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
            btnSearch.Location = new Point(341, 81);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 54);
            btnSearch.TabIndex = 123;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(25, 81);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm hóa đơn";
            tbSearch.Size = new Size(293, 43);
            tbSearch.TabIndex = 122;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 18);
            label6.Name = "label6";
            label6.Size = new Size(313, 46);
            label6.TabIndex = 121;
            label6.Text = "Quản lý hóa đơn";
            // 
            // btnAddBill
            // 
            btnAddBill.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddBill.BackColor = Color.FromArgb(18, 219, 78);
            btnAddBill.Font = new Font("Microsoft Sans Serif", 12F);
            btnAddBill.Image = (Image)resources.GetObject("btnAddBill.Image");
            btnAddBill.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddBill.Location = new Point(1005, 89);
            btnAddBill.Margin = new Padding(3, 4, 3, 4);
            btnAddBill.Name = "btnAddBill";
            btnAddBill.Size = new Size(188, 57);
            btnAddBill.TabIndex = 126;
            btnAddBill.Text = "Thêm hóa đơn";
            btnAddBill.TextAlign = ContentAlignment.MiddleRight;
            btnAddBill.UseVisualStyleBackColor = false;
            btnAddBill.Click += btnAddBill_Click;
            // 
            // ManageBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 800);
            Controls.Add(btnAddBill);
            Controls.Add(dataBill);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageBill";
            Text = "ManageBill";
            Load += ManageBill_Load;
            ((System.ComponentModel.ISupportInitialize)dataBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataBill;
        private component.RJButton btnSearch;
        private TextBox tbSearch;
        private Label label6;
        private Button btnAddBill;
    }
}