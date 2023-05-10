using Pizza_TEST.Model;

namespace Pizza_TEST.PizzaTypeDecorator
{
    public class DecoratorMargherita : PizzaTypePattern
    {
        public DecoratorMargherita(IPizza pizza) : base(pizza)
        {
            _type = "Margherita";
            _price = 7;
        }
    }
}
