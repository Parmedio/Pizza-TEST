namespace Pizza_TEST.DoughDecorator
{
    internal class DoughPattern : IPizza
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

        public string GetAddition() => _pizza.GetAddition();

        public double GetPrice() => _pizza.GetPrice() + _price;
    }
}
}
