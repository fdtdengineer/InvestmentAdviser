
namespace InvestmentAdviser
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_WeightAsset = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LoadCSVData = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox_datanum = new System.Windows.Forms.TextBox();
            this.textBox_ret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_vol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Update = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateHistoricalData = new System.Windows.Forms.Button();
            this.Calculation = new System.Windows.Forms.TabPage();
            this.UncheckAll = new System.Windows.Forms.Button();
            this.CheckAll = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.chart_EfficientFrontier = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Portfolio = new System.Windows.Forms.TabPage();
            this.UpdateChart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_dailyinvestment = new System.Windows.Forms.TextBox();
            this.textBox_asset_goal = new System.Windows.Forms.TextBox();
            this.textBox_asset = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_age_goal = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_WeightAsset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Calculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_EfficientFrontier)).BeginInit();
            this.Portfolio.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_WeightAsset
            // 
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 100F;
            chartArea1.InnerPlotPosition.Width = 50F;
            chartArea1.InnerPlotPosition.X = 5F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.chart_WeightAsset.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 80F;
            legend1.Position.Width = 40F;
            legend1.Position.X = 60F;
            legend1.Position.Y = 10F;
            legend1.TitleFont = new System.Drawing.Font("Arial Narrow", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart_WeightAsset.Legends.Add(legend1);
            this.chart_WeightAsset.Location = new System.Drawing.Point(11, 38);
            this.chart_WeightAsset.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.chart_WeightAsset.Name = "chart_WeightAsset";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.White;
            series1.CustomProperties = "PieStartAngle=270";
            series1.Font = new System.Drawing.Font("Arial Narrow", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_WeightAsset.Series.Add(series1);
            this.chart_WeightAsset.Size = new System.Drawing.Size(253, 167);
            this.chart_WeightAsset.TabIndex = 0;
            this.chart_WeightAsset.Text = "chart1";
            this.chart_WeightAsset.Click += new System.EventHandler(this.PortfolioChartClick);
            // 
            // LoadCSVData
            // 
            this.LoadCSVData.Location = new System.Drawing.Point(312, 147);
            this.LoadCSVData.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.LoadCSVData.Name = "LoadCSVData";
            this.LoadCSVData.Size = new System.Drawing.Size(175, 23);
            this.LoadCSVData.TabIndex = 1;
            this.LoadCSVData.Text = "Culculate Monthly Investment";
            this.LoadCSVData.UseVisualStyleBackColor = true;
            this.LoadCSVData.Click += new System.EventHandler(this.DebugButton1Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(11, 223);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.trackBar1.Maximum = 3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(153, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.PortfolioTrackBarScroll);
            // 
            // textBox_datanum
            // 
            this.textBox_datanum.Location = new System.Drawing.Point(218, 216);
            this.textBox_datanum.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox_datanum.Name = "textBox_datanum";
            this.textBox_datanum.Size = new System.Drawing.Size(48, 19);
            this.textBox_datanum.TabIndex = 3;
            // 
            // textBox_ret
            // 
            this.textBox_ret.Location = new System.Drawing.Point(218, 234);
            this.textBox_ret.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox_ret.Name = "textBox_ret";
            this.textBox_ret.Size = new System.Drawing.Size(48, 19);
            this.textBox_ret.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "return";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "volatility";
            // 
            // textBox_vol
            // 
            this.textBox_vol.Location = new System.Drawing.Point(218, 252);
            this.textBox_vol.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox_vol.Name = "textBox_vol";
            this.textBox_vol.Size = new System.Drawing.Size(48, 19);
            this.textBox_vol.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "DataNum";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Update);
            this.tabControl1.Controls.Add(this.Calculation);
            this.tabControl1.Controls.Add(this.Portfolio);
            this.tabControl1.Location = new System.Drawing.Point(12, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 400);
            this.tabControl1.TabIndex = 9;
            // 
            // Update
            // 
            this.Update.Controls.Add(this.button2);
            this.Update.Controls.Add(this.dataGridView1);
            this.Update.Controls.Add(this.button1);
            this.Update.Controls.Add(this.UpdateHistoricalData);
            this.Update.Location = new System.Drawing.Point(4, 22);
            this.Update.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(772, 374);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save to CSV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ListAssetSave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(737, 307);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reload AssetList";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ListAssetLoad);
            // 
            // UpdateHistoricalData
            // 
            this.UpdateHistoricalData.Location = new System.Drawing.Point(585, 11);
            this.UpdateHistoricalData.Name = "UpdateHistoricalData";
            this.UpdateHistoricalData.Size = new System.Drawing.Size(75, 23);
            this.UpdateHistoricalData.TabIndex = 0;
            this.UpdateHistoricalData.Text = "Update";
            this.UpdateHistoricalData.UseVisualStyleBackColor = true;
            this.UpdateHistoricalData.Click += new System.EventHandler(this.UpdateHistoricalDataClick);
            // 
            // Calculation
            // 
            this.Calculation.Controls.Add(this.UncheckAll);
            this.Calculation.Controls.Add(this.CheckAll);
            this.Calculation.Controls.Add(this.checkedListBox1);
            this.Calculation.Controls.Add(this.button3);
            this.Calculation.Controls.Add(this.chart_EfficientFrontier);
            this.Calculation.Location = new System.Drawing.Point(4, 22);
            this.Calculation.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Calculation.Name = "Calculation";
            this.Calculation.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Calculation.Size = new System.Drawing.Size(772, 374);
            this.Calculation.TabIndex = 0;
            this.Calculation.Text = "EfficientFrontier";
            this.Calculation.UseVisualStyleBackColor = true;
            // 
            // UncheckAll
            // 
            this.UncheckAll.Location = new System.Drawing.Point(97, 22);
            this.UncheckAll.Name = "UncheckAll";
            this.UncheckAll.Size = new System.Drawing.Size(75, 23);
            this.UncheckAll.TabIndex = 4;
            this.UncheckAll.Text = "Uncheck";
            this.UncheckAll.UseVisualStyleBackColor = true;
            this.UncheckAll.Click += new System.EventHandler(this.UncheckAllClick);
            // 
            // CheckAll
            // 
            this.CheckAll.Location = new System.Drawing.Point(16, 22);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(75, 23);
            this.CheckAll.TabIndex = 3;
            this.CheckAll.Text = "Check";
            this.CheckAll.UseVisualStyleBackColor = true;
            this.CheckAll.Click += new System.EventHandler(this.CheckAllClick);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(16, 51);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(156, 172);
            this.checkedListBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.UpdateEfficientFrontierClick);
            // 
            // chart_EfficientFrontier
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_EfficientFrontier.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_EfficientFrontier.Legends.Add(legend2);
            this.chart_EfficientFrontier.Location = new System.Drawing.Point(321, 51);
            this.chart_EfficientFrontier.Name = "chart_EfficientFrontier";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_EfficientFrontier.Series.Add(series2);
            this.chart_EfficientFrontier.Size = new System.Drawing.Size(300, 195);
            this.chart_EfficientFrontier.TabIndex = 0;
            this.chart_EfficientFrontier.Text = "chart1";
            // 
            // Portfolio
            // 
            this.Portfolio.Controls.Add(this.UpdateChart);
            this.Portfolio.Controls.Add(this.label8);
            this.Portfolio.Controls.Add(this.textBox_dailyinvestment);
            this.Portfolio.Controls.Add(this.textBox_asset_goal);
            this.Portfolio.Controls.Add(this.textBox_asset);
            this.Portfolio.Controls.Add(this.label7);
            this.Portfolio.Controls.Add(this.label6);
            this.Portfolio.Controls.Add(this.label5);
            this.Portfolio.Controls.Add(this.label4);
            this.Portfolio.Controls.Add(this.textBox_age_goal);
            this.Portfolio.Controls.Add(this.textBox_age);
            this.Portfolio.Controls.Add(this.chart_WeightAsset);
            this.Portfolio.Controls.Add(this.label3);
            this.Portfolio.Controls.Add(this.label2);
            this.Portfolio.Controls.Add(this.textBox_datanum);
            this.Portfolio.Controls.Add(this.LoadCSVData);
            this.Portfolio.Controls.Add(this.trackBar1);
            this.Portfolio.Controls.Add(this.textBox_ret);
            this.Portfolio.Controls.Add(this.label1);
            this.Portfolio.Controls.Add(this.textBox_vol);
            this.Portfolio.Location = new System.Drawing.Point(4, 22);
            this.Portfolio.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Portfolio.Name = "Portfolio";
            this.Portfolio.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Portfolio.Size = new System.Drawing.Size(772, 374);
            this.Portfolio.TabIndex = 1;
            this.Portfolio.Text = "Portfolio";
            this.Portfolio.UseVisualStyleBackColor = true;
            // 
            // UpdateChart
            // 
            this.UpdateChart.Location = new System.Drawing.Point(11, 10);
            this.UpdateChart.Name = "UpdateChart";
            this.UpdateChart.Size = new System.Drawing.Size(75, 23);
            this.UpdateChart.TabIndex = 19;
            this.UpdateChart.Text = "Update";
            this.UpdateChart.UseVisualStyleBackColor = true;
            this.UpdateChart.Click += new System.EventHandler(this.UpdateChartClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "MonthlyInvestment";
            // 
            // textBox_dailyinvestment
            // 
            this.textBox_dailyinvestment.Location = new System.Drawing.Point(413, 205);
            this.textBox_dailyinvestment.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox_dailyinvestment.Name = "textBox_dailyinvestment";
            this.textBox_dailyinvestment.Size = new System.Drawing.Size(48, 19);
            this.textBox_dailyinvestment.TabIndex = 17;
            // 
            // textBox_asset_goal
            // 
            this.textBox_asset_goal.Location = new System.Drawing.Point(377, 110);
            this.textBox_asset_goal.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox_asset_goal.Name = "textBox_asset_goal";
            this.textBox_asset_goal.Size = new System.Drawing.Size(48, 19);
            this.textBox_asset_goal.TabIndex = 16;
            // 
            // textBox_asset
            // 
            this.textBox_asset.Location = new System.Drawing.Point(377, 92);
            this.textBox_asset.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox_asset.Name = "textBox_asset";
            this.textBox_asset.Size = new System.Drawing.Size(48, 19);
            this.textBox_asset.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "asset (goal)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "asset";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "age (goal)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "age";
            // 
            // textBox_age_goal
            // 
            this.textBox_age_goal.Location = new System.Drawing.Point(377, 60);
            this.textBox_age_goal.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox_age_goal.Name = "textBox_age_goal";
            this.textBox_age_goal.Size = new System.Drawing.Size(48, 19);
            this.textBox_age_goal.TabIndex = 10;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(377, 38);
            this.textBox_age.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(48, 19);
            this.textBox_age.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 455);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_WeightAsset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Update.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Calculation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_EfficientFrontier)).EndInit();
            this.Portfolio.ResumeLayout(false);
            this.Portfolio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LoadCSVData;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chart_WeightAsset;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox_datanum;
        private System.Windows.Forms.TextBox textBox_ret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_vol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Update;
        private System.Windows.Forms.TabPage Calculation;
        private System.Windows.Forms.TabPage Portfolio;
        private System.Windows.Forms.TextBox textBox_asset_goal;
        private System.Windows.Forms.TextBox textBox_asset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_age_goal;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_dailyinvestment;
        private System.Windows.Forms.Button UpdateHistoricalData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_EfficientFrontier;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button UncheckAll;
        private System.Windows.Forms.Button CheckAll;
        private System.Windows.Forms.Button UpdateChart;
    }
}

