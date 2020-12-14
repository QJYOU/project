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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.calories_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.datePickbutton = new System.Windows.Forms.Button();
            this.BegindatePicker = new System.Windows.Forms.DateTimePicker();
            this.EnddatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calories_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
            this.SuspendLayout();
            // 
            // calories_Chart
            // 
            this.calories_Chart.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.calories_Chart.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.calories_Chart.Legends.Add(legend5);
            this.calories_Chart.Location = new System.Drawing.Point(47, 124);
            this.calories_Chart.Name = "calories_Chart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.calories_Chart.Series.Add(series5);
            this.calories_Chart.Size = new System.Drawing.Size(1080, 453);
            this.calories_Chart.TabIndex = 1;
            this.calories_Chart.Text = "Calories_Chart";
            // 
            // datePickbutton
            // 
            this.datePickbutton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.datePickbutton.Location = new System.Drawing.Point(988, 42);
            this.datePickbutton.Name = "datePickbutton";
            this.datePickbutton.Size = new System.Drawing.Size(149, 34);
            this.datePickbutton.TabIndex = 2;
            this.datePickbutton.Text = "Select";
            this.datePickbutton.UseVisualStyleBackColor = true;
            this.datePickbutton.Click += new System.EventHandler(this.datePickbutton_Click);
            // 
            // BegindatePicker
            // 
            this.BegindatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BegindatePicker.Location = new System.Drawing.Point(187, 40);
            this.BegindatePicker.Name = "BegindatePicker";
            this.BegindatePicker.Size = new System.Drawing.Size(145, 29);
            this.BegindatePicker.TabIndex = 3;
            this.BegindatePicker.ValueChanged += new System.EventHandler(this.BegindatePicker_ValueChanged);
            // 
            // EnddatePicker
            // 
            this.EnddatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EnddatePicker.Location = new System.Drawing.Point(439, 41);
            this.EnddatePicker.Name = "EnddatePicker";
            this.EnddatePicker.Size = new System.Drawing.Size(145, 29);
            this.EnddatePicker.TabIndex = 4;
            this.EnddatePicker.ValueChanged += new System.EventHandler(this.EnddatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date：";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(353, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "to";
            // 
            // piechart
            // 
            this.piechart.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Area3DStyle.Enable3D = true;
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.piechart.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Name = "Legend1";
            this.piechart.Legends.Add(legend6);
            this.piechart.Location = new System.Drawing.Point(212, 98);
            this.piechart.Name = "piechart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Label = "#PERCENT";
            series6.Legend = "Legend1";
            series6.LegendText = "#VALX";
            series6.Name = "Series1";
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.piechart.Series.Add(series6);
            this.piechart.Size = new System.Drawing.Size(770, 497);
            this.piechart.TabIndex = 0;
            this.piechart.Text = "chart1";
            title3.Name = "Title1";
            this.piechart.Titles.Add(title3);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Calories",
            "Carbonhydrate",
            "Protein",
            "Fat",
            "Sugar",
            "Average"});
            this.comboBox1.Location = new System.Drawing.Point(757, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 26);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(608, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingredient";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1195, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart calories_Chart;
        private System.Windows.Forms.Button datePickbutton;
        private System.Windows.Forms.DateTimePicker BegindatePicker;
        private System.Windows.Forms.DateTimePicker EnddatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart piechart;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}

