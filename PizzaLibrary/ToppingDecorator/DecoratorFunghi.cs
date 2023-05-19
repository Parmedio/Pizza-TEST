using PizzaLibrary.Model;

namespace PizzaLibrary.ToppingDecorator
{
    public class DecoratorFunghi : ToppingPattern
    {
        public DecoratorFunghi(IPizza pizza) : base(pizza)
        {
            _addition = "Funghi";
            _price = 2;
        }
    }
}
