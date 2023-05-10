namespace Pizza_TEST.AdditionDecorator
{
    public class DecoratorAnanas : AdditionPattern
    {
        public DecoratorAnanas(IPizza pizza) : base(pizza)
        {
            _addition = "Ananas";
            _price = 0;
        }
    }
}
