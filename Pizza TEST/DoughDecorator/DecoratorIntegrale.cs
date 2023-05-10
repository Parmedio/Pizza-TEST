namespace Pizza_TEST.DoughDecorator
{
    public class DecoratorIntegrale : DoughPattern
    {
        public DecoratorIntegrale(IPizza pizza) : base(pizza)
        {
            _dough = "Integrale";
            _price = 1;
        }
    }
}
