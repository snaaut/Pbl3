namespace PBL3
{
    partial class FormDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbbDoanhThuTheoNam = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbDoanhThuTheoNam
            // 
            this.cbbDoanhThuTheoNam.FormattingEnabled = true;
            this.cbbDoanhThuTheoNam.Location = new System.Drawing.Point(85, 70);
            this.cbbDoanhThuTheoNam.Name = "cbbDoanhThuTheoNam";
            this.cbbDoanhThuTheoNam.Size = new System.Drawing.Size(121, 24);
            this.cbbDoanhThuTheoNam.TabIndex = 0;
            this.cbbDoanhThuTheoNam.SelectedIndexChanged += new System.EventHandler(this.cbbDoanhThuTheoNam_SelectedIndexChanged_1);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(85, 124);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Doanh Thu Theo Năm";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(877, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // FormDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 535);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cbbDoanhThuTheoNam);
            this.Name = "FormDoanhThu";
            this.Text = "FormDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDoanhThuTheoNam;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}