using PizzaLibrary.Model;

namespace PizzaLibrary.ToppingDecorator
{
    public class DecoratorAnanas : ToppingPattern
    {
        public DecoratorAnanas(IPizza pizza) : base(pizza)
        {
            _addition = "Ananas";
            _price = 0;
        }
    }
}
