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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.calories_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.datePickbutton = new System.Windows.Forms.Button();
            this.BegindatePicker = new System.Windows.Forms.DateTimePicker();
            this.EnddatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fat_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sugar_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.protein_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.carbonhydrate_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.calories_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fat_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sugar_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protein_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbonhydrate_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // calories_Chart
            // 
            this.calories_Chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.calories_Chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.calories_Chart.Legends.Add(legend1);
            this.calories_Chart.Location = new System.Drawing.Point(56, 12);
            this.calories_Chart.Name = "calories_Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.calories_Chart.Series.Add(series1);
            this.calories_Chart.Size = new System.Drawing.Size(944, 510);
            this.calories_Chart.TabIndex = 1;
            this.calories_Chart.Text = "Calories_Chart";
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
            this.datePickbutton.Location = new System.Drawing.Point(696, 551);
            this.datePickbutton.Name = "datePickbutton";
            this.datePickbutton.Size = new System.Drawing.Size(97, 32);
            this.datePickbutton.TabIndex = 2;
            this.datePickbutton.Text = "Select";
            this.datePickbutton.UseVisualStyleBackColor = true;
            this.datePickbutton.Click += new System.EventHandler(this.datePickbutton_Click);
            // 
            // BegindatePicker
            // 
            this.BegindatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BegindatePicker.Location = new System.Drawing.Point(228, 551);
            this.BegindatePicker.Name = "BegindatePicker";
            this.BegindatePicker.Size = new System.Drawing.Size(145, 29);
            this.BegindatePicker.TabIndex = 3;
            this.BegindatePicker.ValueChanged += new System.EventHandler(this.BegindatePicker_ValueChanged);
            // 
            // EnddatePicker
            // 
            this.EnddatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EnddatePicker.Location = new System.Drawing.Point(517, 551);
            this.EnddatePicker.Name = "EnddatePicker";
            this.EnddatePicker.Size = new System.Drawing.Size(145, 29);
            this.EnddatePicker.TabIndex = 4;
            this.EnddatePicker.ValueChanged += new System.EventHandler(this.EnddatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(78, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date：";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(434, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "to";
            // 
            // fat_chart
            // 
            this.fat_chart.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.fat_chart.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.fat_chart.Legends.Add(legend3);
            this.fat_chart.Location = new System.Drawing.Point(381, 40);
            this.fat_chart.Name = "fat_chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.fat_chart.Series.Add(series3);
            this.fat_chart.Size = new System.Drawing.Size(306, 177);
            this.fat_chart.TabIndex = 7;
            this.fat_chart.Text = "fat_chart";
            this.fat_chart.Visible = false;
            // 
            // sugar_chart
            // 
            this.sugar_chart.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.sugar_chart.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.sugar_chart.Legends.Add(legend4);
            this.sugar_chart.Location = new System.Drawing.Point(652, 162);
            this.sugar_chart.Name = "sugar_chart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.sugar_chart.Series.Add(series4);
            this.sugar_chart.Size = new System.Drawing.Size(306, 177);
            this.sugar_chart.TabIndex = 8;
            this.sugar_chart.Text = "sugar_chart";
            this.sugar_chart.Visible = false;
            // 
            // protein_chart
            // 
            this.protein_chart.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.protein_chart.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.protein_chart.Legends.Add(legend5);
            this.protein_chart.Location = new System.Drawing.Point(211, 162);
            this.protein_chart.Name = "protein_chart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.protein_chart.Series.Add(series5);
            this.protein_chart.Size = new System.Drawing.Size(306, 177);
            this.protein_chart.TabIndex = 9;
            this.protein_chart.Text = "protein_chart";
            this.protein_chart.Visible = false;
            // 
            // carbonhydrate_chart
            // 
            this.carbonhydrate_chart.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.carbonhydrate_chart.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.carbonhydrate_chart.Legends.Add(legend6);
            this.carbonhydrate_chart.Location = new System.Drawing.Point(732, 40);
            this.carbonhydrate_chart.Name = "carbonhydrate_chart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.carbonhydrate_chart.Series.Add(series6);
            this.carbonhydrate_chart.Size = new System.Drawing.Size(306, 177);
            this.carbonhydrate_chart.TabIndex = 10;
            this.carbonhydrate_chart.Text = "carbonhydrate_chart";
            this.carbonhydrate_chart.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(860, 459);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 146);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1195, 617);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.carbonhydrate_chart);
            this.Controls.Add(this.protein_chart);
            this.Controls.Add(this.sugar_chart);
            this.Controls.Add(this.fat_chart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnddatePicker);
            this.Controls.Add(this.BegindatePicker);
            this.Controls.Add(this.datePickbutton);
            this.Controls.Add(this.calories_Chart);
            this.Controls.Add(this.piechart);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calories_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fat_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sugar_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protein_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbonhydrate_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart calories_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart piechart;
        private System.Windows.Forms.Button datePickbutton;
        private System.Windows.Forms.DateTimePicker BegindatePicker;
        private System.Windows.Forms.DateTimePicker EnddatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart sugar_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart protein_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart carbonhydrate_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart fat_chart;
        private System.Windows.Forms.TextBox textBox1;
    }
}

