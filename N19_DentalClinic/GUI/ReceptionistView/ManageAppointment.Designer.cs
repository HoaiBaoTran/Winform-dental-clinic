﻿namespace N19_DentalClinic.GUI.ReceptionistView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAppointment));
            dataAppointmentTable = new DataGridView();
            label1 = new Label();
            button3 = new Button();
            txtCurrDate = new TextBox();
            btnToday = new Button();
            btnTommorow = new Button();
            btnYesterday = new Button();
            btnCreateAppointment = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataAppointmentTable).BeginInit();
            SuspendLayout();
            // 
            // dataAppointmentTable
            // 
            dataAppointmentTable.AllowUserToAddRows = false;
            dataAppointmentTable.AllowUserToDeleteRows = false;
            dataAppointmentTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataAppointmentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataAppointmentTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataAppointmentTable.BackgroundColor = Color.White;
            dataAppointmentTable.BorderStyle = BorderStyle.None;
            dataAppointmentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataAppointmentTable.DefaultCellStyle = dataGridViewCellStyle1;
            dataAppointmentTable.Location = new Point(16, 207);
            dataAppointmentTable.Name = "dataAppointmentTable";
            dataAppointmentTable.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 219, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataAppointmentTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataAppointmentTable.RowHeadersWidth = 51;
            dataAppointmentTable.Size = new Size(1262, 482);
            dataAppointmentTable.TabIndex = 21;
            dataAppointmentTable.MouseClick += dataAppointmentTable_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(171, 46);
            label1.TabIndex = 22;
            label1.Text = "Lịch hẹn";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(1067, 110);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(4, 0, 4, 0);
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(207, 58);
            button3.TabIndex = 27;
            button3.Text = "Chọn Ngày";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtCurrDate
            // 
            txtCurrDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCurrDate.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrDate.Location = new Point(791, 128);
            txtCurrDate.Margin = new Padding(3, 4, 3, 4);
            txtCurrDate.Name = "txtCurrDate";
            txtCurrDate.ReadOnly = true;
            txtCurrDate.Size = new Size(210, 38);
            txtCurrDate.TabIndex = 26;
            txtCurrDate.TextChanged += txtCurrDate_TextChanged;
            // 
            // btnToday
            // 
            btnToday.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToday.Location = new Point(175, 107);
            btnToday.Margin = new Padding(3, 4, 3, 4);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(146, 61);
            btnToday.TabIndex = 25;
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
            btnTommorow.Location = new Point(94, 107);
            btnTommorow.Margin = new Padding(3, 4, 3, 4);
            btnTommorow.Name = "btnTommorow";
            btnTommorow.Size = new Size(58, 61);
            btnTommorow.TabIndex = 24;
            btnTommorow.UseVisualStyleBackColor = false;
            btnTommorow.Click += btnTommorow_Click;
            // 
            // btnYesterday
            // 
            btnYesterday.BackColor = Color.White;
            btnYesterday.BackgroundImage = (Image)resources.GetObject("btnYesterday.BackgroundImage");
            btnYesterday.BackgroundImageLayout = ImageLayout.Center;
            btnYesterday.ForeColor = Color.Black;
            btnYesterday.Location = new Point(16, 107);
            btnYesterday.Margin = new Padding(3, 4, 3, 4);
            btnYesterday.Name = "btnYesterday";
            btnYesterday.Size = new Size(58, 61);
            btnYesterday.TabIndex = 23;
            btnYesterday.UseVisualStyleBackColor = false;
            btnYesterday.Click += btnYesterday_Click;
            // 
            // btnCreateAppointment
            // 
            btnCreateAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateAppointment.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAppointment.Image = (Image)resources.GetObject("btnCreateAppointment.Image");
            btnCreateAppointment.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateAppointment.Location = new Point(1025, 21);
            btnCreateAppointment.Margin = new Padding(3, 4, 3, 4);
            btnCreateAppointment.Name = "btnCreateAppointment";
            btnCreateAppointment.Padding = new Padding(6, 0, 6, 0);
            btnCreateAppointment.Size = new Size(249, 66);
            btnCreateAppointment.TabIndex = 28;
            btnCreateAppointment.Text = "Thêm lịch hẹn";
            btnCreateAppointment.TextAlign = ContentAlignment.MiddleRight;
            btnCreateAppointment.UseVisualStyleBackColor = true;
            btnCreateAppointment.Click += btnCreateAppointment_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(125, 124, 143);
            button1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(848, 21);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(6, 0, 6, 0);
            button1.Size = new Size(153, 66);
            button1.TabIndex = 29;
            button1.Text = "Tải lại";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ManageAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 731);
            Controls.Add(button1);
            Controls.Add(btnCreateAppointment);
            Controls.Add(button3);
            Controls.Add(txtCurrDate);
            Controls.Add(btnToday);
            Controls.Add(btnTommorow);
            Controls.Add(btnYesterday);
            Controls.Add(label1);
            Controls.Add(dataAppointmentTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageAppointment";
            Load += ManageAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dataAppointmentTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataAppointmentTable;
        private Label label1;
        private Button button3;
        private TextBox txtCurrDate;
        private Button btnToday;
        private Button btnTommorow;
        private Button btnYesterday;
        private Button btnCreateAppointment;
        private Button button1;
    }
}
