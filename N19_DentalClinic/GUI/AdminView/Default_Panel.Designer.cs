namespace N19_DentalClinic.GUI.AdminView
{
    partial class Default_Panel
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
            pnChange = new Panel();
            txtDayTo = new TextBox();
            btnDayTo = new Button();
            txtDayFrom = new TextBox();
            btnDayFrom = new Button();
            pnChange.SuspendLayout();
            SuspendLayout();
            // 
            // pnChange
            // 
            pnChange.Controls.Add(txtDayTo);
            pnChange.Controls.Add(btnDayTo);
            pnChange.Controls.Add(txtDayFrom);
            pnChange.Controls.Add(btnDayFrom);
            pnChange.Location = new Point(-2, 1);
            pnChange.Name = "pnChange";
            pnChange.Size = new Size(959, 75);
            pnChange.TabIndex = 20;
            // 
            // txtDayTo
            // 
            txtDayTo.Location = new Point(649, 24);
            txtDayTo.Name = "txtDayTo";
            txtDayTo.ReadOnly = true;
            txtDayTo.Size = new Size(148, 27);
            txtDayTo.TabIndex = 21;
            // 
            // btnDayTo
            // 
            btnDayTo.Location = new Point(502, 20);
            btnDayTo.Name = "btnDayTo";
            btnDayTo.Size = new Size(131, 35);
            btnDayTo.TabIndex = 20;
            btnDayTo.Text = "Ngày kết thúc";
            btnDayTo.UseVisualStyleBackColor = true;
            // 
            // txtDayFrom
            // 
            txtDayFrom.Location = new Point(177, 24);
            txtDayFrom.Name = "txtDayFrom";
            txtDayFrom.ReadOnly = true;
            txtDayFrom.Size = new Size(148, 27);
            txtDayFrom.TabIndex = 19;
            // 
            // btnDayFrom
            // 
            btnDayFrom.Location = new Point(31, 19);
            btnDayFrom.Name = "btnDayFrom";
            btnDayFrom.Size = new Size(131, 36);
            btnDayFrom.TabIndex = 18;
            btnDayFrom.Text = "Ngày bắt đầu";
            btnDayFrom.UseVisualStyleBackColor = true;
            // 
            // Default_Panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnChange);
            Name = "Default_Panel";
            Size = new Size(959, 75);
            pnChange.ResumeLayout(false);
            pnChange.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnChange;
        private TextBox txtDayTo;
        private Button btnDayTo;
        private TextBox txtDayFrom;
        private Button btnDayFrom;
    }
}
