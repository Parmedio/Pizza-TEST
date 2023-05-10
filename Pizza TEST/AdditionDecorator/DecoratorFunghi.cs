namespace Pizza_TEST.AdditionDecorator
{
    internal class DecoratorFunghi : AdditionPattern
    {
        public DecoratorFunghi(IPizza pizza) : base(pizza)
        {
            _addition = "Funghi";
            _price = 2;
        }
    }
}
