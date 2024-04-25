namespace N19_DentalClinic.GUI.SupportView
{
    partial class PatientFileCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientFileCopy));
            label1 = new Label();
            dataPatientTable = new DataGridView();
            btnSearch = new Button();
            cbKindSearch = new ComboBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataPatientTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(409, 46);
            label1.TabIndex = 3;
            label1.Text = "Danh sách bệnh nhân";
            // 
            // dataPatientTable
            // 
            dataPatientTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataPatientTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataPatientTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataPatientTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataPatientTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataPatientTable.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataPatientTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataPatientTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataPatientTable.DefaultCellStyle = dataGridViewCellStyle3;
            dataPatientTable.Location = new Point(20, 146);
            dataPatientTable.Margin = new Padding(3, 4, 3, 4);
            dataPatientTable.Name = "dataPatientTable";
            dataPatientTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataPatientTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataPatientTable.RowHeadersWidth = 51;
            dataPatientTable.RowTemplate.Height = 24;
            dataPatientTable.Size = new Size(1066, 469);
            dataPatientTable.TabIndex = 8;
            dataPatientTable.MouseClick += dataPatientTable_MouseClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(219, 175, 9);
            btnSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(560, 83);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(67, 55);
            btnSearch.TabIndex = 11;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbKindSearch
            // 
            cbKindSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKindSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKindSearch.FormattingEnabled = true;
            cbKindSearch.Items.AddRange(new object[] { "Mã bệnh nhân", "Tên bệnh nhân" });
            cbKindSearch.Location = new Point(20, 92);
            cbKindSearch.Margin = new Padding(3, 4, 3, 4);
            cbKindSearch.Name = "cbKindSearch";
            cbKindSearch.Size = new Size(258, 39);
            cbKindSearch.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(284, 92);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(270, 38);
            txtSearch.TabIndex = 9;
            // 
            // PatientFileCopy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 629);
            Controls.Add(btnSearch);
            Controls.Add(cbKindSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataPatientTable);
            Controls.Add(label1);
            Name = "PatientFileCopy";
            Text = "PatientFileCopy";
            Load += PatientFileCopy_Load;
            ((System.ComponentModel.ISupportInitialize)dataPatientTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataPatientTable;
        private Button btnSearch;
        private ComboBox cbKindSearch;
        private TextBox txtSearch;
    }
}