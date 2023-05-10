namespace Pizza_TEST.AdditionDecorator
{
    internal class DecoratorAnanas : AdditionPattern
    {
        public DecoratorAnanas(IPizza pizza) : base(pizza)
        {
            _addition = "Ananas";
            _price = 0;
        }
    }
}
