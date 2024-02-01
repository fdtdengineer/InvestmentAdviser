using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // to call python scripts
using System.IO;


namespace InvestmentAdviser.Pyscripts
{
    class Pyscripts
    {
        public static void RunPyScripts(string filename_py, params string[] str)
        {
            string filepath = "py\\"; // str: 可変長引数

            var PyProcess = new Process
            {
                StartInfo = new ProcessStartInfo("python.exe")
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = filepath + filename_py + " " + String.Join(" ", str),
                    CreateNoWindow = false
                    
                }
            };
            PyProcess.Start();
            StreamReader myStreamReader = PyProcess.StandardOutput;

            string myString = myStreamReader.ReadLine();
            PyProcess.WaitForExit();
            PyProcess.Close();
            Console.WriteLine(myString);
        }
    }
}
