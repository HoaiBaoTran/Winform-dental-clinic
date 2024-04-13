namespace N19_DentalClinic.GUI
{
    partial class PatientDecriptionDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDecriptionDetail));
            groupBox1 = new GroupBox();
            btnCalendar = new Button();
            txtDenOfPat = new TextBox();
            label2 = new Label();
            txtBirthday = new TextBox();
            label12 = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtPatID = new TextBox();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnCreatePatient = new Button();
            btnBack = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnCalendar);
            groupBox1.Controls.Add(txtDenOfPat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBirthday);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtPatID);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(20, 90);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1269, 550);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnCalendar
            // 
            btnCalendar.Enabled = false;
            btnCalendar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalendar.Image = (Image)resources.GetObject("btnCalendar.Image");
            btnCalendar.ImageAlign = ContentAlignment.MiddleRight;
            btnCalendar.Location = new Point(625, 248);
            btnCalendar.Margin = new Padding(3, 4, 3, 4);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Padding = new Padding(4, 0, 4, 0);
            btnCalendar.RightToLeft = RightToLeft.No;
            btnCalendar.Size = new Size(50, 58);
            btnCalendar.TabIndex = 1;
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // txtDenOfPat
            // 
            txtDenOfPat.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDenOfPat.Location = new Point(214, 482);
            txtDenOfPat.Margin = new Padding(3, 4, 3, 4);
            txtDenOfPat.Name = "txtDenOfPat";
            txtDenOfPat.ReadOnly = true;
            txtDenOfPat.Size = new Size(461, 34);
            txtDenOfPat.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 485);
            label2.Name = "label2";
            label2.Size = new Size(189, 29);
            label2.TabIndex = 25;
            label2.Text = "Nha sĩ chăm sóc";
            label2.Click += label2_Click;
            // 
            // txtBirthday
            // 
            txtBirthday.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBirthday.Location = new Point(214, 260);
            txtBirthday.Margin = new Padding(3, 4, 3, 4);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.ReadOnly = true;
            txtBirthday.Size = new Size(391, 34);
            txtBirthday.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(7, 262);
            label12.Name = "label12";
            label12.Size = new Size(114, 29);
            label12.TabIndex = 23;
            label12.Text = "Năm sinh";
            // 
            // rbFemale
            // 
            rbFemale.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbFemale.AutoSize = true;
            rbFemale.Enabled = false;
            rbFemale.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(866, 160);
            rbFemale.Margin = new Padding(3, 4, 3, 4);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(65, 33);
            rbFemale.TabIndex = 5;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbMale.AutoSize = true;
            rbMale.Enabled = false;
            rbMale.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(1032, 160);
            rbMale.Margin = new Padding(3, 4, 3, 4);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(85, 33);
            rbMale.TabIndex = 4;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(214, 372);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(461, 34);
            txtAddress.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(877, 257);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(385, 34);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEmail.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(787, 50);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(476, 34);
            txtEmail.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(214, 161);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(461, 34);
            txtName.TabIndex = 0;
            // 
            // txtPatID
            // 
            txtPatID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPatID.Location = new Point(214, 50);
            txtPatID.Margin = new Padding(3, 4, 3, 4);
            txtPatID.Name = "txtPatID";
            txtPatID.ReadOnly = true;
            txtPatID.Size = new Size(461, 34);
            txtPatID.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(7, 377);
            label11.Name = "label11";
            label11.Size = new Size(92, 29);
            label11.TabIndex = 10;
            label11.Text = "Địa chỉ ";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(686, 260);
            label8.Name = "label8";
            label8.Size = new Size(154, 29);
            label8.TabIndex = 7;
            label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(686, 53);
            label7.Name = "label7";
            label7.Size = new Size(74, 29);
            label7.TabIndex = 5;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(686, 160);
            label6.Name = "label6";
            label6.Size = new Size(101, 29);
            label6.TabIndex = 4;
            label6.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 164);
            label4.Name = "label4";
            label4.Size = new Size(83, 29);
            label4.TabIndex = 2;
            label4.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 53);
            label3.Name = "label3";
            label3.Size = new Size(164, 29);
            label3.TabIndex = 1;
            label3.Text = "Mã bệnh nhân";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(384, 46);
            label1.TabIndex = 4;
            label1.Text = "Thông tin bệnh nhân";
            // 
            // btnCreatePatient
            // 
            btnCreatePatient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreatePatient.Enabled = false;
            btnCreatePatient.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreatePatient.Image = (Image)resources.GetObject("btnCreatePatient.Image");
            btnCreatePatient.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreatePatient.Location = new Point(933, 16);
            btnCreatePatient.Margin = new Padding(3, 4, 3, 4);
            btnCreatePatient.Name = "btnCreatePatient";
            btnCreatePatient.Padding = new Padding(6, 0, 6, 0);
            btnCreatePatient.Size = new Size(177, 54);
            btnCreatePatient.TabIndex = 6;
            btnCreatePatient.Text = "Tạo mới";
            btnCreatePatient.TextAlign = ContentAlignment.MiddleRight;
            btnCreatePatient.UseVisualStyleBackColor = true;
            btnCreatePatient.Click += btnCreatePatient_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(1135, 16);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Padding = new Padding(6, 0, 6, 0);
            btnBack.Size = new Size(154, 54);
            btnBack.TabIndex = 7;
            btnBack.Text = "Trở lại";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PatientDecriptionDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 655);
            Controls.Add(btnBack);
            Controls.Add(btnCreatePatient);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientDecriptionDetail";
            Text = "PatientDecriptionDetail";
            Load += PatientDecriptionDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPatID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDenOfPat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnCreatePatient;
        private System.Windows.Forms.Button btnBack;
    }
}