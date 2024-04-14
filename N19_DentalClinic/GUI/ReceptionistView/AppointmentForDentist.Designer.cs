namespace N19_DentalClinic.GUI
{
    partial class AppointmentForDentist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForDentist));
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataAppointmentDentist = new DataGridView();
            button3 = new Button();
            txtCurrDate = new TextBox();
            btnToday = new Button();
            btnTommorow = new Button();
            btnYesterday = new Button();
            txtNameDentist = new TextBox();
            label8 = new Label();
            txtDenID = new TextBox();
            label3 = new Label();
            btnBack = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataAppointmentDentist).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(171, 46);
            label1.TabIndex = 3;
            label1.Text = "Lịch hẹn";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataAppointmentDentist);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txtCurrDate);
            groupBox1.Controls.Add(btnToday);
            groupBox1.Controls.Add(btnTommorow);
            groupBox1.Controls.Add(btnYesterday);
            groupBox1.Controls.Add(txtNameDentist);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtDenID);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(20, 89);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1269, 628);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataAppointmentDentist
            // 
            dataAppointmentDentist.AllowUserToAddRows = false;
            dataAppointmentDentist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataAppointmentDentist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAppointmentDentist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataAppointmentDentist.BackgroundColor = Color.White;
            dataAppointmentDentist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataAppointmentDentist.DefaultCellStyle = dataGridViewCellStyle1;
            dataAppointmentDentist.Location = new Point(11, 199);
            dataAppointmentDentist.Margin = new Padding(3, 4, 3, 4);
            dataAppointmentDentist.Name = "dataAppointmentDentist";
            dataAppointmentDentist.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataAppointmentDentist.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataAppointmentDentist.RowHeadersWidth = 51;
            dataAppointmentDentist.RowTemplate.Height = 24;
            dataAppointmentDentist.Size = new Size(1243, 421);
            dataAppointmentDentist.TabIndex = 21;
            dataAppointmentDentist.CellFormatting += dataAppointmentDentist_CellFormatting;
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
            button3.TabIndex = 20;
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
            btnTommorow.Click += button2_Click;
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
            btnYesterday.Click += button1_Click;
            // 
            // txtNameDentist
            // 
            txtNameDentist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNameDentist.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameDentist.Location = new Point(821, 48);
            txtNameDentist.Margin = new Padding(3, 4, 3, 4);
            txtNameDentist.Name = "txtNameDentist";
            txtNameDentist.ReadOnly = true;
            txtNameDentist.Size = new Size(433, 34);
            txtNameDentist.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(654, 51);
            label8.Name = "label8";
            label8.Size = new Size(125, 29);
            label8.TabIndex = 14;
            label8.Text = "Tên nha sĩ";
            // 
            // txtDenID
            // 
            txtDenID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDenID.Location = new Point(144, 48);
            txtDenID.Margin = new Padding(3, 4, 3, 4);
            txtDenID.Name = "txtDenID";
            txtDenID.ReadOnly = true;
            txtDenID.Size = new Size(461, 34);
            txtDenID.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 51);
            label3.Name = "label3";
            label3.Size = new Size(115, 29);
            label3.TabIndex = 2;
            label3.Text = "Mã nha sĩ";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(80, 101, 122);
            btnBack.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(1124, 13);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Padding = new Padding(6, 0, 6, 0);
            btnBack.Size = new Size(150, 54);
            btnBack.TabIndex = 27;
            btnBack.Text = "Trở lại";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AppointmentForDentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 731);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AppointmentForDentist";
            Text = "AppointmentForDentist";
            Load += AppointmentForDentist_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataAppointmentDentist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDenID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNameDentist;
        private System.Windows.Forms.Button btnTommorow;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCurrDate;
        private System.Windows.Forms.DataGridView dataAppointmentDentist;
        private Button btnBack;
    }
}
