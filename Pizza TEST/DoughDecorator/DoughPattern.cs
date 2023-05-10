using Pizza_TEST.Model;

namespace Pizza_TEST.DoughDecorator
{
    public abstract class DoughPattern : Pizza //IPizza
    {
        private readonly IPizza _pizza;

        protected string _dough = "";
        protected double _price = 0;

        public DoughPattern(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetPizzaType() => _pizza.GetPizzaType();

        public string GetDough() => _dough;

        public string GetTopping() => _pizza.GetTopping();

        public double GetPrice() => _pizza.GetPrice() + _price;
    }
}

