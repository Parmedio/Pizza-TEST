using Pizza_TEST.Model;

namespace Pizza_TEST.AdditionDecorator
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
