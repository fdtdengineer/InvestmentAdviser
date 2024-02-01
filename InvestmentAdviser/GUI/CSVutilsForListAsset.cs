using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;

namespace InvestmentAdviser.GUI
{
    class CSVutilsForListAsset
    {
        public static void ListAssetLoad(DataGridView dataGridView)
        {
            string filepath = "py\\config\\";
            string filename = "list_asset.csv";
            string csvfile = filepath + filename;

            TextFieldParser parser = new TextFieldParser(csvfile, Encoding.GetEncoding("Shift_JIS"));
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(","); // 区切り文字はコンマ

            string[] colheaders = parser.ReadFields(); // 1行読み込み
            for (int n = 0; n < colheaders.Length; n++)
            {
                string[] heads = colheaders[n].Split(':');
                dataGridView.Columns.Add(heads[0], heads[heads.Length > 1 ? 1 : 0]);
            }
            while (!parser.EndOfData)
            {
                string[] row = parser.ReadFields(); // 1行読み込み
                dataGridView.Rows.Add(row);
            }
            // 列の幅を調整
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.RowHeadersWidth = 40;
        }

        // ref ... https://hensa40.cutegirl.jp/archives/760
        public static void ListAssetSave(DataGridView dataGridView, string filename_csv = "list_asset.csv")
        {
            string filepath = "py\\config\\";
            using (StreamWriter writer = new StreamWriter(filepath + filename_csv, false, Encoding.GetEncoding("shift_jis")))
            {

                int rowCount = dataGridView.Rows.Count;

                // ユーザによる行追加が許可されている場合は、最後の新規入力用の
                // 1行分を差し引く
                if (dataGridView.AllowUserToAddRows == true)
                {
                    rowCount = rowCount - 1;
                }

                // column                 
                List<String> strList_columns = new List<String>();
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView.Columns[j] != null)
                    {
                        strList_columns.Add(dataGridView.Columns[j].Name.ToString());
                        
                    }
                    else
                    {
                        strList_columns.Add(0.ToString());
                    }
                }
                String[] strArray_columns = strList_columns.ToArray(); // 配列へ変換
                String strCsvData_columns = String.Join(",", strArray_columns);
                writer.WriteLine(strCsvData_columns);
                

                // 中身
                for (int i = 0; i < rowCount; i++)
                {
                    // リストの初期化
                    List<String> strList = new List<String>();

                    // 列
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        if (dataGridView[j, i].Value != null)
                        {
                            strList.Add(dataGridView[j, i].Value.ToString());
                        }
                        else
                        {
                            strList.Add(0.ToString());
                        }
                    }
                    String[] strArray = strList.ToArray(); // 配列へ変換

                    // CSV 形式に変換
                    String strCsvData = String.Join(",", strArray);

                    writer.WriteLine(strCsvData);
                }
            }
            Console.WriteLine("The list of asset data has been saved!");
        }

    }


}
