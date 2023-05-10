using Pizza_TEST.Model;

namespace Pizza_TEST.AdditionDecorator
{
    public abstract class ToppingPattern : IPizza
    {
        private readonly IPizza _pizza;

        protected string _addition = "";
        protected double _price = 0;

        public ToppingPattern(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetPizzaType() => _pizza.GetPizzaType();

        public string GetDough() => _pizza.GetDough();

        public string GetTopping() => _addition != String.Empty ? $"{_addition}, {_pizza.GetTopping()}" : $"{_pizza.GetTopping()}";

        public double GetPrice() => _pizza.GetPrice() + _price;
    }
}
