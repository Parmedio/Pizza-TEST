namespace Pizza_TEST.DoughDecorator
{
    public class DecoratorNormale : DoughPattern
    {
        public DecoratorNormale(IPizza pizza) : base(pizza)
        {
            _dough = "Normale";
            _price = 0;
        }
    }
}
