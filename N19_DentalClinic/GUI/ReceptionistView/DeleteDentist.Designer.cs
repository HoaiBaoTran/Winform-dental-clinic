namespace N19_DentalClinic.GUI.ReceptionistView
{
    partial class DeleteDentist
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
            btnBack = new Button();
            btnDelete = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(586, 296);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(158, 88);
            btnBack.TabIndex = 5;
            btnBack.Text = "Hủy ";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(410, 296);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 88);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Đồng ý";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 51);
            label1.Name = "label1";
            label1.Size = new Size(537, 46);
            label1.TabIndex = 3;
            label1.Text = "Bạn có muốn xóa nha sĩ này ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 430);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // DeleteDentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteDentist";
            Text = "Xóa nha sĩ";
            Load += DeleteDentist_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnDelete;
        private Label label1;
        private GroupBox groupBox1;
    }
}