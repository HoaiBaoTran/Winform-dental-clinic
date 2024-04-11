namespace N19_ProjectForm.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryCheckUp));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataAppointPatient = new System.Windows.Forms.DataGridView();
            this.btnChooseDay = new System.Windows.Forms.Button();
            this.txtCurrDate = new System.Windows.Forms.TextBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnTommorow = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.txtNamePat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPatID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lịch sử khám";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataAppointPatient);
            this.groupBox1.Controls.Add(this.btnChooseDay);
            this.groupBox1.Controls.Add(this.txtCurrDate);
            this.groupBox1.Controls.Add(this.btnToday);
            this.groupBox1.Controls.Add(this.btnTommorow);
            this.groupBox1.Controls.Add(this.btnYesterday);
            this.groupBox1.Controls.Add(this.txtNamePat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPatID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1252, 502);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // dataAppointPatient
            // 
            this.dataAppointPatient.AllowUserToAddRows = false;
            this.dataAppointPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataAppointPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAppointPatient.Location = new System.Drawing.Point(11, 159);
            this.dataAppointPatient.Name = "dataAppointPatient";
            this.dataAppointPatient.ReadOnly = true;
            this.dataAppointPatient.RowHeadersVisible = false;
            this.dataAppointPatient.RowHeadersWidth = 51;
            this.dataAppointPatient.RowTemplate.Height = 24;
            this.dataAppointPatient.Size = new System.Drawing.Size(1226, 337);
            this.dataAppointPatient.TabIndex = 21;
            // 
            // btnChooseDay
            // 
            this.btnChooseDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseDay.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseDay.Image")));
            this.btnChooseDay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChooseDay.Location = new System.Drawing.Point(1030, 102);
            this.btnChooseDay.Name = "btnChooseDay";
            this.btnChooseDay.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnChooseDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChooseDay.Size = new System.Drawing.Size(207, 46);
            this.btnChooseDay.TabIndex = 20;
            this.btnChooseDay.Text = "Chọn Ngày";
            this.btnChooseDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseDay.UseVisualStyleBackColor = true;
            this.btnChooseDay.Click += new System.EventHandler(this.btnChooseDay_Click);
            // 
            // txtCurrDate
            // 
            this.txtCurrDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrDate.Location = new System.Drawing.Point(790, 105);
            this.txtCurrDate.Name = "txtCurrDate";
            this.txtCurrDate.ReadOnly = true;
            this.txtCurrDate.Size = new System.Drawing.Size(210, 38);
            this.txtCurrDate.TabIndex = 19;
            this.txtCurrDate.TextChanged += new System.EventHandler(this.txtCurrDate_TextChanged);
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.Location = new System.Drawing.Point(170, 94);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(146, 49);
            this.btnToday.TabIndex = 18;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnTommorow
            // 
            this.btnTommorow.BackColor = System.Drawing.Color.White;
            this.btnTommorow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTommorow.BackgroundImage")));
            this.btnTommorow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTommorow.ForeColor = System.Drawing.Color.Black;
            this.btnTommorow.Location = new System.Drawing.Point(89, 94);
            this.btnTommorow.Name = "btnTommorow";
            this.btnTommorow.Size = new System.Drawing.Size(58, 49);
            this.btnTommorow.TabIndex = 17;
            this.btnTommorow.UseVisualStyleBackColor = false;
            this.btnTommorow.Click += new System.EventHandler(this.btnTommorow_Click);
            // 
            // btnYesterday
            // 
            this.btnYesterday.BackColor = System.Drawing.Color.White;
            this.btnYesterday.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYesterday.BackgroundImage")));
            this.btnYesterday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnYesterday.ForeColor = System.Drawing.Color.Black;
            this.btnYesterday.Location = new System.Drawing.Point(11, 94);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(58, 49);
            this.btnYesterday.TabIndex = 16;
            this.btnYesterday.UseVisualStyleBackColor = false;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // txtNamePat
            // 
            this.txtNamePat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePat.Location = new System.Drawing.Point(825, 38);
            this.txtNamePat.Name = "txtNamePat";
            this.txtNamePat.ReadOnly = true;
            this.txtNamePat.Size = new System.Drawing.Size(412, 34);
            this.txtNamePat.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(645, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tên bệnh nhân";
            // 
            // txtPatID
            // 
            this.txtPatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatID.Location = new System.Drawing.Point(176, 38);
            this.txtPatID.Name = "txtPatID";
            this.txtPatID.ReadOnly = true;
            this.txtPatID.Size = new System.Drawing.Size(429, 34);
            this.txtPatID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã bệnh nhân";
            // 
            // HistoryCheckUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryCheckUp";
            this.Text = "HistoryCheckUp";
            this.Load += new System.EventHandler(this.HistoryCheckUp_Load);
            this.Resize += new System.EventHandler(this.HistoryCheckUp_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}