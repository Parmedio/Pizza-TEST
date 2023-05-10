namespace Pizza_TEST.AdditionDecorator
{
    public class DecoratorProsciuttoCrudo : AdditionPattern
    {
        public DecoratorProsciuttoCrudo(IPizza pizza) : base(pizza)
        {
            _addition = "ProsciuttoCrudo";
            _price = 2;
        }
    }
}
