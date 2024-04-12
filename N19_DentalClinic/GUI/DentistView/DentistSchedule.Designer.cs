namespace N19_DentalClinic.GUI.DentistView
{
    partial class DentistSchedule
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataSchedule = new DataGridView();
            dateTimePicker = new DateTimePicker();
            label7 = new Label();
            lbDate = new Label();
            rjButton1 = new component.RJButton();
            btnLeftArrow = new component.RJButton();
            label6 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataSchedule).BeginInit();
            SuspendLayout();
            // 
            // dataSchedule
            // 
            dataSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataSchedule.BackgroundColor = Color.White;
            dataSchedule.BorderStyle = BorderStyle.None;
            dataSchedule.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataSchedule.DefaultCellStyle = dataGridViewCellStyle3;
            dataSchedule.GridColor = Color.White;
            dataSchedule.Location = new Point(10, 193);
            dataSchedule.Name = "dataSchedule";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataSchedule.RowHeadersWidth = 51;
            dataSchedule.Size = new Size(1181, 597);
            dataSchedule.TabIndex = 31;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(1010, 72);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(181, 39);
            dateTimePicker.TabIndex = 28;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(783, 78);
            label7.Name = "label7";
            label7.Size = new Size(189, 32);
            label7.TabIndex = 27;
            label7.Text = "Chọn thời gian:";
            // 
            // lbDate
            // 
            lbDate.BackColor = Color.FromArgb(9, 24, 219);
            lbDate.ForeColor = Color.White;
            lbDate.Location = new Point(206, 70);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(125, 55);
            lbDate.TabIndex = 26;
            lbDate.Text = "Hôm nay";
            lbDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(18, 219, 78);
            rjButton1.BackgroundColor = Color.FromArgb(18, 219, 78);
            rjButton1.BackgroundImage = Properties.Resources.right_arrow_icon;
            rjButton1.BackgroundImageLayout = ImageLayout.Zoom;
            rjButton1.BorderColor = Color.Empty;
            rjButton1.BorderRadius = 30;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(115, 70);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(58, 55);
            rjButton1.TabIndex = 25;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // btnLeftArrow
            // 
            btnLeftArrow.BackColor = Color.FromArgb(18, 219, 78);
            btnLeftArrow.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnLeftArrow.BackgroundImage = Properties.Resources.left_arrow_icon;
            btnLeftArrow.BackgroundImageLayout = ImageLayout.Zoom;
            btnLeftArrow.BorderColor = Color.Empty;
            btnLeftArrow.BorderRadius = 30;
            btnLeftArrow.BorderSize = 0;
            btnLeftArrow.FlatAppearance.BorderSize = 0;
            btnLeftArrow.FlatStyle = FlatStyle.Flat;
            btnLeftArrow.ForeColor = Color.White;
            btnLeftArrow.Location = new Point(39, 70);
            btnLeftArrow.Name = "btnLeftArrow";
            btnLeftArrow.Size = new Size(58, 55);
            btnLeftArrow.TabIndex = 24;
            btnLeftArrow.TextColor = Color.White;
            btnLeftArrow.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 9);
            label6.Name = "label6";
            label6.Size = new Size(197, 41);
            label6.TabIndex = 23;
            label6.Text = "Lịch làm việc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 26);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 22;
            // 
            // DentistSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(dataSchedule);
            Controls.Add(dateTimePicker);
            Controls.Add(label7);
            Controls.Add(lbDate);
            Controls.Add(rjButton1);
            Controls.Add(btnLeftArrow);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DentistSchedule";
            Text = "DentistSchedule";
            Load += DentistSchedule_Load;
            ((System.ComponentModel.ISupportInitialize)dataSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataSchedule;
        private DateTimePicker dateTimePicker;
        private Label label7;
        private Label lbDate;
        private component.RJButton rjButton1;
        private component.RJButton btnLeftArrow;
        private Label label6;
        private Label label1;
    }
}