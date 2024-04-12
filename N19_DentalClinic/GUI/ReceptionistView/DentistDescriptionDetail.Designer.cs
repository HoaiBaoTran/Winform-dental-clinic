namespace N19_DentalClinic.GUI.ReceptionistView
{
    partial class DentistDescriptionDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DentistDescriptionDetail));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtSalary = new TextBox();
            label13 = new Label();
            btnCalendar = new Button();
            txtBirthday = new TextBox();
            label12 = new Label();
            cbRank = new ComboBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtAddress = new TextBox();
            txtNation = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtTitle = new TextBox();
            txtName = new TextBox();
            txtDenID = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            cbFaculty = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnBack = new Button();
            btnCreateDentist = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(303, 46);
            label1.TabIndex = 2;
            label1.Text = "Thông tin nha sĩ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(btnCalendar);
            groupBox1.Controls.Add(txtBirthday);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cbRank);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtNation);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtDenID);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbFaculty);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(20, 89);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1269, 628);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // txtSalary
            // 
            txtSalary.AcceptsReturn = true;
            txtSalary.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSalary.Location = new Point(793, 549);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.ReadOnly = true;
            txtSalary.Size = new Size(452, 34);
            txtSalary.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(633, 549);
            label13.Name = "label13";
            label13.Size = new Size(80, 29);
            label13.TabIndex = 26;
            label13.Text = "Lương";
            // 
            // btnCalendar
            // 
            btnCalendar.Enabled = false;
            btnCalendar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalendar.Image = (Image)resources.GetObject("btnCalendar.Image");
            btnCalendar.ImageAlign = ContentAlignment.MiddleRight;
            btnCalendar.Location = new Point(1171, 433);
            btnCalendar.Margin = new Padding(3, 4, 3, 4);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Padding = new Padding(4, 0, 4, 0);
            btnCalendar.RightToLeft = RightToLeft.No;
            btnCalendar.Size = new Size(50, 58);
            btnCalendar.TabIndex = 25;
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // txtBirthday
            // 
            txtBirthday.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBirthday.Location = new Point(793, 444);
            txtBirthday.Margin = new Padding(3, 4, 3, 4);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.ReadOnly = true;
            txtBirthday.Size = new Size(362, 34);
            txtBirthday.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(633, 448);
            label12.Name = "label12";
            label12.Size = new Size(114, 29);
            label12.TabIndex = 23;
            label12.Text = "Năm sinh";
            // 
            // cbRank
            // 
            cbRank.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRank.Enabled = false;
            cbRank.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRank.FormattingEnabled = true;
            cbRank.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F" });
            cbRank.Location = new Point(793, 141);
            cbRank.Margin = new Padding(3, 4, 3, 4);
            cbRank.Name = "cbRank";
            cbRank.Size = new Size(198, 37);
            cbRank.TabIndex = 22;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Enabled = false;
            rbFemale.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(337, 445);
            rbFemale.Margin = new Padding(3, 4, 3, 4);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(65, 33);
            rbFemale.TabIndex = 21;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Enabled = false;
            rbMale.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(150, 445);
            rbMale.Margin = new Padding(3, 4, 3, 4);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(85, 33);
            rbMale.TabIndex = 20;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(793, 348);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(461, 34);
            txtAddress.TabIndex = 18;
            // 
            // txtNation
            // 
            txtNation.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNation.Location = new Point(793, 236);
            txtNation.Margin = new Padding(3, 4, 3, 4);
            txtNation.Name = "txtNation";
            txtNation.ReadOnly = true;
            txtNation.Size = new Size(461, 34);
            txtNation.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(793, 48);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(461, 34);
            txtPhoneNumber.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(150, 545);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(461, 34);
            txtEmail.TabIndex = 15;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(150, 348);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(461, 34);
            txtTitle.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(150, 239);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(461, 34);
            txtName.TabIndex = 13;
            // 
            // txtDenID
            // 
            txtDenID.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDenID.Location = new Point(150, 141);
            txtDenID.Margin = new Padding(3, 4, 3, 4);
            txtDenID.Name = "txtDenID";
            txtDenID.ReadOnly = true;
            txtDenID.Size = new Size(461, 34);
            txtDenID.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(633, 351);
            label11.Name = "label11";
            label11.Size = new Size(92, 29);
            label11.TabIndex = 10;
            label11.Text = "Địa chỉ ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(633, 242);
            label10.Name = "label10";
            label10.Size = new Size(114, 29);
            label10.TabIndex = 9;
            label10.Text = "Quốc tịch";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(633, 145);
            label9.Name = "label9";
            label9.Size = new Size(113, 29);
            label9.TabIndex = 8;
            label9.Text = "Bậc hạng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(633, 51);
            label8.Name = "label8";
            label8.Size = new Size(154, 29);
            label8.TabIndex = 7;
            label8.Text = "Số điện thoại";
            // 
            // cbFaculty
            // 
            cbFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFaculty.Enabled = false;
            cbFaculty.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Location = new Point(150, 41);
            cbFaculty.Margin = new Padding(3, 4, 3, 4);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(198, 37);
            cbFaculty.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 549);
            label7.Name = "label7";
            label7.Size = new Size(74, 29);
            label7.TabIndex = 5;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 448);
            label6.Name = "label6";
            label6.Size = new Size(101, 29);
            label6.TabIndex = 4;
            label6.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 351);
            label5.Name = "label5";
            label5.Size = new Size(79, 29);
            label5.TabIndex = 3;
            label5.Text = "Học vị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 242);
            label4.Name = "label4";
            label4.Size = new Size(83, 29);
            label4.TabIndex = 2;
            label4.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 145);
            label3.Name = "label3";
            label3.Size = new Size(115, 29);
            label3.TabIndex = 1;
            label3.Text = "Mã nha sĩ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 51);
            label2.Name = "label2";
            label2.Size = new Size(69, 29);
            label2.TabIndex = 0;
            label2.Text = "Khoa";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.Location = new Point(1155, 15);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(134, 54);
            btnBack.TabIndex = 26;
            btnBack.Text = "Trở lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreateDentist
            // 
            btnCreateDentist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateDentist.Enabled = false;
            btnCreateDentist.Location = new Point(999, 15);
            btnCreateDentist.Margin = new Padding(3, 4, 3, 4);
            btnCreateDentist.Name = "btnCreateDentist";
            btnCreateDentist.Size = new Size(121, 54);
            btnCreateDentist.TabIndex = 25;
            btnCreateDentist.Text = "Tạo mới";
            btnCreateDentist.UseVisualStyleBackColor = true;
            btnCreateDentist.Click += btnCreateDentist_Click;
            // 
            // DentistDescriptionDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 731);
            Controls.Add(btnBack);
            Controls.Add(btnCreateDentist);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DentistDescriptionDetail";
            Text = "DentistDescriptionDetail";
            Load += DentistDescriptionDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.TextBox txtDenID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox cbRank;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBirthday;
        private Button btnBack;
        private Button btnCreateDentist;
        private Button btnCalendar;
        private TextBox txtSalary;
        private Label label13;
    }
}