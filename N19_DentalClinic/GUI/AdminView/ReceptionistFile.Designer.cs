namespace N19_DentalClinic.GUI.AdminView
{
    partial class ReceptionistFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistFile));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnCreateReptionist = new Button();
            cbKindSearch = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dataReceptionistTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataReceptionistTable).BeginInit();
            SuspendLayout();
            // 
            // btnCreateReptionist
            // 
            btnCreateReptionist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateReptionist.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateReptionist.Image = (Image)resources.GetObject("btnCreateReptionist.Image");
            btnCreateReptionist.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateReptionist.Location = new Point(1211, 76);
            btnCreateReptionist.Margin = new Padding(3, 4, 3, 4);
            btnCreateReptionist.Name = "btnCreateReptionist";
            btnCreateReptionist.Padding = new Padding(6, 0, 6, 0);
            btnCreateReptionist.Size = new Size(218, 66);
            btnCreateReptionist.TabIndex = 21;
            btnCreateReptionist.Text = "Thêm lễ tân";
            btnCreateReptionist.TextAlign = ContentAlignment.MiddleRight;
            btnCreateReptionist.UseVisualStyleBackColor = true;
            btnCreateReptionist.Click += btnCreateReptionist_Click;
            // 
            // cbKindSearch
            // 
            cbKindSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKindSearch.FormattingEnabled = true;
            cbKindSearch.Items.AddRange(new object[] { "Mã lễ tân", "Tên lễ tân" });
            cbKindSearch.Location = new Point(317, 91);
            cbKindSearch.Margin = new Padding(3, 4, 3, 4);
            cbKindSearch.Name = "cbKindSearch";
            cbKindSearch.Size = new Size(212, 39);
            cbKindSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(559, 82);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 55);
            btnSearch.TabIndex = 19;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(54, 92);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(235, 38);
            txtSearch.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(54, 20);
            label1.Name = "label1";
            label1.Size = new Size(319, 46);
            label1.TabIndex = 17;
            label1.Text = "Danh sách lễ tân";
            // 
            // dataReceptionistTable
            // 
            dataReceptionistTable.AllowUserToAddRows = false;
            dataReceptionistTable.AllowUserToDeleteRows = false;
            dataReceptionistTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataReceptionistTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataReceptionistTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataReceptionistTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataReceptionistTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataReceptionistTable.DefaultCellStyle = dataGridViewCellStyle2;
            dataReceptionistTable.Location = new Point(54, 171);
            dataReceptionistTable.Margin = new Padding(3, 4, 3, 4);
            dataReceptionistTable.Name = "dataReceptionistTable";
            dataReceptionistTable.ReadOnly = true;
            dataReceptionistTable.RowHeadersWidth = 51;
            dataReceptionistTable.RowTemplate.Height = 24;
            dataReceptionistTable.Size = new Size(1375, 667);
            dataReceptionistTable.TabIndex = 16;
            dataReceptionistTable.CellContentClick += dataReceptionistTable_CellContentClick;
            dataReceptionistTable.MouseClick += dataReceptionistTable_MouseClick;
            // 
            // ReceptionistFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 850);
            Controls.Add(btnCreateReptionist);
            Controls.Add(cbKindSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dataReceptionistTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReceptionistFile";
            Text = "ReceptionistFile";
            Load += ReceptionistFile_Load;
            ((System.ComponentModel.ISupportInitialize)dataReceptionistTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateReptionist;
        private ComboBox cbKindSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dataReceptionistTable;
    }
}