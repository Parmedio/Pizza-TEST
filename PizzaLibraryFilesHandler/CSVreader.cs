using PizzaLibrary;
using PizzaLibrary.Model;

namespace PizzaLibraryFilesHandler
{
    public static class CSVreader
    {
        public static List<IOrder> ReadAllCSV(string directoryPath)
        {
            var allOrders = new List<IOrder>();
            var receiptNumber = 1;

            var csvFiles = Directory.GetFiles(directoryPath, "*.csv");

            foreach (var orderFile in csvFiles)
            {
                var rows = File.ReadAllLines(orderFile);

                var pizzas = rows.Select(x => PizzaFactory.assemblePizzaOrder(x.Trim())).ToList();

                var currentOrder = new Order(receiptNumber, pizzas, GetSubtotal(pizzas));
                
                allOrders.Add(currentOrder);
                
                receiptNumber++;
            }
            return allOrders;
        }

        private static double GetSubtotal(IEnumerable<IPizza> pizzaList)
        => pizzaList.Sum(x => x.GetPrice());
    }
}
