using PizzaLibrary.Model;

namespace PizzaLibrary.PizzaTypeDecorator
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
