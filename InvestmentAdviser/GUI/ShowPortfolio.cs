using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace InvestmentAdviser
{
    class ShowPortfolio
    {
        public static DataTable LoadCSV()
        {
            string filepath = "py\\ret_vol_and_weight\\";
            string filename = "ret_vol_and_weight.csv";
            bool isHeader = true;
            CSVtoDataTable cls;
            cls = new CSVtoDataTable();
            System.Data.DataTable Table = cls.Read(filepath + filename, isHeader);
            return Table;
        }
        public static DataTable GetTablePortfolio(DataTable Table)
        {
            //ポートフォリオ比のデータ抽出
            DataTable Table_portfolio = Table.Copy();
            Table_portfolio.Columns.RemoveAt(0); //列番号消去
            Table_portfolio.Columns.Remove("ret");
            Table_portfolio.Columns.Remove("vol");
            return Table_portfolio;
        }
        public static DataRow GenRows(DataTable Table_portfolio, int num_row_Table = 2)
        {
            DataRow Rows = Table_portfolio.Rows[num_row_Table];

            // 各(ret,vol)ごとのウェイトのsumが1になることの確認(デバッグ用)
            /*
            int len_Table = Table_portfolio.Columns.Count;
            double sum_Rows = 0;
            for (int i=0; i < len_Table; i++)
            {
                double Rows_i = Convert.ToDouble(Rows[i]);
                sum_Rows += Rows_i;
            }
            */

            return Rows;
        }

        public static void PlotPortfolioWeight(
            System.Windows.Forms.DataVisualization.Charting.Chart chart1,
            System.Windows.Forms.TrackBar trackBar1,
            DataTable Table_portofolio, 
            double othersTime = 0, 
            int limit_num_plot = 10
            )
        {
            // グラフ更新
            long maxSize = 0;
            long sumRowHeight = 0;
            chart1.Series["Series1"].Points.Clear();

            DataRow Rows = ShowPortfolio.GenRows(Table_portofolio, trackBar1.Value);

            for (int i1 = 0; i1 < Table_portofolio.Columns.Count; i1++)
            {
                if (i1 < limit_num_plot)
                {
                    double rate = Math.Round(Convert.ToDouble(Rows[i1]), 3, MidpointRounding.AwayFromZero) * 100;//グラフへプロットする比率を計算
                    string itemName = (Table_portofolio.Columns[i1].ToString().Length > 20) ? Table_portofolio.Columns[i1].ToString().Substring(0, 20) : Table_portofolio.Columns[i1].ToString();//項グラフへプロットする項目名を取得

                    //グラフにプロット
                    System.Windows.Forms.DataVisualization.Charting.DataPoint dp = new System.Windows.Forms.DataVisualization.Charting.DataPoint();
                    dp.SetValueXY(itemName, rate);
                    chart1.Series["Series1"].Points.Add(dp);

                    //凡例
                    maxSize = Math.Max(maxSize, TextRenderer.MeasureText(itemName, chart1.Legends["Legend1"].Font).Width);
                    sumRowHeight += TextRenderer.MeasureText(itemName, chart1.Legends["Legend1"].Font).Height;

                }
                else
                {
                    //上位10位より下の項目の合計値をまとめる
                    othersTime += Convert.ToInt32(Rows[i1]);

                }

            }

            //Value列の値の上位10位より下の項目の合計値は「その他」としてまとめて表示する。
            if (othersTime > 0)
            {
                //凡例のサイズ計算を行う。
                maxSize = Math.Max(maxSize, TextRenderer.MeasureText("その他", chart1.Legends["Legend1"].Font).Width);
                sumRowHeight += TextRenderer.MeasureText("その他", chart1.Legends["Legend1"].Font).Height;

                //グラフにデータをプロットする。
                double othersRate = Math.Round(othersTime, 3, MidpointRounding.AwayFromZero) * 100;
                System.Windows.Forms.DataVisualization.Charting.DataPoint dp = new System.Windows.Forms.DataVisualization.Charting.DataPoint();
                dp.SetValueXY("その他", othersRate);
                chart1.Series["Series1"].Points.Add(dp);
            }
        }


    }

}
