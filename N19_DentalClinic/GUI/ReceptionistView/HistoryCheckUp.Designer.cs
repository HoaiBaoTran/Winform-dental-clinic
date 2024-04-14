namespace N19_DentalClinic.GUI
{
    partial class HistoryCheckUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryCheckUp));
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataAppointPatient = new DataGridView();
            btnChooseDay = new Button();
            txtCurrDate = new TextBox();
            btnToday = new Button();
            btnTommorow = new Button();
            btnYesterday = new Button();
            txtNamePat = new TextBox();
            label8 = new Label();
            txtPatID = new TextBox();
            label3 = new Label();
            btnBack = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataAppointPatient).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(255, 46);
            label1.TabIndex = 4;
            label1.Text = "Lịch sử khám";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataAppointPatient);
            groupBox1.Controls.Add(btnChooseDay);
            groupBox1.Controls.Add(txtCurrDate);
            groupBox1.Controls.Add(btnToday);
            groupBox1.Controls.Add(btnTommorow);
            groupBox1.Controls.Add(btnYesterday);
            groupBox1.Controls.Add(txtNamePat);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPatID);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(20, 89);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1252, 628);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // dataAppointPatient
            // 
            dataAppointPatient.AllowUserToAddRows = false;
            dataAppointPatient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataAppointPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAppointPatient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataAppointPatient.BackgroundColor = Color.White;
            dataAppointPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAppointPatient.Location = new Point(11, 199);
            dataAppointPatient.Margin = new Padding(3, 4, 3, 4);
            dataAppointPatient.Name = "dataAppointPatient";
            dataAppointPatient.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataAppointPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataAppointPatient.RowHeadersWidth = 51;
            dataAppointPatient.RowTemplate.Height = 24;
            dataAppointPatient.Size = new Size(1226, 421);
            dataAppointPatient.TabIndex = 21;
            dataAppointPatient.CellFormatting += dataAppointPatient_CellFormatting;
            // 
            // btnChooseDay
            // 
            btnChooseDay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChooseDay.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChooseDay.Image = (Image)resources.GetObject("btnChooseDay.Image");
            btnChooseDay.ImageAlign = ContentAlignment.MiddleRight;
            btnChooseDay.Location = new Point(1030, 128);
            btnChooseDay.Margin = new Padding(3, 4, 3, 4);
            btnChooseDay.Name = "btnChooseDay";
            btnChooseDay.Padding = new Padding(4, 0, 4, 0);
            btnChooseDay.RightToLeft = RightToLeft.No;
            btnChooseDay.Size = new Size(207, 58);
            btnChooseDay.TabIndex = 20;
            btnChooseDay.Text = "Chọn Ngày";
            btnChooseDay.TextAlign = ContentAlignment.MiddleLeft;
            btnChooseDay.UseVisualStyleBackColor = true;
            btnChooseDay.Click += btnChooseDay_Click;
            // 
            // txtCurrDate
            // 
            txtCurrDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCurrDate.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrDate.Location = new Point(790, 131);
            txtCurrDate.Margin = new Padding(3, 4, 3, 4);
            txtCurrDate.Name = "txtCurrDate";
            txtCurrDate.ReadOnly = true;
            txtCurrDate.Size = new Size(210, 38);
            txtCurrDate.TabIndex = 19;
            txtCurrDate.TextChanged += txtCurrDate_TextChanged;
            // 
            // btnToday
            // 
            btnToday.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToday.Location = new Point(170, 118);
            btnToday.Margin = new Padding(3, 4, 3, 4);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(146, 61);
            btnToday.TabIndex = 18;
            btnToday.Text = "Hôm nay";
            btnToday.UseVisualStyleBackColor = true;
            btnToday.Click += btnToday_Click;
            // 
            // btnTommorow
            // 
            btnTommorow.BackColor = Color.White;
            btnTommorow.BackgroundImage = (Image)resources.GetObject("btnTommorow.BackgroundImage");
            btnTommorow.BackgroundImageLayout = ImageLayout.Center;
            btnTommorow.ForeColor = Color.Black;
            btnTommorow.Location = new Point(89, 118);
            btnTommorow.Margin = new Padding(3, 4, 3, 4);
            btnTommorow.Name = "btnTommorow";
            btnTommorow.Size = new Size(58, 61);
            btnTommorow.TabIndex = 17;
            btnTommorow.UseVisualStyleBackColor = false;
            btnTommorow.Click += btnTommorow_Click;
            // 
            // btnYesterday
            // 
            btnYesterday.BackColor = Color.White;
            btnYesterday.BackgroundImage = (Image)resources.GetObject("btnYesterday.BackgroundImage");
            btnYesterday.BackgroundImageLayout = ImageLayout.Center;
            btnYesterday.ForeColor = Color.Black;
            btnYesterday.Location = new Point(11, 118);
            btnYesterday.Margin = new Padding(3, 4, 3, 4);
            btnYesterday.Name = "btnYesterday";
            btnYesterday.Size = new Size(58, 61);
            btnYesterday.TabIndex = 16;
            btnYesterday.UseVisualStyleBackColor = false;
            btnYesterday.Click += btnYesterday_Click;
            // 
            // txtNamePat
            // 
            txtNamePat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNamePat.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamePat.Location = new Point(825, 48);
            txtNamePat.Margin = new Padding(3, 4, 3, 4);
            txtNamePat.Name = "txtNamePat";
            txtNamePat.ReadOnly = true;
            txtNamePat.Size = new Size(412, 34);
            txtNamePat.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(645, 51);
            label8.Name = "label8";
            label8.Size = new Size(174, 29);
            label8.TabIndex = 14;
            label8.Text = "Tên bệnh nhân";
            // 
            // txtPatID
            // 
            txtPatID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPatID.Location = new Point(176, 48);
            txtPatID.Margin = new Padding(3, 4, 3, 4);
            txtPatID.Name = "txtPatID";
            txtPatID.ReadOnly = true;
            txtPatID.Size = new Size(429, 34);
            txtPatID.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 51);
            label3.Name = "label3";
            label3.Size = new Size(164, 29);
            label3.TabIndex = 2;
            label3.Text = "Mã bệnh nhân";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(80, 101, 122);
            btnBack.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(1122, 27);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Padding = new Padding(6, 0, 6, 0);
            btnBack.Size = new Size(150, 54);
            btnBack.TabIndex = 28;
            btnBack.Text = "Trở lại";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // HistoryCheckUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 731);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HistoryCheckUp";
            Text = "HistoryCheckUp";
            Load += HistoryCheckUp_Load;
            Resize += HistoryCheckUp_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataAppointPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataAppointPatient;
        private System.Windows.Forms.Button btnChooseDay;
        private System.Windows.Forms.TextBox txtCurrDate;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnTommorow;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.TextBox txtNamePat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPatID;
        private System.Windows.Forms.Label label3;
        private Button btnBack;
    }
}