using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // to call python scripts
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms.DataVisualization.Charting;

namespace InvestmentAdviser
{
    public partial class Form1 : Form
    {
        // Initialization
        // Load CSV
        public static DataTable Table = ShowPortfolio.LoadCSV();
        public static DataTable Table_portofolio = ShowPortfolio.GetTablePortfolio(Table);
        public static DataRow Rows = ShowPortfolio.GenRows(Table_portofolio);

        // settings from CSV 
        public static int len_Rows_Table_portofolio = Table_portofolio.Rows.Count;
        public static int trackBar1_value_before = 0; // trackBar1_Scrollの初期値
        public static int column_ret = Table.Columns.Count - 2;
        public static int column_vol = Table.Columns.Count - 1;

        // variables to plot graphs
        public static double othersTime = 0;
        public static int limit_num_plot = 10;


        public Form1()
        {
            InitializeComponent();

            // ##### Initial settings #####
            // Initial settings of the portfolio tabs
            trackBar1.Minimum = 0;
            trackBar1.Maximum = len_Rows_Table_portofolio - 1;

            // Initial settings of the investment simulation
            textBox_age.Text = 25.ToString();
            textBox_age_goal.Text = 55.ToString();
            textBox_asset.Text = 0.ToString();
            textBox_asset_goal.Text = 2000.ToString();

            textBox_datanum.ReadOnly = true;
            textBox_ret.ReadOnly = true;
            textBox_vol.ReadOnly = true;

            // settings of significant figure
            int SIGNIFICANT_FIGURE = 4;
            textBox_datanum.Text = 0.ToString();
            textBox_ret.Text = Convert.ToString(Math.Round(Convert.ToDouble(Table.Rows[trackBar1_value_before][column_ret]), SIGNIFICANT_FIGURE));
            textBox_vol.Text = Convert.ToString(Math.Round(Convert.ToDouble(Table.Rows[trackBar1_value_before][column_vol]), SIGNIFICANT_FIGURE));

            // Show the Chart of asset ratio in portfolio
            ShowPortfolio.PlotPortfolioWeight(chart_WeightAsset, trackBar1, Table_portofolio);

            // Show the asset list on "Update" tab
            GUI.CSVutilsForListAsset.ListAssetLoad(dataGridView1);

            // Set checklistbox about list asset
            GUI.ShowEfficientFrontier.CheckedListBoxSet(checkedListBox1);
        }

        private void DebugButton1Click(object sender, EventArgs e)
        {
            Console.WriteLine("Debug");

            double asset_goal = Convert.ToDouble(textBox_asset_goal.Text.ToString());
            double asset_now = Convert.ToDouble(textBox_asset.Text.ToString());
            double period = Convert.ToDouble(textBox_age_goal.Text.ToString()) - Convert.ToDouble(textBox_age.Text.ToString());
            double ret = Convert.ToDouble(Table.Rows[trackBar1.Value][column_ret]);

            double MonthlyInvestment = CalcRequiredMoney.AmountOfMonthlyInvestment(asset_goal, asset_now, period, ret);

            textBox_dailyinvestment.Text = MonthlyInvestment.ToString();
        }

        private void PortfolioTrackBarScroll(object sender, EventArgs e)
        {
            // Update Textbox
            int diff_num = trackBar1.Value - trackBar1_value_before;
            textBox_datanum.Text = (int.Parse(textBox_datanum.Text) + diff_num).ToString();
            trackBar1_value_before = trackBar1.Value;

            textBox_ret.Text = Convert.ToString(Math.Round(Convert.ToDouble(Table.Rows[trackBar1.Value][column_ret]), 4));
            textBox_vol.Text = Convert.ToString(Math.Round(Convert.ToDouble(Table.Rows[trackBar1.Value][column_vol]), 4));

            ShowPortfolio.PlotPortfolioWeight(chart_WeightAsset, trackBar1, Table_portofolio);
        }

        private void PortfolioChartClick(object sender, EventArgs e)
        {
            MessageBox.Show("Gori-Macho Operation");
        }


        // ##### Update #####
        // Load and save the list of asset data
        private void ListAssetLoad(object sender, EventArgs e)
        {
            // Initialization
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // Reloading
            GUI.CSVutilsForListAsset.ListAssetLoad(dataGridView1);
        }

        private void ListAssetSave(object sender, EventArgs e)
        {
            GUI.CSVutilsForListAsset.ListAssetSave(dataGridView1);
        }

        // Update Historical Data
        private void UpdateHistoricalDataClick(object sender, EventArgs e)
        {
            Pyscripts.Pyscripts.RunPyScripts("HistoricalDataDownloader.py");
            Console.WriteLine("Done");
        }

        // ##### EfficientFrontier #####
        private void UpdateEfficientFrontierClick(object sender, EventArgs e)
        {
            List<string> list_checked = GUI.ShowEfficientFrontier.CheckedListBoxGet(checkedListBox1);
            string[] list_checked_str = list_checked.ToArray();
            //list_checked.ForEach(Console.WriteLine);
            InvestmentAdviser.Pyscripts.Pyscripts.RunPyScripts("GenEfficientFrontier.py", list_checked_str);
            GUI.ShowEfficientFrontier.PlotEfficientFrontier(chart_EfficientFrontier);
        }

        private void CheckAllClick(object sender, EventArgs e)
        {
            GUI.ShowEfficientFrontier.CheckedListBoxCheck(checkedListBox1, true);
        }

        private void UncheckAllClick(object sender, EventArgs e)
        {
            GUI.ShowEfficientFrontier.CheckedListBoxCheck(checkedListBox1, false);
        }

        private void UpdateChartClick(object sender, EventArgs e)
        {
            Table = ShowPortfolio.LoadCSV();
            Table_portofolio = ShowPortfolio.GetTablePortfolio(Table);
            //Rows = ShowPortfolio.GenRows(Table_portofolio);
            len_Rows_Table_portofolio = Table_portofolio.Rows.Count;
            trackBar1.Minimum = 0;
            trackBar1.Maximum = len_Rows_Table_portofolio - 1;
            textBox_datanum.Text = 0.ToString();
            column_ret = Table.Columns.Count - 2;
            column_vol = Table.Columns.Count - 1;
            int SIGNIFICANT_FIGURE = 4;
            textBox_ret.Text = Convert.ToString(Math.Round(Convert.ToDouble(Table.Rows[trackBar1_value_before][column_ret]), SIGNIFICANT_FIGURE));
            textBox_vol.Text = Convert.ToString(Math.Round(Convert.ToDouble(Table.Rows[trackBar1_value_before][column_vol]), SIGNIFICANT_FIGURE));
            ShowPortfolio.PlotPortfolioWeight(chart_WeightAsset, trackBar1, Table_portofolio);
            Console.WriteLine("UpdateChartClick");
        }
    }
}
