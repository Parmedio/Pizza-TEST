namespace Pizza_TEST.AdditionDecorator
{
    public class DecoratorFunghi : AdditionPattern
    {
        public DecoratorFunghi(IPizza pizza) : base(pizza)
        {
            _addition = "Funghi";
            _price = 2;
        }
    }
}
