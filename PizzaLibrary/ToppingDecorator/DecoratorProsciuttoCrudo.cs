using PizzaLibrary.Model;

namespace PizzaLibrary.ToppingDecorator
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
