using PizzaLibrary.Model;

namespace PizzaLibrary.ToppingDecorator
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
