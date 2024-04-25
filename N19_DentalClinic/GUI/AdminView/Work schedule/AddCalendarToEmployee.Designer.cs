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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCalendarToEmployee));
            lbCalendar = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpDayWork = new DateTimePicker();
            dtpTimeStart = new DateTimePicker();
            dtpTimeEnd = new DateTimePicker();
            btnSave = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lbCalendar
            // 
            lbCalendar.AutoSize = true;
            lbCalendar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCalendar.Location = new Point(1, 19);
            lbCalendar.Name = "lbCalendar";
            lbCalendar.Size = new Size(276, 36);
            lbCalendar.TabIndex = 1;
            lbCalendar.Text = "Thêm lịch làm việc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 138);
            label2.Name = "label2";
            label2.Size = new Size(221, 29);
            label2.TabIndex = 2;
            label2.Text = "Chọn ngày làm việc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 254);
            label3.Name = "label3";
            label3.Size = new Size(233, 29);
            label3.TabIndex = 3;
            label3.Text = "Thời gian làm việc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 341);
            label4.Name = "label4";
            label4.Size = new Size(136, 29);
            label4.TabIndex = 4;
            label4.Text = "Giờ bắt đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 441);
            label5.Name = "label5";
            label5.Size = new Size(139, 29);
            label5.TabIndex = 5;
            label5.Text = "Giờ kết thúc";
            // 
            // dtpDayWork
            // 
            dtpDayWork.CalendarFont = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDayWork.CalendarMonthBackground = Color.White;
            dtpDayWork.CustomFormat = "dd/MM/yyyy";
            dtpDayWork.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDayWork.Format = DateTimePickerFormat.Custom;
            dtpDayWork.Location = new Point(276, 138);
            dtpDayWork.Margin = new Padding(3, 4, 3, 4);
            dtpDayWork.Name = "dtpDayWork";
            dtpDayWork.Size = new Size(224, 34);
            dtpDayWork.TabIndex = 7;
            dtpDayWork.ValueChanged += dtpDayWork_ValueChanged;
            // 
            // dtpTimeStart
            // 
            dtpTimeStart.CalendarFont = new Font("Cambria Math", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTimeStart.CalendarMonthBackground = Color.White;
            dtpTimeStart.CustomFormat = "HH:mm:ss";
            dtpTimeStart.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTimeStart.Format = DateTimePickerFormat.Custom;
            dtpTimeStart.Location = new Point(276, 341);
            dtpTimeStart.Margin = new Padding(3, 4, 3, 4);
            dtpTimeStart.Name = "dtpTimeStart";
            dtpTimeStart.ShowUpDown = true;
            dtpTimeStart.Size = new Size(224, 34);
            dtpTimeStart.TabIndex = 8;
            dtpTimeStart.ValueChanged += dtpTimeStart_ValueChanged_1;
            // 
            // dtpTimeEnd
            // 
            dtpTimeEnd.CalendarFont = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTimeEnd.CalendarMonthBackground = Color.White;
            dtpTimeEnd.CustomFormat = "HH:mm:ss";
            dtpTimeEnd.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTimeEnd.Format = DateTimePickerFormat.Custom;
            dtpTimeEnd.Location = new Point(276, 435);
            dtpTimeEnd.Margin = new Padding(3, 4, 3, 4);
            dtpTimeEnd.Name = "dtpTimeEnd";
            dtpTimeEnd.ShowUpDown = true;
            dtpTimeEnd.Size = new Size(224, 34);
            dtpTimeEnd.TabIndex = 9;
            dtpTimeEnd.ValueChanged += dtpTimeEnd_ValueChanged_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(85, 230, 144);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(380, 508);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 65);
            btnSave.TabIndex = 10;
            btnSave.Text = "Lưu";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(50, 56, 134);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(368, 19);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(128, 50);
            btnBack.TabIndex = 12;
            btnBack.Text = "Thoát";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AddCalendarToEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 186, 245);
            ClientSize = new Size(509, 598);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(dtpTimeEnd);
            Controls.Add(dtpTimeStart);
            Controls.Add(dtpDayWork);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbCalendar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddCalendarToEmployee";
            Text = "Thêm lịch làm việc";
            Load += AddEvents_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lbCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDayWork;
        private System.Windows.Forms.DateTimePicker dtpTimeStart;
        private System.Windows.Forms.DateTimePicker dtpTimeEnd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }

    
}