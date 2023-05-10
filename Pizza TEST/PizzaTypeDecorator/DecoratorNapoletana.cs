using Pizza_TEST.Model;

namespace Pizza_TEST.PizzaTypeDecorator
{
    internal class DecoratorNapoletana : PizzaTypePattern
    {
        public DecoratorNapoletana(IPizza pizza) : base(pizza)
        {
            _type = "Napoletana";
            _price = 3;
        }
    }
}
