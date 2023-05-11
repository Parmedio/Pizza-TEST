using Pizza_TEST.Model;

namespace Pizza_TEST
{
    public static class ReceiptLogger
    {
        public static void GenerateReceiptFiles(IOrder[] orders, string directoryPath, string receiptFileExtension)
        {
            foreach (var order in orders)
            {
                string fileName = $"{order.GetOrderID()}.{receiptFileExtension}";
                string filePath = Path.Combine(directoryPath, fileName);

                using (var writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"Total - {order.GetOrderSubtotal()}\n");

                    writer.WriteLine($"order contain { order.GetOrderPizzas().Length} pizza:");
                    
                    foreach (var pizza in order.GetOrderPizzas())
                    {
                        writer.WriteLine("\n===============================================\n");
                        writer.WriteLine($"type: {pizza.GetPizzaType()}\ndough: {pizza.GetDough()}\ntopping: {pizza.GetTopping()}\nprice: {pizza.GetPrice()}");
                    }
                }
            }
        }
    }
}
