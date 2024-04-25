namespace N19_DentalClinic.GUI.Work_schedule
{
    partial class MainSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSchedule));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            daycontainer = new FlowLayoutPanel();
            btnAdd = new Button();
            nowWeek = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dateFrom = new DateTimePicker();
            dateTo = new DateTimePicker();
            btnYesterday = new Button();
            btnTommorow = new Button();
            button1 = new Button();
            btnBack = new Button();
            label11 = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(1143, 162);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 3;
            label1.Text = "Chủ nhật";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(41, 162);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 4;
            label2.Text = "Thứ 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(250, 162);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 5;
            label3.Text = "Thứ 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(431, 162);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 6;
            label4.Text = "Thứ 4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(612, 162);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 7;
            label5.Text = "Thứ 5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(784, 162);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 8;
            label6.Text = "Thứ 6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(973, 162);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 9;
            label7.Text = "Thứ 7";
            // 
            // daycontainer
            // 
            daycontainer.BorderStyle = BorderStyle.FixedSingle;
            daycontainer.Location = new Point(10, 198);
            daycontainer.Margin = new Padding(0);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1277, 700);
            daycontainer.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(18, 219, 78);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(873, 79);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(6, 0, 6, 0);
            btnAdd.Size = new Size(131, 62);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // nowWeek
            // 
            nowWeek.BackColor = Color.FromArgb(7, 127, 250);
            nowWeek.FlatStyle = FlatStyle.Flat;
            nowWeek.Font = new Font("Microsoft Sans Serif", 12F);
            nowWeek.Location = new Point(1023, 80);
            nowWeek.Margin = new Padding(0);
            nowWeek.Name = "nowWeek";
            nowWeek.Size = new Size(126, 62);
            nowWeek.TabIndex = 17;
            nowWeek.Text = "Tuần này";
            nowWeek.UseVisualStyleBackColor = false;
            nowWeek.Click += nowWeek_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 23);
            label8.Name = "label8";
            label8.Size = new Size(227, 39);
            label8.TabIndex = 20;
            label8.Text = "Lịch làm việc";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(700, 18);
            label9.Name = "label9";
            label9.Size = new Size(42, 25);
            label9.TabIndex = 21;
            label9.Text = "Từ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.Location = new Point(928, 18);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 22;
            label10.Text = "Đến:";
            // 
            // dateFrom
            // 
            dateFrom.CalendarFont = new Font("Cambria Math", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateFrom.CustomFormat = "dd/MM/yyyy";
            dateFrom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateFrom.Format = DateTimePickerFormat.Custom;
            dateFrom.Location = new Point(748, 15);
            dateFrom.Margin = new Padding(3, 4, 3, 4);
            dateFrom.Name = "dateFrom";
            dateFrom.Size = new Size(154, 30);
            dateFrom.TabIndex = 23;
            dateFrom.ValueChanged += dateFrom_ValueChanged;
            // 
            // dateTo
            // 
            dateTo.CalendarFont = new Font("Cambria Math", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTo.CustomFormat = "dd/MM/yyyy";
            dateTo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTo.Format = DateTimePickerFormat.Custom;
            dateTo.Location = new Point(988, 15);
            dateTo.Margin = new Padding(3, 4, 3, 4);
            dateTo.Name = "dateTo";
            dateTo.Size = new Size(151, 30);
            dateTo.TabIndex = 24;
            dateTo.ValueChanged += dateTo_ValueChanged;
            // 
            // btnYesterday
            // 
            btnYesterday.BackColor = Color.White;
            btnYesterday.BackgroundImage = (Image)resources.GetObject("btnYesterday.BackgroundImage");
            btnYesterday.BackgroundImageLayout = ImageLayout.Center;
            btnYesterday.ForeColor = Color.Black;
            btnYesterday.Location = new Point(1159, 4);
            btnYesterday.Margin = new Padding(3, 4, 3, 4);
            btnYesterday.Name = "btnYesterday";
            btnYesterday.Size = new Size(58, 61);
            btnYesterday.TabIndex = 25;
            btnYesterday.UseVisualStyleBackColor = false;
            btnYesterday.Click += btnYesterday_Click;
            // 
            // btnTommorow
            // 
            btnTommorow.BackColor = Color.White;
            btnTommorow.BackgroundImage = (Image)resources.GetObject("btnTommorow.BackgroundImage");
            btnTommorow.BackgroundImageLayout = ImageLayout.Center;
            btnTommorow.ForeColor = Color.Black;
            btnTommorow.Location = new Point(1229, 4);
            btnTommorow.Margin = new Padding(3, 4, 3, 4);
            btnTommorow.Name = "btnTommorow";
            btnTommorow.Size = new Size(58, 61);
            btnTommorow.TabIndex = 26;
            btnTommorow.UseVisualStyleBackColor = false;
            btnTommorow.Click += btnTommorow_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(219, 175, 9);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(699, 79);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(6, 0, 6, 0);
            button1.Size = new Size(160, 62);
            button1.TabIndex = 27;
            button1.Text = "Điều chỉnh";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(50, 56, 134);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(1159, 79);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(128, 62);
            btnBack.TabIndex = 28;
            btnBack.Text = "Thoát";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 96);
            label11.Name = "label11";
            label11.Size = new Size(156, 29);
            label11.TabIndex = 29;
            label11.Text = "Tên nhân sự";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(188, 90);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(343, 38);
            txtName.TabIndex = 30;
            // 
            // MainSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 961);
            Controls.Add(btnTommorow);
            Controls.Add(txtName);
            Controls.Add(btnYesterday);
            Controls.Add(label11);
            Controls.Add(btnBack);
            Controls.Add(button1);
            Controls.Add(dateTo);
            Controls.Add(dateFrom);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(nowWeek);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(daycontainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainSchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainSchedule_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button nowWeek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private Button btnYesterday;
        private Button btnTommorow;
        private Button button1;
        private Button btnBack;
        private Label label11;
        private TextBox txtName;
    }

       
    
}