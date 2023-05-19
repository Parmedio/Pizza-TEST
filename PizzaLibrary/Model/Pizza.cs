namespace PizzaLibrary.Model
{
    public class Pizza : IPizza
    {
        public virtual string GetPizzaType() => string.Empty;
        public virtual string GetDough() => string.Empty;
        public virtual string GetTopping() => string.Empty;
        public virtual double GetPrice() => 0;
    }
}