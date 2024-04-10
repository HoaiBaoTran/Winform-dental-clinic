namespace N19_ProjectForm.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForDentist));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataAppointDentist = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCurrDate = new System.Windows.Forms.TextBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNameDentist = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDenID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointDentist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lịch hẹn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataAppointDentist);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtCurrDate);
            this.groupBox1.Controls.Add(this.btnToday);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtNameDentist);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDenID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1269, 502);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dataAppointDentist
            // 
            this.dataAppointDentist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAppointDentist.Location = new System.Drawing.Point(11, 159);
            this.dataAppointDentist.Name = "dataAppointDentist";
            this.dataAppointDentist.ReadOnly = true;
            this.dataAppointDentist.RowHeadersWidth = 51;
            this.dataAppointDentist.RowTemplate.Height = 24;
            this.dataAppointDentist.Size = new System.Drawing.Size(1243, 337);
            this.dataAppointDentist.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(1056, 102);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(207, 46);
            this.button3.TabIndex = 20;
            this.button3.Text = "Chọn Ngày";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCurrDate
            // 
            this.txtCurrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrDate.Location = new System.Drawing.Point(821, 105);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(89, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 49);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(11, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 49);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtNameDentist
            // 
            this.txtNameDentist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameDentist.Location = new System.Drawing.Point(808, 38);
            this.txtNameDentist.Name = "txtNameDentist";
            this.txtNameDentist.ReadOnly = true;
            this.txtNameDentist.Size = new System.Drawing.Size(461, 34);
            this.txtNameDentist.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(654, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tên nha sĩ";
            // 
            // txtDenID
            // 
            this.txtDenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenID.Location = new System.Drawing.Point(144, 38);
            this.txtDenID.Name = "txtDenID";
            this.txtDenID.ReadOnly = true;
            this.txtDenID.Size = new System.Drawing.Size(461, 34);
            this.txtDenID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nha sĩ";
            // 
            // AppointmentForDentist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentForDentist";
            this.Text = "AppointmentForDentist";
            this.Load += new System.EventHandler(this.AppointmentForDentist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointDentist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDenID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNameDentist;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCurrDate;
        private System.Windows.Forms.DataGridView dataAppointDentist;
    }
}