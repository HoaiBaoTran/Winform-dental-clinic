namespace N19_DentalClinic.GUI.ReceptionistView
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataDentistTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataDentistTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataDentistTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDentistTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataDentistTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataDentistTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataDentistTable.DefaultCellStyle = dataGridViewCellStyle3;
            dataDentistTable.Location = new Point(44, 170);
            dataDentistTable.Margin = new Padding(3, 4, 3, 4);
            dataDentistTable.Name = "dataDentistTable";
            dataDentistTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataDentistTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            label1.Location = new Point(44, 21);
            label1.Name = "label1";
            label1.Size = new Size(328, 46);
            label1.TabIndex = 1;
            label1.Text = "Danh sách nha sĩ";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(44, 89);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(235, 38);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(552, 80);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(57, 55);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbKindSearch
            // 
            cbKindSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKindSearch.FormattingEnabled = true;
            cbKindSearch.Items.AddRange(new object[] { "Mã nha sĩ", "Tên nha sĩ" });
            cbKindSearch.Location = new Point(314, 88);
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
            btnCreateDentist.Location = new Point(1196, 74);
            btnCreateDentist.Margin = new Padding(3, 4, 3, 4);
            btnCreateDentist.Name = "btnCreateDentist";
            btnCreateDentist.Padding = new Padding(6, 0, 6, 0);
            btnCreateDentist.Size = new Size(223, 66);
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
