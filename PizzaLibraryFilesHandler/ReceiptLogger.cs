using PizzaLibrary.Model;

namespace PizzaLibraryFilesHandler
{
    public static class ReceiptLogger
    {
        public static void GenerateCSVReceipts(IEnumerable<IOrder> orders, string directoryPath)
        {
            foreach (var order in orders)
            {
                var fileName = $"receipt{order.GetOrderID()}.csv";
                var filePath = Path.Combine(directoryPath, fileName);

                using (var writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(order.GetOrderSubtotal());

                    writer.WriteLine($"order contain { order.GetOrderPizzas().Count} pizza");
                    
                    foreach (var pizza in order.GetOrderPizzas())
                    {
                        writer.WriteLine($"type: {pizza.GetPizzaType()} - dough: {pizza.GetDough()} - topping: {pizza.GetTopping()} - price: {pizza.GetPrice()}");
                    }
                }
            }
        }
    }
}
