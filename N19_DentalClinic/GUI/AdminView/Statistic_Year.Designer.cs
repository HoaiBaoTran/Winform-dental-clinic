namespace N19_DentalClinic.GUI.AdminView
{
    partial class Statistic_Year
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
            button2 = new Button();
            button1 = new Button();
            nmYear1 = new NumericUpDown();
            nmYear2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nmYear1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmYear2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(471, 22);
            button2.Name = "button2";
            button2.Size = new Size(131, 36);
            button2.TabIndex = 5;
            button2.Text = "Năm kết thúc";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(29, 22);
            button1.Name = "button1";
            button1.Size = new Size(131, 36);
            button1.TabIndex = 4;
            button1.Text = "Năm bắt đầu";
            button1.UseVisualStyleBackColor = true;
            // 
            // nmYear1
            // 
            nmYear1.Location = new Point(183, 28);
            nmYear1.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nmYear1.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmYear1.Name = "nmYear1";
            nmYear1.Size = new Size(150, 27);
            nmYear1.TabIndex = 6;
            nmYear1.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            nmYear1.ValueChanged += nmYear1_ValueChanged;
            // 
            // nmYear2
            // 
            nmYear2.Location = new Point(625, 27);
            nmYear2.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nmYear2.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nmYear2.Name = "nmYear2";
            nmYear2.Size = new Size(150, 27);
            nmYear2.TabIndex = 7;
            nmYear2.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // Statistic_Year
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nmYear2);
            Controls.Add(nmYear1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Statistic_Year";
            Size = new Size(959, 75);
            Load += Statistic_Year_Load;
            ((System.ComponentModel.ISupportInitialize)nmYear1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmYear2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button1;
        private NumericUpDown nmYear1;
        private NumericUpDown nmYear2;
    }
}
