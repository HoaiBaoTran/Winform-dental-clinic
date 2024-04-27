namespace N19_DentalClinic.GUI.AdminView
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            pnChange = new Panel();
            txtDayTo = new TextBox();
            btnDayTo = new Button();
            txtDayFrom = new TextBox();
            btnDayFrom = new Button();
            pnEmpty = new Panel();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbChart = new ComboBox();
            cbDay = new ComboBox();
            panel2 = new Panel();
            btnExport = new Button();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel1.SuspendLayout();
            pnChange.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(180, 19);
            chart1.Margin = new Padding(4);
            chart1.Name = "chart1";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.FromArgb(91, 85, 229);
            series1.Font = new Font("Cambria Math", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            series1.ShadowColor = Color.White;
            chart1.Series.Add(series1);
            chart1.Size = new Size(783, 361);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pnChange);
            panel1.Controls.Add(pnEmpty);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbChart);
            panel1.Controls.Add(cbDay);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 207);
            panel1.TabIndex = 1;
            // 
            // pnChange
            // 
            pnChange.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnChange.Controls.Add(txtDayTo);
            pnChange.Controls.Add(btnDayTo);
            pnChange.Controls.Add(txtDayFrom);
            pnChange.Controls.Add(btnDayFrom);
            pnChange.Location = new Point(3, 129);
            pnChange.Name = "pnChange";
            pnChange.Size = new Size(959, 75);
            pnChange.TabIndex = 18;
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
            btnDayTo.Click += btnDayTo_Click_1;
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
            btnDayFrom.Click += btnDayFrom_Click_1;
            // 
            // pnEmpty
            // 
            pnEmpty.Location = new Point(3, 129);
            pnEmpty.Name = "pnEmpty";
            pnEmpty.Size = new Size(959, 75);
            pnEmpty.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(446, 91);
            label5.Name = "label5";
            label5.Size = new Size(193, 25);
            label5.TabIndex = 14;
            label5.Text = "Thống kê theo biểu đồ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 95);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 3;
            label2.Text = "Thống kê theo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 18);
            label3.Name = "label3";
            label3.Size = new Size(205, 30);
            label3.TabIndex = 5;
            label3.Text = "Thống kê doanh thu";
            // 
            // cbChart
            // 
            cbChart.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChart.FormattingEnabled = true;
            cbChart.Location = new Point(645, 92);
            cbChart.Name = "cbChart";
            cbChart.Size = new Size(185, 28);
            cbChart.TabIndex = 4;
            // 
            // cbDay
            // 
            cbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDay.FormattingEnabled = true;
            cbDay.Location = new Point(173, 92);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(185, 28);
            cbDay.TabIndex = 3;
            cbDay.SelectedIndexChanged += cbDay_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(128, 255, 255);
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(chart1);
            panel2.Location = new Point(-6, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(972, 390);
            panel2.TabIndex = 2;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(56, 92, 67);
            btnExport.Location = new Point(27, 126);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(117, 54);
            btnExport.TabIndex = 7;
            btnExport.Text = "Xuất file";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(189, 175, 9);
            btnTimKiem.Location = new Point(27, 43);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(117, 54);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 603);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Report";
            Text = "Form1";
            Load += Report_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnChange.ResumeLayout(false);
            pnChange.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel1;
        private Label label3;
        private ComboBox cbDay;
        private Panel panel2;
        private Button btnExport;
        private Button btnTimKiem;
        private ComboBox cbChart;
        private Label label5;
        private Label label2;
        private Panel pnChange;
        private TextBox txtDayTo;
        private Button btnDayTo;
        private TextBox txtDayFrom;
        private Button btnDayFrom;
        private Panel pnEmpty;
    }
}