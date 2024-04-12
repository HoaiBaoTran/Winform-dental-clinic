namespace N19_DentalClinic.GUI
{
    partial class Calendar
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel3 = new Panel();
            btnToDay = new Button();
            dtpkDate = new DateTimePicker();
            panel2 = new Panel();
            btnAccept = new Button();
            pnlMatrix = new Panel();
            panel4 = new Panel();
            btnNext = new Button();
            btnPreviours = new Button();
            btnSunday = new Button();
            btnSaturday = new Button();
            btnFriday = new Button();
            btnThusday = new Button();
            btnWednesday = new Button();
            btnTuesday = new Button();
            btnMonday = new Button();
            tmNotify = new System.Windows.Forms.Timer(components);
            Notify = new NotifyIcon(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(16, 19);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 548);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnToDay);
            panel3.Controls.Add(dtpkDate);
            panel3.Location = new Point(4, 5);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(980, 42);
            panel3.TabIndex = 1;
            // 
            // btnToDay
            // 
            btnToDay.Location = new Point(810, 0);
            btnToDay.Margin = new Padding(4, 5, 4, 5);
            btnToDay.Name = "btnToDay";
            btnToDay.Size = new Size(100, 35);
            btnToDay.TabIndex = 1;
            btnToDay.Text = "Hôm nay";
            btnToDay.UseVisualStyleBackColor = true;
            btnToDay.Click += btnToDay_Click;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(383, 5);
            dtpkDate.Margin = new Padding(4, 5, 4, 5);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(265, 27);
            dtpkDate.TabIndex = 0;
            dtpkDate.ValueChanged += dtpkDate_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAccept);
            panel2.Controls.Add(pnlMatrix);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(4, 58);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 482);
            panel2.TabIndex = 0;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(872, 426);
            btnAccept.Margin = new Padding(4, 5, 4, 5);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(100, 35);
            btnAccept.TabIndex = 2;
            btnAccept.Text = "Xác nhận";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // pnlMatrix
            // 
            pnlMatrix.Location = new Point(117, 85);
            pnlMatrix.Margin = new Padding(4, 5, 4, 5);
            pnlMatrix.Name = "pnlMatrix";
            pnlMatrix.Size = new Size(735, 391);
            pnlMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnNext);
            panel4.Controls.Add(btnPreviours);
            panel4.Controls.Add(btnSunday);
            panel4.Controls.Add(btnSaturday);
            panel4.Controls.Add(btnFriday);
            panel4.Controls.Add(btnThusday);
            panel4.Controls.Add(btnWednesday);
            panel4.Controls.Add(btnTuesday);
            panel4.Controls.Add(btnMonday);
            panel4.Location = new Point(4, 5);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(972, 71);
            panel4.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(868, 5);
            btnNext.Margin = new Padding(4, 5, 4, 5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 61);
            btnNext.TabIndex = 8;
            btnNext.Text = "Tháng sau";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPreviours
            // 
            btnPreviours.Location = new Point(6, 5);
            btnPreviours.Margin = new Padding(4, 5, 4, 5);
            btnPreviours.Name = "btnPreviours";
            btnPreviours.Size = new Size(100, 61);
            btnPreviours.TabIndex = 7;
            btnPreviours.Text = "Tháng trước";
            btnPreviours.UseVisualStyleBackColor = true;
            btnPreviours.Click += btnPreviours_Click;
            // 
            // btnSunday
            // 
            btnSunday.Location = new Point(746, 5);
            btnSunday.Margin = new Padding(4, 5, 4, 5);
            btnSunday.Name = "btnSunday";
            btnSunday.Size = new Size(100, 61);
            btnSunday.TabIndex = 6;
            btnSunday.Text = "Chủ nhật";
            btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            btnSaturday.Location = new Point(640, 5);
            btnSaturday.Margin = new Padding(4, 5, 4, 5);
            btnSaturday.Name = "btnSaturday";
            btnSaturday.Size = new Size(100, 61);
            btnSaturday.TabIndex = 5;
            btnSaturday.Text = "Thứ 7";
            btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            btnFriday.Location = new Point(534, 5);
            btnFriday.Margin = new Padding(4, 5, 4, 5);
            btnFriday.Name = "btnFriday";
            btnFriday.Size = new Size(100, 61);
            btnFriday.TabIndex = 4;
            btnFriday.Text = "Thứ 6";
            btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnThusday
            // 
            btnThusday.Location = new Point(429, 5);
            btnThusday.Margin = new Padding(4, 5, 4, 5);
            btnThusday.Name = "btnThusday";
            btnThusday.Size = new Size(100, 61);
            btnThusday.TabIndex = 3;
            btnThusday.Text = "Thứ 5";
            btnThusday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            btnWednesday.Location = new Point(323, 5);
            btnWednesday.Margin = new Padding(4, 5, 4, 5);
            btnWednesday.Name = "btnWednesday";
            btnWednesday.Size = new Size(100, 61);
            btnWednesday.TabIndex = 2;
            btnWednesday.Text = "Thứ 4";
            btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            btnTuesday.Location = new Point(217, 5);
            btnTuesday.Margin = new Padding(4, 5, 4, 5);
            btnTuesday.Name = "btnTuesday";
            btnTuesday.Size = new Size(100, 61);
            btnTuesday.TabIndex = 1;
            btnTuesday.Text = "Thứ 3";
            btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            btnMonday.Location = new Point(113, 5);
            btnMonday.Margin = new Padding(4, 5, 4, 5);
            btnMonday.Name = "btnMonday";
            btnMonday.Size = new Size(100, 61);
            btnMonday.TabIndex = 0;
            btnMonday.Text = "Thứ 2";
            btnMonday.UseVisualStyleBackColor = true;
            // 
            // tmNotify
            // 
            tmNotify.Enabled = true;
            tmNotify.Interval = 5000;
            // 
            // Notify
            // 
            Notify.Text = "Lập lịch";
            Notify.Visible = true;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 569);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Calendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lập lịch công việc";
            Load += Calendar_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnToDay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPreviours;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThusday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Timer tmNotify;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.Button btnAccept;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}