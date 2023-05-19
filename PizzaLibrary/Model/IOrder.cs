namespace PizzaLibrary.Model
{
    public interface IOrder
    {
        int GetOrderID();
        List<IPizza> GetOrderPizzas();
        double GetOrderSubtotal();
    }
}
