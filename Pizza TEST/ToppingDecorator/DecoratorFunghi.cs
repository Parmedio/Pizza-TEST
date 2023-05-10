namespace Pizza_TEST.AdditionDecorator
{
    public class DecoratorFunghi : ToppingPattern
    {
        public DecoratorFunghi(IPizza pizza) : base(pizza)
        {
            _addition = "Funghi";
            _price = 2;
        }
    }
}
