namespace Pizza_TEST
{
    public class Order : IOrder
    {
        int _orderID;

        (string, int)[] _pizzasAndPrices;

        double _subtotal;

        public Order(int orderID, (string, int)[] pizzasAndPrices, double subtotal)
        {
            _orderID = orderID;
            _pizzasAndPrices = pizzasAndPrices;
            _subtotal = subtotal;
        }

        public int GetOrderID() => _orderID;

        public (string, int)[] GetOrderPizzasAndPrices() => _pizzasAndPrices;

        public double GetOrdersubtotal() => _subtotal;
    }
}
