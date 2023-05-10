namespace Pizza_TEST.AdditionDecorator
{
    public class DecoratorProsciuttoCotto : AdditionPattern
    {
        public DecoratorProsciuttoCotto(IPizza pizza) : base(pizza)
        {
            _addition = "ProsciuttoCotto";
            _price = 1;
        }
    }
}
