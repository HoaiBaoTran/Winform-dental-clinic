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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataBill = new DataGridView();
            btnSearch = new component.RJButton();
            tbSearch = new TextBox();
            label6 = new Label();
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataBill.DefaultCellStyle = dataGridViewCellStyle3;
            dataBill.GridColor = Color.White;
            dataBill.Location = new Point(9, 167);
            dataBill.Name = "dataBill";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataBill.RowHeadersWidth = 51;
            dataBill.Size = new Size(1186, 623);
            dataBill.TabIndex = 125;
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
            btnSearch.Location = new Point(313, 66);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 34);
            btnSearch.TabIndex = 123;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.Location = new Point(14, 66);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm hóa đơn";
            tbSearch.Size = new Size(293, 34);
            tbSearch.TabIndex = 122;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 11);
            label6.Name = "label6";
            label6.Size = new Size(250, 41);
            label6.TabIndex = 121;
            label6.Text = "Quản lý hóa đơn";
            // 
            // ManageBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 800);
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
    }
}