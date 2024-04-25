namespace N19_DentalClinic.GUI.AccountView
{
    partial class ConfirmToLogin
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
            btnCancel = new Button();
            btnBackToLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 40);
            label1.Name = "label1";
            label1.Size = new Size(337, 39);
            label1.TabIndex = 0;
            label1.Text = "Xác nhận đăng xuất";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(80, 101, 122);
            btnCancel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(453, 198);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(158, 88);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Hủy ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBackToLogin.BackColor = Color.FromArgb(250, 51, 38);
            btnBackToLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackToLogin.ForeColor = Color.White;
            btnBackToLogin.Location = new Point(277, 198);
            btnBackToLogin.Margin = new Padding(3, 4, 3, 4);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(144, 88);
            btnBackToLogin.TabIndex = 9;
            btnBackToLogin.Text = "Đồng ý";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // ConfirmToLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 316);
            Controls.Add(btnCancel);
            Controls.Add(btnBackToLogin);
            Controls.Add(label1);
            Name = "ConfirmToLogin";
            Text = "ConfirmToLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancel;
        private Button btnBackToLogin;
    }
}