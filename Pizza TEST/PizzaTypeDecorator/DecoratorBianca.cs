using Pizza_TEST.Model;

namespace Pizza_TEST.PizzaTypeDecorator
{
    public class DecoratorBianca : PizzaTypePattern
    {
        public DecoratorBianca(IPizza pizza) : base(pizza)
        {
            _type = "Bianca";
            _price = 5;
        }
    }
}
