namespace Pizza_TEST.AdditionDecorator
{
    internal class DecoratorProsciuttoCotto : AdditionPattern
    {
        public DecoratorProsciuttoCotto(IPizza pizza) : base(pizza)
        {
            _addition = "ProsciuttoCotto";
            _price = 1;
        }
    }
}
