namespace N19_DentalClinic.GUI.AdminView
{
    partial class Statistic_Month
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
            btnMonthFrom = new Button();
            button2 = new Button();
            cbMonth1 = new ComboBox();
            cbMonth2 = new ComboBox();
            SuspendLayout();
            // 
            // btnMonthFrom
            // 
            btnMonthFrom.Location = new Point(29, 22);
            btnMonthFrom.Name = "btnMonthFrom";
            btnMonthFrom.Size = new Size(131, 36);
            btnMonthFrom.TabIndex = 0;
            btnMonthFrom.Text = "Tháng bắt đầu";
            btnMonthFrom.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(471, 22);
            button2.Name = "button2";
            button2.Size = new Size(131, 36);
            button2.TabIndex = 1;
            button2.Text = "Tháng kết thúc";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbMonth1
            // 
            cbMonth1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMonth1.FormattingEnabled = true;
            cbMonth1.Location = new Point(175, 27);
            cbMonth1.Name = "cbMonth1";
            cbMonth1.Size = new Size(148, 28);
            cbMonth1.TabIndex = 2;
            // 
            // cbMonth2
            // 
            cbMonth2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMonth2.FormattingEnabled = true;
            cbMonth2.Location = new Point(618, 27);
            cbMonth2.Name = "cbMonth2";
            cbMonth2.Size = new Size(148, 28);
            cbMonth2.TabIndex = 3;
            // 
            // Statistic_Month
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbMonth2);
            Controls.Add(cbMonth1);
            Controls.Add(button2);
            Controls.Add(btnMonthFrom);
            Name = "Statistic_Month";
            Size = new Size(959, 75);
            Load += Statistic_Month_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMonthFrom;
        private Button button2;
        private ComboBox cbMonth1;
        private ComboBox cbMonth2;
    }
}
