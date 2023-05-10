using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_TEST
{
    public static class CSVreader
    {
        public static string[] ReadAllCsvRows(string directoryPath)
        {
            List<string> allRows = new List<string>();

            try
            {
                string[] csvFiles = Directory.GetFiles(directoryPath, "*.csv");

                foreach (string filePath in csvFiles)
                {
                    string[] rows = File.ReadAllLines(filePath);
                    allRows.AddRange(rows);
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("directory does not exist");
            }
            catch (Exception ex)
            {
                Console.WriteLine("there were some issues when reading file CSV" + ex.Message);
            }

            return allRows.ToArray();
        }
    }
}
