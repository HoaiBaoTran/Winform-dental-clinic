namespace N19_DentalClinic.GUI.ReceptionistView
{
    partial class DeleteAppointment
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
            btnDelete = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 49);
            label1.Name = "label1";
            label1.Size = new Size(618, 46);
            label1.TabIndex = 1;
            label1.Text = "Bạn có muốn xóa bệnh nhân này ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(297, 277);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 88);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Đồng ý";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(567, 277);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(158, 88);
            btnBack.TabIndex = 3;
            btnBack.Text = "Hủy ";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DeleteAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Name = "DeleteAppointment";
            Text = "DeleteAppointment";
            Load += DeleteAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDelete;
        private Button btnBack;
    }
}