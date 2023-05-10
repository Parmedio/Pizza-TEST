namespace Pizza_TEST.Model
{
    public class Pizza : IPizza
    {
        public string GetPizzaType() => string.Empty;

        public string GetDough() => string.Empty;

        public string GetTopping() => string.Empty;

        public double GetPrice() => 0;

        public override string ToString() => $"Pizza type: {GetPizzaType()}\n Dough type:{GetDough()}\nTopping: {GetTopping().Replace(",", ", ")}\nPrice: {GetPrice()}";
    }
}
