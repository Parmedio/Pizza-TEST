using PizzaLibrary.Model;

namespace PizzaLibrary.PizzaTypeDecorator
{
    public class DecoratorBianca : PizzaTypePattern
    {
        public DecoratorBianca(IPizza pizza) : base(pizza)
        {
            _type = "Bianca";
            _price = 5;
        }
    }
}
