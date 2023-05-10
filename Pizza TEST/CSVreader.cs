using Pizza_TEST.Model;

namespace Pizza_TEST
{
    public static class CSVreader
    {
        public static IOrder[] ReadAllCSV(string directoryPath)
        {
            var allOrders = new List<IOrder>();
            int receiptNumber = 1;

            string[] csvFiles = Directory.GetFiles(directoryPath, "*.csv");

            foreach (string orderFile in csvFiles)
            {
                string[] rows = File.ReadAllLines(orderFile);

                var pizzas = new IPizza[rows.Length];

                for (int i = 0; i < rows.Length; i++)
                {
                    pizzas[i] = PizzaFactory.assemblePizzaOrder(rows[i].Replace(" ", string.Empty));
                }

                var currentOrder = new Order(receiptNumber, pizzas, GetSubtotal(pizzas));
                
                allOrders.Add(currentOrder);
                
                receiptNumber++;
            }
            return allOrders.ToArray();
        }
        private static double GetSubtotal(IPizza[] pizzaArray)
        {
            double subtotal = 0;
            foreach (var pizza in pizzaArray)
            {
                subtotal += pizza.GetPrice();
            }
            return subtotal;
        }
    }
}
