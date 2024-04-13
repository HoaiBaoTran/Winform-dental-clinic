namespace N19_DentalClinic.GUI.AdminView
{
    partial class Statistic_Season
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
            cbSea2 = new ComboBox();
            cbSea1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // cbSea2
            // 
            cbSea2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSea2.FormattingEnabled = true;
            cbSea2.Location = new Point(618, 27);
            cbSea2.Name = "cbSea2";
            cbSea2.Size = new Size(148, 28);
            cbSea2.TabIndex = 11;
            // 
            // cbSea1
            // 
            cbSea1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSea1.FormattingEnabled = true;
            cbSea1.Location = new Point(175, 27);
            cbSea1.Name = "cbSea1";
            cbSea1.Size = new Size(148, 28);
            cbSea1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(471, 22);
            button2.Name = "button2";
            button2.Size = new Size(131, 36);
            button2.TabIndex = 9;
            button2.Text = "Quý kết thúc";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(29, 22);
            button1.Name = "button1";
            button1.Size = new Size(131, 36);
            button1.TabIndex = 8;
            button1.Text = "Quý bắt đầu";
            button1.UseVisualStyleBackColor = true;
            // 
            // Statistic_Season
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbSea2);
            Controls.Add(cbSea1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Statistic_Season";
            Size = new Size(959, 75);
            Load += Statistic_Season_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbSea2;
        private ComboBox cbSea1;
        private Button button2;
        private Button button1;
    }
}
