using Pizza_TEST.Model;

namespace Pizza_TEST
{
    public static class OrderReader
    {
        public static IOrder[] ReadAllOrders(string directoryPath, string ordersFileExtension)
        {
            string[] orderFilePaths = Directory.GetFiles(directoryPath, $"*.{ordersFileExtension}");

            var allOrders = GetOrders(orderFilePaths);

            return allOrders;
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

        private static IPizza[] GetPizzas(string[] rows)
        {
            var pizzas = new IPizza[rows.Length];

            for (int i = 0; i < rows.Length; i++)
            {
                pizzas[i] = PizzaFactory.assemblePizzaOrder(rows[i].Replace(" ", string.Empty));
            }

            return pizzas;
        }

        private static IOrder[] GetOrders(string[] orderFilePaths)
        {
            var allOrders = new List<IOrder>();
            int receiptNumber = 1;

            foreach (string orderFile in orderFilePaths)
            {
                string[] rows = File.ReadAllLines(orderFile);

                var pizzas = GetPizzas(rows);

                var currentOrder = new Order(receiptNumber, pizzas, GetSubtotal(pizzas));

                allOrders.Add(currentOrder);

                receiptNumber++;
            }
            return allOrders.ToArray();
        }
    }
}
