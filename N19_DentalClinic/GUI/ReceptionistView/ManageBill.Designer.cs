namespace N19_DentalClinic.GUI.ReceptionistView
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
            dataGridView = new DataGridView();
            billIdCol = new DataGridViewTextBoxColumn();
            dateCol = new DataGridViewTextBoxColumn();
            paymentTimeCol = new DataGridViewTextBoxColumn();
            totalPriceCol = new DataGridViewTextBoxColumn();
            patientIdCol = new DataGridViewTextBoxColumn();
            patientNameCol = new DataGridViewTextBoxColumn();
            serviceAndMedicine = new DataGridViewTextBoxColumn();
            roundPictureBox3 = new component.RoundPictureBox();
            btnReload = new component.RJButton();
            roundPictureBox2 = new component.RoundPictureBox();
            btnAddDentist = new component.RJButton();
            btnSearch = new component.RJButton();
            tbSearch = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { billIdCol, dateCol, paymentTimeCol, totalPriceCol, patientIdCol, patientNameCol, serviceAndMedicine });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(49, 160);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1340, 553);
            dataGridView.TabIndex = 33;
            // 
            // billIdCol
            // 
            billIdCol.HeaderText = "Mã hóa đơn";
            billIdCol.MinimumWidth = 6;
            billIdCol.Name = "billIdCol";
            billIdCol.Width = 150;
            // 
            // dateCol
            // 
            dateCol.HeaderText = "Ngày lập";
            dateCol.MinimumWidth = 6;
            dateCol.Name = "dateCol";
            dateCol.Width = 150;
            // 
            // paymentTimeCol
            // 
            paymentTimeCol.HeaderText = "Thời gian thanh toán";
            paymentTimeCol.MinimumWidth = 6;
            paymentTimeCol.Name = "paymentTimeCol";
            paymentTimeCol.Width = 200;
            // 
            // totalPriceCol
            // 
            totalPriceCol.HeaderText = "Tổng tiền";
            totalPriceCol.MinimumWidth = 6;
            totalPriceCol.Name = "totalPriceCol";
            totalPriceCol.Width = 175;
            // 
            // patientIdCol
            // 
            patientIdCol.HeaderText = "Mã bệnh nhân";
            patientIdCol.MinimumWidth = 6;
            patientIdCol.Name = "patientIdCol";
            patientIdCol.Width = 175;
            // 
            // patientNameCol
            // 
            patientNameCol.HeaderText = "Tên bệnh nhân";
            patientNameCol.MinimumWidth = 6;
            patientNameCol.Name = "patientNameCol";
            patientNameCol.Width = 250;
            // 
            // serviceAndMedicine
            // 
            serviceAndMedicine.HeaderText = "Dịch vụ và đơn thuốc";
            serviceAndMedicine.MinimumWidth = 6;
            serviceAndMedicine.Name = "serviceAndMedicine";
            serviceAndMedicine.Width = 150;
            // 
            // roundPictureBox3
            // 
            roundPictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundPictureBox3.BackColor = Color.FromArgb(219, 175, 9);
            roundPictureBox3.BackgroundImage = Properties.Resources.reload_icon;
            roundPictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox3.Location = new Point(1282, 59);
            roundPictureBox3.Name = "roundPictureBox3";
            roundPictureBox3.Size = new Size(39, 41);
            roundPictureBox3.TabIndex = 32;
            roundPictureBox3.TabStop = false;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReload.BackColor = Color.FromArgb(50, 56, 134);
            btnReload.BackgroundColor = Color.FromArgb(50, 56, 134);
            btnReload.BackgroundImageLayout = ImageLayout.Zoom;
            btnReload.BorderColor = Color.PaleVioletRed;
            btnReload.BorderRadius = 5;
            btnReload.BorderSize = 0;
            btnReload.FlatAppearance.BorderSize = 0;
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.Font = new Font("Segoe UI", 11F);
            btnReload.ForeColor = Color.White;
            btnReload.ImageAlign = ContentAlignment.MiddleLeft;
            btnReload.Location = new Point(1272, 52);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(117, 56);
            btnReload.TabIndex = 31;
            btnReload.Text = "Tải lại";
            btnReload.TextAlign = ContentAlignment.MiddleRight;
            btnReload.TextColor = Color.White;
            btnReload.UseVisualStyleBackColor = false;
            // 
            // roundPictureBox2
            // 
            roundPictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundPictureBox2.BackColor = Color.FromArgb(56, 92, 67);
            roundPictureBox2.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(1091, 57);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(39, 41);
            roundPictureBox2.TabIndex = 30;
            roundPictureBox2.TabStop = false;
            // 
            // btnAddDentist
            // 
            btnAddDentist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddDentist.BackColor = Color.FromArgb(18, 219, 78);
            btnAddDentist.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnAddDentist.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddDentist.BorderColor = Color.PaleVioletRed;
            btnAddDentist.BorderRadius = 5;
            btnAddDentist.BorderSize = 0;
            btnAddDentist.FlatAppearance.BorderSize = 0;
            btnAddDentist.FlatStyle = FlatStyle.Flat;
            btnAddDentist.Font = new Font("Segoe UI", 11F);
            btnAddDentist.ForeColor = Color.Black;
            btnAddDentist.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddDentist.Location = new Point(1084, 51);
            btnAddDentist.Name = "btnAddDentist";
            btnAddDentist.Size = new Size(182, 56);
            btnAddDentist.TabIndex = 29;
            btnAddDentist.Text = "Thêm hóa đơn";
            btnAddDentist.TextAlign = ContentAlignment.MiddleRight;
            btnAddDentist.TextColor = Color.Black;
            btnAddDentist.UseVisualStyleBackColor = false;
            btnAddDentist.Click += btnAddDentist_Click;
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
            btnSearch.Location = new Point(311, 84);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 48);
            btnSearch.TabIndex = 28;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.Location = new Point(12, 84);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm hóa đơn";
            tbSearch.Size = new Size(293, 34);
            tbSearch.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 27);
            label6.Name = "label6";
            label6.Size = new Size(285, 41);
            label6.TabIndex = 26;
            label6.Text = "Danh sách hóa đơn";
            // 
            // ManageBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 753);
            Controls.Add(dataGridView);
            Controls.Add(roundPictureBox3);
            Controls.Add(btnReload);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnAddDentist);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageBill";
            Text = "ManageBill";
            Load += ManageBill_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private component.RoundPictureBox roundPictureBox3;
        private component.RJButton btnReload;
        private component.RoundPictureBox roundPictureBox2;
        private component.RJButton btnAddDentist;
        private component.RJButton btnSearch;
        private TextBox tbSearch;
        private Label label6;
        private DataGridViewTextBoxColumn billIdCol;
        private DataGridViewTextBoxColumn dateCol;
        private DataGridViewTextBoxColumn paymentTimeCol;
        private DataGridViewTextBoxColumn totalPriceCol;
        private DataGridViewTextBoxColumn patientIdCol;
        private DataGridViewTextBoxColumn patientNameCol;
        private DataGridViewTextBoxColumn serviceAndMedicine;
    }
}