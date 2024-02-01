using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;


namespace InvestmentAdviser.GUI
{
    class ShowEfficientFrontier
    {
        public static List<string> LoadListAsset_old()
        {
            string filepath = "py\\ret_vol_and_weight\\";
            string filename = "ret_vol_and_weight.csv";
            string csvfile = filepath + filename;

            List<string> mylist = new List<string>();
            //string line;
            using (StreamReader sr = new StreamReader(csvfile))
            {
                //while ((line = sr.ReadLine()) != null)
                //{
                //    mylist.Add(line);
                //}
                mylist.Add(sr.ReadLine());
            }
            Console.WriteLine(mylist);

            int num_coldata = 3; // アセットタイトル以外のカラムの数。ret, col, weight の3つ。
            List<string> listasset = mylist[0].Split(',').ToList();
            listasset = listasset.GetRange(1, listasset.Count - num_coldata);

            return listasset;
        }

        public static List<string> LoadListAsset()
        {
            string filepath = "py\\config\\";
            string filename = "list_asset.csv";
            string csvfile = filepath + filename;

            int num_listname = 1; // name_ENG の列番号
            List<string> mylist = new List<string>();
            string line;
            using (StreamReader sr = new StreamReader(csvfile))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string name_i = line.Split(',').ToList()[num_listname];
                    mylist.Add(name_i);
                }
            }
            List<string> listasset = mylist.GetRange(1, mylist.Count-1);
            return listasset;
        }



        public static void CheckedListBoxSet(CheckedListBox checkedListBox1)
        {
            List<string> listasset = LoadListAsset();

            for (int i=0; i < listasset.Count; i++)
            {
                checkedListBox1.Items.Add(listasset[i]); // add
                //checkedListBox1.SetItemChecked(i, true); // checked
            }
        }

        public static void CheckedListBoxCheck(CheckedListBox checkedListBox1, bool TF = true)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, TF); // check or uncheck
            }
        }

        public static List<string> CheckedListBoxGet(CheckedListBox checkedListBox1)
        {
            var list_checked = new List<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                bool bool_ifchecked = checkedListBox1.GetItemChecked(i);
                string str_ifchecked = bool_ifchecked.ToString();
                list_checked.Add(str_ifchecked);

            }
            return list_checked;

        }




        public static void PlotEfficientFrontier(Chart chart_EfficientFrontier)
        {
            DataTable dt_EfficientFrontier = ShowPortfolio.LoadCSV();

            chart_EfficientFrontier.ChartAreas.Clear();
            chart_EfficientFrontier.Series.Clear();
            ChartArea chartArea = new ChartArea("chartArea");

            // 生成したエリアをChartコントロールに追加します。
            chart_EfficientFrontier.ChartAreas.Add(chartArea);

            // Series(系列)を生成します
            Series series = new Series();

            // 系列の種類を折れ線グラフ(Line)に設定します
            series.ChartType = SeriesChartType.Point;

            // 系列の凡例を設置します
            series.LegendText = "Efficient Frontier";

            // 系列のポイント情報をセットします
            int len_Table = dt_EfficientFrontier.Rows.Count;


            for (int i = 0; i < len_Table; i++)
            {
                series.Points.AddXY(Convert.ToDouble(dt_EfficientFrontier.Rows[i]["vol"]), Convert.ToDouble(dt_EfficientFrontier.Rows[i]["ret"]));
            }
            // 生成・設定した系列をChartコントロールに追加します
            chart_EfficientFrontier.Series.Add(series);

            chartArea.AxisX.Title = "return [1/y]";
            chartArea.AxisY.Title = "volatility [1/y]";
            chart_EfficientFrontier.ChartAreas["chartArea"].AxisX.Minimum = 0;
            chart_EfficientFrontier.ChartAreas["chartArea"].AxisX.Maximum = 0.25;

            // 凡例非表示
            series.IsVisibleInLegend = false;
        }
    }
}
