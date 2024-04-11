namespace N19_ProjectForm.GUI.ReceptionistView
{
    partial class DentistFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DentistFile));
            dataDentistTable = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            cbKindSearch = new ComboBox();
            btnCreateDentist = new Button();
            ((System.ComponentModel.ISupportInitialize)dataDentistTable).BeginInit();
            SuspendLayout();
            // 
            // dataDentistTable
            // 
            dataDentistTable.AllowUserToAddRows = false;
            dataDentistTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataDentistTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDentistTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
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
            dataDentistTable.Location = new Point(44, 170);
            dataDentistTable.Margin = new Padding(3, 4, 3, 4);
            dataDentistTable.Name = "dataDentistTable";
            dataDentistTable.ReadOnly = true;
            dataDentistTable.RowHeadersVisible = false;
            dataDentistTable.RowHeadersWidth = 51;
            dataDentistTable.RowTemplate.Height = 24;
            dataDentistTable.Size = new Size(1375, 667);
            dataDentistTable.TabIndex = 0;
            dataDentistTable.MouseClick += dataDentistTable_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(328, 46);
            label1.TabIndex = 1;
            label1.Text = "Danh sách nha sĩ";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(20, 91);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(235, 38);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnSearch.Location = new Point(525, 86);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(196, 55);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbKindSearch
            // 
            cbKindSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKindSearch.FormattingEnabled = true;
            cbKindSearch.Items.AddRange(new object[] { "Mã nha sĩ", "Tên nha sĩ" });
            cbKindSearch.Location = new Point(282, 90);
            cbKindSearch.Margin = new Padding(3, 4, 3, 4);
            cbKindSearch.Name = "cbKindSearch";
            cbKindSearch.Size = new Size(212, 39);
            cbKindSearch.TabIndex = 4;
            // 
            // btnCreateDentist
            // 
            btnCreateDentist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateDentist.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateDentist.Image = (Image)resources.GetObject("btnCreateDentist.Image");
            btnCreateDentist.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateDentist.Location = new Point(1201, 75);
            btnCreateDentist.Margin = new Padding(3, 4, 3, 4);
            btnCreateDentist.Name = "btnCreateDentist";
            btnCreateDentist.Size = new Size(218, 66);
            btnCreateDentist.TabIndex = 9;
            btnCreateDentist.Text = "Thêm nha sĩ";
            btnCreateDentist.TextAlign = ContentAlignment.MiddleRight;
            btnCreateDentist.UseVisualStyleBackColor = true;
            btnCreateDentist.Click += btnCreateDentist_Click;
            // 
            // DentistFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 850);
            Controls.Add(btnCreateDentist);
            Controls.Add(cbKindSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dataDentistTable);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DentistFile";
            Text = "DentistFile";
            Load += DentistFile_Load;
            ((System.ComponentModel.ISupportInitialize)dataDentistTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataDentistTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbKindSearch;
        private Button btnCreateDentist;
    }
}
