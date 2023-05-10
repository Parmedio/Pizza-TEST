using Pizza_TEST.Model;

namespace Pizza_TEST
{
    public static class ReceiptLogger
    {
        public static void GenerateCSVReceipts(IOrder[] orders, string directoryPath)
        {
            foreach (var order in orders)
            {
                string fileName = $"receipt{order.GetOrderID()}.csv";
                string filePath = Path.Combine(directoryPath, fileName);

                using (var writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(order.GetOrderSubtotal());

                    writer.WriteLine($"order contain { order.GetOrderPizzas().Length} pizza");
                    
                    foreach (var pizza in order.GetOrderPizzas())
                    {
                        writer.WriteLine($"type: {pizza.GetPizzaType()} - dough: {pizza.GetDough()} - topping: {pizza.GetTopping()} - price: {pizza.GetPrice()}");
                    }
                }
            }
        }
    }
}
