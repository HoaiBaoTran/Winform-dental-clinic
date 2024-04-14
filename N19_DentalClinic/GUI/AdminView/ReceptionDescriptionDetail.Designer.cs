namespace N19_DentalClinic.GUI.AdminView
{
    partial class ReceptionDescriptionDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionDescriptionDetail));
            btnBack = new Button();
            btnCreateRecep = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtSalary = new TextBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            label2 = new Label();
            label10 = new Label();
            label5 = new Label();
            label9 = new Label();
            btnCalendar = new Button();
            txtBirthday = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtRecepId = new TextBox();
            label12 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnCalendarWork = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(1137, 16);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Padding = new Padding(6, 0, 6, 0);
            btnBack.Size = new Size(152, 54);
            btnBack.TabIndex = 34;
            btnBack.Text = "Trở lại";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreateRecep
            // 
            btnCreateRecep.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateRecep.Enabled = false;
            btnCreateRecep.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateRecep.Image = (Image)resources.GetObject("btnCreateRecep.Image");
            btnCreateRecep.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateRecep.Location = new Point(950, 16);
            btnCreateRecep.Margin = new Padding(3, 4, 3, 4);
            btnCreateRecep.Name = "btnCreateRecep";
            btnCreateRecep.Padding = new Padding(6, 0, 6, 0);
            btnCreateRecep.Size = new Size(170, 54);
            btnCreateRecep.TabIndex = 33;
            btnCreateRecep.Text = "Tạo mới";
            btnCreateRecep.TextAlign = ContentAlignment.MiddleRight;
            btnCreateRecep.UseVisualStyleBackColor = true;
            btnCreateRecep.Click += btnCreateRecep_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(294, 46);
            label1.TabIndex = 31;
            label1.Text = "Thông tin lễ tân";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnCalendar);
            groupBox1.Controls.Add(txtBirthday);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtRecepId);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(20, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1269, 421);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // txtSalary
            // 
            txtSalary.AcceptsReturn = true;
            txtSalary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSalary.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSalary.Location = new Point(781, 335);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Name = "txtSalary";
            txtSalary.ReadOnly = true;
            txtSalary.Size = new Size(452, 34);
            txtSalary.TabIndex = 53;
            // 
            // rbFemale
            // 
            rbFemale.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbFemale.AutoSize = true;
            rbFemale.Enabled = false;
            rbFemale.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(979, 233);
            rbFemale.Margin = new Padding(3, 4, 3, 4);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(65, 33);
            rbFemale.TabIndex = 52;
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
            rbMale.Location = new Point(788, 240);
            rbMale.Margin = new Padding(3, 4, 3, 4);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(85, 33);
            rbMale.TabIndex = 51;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAddress.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(779, 148);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(461, 34);
            txtAddress.TabIndex = 50;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(788, 48);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(452, 34);
            txtPhoneNumber.TabIndex = 49;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(641, 340);
            label2.Name = "label2";
            label2.Size = new Size(80, 29);
            label2.TabIndex = 48;
            label2.Text = "Lương";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(641, 235);
            label10.Name = "label10";
            label10.Size = new Size(101, 29);
            label10.TabIndex = 46;
            label10.Text = "Giới tính";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(641, 148);
            label5.Name = "label5";
            label5.Size = new Size(92, 29);
            label5.TabIndex = 45;
            label5.Text = "Địa chỉ ";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(628, 54);
            label9.Name = "label9";
            label9.Size = new Size(154, 29);
            label9.TabIndex = 44;
            label9.Text = "Số điện thoại";
            // 
            // btnCalendar
            // 
            btnCalendar.Enabled = false;
            btnCalendar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalendar.Image = (Image)resources.GetObject("btnCalendar.Image");
            btnCalendar.ImageAlign = ContentAlignment.MiddleRight;
            btnCalendar.Location = new Point(561, 328);
            btnCalendar.Margin = new Padding(3, 4, 3, 4);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Padding = new Padding(4, 0, 4, 0);
            btnCalendar.RightToLeft = RightToLeft.No;
            btnCalendar.Size = new Size(50, 58);
            btnCalendar.TabIndex = 43;
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click_1;
            // 
            // txtBirthday
            // 
            txtBirthday.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBirthday.Location = new Point(171, 340);
            txtBirthday.Margin = new Padding(3, 4, 3, 4);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.ReadOnly = true;
            txtBirthday.Size = new Size(362, 34);
            txtBirthday.TabIndex = 42;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(150, 235);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(461, 34);
            txtEmail.TabIndex = 41;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(150, 143);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(461, 34);
            txtName.TabIndex = 40;
            // 
            // txtRecepId
            // 
            txtRecepId.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecepId.Location = new Point(150, 49);
            txtRecepId.Margin = new Padding(3, 4, 3, 4);
            txtRecepId.Name = "txtRecepId";
            txtRecepId.ReadOnly = true;
            txtRecepId.Size = new Size(461, 34);
            txtRecepId.TabIndex = 39;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(15, 343);
            label12.Name = "label12";
            label12.Size = new Size(114, 29);
            label12.TabIndex = 38;
            label12.Text = "Năm sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 240);
            label7.Name = "label7";
            label7.Size = new Size(74, 29);
            label7.TabIndex = 35;
            label7.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 144);
            label4.Name = "label4";
            label4.Size = new Size(83, 29);
            label4.TabIndex = 34;
            label4.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 51);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 33;
            label3.Text = "Mã lễ tân";
            // 
            // btnCalendarWork
            // 
            btnCalendarWork.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCalendarWork.BackColor = Color.FromArgb(91, 85, 229);
            btnCalendarWork.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalendarWork.Image = (Image)resources.GetObject("btnCalendarWork.Image");
            btnCalendarWork.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalendarWork.Location = new Point(711, 16);
            btnCalendarWork.Margin = new Padding(3, 4, 3, 4);
            btnCalendarWork.Name = "btnCalendarWork";
            btnCalendarWork.Padding = new Padding(6, 0, 6, 0);
            btnCalendarWork.Size = new Size(224, 54);
            btnCalendarWork.TabIndex = 36;
            btnCalendarWork.Text = "Lịch làm việc";
            btnCalendarWork.TextAlign = ContentAlignment.MiddleRight;
            btnCalendarWork.UseVisualStyleBackColor = false;
            // 
            // ReceptionDescriptionDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 535);
            Controls.Add(btnCalendarWork);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(btnCreateRecep);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReceptionDescriptionDetail";
            Text = "ReceptionDescriptionDetail";
            Load += ReceptionDescriptionDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnCreateRecep;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label12;
        private TextBox txtRecepId;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtBirthday;
        private Button btnCalendar;
        private Label label9;
        private Label label5;
        private Label label10;
        private Label label2;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private TextBox txtSalary;
        private Button btnCalendarWork;
    }
}