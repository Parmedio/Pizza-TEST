using PizzaLibrary.Model;

namespace PizzaLibrary.ToppingDecorator
{
    public class DecoratorSpecialDiscount : ToppingPattern
    {
        public DecoratorSpecialDiscount(IPizza pizza, double discount) : base(pizza)
        {
            _addition = "";
            _price = -discount;
        }
    }
}
