namespace PizzaLibrary.Model
{
    public interface IPizza
    {
        string GetPizzaType();
        string GetDough();
        string GetTopping();
        double GetPrice();
    }
}
