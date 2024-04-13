namespace N19_ProjectForm.GUI
{
    partial class PatientFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientFile));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            txtSearch = new TextBox();
            cbKindSearch = new ComboBox();
            btnSearch = new Button();
            dataPatientTable = new DataGridView();
            createNewPat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataPatientTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(51, 25);
            label1.Name = "label1";
            label1.Size = new Size(409, 46);
            label1.TabIndex = 2;
            label1.Text = "Danh sách bệnh nhân";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(51, 96);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(235, 38);
            txtSearch.TabIndex = 3;
            // 
            // cbKindSearch
            // 
            cbKindSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKindSearch.FormattingEnabled = true;
            cbKindSearch.Items.AddRange(new object[] { "Mã bệnh nhân", "Tên bệnh nhân" });
            cbKindSearch.Location = new Point(315, 95);
            cbKindSearch.Margin = new Padding(3, 4, 3, 4);
            cbKindSearch.Name = "cbKindSearch";
            cbKindSearch.Size = new Size(212, 39);
            cbKindSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(558, 86);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 55);
            btnSearch.TabIndex = 6;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataPatientTable
            // 
            dataPatientTable.AllowUserToAddRows = false;
            dataPatientTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataPatientTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataPatientTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataPatientTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataPatientTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataPatientTable.DefaultCellStyle = dataGridViewCellStyle2;
            dataPatientTable.Location = new Point(51, 170);
            dataPatientTable.Margin = new Padding(3, 4, 3, 4);
            dataPatientTable.Name = "dataPatientTable";
            dataPatientTable.ReadOnly = true;
            dataPatientTable.RowHeadersWidth = 51;
            dataPatientTable.RowTemplate.Height = 24;
            dataPatientTable.Size = new Size(1270, 667);
            dataPatientTable.TabIndex = 7;
            dataPatientTable.MouseClick += dataPatientTable_MouseClick;
            // 
            // createNewPat
            // 
            createNewPat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createNewPat.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createNewPat.Image = (Image)resources.GetObject("createNewPat.Image");
            createNewPat.ImageAlign = ContentAlignment.MiddleLeft;
            createNewPat.Location = new Point(1038, 80);
            createNewPat.Margin = new Padding(3, 4, 3, 4);
            createNewPat.Name = "createNewPat";
            createNewPat.Padding = new Padding(6, 0, 6, 0);
            createNewPat.Size = new Size(283, 66);
            createNewPat.TabIndex = 8;
            createNewPat.Text = "Thêm bệnh nhân";
            createNewPat.TextAlign = ContentAlignment.MiddleRight;
            createNewPat.UseVisualStyleBackColor = true;
            createNewPat.Click += createNewPat_Click;
            // 
            // PatientFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 730);
            Controls.Add(createNewPat);
            Controls.Add(dataPatientTable);
            Controls.Add(btnSearch);
            Controls.Add(cbKindSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientFile";
            Text = "PatientFile";
            Load += PatientFile_Load;
            ((System.ComponentModel.ISupportInitialize)dataPatientTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbKindSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataPatientTable;
        private System.Windows.Forms.Button createNewPat;
    }
}