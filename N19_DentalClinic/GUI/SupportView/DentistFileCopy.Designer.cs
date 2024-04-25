namespace N19_DentalClinic.GUI.SupportView
{
    partial class DentistFileCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DentistFileCopy));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cbKindSearch = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dataDentistTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataDentistTable).BeginInit();
            SuspendLayout();
            // 
            // cbKindSearch
            // 
            cbKindSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKindSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKindSearch.FormattingEnabled = true;
            cbKindSearch.Items.AddRange(new object[] { "Mã nha sĩ", "Tên nha sĩ", "Khoa" });
            cbKindSearch.Location = new Point(12, 76);
            cbKindSearch.Margin = new Padding(3, 4, 3, 4);
            cbKindSearch.Name = "cbKindSearch";
            cbKindSearch.Size = new Size(246, 39);
            cbKindSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(219, 175, 9);
            btnSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(567, 68);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(57, 55);
            btnSearch.TabIndex = 7;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(279, 77);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(282, 38);
            txtSearch.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 46);
            label1.TabIndex = 5;
            label1.Text = "Danh sách nha sĩ";
            // 
            // dataDentistTable
            // 
            dataDentistTable.AllowUserToAddRows = false;
            dataDentistTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataDentistTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDentistTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataDentistTable.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataDentistTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataDentistTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataDentistTable.DefaultCellStyle = dataGridViewCellStyle2;
            dataDentistTable.Location = new Point(12, 131);
            dataDentistTable.Margin = new Padding(3, 4, 3, 4);
            dataDentistTable.Name = "dataDentistTable";
            dataDentistTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataDentistTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataDentistTable.RowHeadersWidth = 51;
            dataDentistTable.RowTemplate.Height = 24;
            dataDentistTable.Size = new Size(1062, 450);
            dataDentistTable.TabIndex = 9;
            dataDentistTable.MouseClick += dataDentistTable_MouseClick;
            // 
            // DentistFileCopy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 594);
            Controls.Add(dataDentistTable);
            Controls.Add(cbKindSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "DentistFileCopy";
            Text = "DentistFileCopy";
            Load += DentistFileCopy_Load;
            ((System.ComponentModel.ISupportInitialize)dataDentistTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbKindSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dataDentistTable;
    }
}