namespace Pizza_TEST.Model
{
    public interface IPizza
    {
        string GetPizzaType();
        string GetDough();
        string GetTopping();
        double GetPrice();
    }
}
