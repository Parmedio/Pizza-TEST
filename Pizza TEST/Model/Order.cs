namespace Pizza_TEST.Model
{
    public class Order : IOrder
    {
        private int _orderID;

        private IPizza[] _pizzas;

        private double _subtotal;

        public Order(int orderID, IPizza[] pizzas, double subtotal)
        {
            _orderID = orderID;
            _pizzas = pizzas;
            _subtotal = subtotal;
        }

        public int GetOrderID() => _orderID;

        public IPizza[] GetOrderPizzas() => _pizzas;

        public double GetOrderSubtotal() => _subtotal;
    }
}
