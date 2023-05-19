namespace PizzaLibrary.Model
{
    public class Order : IOrder
    {
        private int _orderID;

        private List<IPizza> _pizzas;

        private double _subtotal;

        public Order(int orderID, List<IPizza> pizzas, double subtotal)
        {
            _orderID = orderID;
            _pizzas = pizzas;
            _subtotal = subtotal;
        }

        public int GetOrderID() => _orderID;

        public List<IPizza> GetOrderPizzas() => _pizzas;

        public double GetOrderSubtotal() => _subtotal;
    }
}
