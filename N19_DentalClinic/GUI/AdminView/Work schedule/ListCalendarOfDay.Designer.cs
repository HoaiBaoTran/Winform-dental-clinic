namespace N19_DentalClinic.GUI.AdminView
{
    partial class ListCalendarOfDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCalendarOfDay));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            dataCalendarEmployee = new DataGridView();
            button3 = new Button();
            txtCurrDate = new TextBox();
            btnToday = new Button();
            btnTommorow = new Button();
            btnYesterday = new Button();
            txtNameEmploy = new TextBox();
            label8 = new Label();
            txtEmplyID = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataCalendarEmployee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(251, 46);
            label1.TabIndex = 4;
            label1.Text = "Lịch làm việc";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(80, 101, 122);
            btnBack.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(1137, 16);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(dataCalendarEmployee);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txtCurrDate);
            groupBox1.Controls.Add(btnToday);
            groupBox1.Controls.Add(btnTommorow);
            groupBox1.Controls.Add(btnYesterday);
            groupBox1.Controls.Add(txtNameEmploy);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtEmplyID);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(18, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1269, 628);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // dataCalendarEmployee
            // 
            dataCalendarEmployee.AllowUserToAddRows = false;
            dataCalendarEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataCalendarEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataCalendarEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataCalendarEmployee.BackgroundColor = Color.White;
            dataCalendarEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataCalendarEmployee.DefaultCellStyle = dataGridViewCellStyle1;
            dataCalendarEmployee.Location = new Point(11, 199);
            dataCalendarEmployee.Margin = new Padding(3, 4, 3, 4);
            dataCalendarEmployee.Name = "dataCalendarEmployee";
            dataCalendarEmployee.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataCalendarEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataCalendarEmployee.RowHeadersWidth = 51;
            dataCalendarEmployee.RowTemplate.Height = 24;
            dataCalendarEmployee.Size = new Size(1243, 421);
            dataCalendarEmployee.TabIndex = 22;
            dataCalendarEmployee.MouseClick += dataCalendarEmployee_MouseClick;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(1047, 119);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(4, 0, 4, 0);
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(207, 58);
            button3.TabIndex = 21;
            button3.Text = "Chọn Ngày";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtCurrDate
            // 
            txtCurrDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCurrDate.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrDate.Location = new Point(771, 137);
            txtCurrDate.Margin = new Padding(3, 4, 3, 4);
            txtCurrDate.Name = "txtCurrDate";
            txtCurrDate.ReadOnly = true;
            txtCurrDate.Size = new Size(210, 38);
            txtCurrDate.TabIndex = 20;
            txtCurrDate.TextChanged += txtCurrDate_TextChanged;
            // 
            // btnToday
            // 
            btnToday.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToday.Location = new Point(170, 118);
            btnToday.Margin = new Padding(3, 4, 3, 4);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(146, 61);
            btnToday.TabIndex = 19;
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
            btnTommorow.TabIndex = 18;
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
            btnYesterday.TabIndex = 17;
            btnYesterday.UseVisualStyleBackColor = false;
            btnYesterday.Click += btnYesterday_Click;
            // 
            // txtNameEmploy
            // 
            txtNameEmploy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNameEmploy.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameEmploy.Location = new Point(821, 48);
            txtNameEmploy.Margin = new Padding(3, 4, 3, 4);
            txtNameEmploy.Name = "txtNameEmploy";
            txtNameEmploy.ReadOnly = true;
            txtNameEmploy.Size = new Size(433, 34);
            txtNameEmploy.TabIndex = 16;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(654, 51);
            label8.Name = "label8";
            label8.Size = new Size(145, 29);
            label8.TabIndex = 15;
            label8.Text = "Tên nhân sự";
            // 
            // txtEmplyID
            // 
            txtEmplyID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmplyID.Location = new Point(144, 48);
            txtEmplyID.Margin = new Padding(3, 4, 3, 4);
            txtEmplyID.Name = "txtEmplyID";
            txtEmplyID.ReadOnly = true;
            txtEmplyID.Size = new Size(461, 34);
            txtEmplyID.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 51);
            label3.Name = "label3";
            label3.Size = new Size(135, 29);
            label3.TabIndex = 3;
            label3.Text = "Mã nhân sự";
            // 
            // ListCalendarOfDay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 731);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListCalendarOfDay";
            Text = "ListCalendarOfDay";
            Load += ListCalendarOfDay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataCalendarEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtEmplyID;
        private Label label8;
        private TextBox txtNameEmploy;
        private Button btnYesterday;
        private Button btnTommorow;
        private Button btnToday;
        private TextBox txtCurrDate;
        private Button button3;
        private DataGridView dataCalendarEmployee;
    }
}