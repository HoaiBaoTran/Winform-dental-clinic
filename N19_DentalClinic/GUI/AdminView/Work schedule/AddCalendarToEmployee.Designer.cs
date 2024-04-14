namespace N19_DentalClinic.GUI.Work_schedule
{
    partial class AddCalendarToEmployee
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpDayWork = new DateTimePicker();
            dtpTimeStart = new DateTimePicker();
            dtpTimeEnd = new DateTimePicker();
            btnSave = new Button();
            pictureBox2 = new PictureBox();
            btnBack = new Button();
            btnRed = new Button();
            btnYellow = new Button();
            btnGreen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(247, 30);
            label1.TabIndex = 1;
            label1.Text = "Thêm lịch làm việc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 138);
            label2.Name = "label2";
            label2.Size = new Size(190, 22);
            label2.TabIndex = 2;
            label2.Text = "Chọn ngày làm việc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 228);
            label3.Name = "label3";
            label3.Size = new Size(200, 22);
            label3.TabIndex = 3;
            label3.Text = "Thời gian làm việc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 341);
            label4.Name = "label4";
            label4.Size = new Size(120, 22);
            label4.TabIndex = 4;
            label4.Text = "Giờ bắt đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 441);
            label5.Name = "label5";
            label5.Size = new Size(130, 22);
            label5.TabIndex = 5;
            label5.Text = "Giờ kết thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 554);
            label6.Name = "label6";
            label6.Size = new Size(100, 22);
            label6.TabIndex = 6;
            label6.Text = "Chọn màu:";
            // 
            // dtpDayWork
            // 
            dtpDayWork.CalendarFont = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDayWork.CalendarMonthBackground = Color.White;
            dtpDayWork.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDayWork.Format = DateTimePickerFormat.Short;
            dtpDayWork.Location = new Point(276, 138);
            dtpDayWork.Margin = new Padding(3, 4, 3, 4);
            dtpDayWork.Name = "dtpDayWork";
            dtpDayWork.Size = new Size(224, 27);
            dtpDayWork.TabIndex = 7;
            dtpDayWork.ValueChanged += dtpDayWork_ValueChanged;
            // 
            // dtpTimeStart
            // 
            dtpTimeStart.CalendarFont = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTimeStart.CalendarMonthBackground = Color.White;
            dtpTimeStart.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTimeStart.Format = DateTimePickerFormat.Time;
            dtpTimeStart.Location = new Point(276, 341);
            dtpTimeStart.Margin = new Padding(3, 4, 3, 4);
            dtpTimeStart.Name = "dtpTimeStart";
            dtpTimeStart.ShowUpDown = true;
            dtpTimeStart.Size = new Size(224, 27);
            dtpTimeStart.TabIndex = 8;
            dtpTimeStart.ValueChanged += dtpTimeStart_ValueChanged_1;
            // 
            // dtpTimeEnd
            // 
            dtpTimeEnd.CalendarFont = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTimeEnd.CalendarMonthBackground = Color.White;
            dtpTimeEnd.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTimeEnd.Format = DateTimePickerFormat.Time;
            dtpTimeEnd.Location = new Point(276, 435);
            dtpTimeEnd.Margin = new Padding(3, 4, 3, 4);
            dtpTimeEnd.Name = "dtpTimeEnd";
            dtpTimeEnd.ShowUpDown = true;
            dtpTimeEnd.Size = new Size(224, 27);
            dtpTimeEnd.TabIndex = 9;
            dtpTimeEnd.ValueChanged += dtpTimeEnd_ValueChanged_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(85, 230, 144);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(380, 588);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 75);
            btnSave.TabIndex = 10;
            btnSave.Text = "Lưu";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(395, 606);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(50, 56, 134);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(384, 28);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(116, 50);
            btnBack.TabIndex = 12;
            btnBack.Text = "Thoát";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.FlatStyle = FlatStyle.Flat;
            btnRed.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRed.ForeColor = SystemColors.ControlText;
            btnRed.Location = new Point(12, 606);
            btnRed.Margin = new Padding(3, 4, 3, 4);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(44, 44);
            btnRed.TabIndex = 14;
            btnRed.Text = "Đỏ";
            btnRed.UseVisualStyleBackColor = false;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Yellow;
            btnYellow.FlatStyle = FlatStyle.Flat;
            btnYellow.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnYellow.ForeColor = SystemColors.ControlText;
            btnYellow.Location = new Point(62, 606);
            btnYellow.Margin = new Padding(3, 4, 3, 4);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(55, 44);
            btnYellow.TabIndex = 15;
            btnYellow.Text = "Vàng";
            btnYellow.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.GreenYellow;
            btnGreen.FlatStyle = FlatStyle.Flat;
            btnGreen.Font = new Font("Cascadia Mono", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGreen.ForeColor = SystemColors.ControlText;
            btnGreen.Location = new Point(123, 606);
            btnGreen.Margin = new Padding(3, 4, 3, 4);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(47, 44);
            btnGreen.TabIndex = 16;
            btnGreen.Text = "Lục";
            btnGreen.UseVisualStyleBackColor = false;
            // 
            // AddCalendarToEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 186, 245);
            ClientSize = new Size(507, 674);
            Controls.Add(btnGreen);
            Controls.Add(btnYellow);
            Controls.Add(btnRed);
            Controls.Add(btnBack);
            Controls.Add(pictureBox2);
            Controls.Add(btnSave);
            Controls.Add(dtpTimeEnd);
            Controls.Add(dtpTimeStart);
            Controls.Add(dtpDayWork);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCalendarToEmployee";
            Text = "AddEvents";
            Load += AddEvents_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpDayWork;
        private System.Windows.Forms.DateTimePicker dtpTimeStart;
        private System.Windows.Forms.DateTimePicker dtpTimeEnd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
    }

    
}