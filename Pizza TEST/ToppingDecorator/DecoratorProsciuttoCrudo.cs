using Pizza_TEST.Model;

namespace Pizza_TEST.AdditionDecorator
{
    public class DecoratorProsciuttoCrudo : ToppingPattern
    {
        public DecoratorProsciuttoCrudo(IPizza pizza) : base(pizza)
        {
            _addition = "ProsciuttoCrudo";
            _price = 2;
        }
    }
}
