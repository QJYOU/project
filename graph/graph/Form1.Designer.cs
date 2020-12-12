namespace graph
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.linechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.datePickbutton = new System.Windows.Forms.Button();
            this.BegindatePicker = new System.Windows.Forms.DateTimePicker();
            this.EnddatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.linechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
            this.SuspendLayout();
            // 
            // linechart
            // 
            this.linechart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.linechart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.linechart.Legends.Add(legend1);
            this.linechart.Location = new System.Drawing.Point(521, 61);
            this.linechart.Name = "linechart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.linechart.Series.Add(series1);
            this.linechart.Size = new System.Drawing.Size(402, 233);
            this.linechart.TabIndex = 1;
            this.linechart.Text = "chart2";
            // 
            // piechart
            // 
            this.piechart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.piechart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.piechart.Legends.Add(legend2);
            this.piechart.Location = new System.Drawing.Point(34, 26);
            this.piechart.Name = "piechart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Label = "#PERCENT{P1}";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.piechart.Series.Add(series2);
            this.piechart.Size = new System.Drawing.Size(501, 313);
            this.piechart.TabIndex = 0;
            this.piechart.Text = "chart1";
            title1.Name = "Title1";
            this.piechart.Titles.Add(title1);
            // 
            // datePickbutton
            // 
            this.datePickbutton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.datePickbutton.Location = new System.Drawing.Point(621, 370);
            this.datePickbutton.Name = "datePickbutton";
            this.datePickbutton.Size = new System.Drawing.Size(97, 32);
            this.datePickbutton.TabIndex = 2;
            this.datePickbutton.Text = "選擇日期";
            this.datePickbutton.UseVisualStyleBackColor = true;
            this.datePickbutton.Click += new System.EventHandler(this.datePickbutton_Click);
            // 
            // BegindatePicker
            // 
            this.BegindatePicker.Location = new System.Drawing.Point(259, 373);
            this.BegindatePicker.Name = "BegindatePicker";
            this.BegindatePicker.Size = new System.Drawing.Size(145, 29);
            this.BegindatePicker.TabIndex = 3;
            this.BegindatePicker.ValueChanged += new System.EventHandler(this.BegindatePicker_ValueChanged);
            // 
            // EnddatePicker
            // 
            this.EnddatePicker.Location = new System.Drawing.Point(432, 373);
            this.EnddatePicker.Name = "EnddatePicker";
            this.EnddatePicker.Size = new System.Drawing.Size(145, 29);
            this.EnddatePicker.TabIndex = 4;
            this.EnddatePicker.ValueChanged += new System.EventHandler(this.EnddatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(102, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "日期範圍";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1046, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnddatePicker);
            this.Controls.Add(this.BegindatePicker);
            this.Controls.Add(this.datePickbutton);
            this.Controls.Add(this.linechart);
            this.Controls.Add(this.piechart);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.linechart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart linechart;
        private System.Windows.Forms.DataVisualization.Charting.Chart piechart;
        private System.Windows.Forms.Button datePickbutton;
        private System.Windows.Forms.DateTimePicker BegindatePicker;
        private System.Windows.Forms.DateTimePicker EnddatePicker;
        private System.Windows.Forms.Label label1;
    }
}

