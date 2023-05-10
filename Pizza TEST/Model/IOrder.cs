namespace Pizza_TEST.Model
{
    public interface IOrder
    {
        int GetOrderID();
        IPizza[] GetOrderPizzas();
        double GetOrderSubtotal();
    }
}
