using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_TEST
{
    public static class ReceiptLogger
    {
        public static void GenerateCSVReceipt((int, string)[] data, string directoryPath)
        {
            foreach (var item in data)
            {
                int fileNumber = item.Item1;
                string row = item.Item2;

                string fileName = $"scontrino {fileNumber}.csv";
                string filePath = Path.Combine(directoryPath, fileName);

                using (var writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(row);
                }
            }
        }
    }
}
