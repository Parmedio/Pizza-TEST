namespace Pizza_TEST.PizzaTypeDecorator
{
    public abstract class PizzaTypePattern : IPizza
    {
        private readonly IPizza _pizza;

        protected string _type = "";
        protected double _price = 0;

        public PizzaTypePattern(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetPizzaType() => _type;

        public string GetDough() => _pizza.GetDough();

        public string GetAddition() => _pizza.GetAddition();

        public double GetPrice() => _pizza.GetPrice() + _price;
    }
}
