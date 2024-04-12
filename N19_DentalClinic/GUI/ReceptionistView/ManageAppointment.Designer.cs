namespace N19_DentalClinic.GUI.ReceptionistView
{
    partial class ManageAppointment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataAppointment = new DataGridView();
            roundPictureBox2 = new component.RoundPictureBox();
            btnAddAppointment = new component.RJButton();
            dateTimePicker = new DateTimePicker();
            label7 = new Label();
            lbDate = new Label();
            rjButton1 = new component.RJButton();
            btnLeftArrow = new component.RJButton();
            label6 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataAppointment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataAppointment
            // 
            dataAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAppointment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataAppointment.BackgroundColor = Color.White;
            dataAppointment.BorderStyle = BorderStyle.None;
            dataAppointment.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataAppointment.DefaultCellStyle = dataGridViewCellStyle1;
            dataAppointment.GridColor = Color.White;
            dataAppointment.Location = new Point(12, 203);
            dataAppointment.Name = "dataAppointment";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataAppointment.RowHeadersWidth = 51;
            dataAppointment.Size = new Size(1163, 550);
            dataAppointment.TabIndex = 21;
            // 
            // roundPictureBox2
            // 
            roundPictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundPictureBox2.BackColor = Color.FromArgb(56, 92, 67);
            roundPictureBox2.BackgroundImage = Properties.Resources.white_plus_icon;
            roundPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            roundPictureBox2.Location = new Point(1005, 27);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(35, 33);
            roundPictureBox2.TabIndex = 20;
            roundPictureBox2.TabStop = false;
            roundPictureBox2.Click += roundPictureBox2_Click;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddAppointment.BackColor = Color.FromArgb(18, 219, 78);
            btnAddAppointment.BackgroundColor = Color.FromArgb(18, 219, 78);
            btnAddAppointment.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddAppointment.BorderColor = Color.PaleVioletRed;
            btnAddAppointment.BorderRadius = 5;
            btnAddAppointment.BorderSize = 0;
            btnAddAppointment.FlatAppearance.BorderSize = 0;
            btnAddAppointment.FlatStyle = FlatStyle.Flat;
            btnAddAppointment.Font = new Font("Segoe UI", 11F);
            btnAddAppointment.ForeColor = Color.Black;
            btnAddAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddAppointment.Location = new Point(994, 19);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(181, 50);
            btnAddAppointment.TabIndex = 19;
            btnAddAppointment.Text = "Thêm lịch hẹn";
            btnAddAppointment.TextAlign = ContentAlignment.MiddleRight;
            btnAddAppointment.TextColor = Color.Black;
            btnAddAppointment.UseVisualStyleBackColor = false;
            btnAddAppointment.Click += btnAddAppointment_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.Font = new Font("Segoe UI", 14F);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(994, 82);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(181, 39);
            dateTimePicker.TabIndex = 18;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(767, 88);
            label7.Name = "label7";
            label7.Size = new Size(189, 32);
            label7.TabIndex = 17;
            label7.Text = "Chọn thời gian:";
            // 
            // lbDate
            // 
            lbDate.BackColor = Color.FromArgb(9, 24, 219);
            lbDate.ForeColor = Color.White;
            lbDate.Location = new Point(208, 80);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(125, 55);
            lbDate.TabIndex = 16;
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
            rjButton1.Location = new Point(117, 80);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(58, 55);
            rjButton1.TabIndex = 15;
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
            btnLeftArrow.Location = new Point(41, 80);
            btnLeftArrow.Name = "btnLeftArrow";
            btnLeftArrow.Size = new Size(58, 55);
            btnLeftArrow.TabIndex = 14;
            btnLeftArrow.TextColor = Color.White;
            btnLeftArrow.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 19);
            label6.Name = "label6";
            label6.Size = new Size(134, 41);
            label6.TabIndex = 13;
            label6.Text = "Lịch hẹn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 12;
            // 
            // ManageAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(dataAppointment);
            Controls.Add(roundPictureBox2);
            Controls.Add(btnAddAppointment);
            Controls.Add(dateTimePicker);
            Controls.Add(label7);
            Controls.Add(lbDate);
            Controls.Add(rjButton1);
            Controls.Add(btnLeftArrow);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageAppointment";
            Load += ManageAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dataAppointment).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataAppointment;
        private component.RoundPictureBox roundPictureBox2;
        private component.RJButton btnAddAppointment;
        private DateTimePicker dateTimePicker;
        private Label label7;
        private Label lbDate;
        private component.RJButton rjButton1;
        private component.RJButton btnLeftArrow;
        private Label label6;
        private Label label1;
    }
}
