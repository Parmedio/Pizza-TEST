using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_TEST
{
    public static class CSVreader
    {
        public static (int, string)[] ReadAllCsvRows(string directoryPath)
        {
            List<(int, string)> allRows = new List<(int, string)>();
            int receiptNumber = 1;

            string[] csvFiles = Directory.GetFiles(directoryPath, "*.csv");

            foreach (string orderFile in csvFiles)
            {
                string[] rows = File.ReadAllLines(orderFile);

                foreach (string row in rows)
                {
                    allRows.Add((receiptNumber, row.Replace(" ", "")));
                }
                receiptNumber++;
            }
            return allRows.ToArray();
        }
    }
}
