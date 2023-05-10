using Pizza_TEST.Model;

namespace Pizza_TEST.AdditionDecorator
{
    public class DecoratorProsciuttoCotto : ToppingPattern
    {
        public DecoratorProsciuttoCotto(IPizza pizza) : base(pizza)
        {
            _addition = "ProsciuttoCotto";
            _price = 1;
        }
    }
}
