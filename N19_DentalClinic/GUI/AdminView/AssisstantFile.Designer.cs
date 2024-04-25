namespace N19_DentalClinic.GUI.AdminView
{
    partial class AssisstantFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssisstantFile));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnCreateDentist = new Button();
            cbKindSearch = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dataAssisstantTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataAssisstantTable).BeginInit();
            SuspendLayout();
            // 
            // btnCreateDentist
            // 
            btnCreateDentist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateDentist.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateDentist.Image = (Image)resources.GetObject("btnCreateDentist.Image");
            btnCreateDentist.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateDentist.Location = new Point(1205, 81);
            btnCreateDentist.Margin = new Padding(3, 4, 3, 4);
            btnCreateDentist.Name = "btnCreateDentist";
            btnCreateDentist.Padding = new Padding(6, 0, 6, 0);
            btnCreateDentist.Size = new Size(224, 66);
            btnCreateDentist.TabIndex = 15;
            btnCreateDentist.Text = "Thêm phụ tá";
            btnCreateDentist.TextAlign = ContentAlignment.MiddleRight;
            btnCreateDentist.UseVisualStyleBackColor = true;
            btnCreateDentist.Click += btnCreateDentist_Click;
            // 
            // cbKindSearch
            // 
            cbKindSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKindSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKindSearch.FormattingEnabled = true;
            cbKindSearch.Items.AddRange(new object[] { "Mã phụ tá", "Tên phụ tá" });
            cbKindSearch.Location = new Point(54, 96);
            cbKindSearch.Margin = new Padding(3, 4, 3, 4);
            cbKindSearch.Name = "cbKindSearch";
            cbKindSearch.Size = new Size(263, 39);
            cbKindSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(219, 175, 9);
            btnSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(628, 87);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(66, 55);
            btnSearch.TabIndex = 13;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(323, 96);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm phụ tá";
            txtSearch.Size = new Size(289, 38);
            txtSearch.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(54, 21);
            label1.Name = "label1";
            label1.Size = new Size(332, 46);
            label1.TabIndex = 11;
            label1.Text = "Danh sách phụ tá";
            // 
            // dataAssisstantTable
            // 
            dataAssisstantTable.AllowUserToAddRows = false;
            dataAssisstantTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataAssisstantTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAssisstantTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataAssisstantTable.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataAssisstantTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataAssisstantTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataAssisstantTable.DefaultCellStyle = dataGridViewCellStyle2;
            dataAssisstantTable.Location = new Point(54, 171);
            dataAssisstantTable.Margin = new Padding(3, 4, 3, 4);
            dataAssisstantTable.Name = "dataAssisstantTable";
            dataAssisstantTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataAssisstantTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataAssisstantTable.RowHeadersWidth = 51;
            dataAssisstantTable.RowTemplate.Height = 24;
            dataAssisstantTable.Size = new Size(1375, 667);
            dataAssisstantTable.TabIndex = 10;
            dataAssisstantTable.MouseClick += dataAssisstantTable_MouseClick;
            // 
            // AssisstantFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 850);
            Controls.Add(btnCreateDentist);
            Controls.Add(cbKindSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dataAssisstantTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AssisstantFile";
            Text = "AssisstantFile";
            Load += AssisstantFile_Load;
            ((System.ComponentModel.ISupportInitialize)dataAssisstantTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateDentist;
        private ComboBox cbKindSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dataAssisstantTable;
    }
}