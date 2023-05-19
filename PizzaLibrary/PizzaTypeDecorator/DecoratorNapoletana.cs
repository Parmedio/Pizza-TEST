using PizzaLibrary.Model;

namespace PizzaLibrary.PizzaTypeDecorator
{
    public class DecoratorNapoletana : PizzaTypePattern
    {
        public DecoratorNapoletana(IPizza pizza) : base(pizza)
        {
            _type = "Napoletana";
            _price = 3;
        }
    }
}
