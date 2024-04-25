namespace N19_DentalClinic.GUI.AdminView
{
    partial class ManageMaterial
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMaterial));
            dataMaterial = new DataGridView();
            btnAddMaterial = new Button();
            btnSearch = new component.RJButton();
            tbSearch = new TextBox();
            label6 = new Label();
            btnFixedMaterial = new component.RJButton();
            btnConsumableMaterial = new component.RJButton();
            btnMedicine = new component.RJButton();
            cbKindSearch = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataMaterial).BeginInit();
            SuspendLayout();
            // 
            // dataMaterial
            // 
            dataMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataMaterial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataMaterial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataMaterial.BackgroundColor = Color.White;
            dataMaterial.BorderStyle = BorderStyle.None;
            dataMaterial.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(4);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataMaterial.DefaultCellStyle = dataGridViewCellStyle5;
            dataMaterial.GridColor = Color.White;
            dataMaterial.Location = new Point(9, 167);
            dataMaterial.Name = "dataMaterial";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new Padding(4);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataMaterial.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataMaterial.RowHeadersWidth = 51;
            dataMaterial.Size = new Size(1186, 623);
            dataMaterial.TabIndex = 117;
            dataMaterial.MouseClick += dataMaterial_MouseClick;
            // 
            // btnAddMaterial
            // 
            btnAddMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddMaterial.BackColor = Color.FromArgb(18, 219, 78);
            btnAddMaterial.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddMaterial.Image = (Image)resources.GetObject("btnAddMaterial.Image");
            btnAddMaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMaterial.Location = new Point(957, 64);
            btnAddMaterial.Margin = new Padding(3, 4, 3, 4);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Padding = new Padding(6, 0, 6, 0);
            btnAddMaterial.Size = new Size(238, 57);
            btnAddMaterial.TabIndex = 116;
            btnAddMaterial.Text = "Thêm vật liệu";
            btnAddMaterial.TextAlign = ContentAlignment.MiddleRight;
            btnAddMaterial.UseVisualStyleBackColor = false;
            btnAddMaterial.Click += btnAddMaterial_Click;
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
            btnSearch.Location = new Point(575, 61);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(60, 52);
            btnSearch.TabIndex = 115;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(276, 64);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm vật liệu";
            tbSearch.Size = new Size(293, 43);
            tbSearch.TabIndex = 114;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 11);
            label6.Name = "label6";
            label6.Size = new Size(293, 46);
            label6.TabIndex = 113;
            label6.Text = "Quản lý vật liệu";
            // 
            // btnFixedMaterial
            // 
            btnFixedMaterial.BackColor = Color.FromArgb(219, 175, 9);
            btnFixedMaterial.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnFixedMaterial.BorderColor = Color.PaleVioletRed;
            btnFixedMaterial.BorderRadius = 5;
            btnFixedMaterial.BorderSize = 0;
            btnFixedMaterial.FlatAppearance.BorderSize = 0;
            btnFixedMaterial.FlatStyle = FlatStyle.Flat;
            btnFixedMaterial.ForeColor = Color.White;
            btnFixedMaterial.Location = new Point(11, 123);
            btnFixedMaterial.Name = "btnFixedMaterial";
            btnFixedMaterial.Size = new Size(106, 38);
            btnFixedMaterial.TabIndex = 119;
            btnFixedMaterial.Text = "Cố định";
            btnFixedMaterial.TextColor = Color.White;
            btnFixedMaterial.UseVisualStyleBackColor = false;
            btnFixedMaterial.Click += btnFixedMaterial_Click;
            // 
            // btnConsumableMaterial
            // 
            btnConsumableMaterial.BackColor = Color.FromArgb(219, 175, 9);
            btnConsumableMaterial.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnConsumableMaterial.BorderColor = Color.PaleVioletRed;
            btnConsumableMaterial.BorderRadius = 5;
            btnConsumableMaterial.BorderSize = 0;
            btnConsumableMaterial.FlatAppearance.BorderSize = 0;
            btnConsumableMaterial.FlatStyle = FlatStyle.Flat;
            btnConsumableMaterial.ForeColor = Color.White;
            btnConsumableMaterial.Location = new Point(156, 123);
            btnConsumableMaterial.Name = "btnConsumableMaterial";
            btnConsumableMaterial.Size = new Size(109, 38);
            btnConsumableMaterial.TabIndex = 120;
            btnConsumableMaterial.Text = "Tiêu hao";
            btnConsumableMaterial.TextColor = Color.White;
            btnConsumableMaterial.UseVisualStyleBackColor = false;
            btnConsumableMaterial.Click += btnConsumableMaterial_Click;
            // 
            // btnMedicine
            // 
            btnMedicine.BackColor = Color.FromArgb(219, 175, 9);
            btnMedicine.BackgroundColor = Color.FromArgb(219, 175, 9);
            btnMedicine.BorderColor = Color.PaleVioletRed;
            btnMedicine.BorderRadius = 5;
            btnMedicine.BorderSize = 0;
            btnMedicine.FlatAppearance.BorderSize = 0;
            btnMedicine.FlatStyle = FlatStyle.Flat;
            btnMedicine.ForeColor = Color.White;
            btnMedicine.Location = new Point(292, 123);
            btnMedicine.Name = "btnMedicine";
            btnMedicine.Size = new Size(109, 38);
            btnMedicine.TabIndex = 121;
            btnMedicine.Text = "Thuốc";
            btnMedicine.TextColor = Color.White;
            btnMedicine.UseVisualStyleBackColor = false;
            btnMedicine.Click += btnMedicine_Click;
            // 
            // cbKindSearch
            // 
            cbKindSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKindSearch.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbKindSearch.FormattingEnabled = true;
            cbKindSearch.Items.AddRange(new object[] { "Mã vật liệu", "Tên vật liệu" });
            cbKindSearch.Location = new Point(14, 68);
            cbKindSearch.Margin = new Padding(3, 4, 3, 4);
            cbKindSearch.Name = "cbKindSearch";
            cbKindSearch.Size = new Size(256, 39);
            cbKindSearch.TabIndex = 122;
            // 
            // ManageMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 800);
            Controls.Add(cbKindSearch);
            Controls.Add(btnMedicine);
            Controls.Add(btnConsumableMaterial);
            Controls.Add(btnFixedMaterial);
            Controls.Add(dataMaterial);
            Controls.Add(btnAddMaterial);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageMaterial";
            Text = "ManageMaterial";
            Load += ManageMaterial_Load;
            ((System.ComponentModel.ISupportInitialize)dataMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataMaterial;
        private Button btnAddMaterial;
        private component.RJButton btnSearch;
        private TextBox tbSearch;
        private Label label6;
        private component.RJButton btnFixedMaterial;
        private component.RJButton btnConsumableMaterial;
        private component.RJButton btnMedicine;
        private ComboBox cbKindSearch;
    }
}