namespace Pizza_TEST
{
    internal class PizzaFactory
    {
        public static IPizza assemblePizzaOrder(string orderstring)
        {
            IPizza currentOrder = new Pizza();

            var stringNumbers = orderstring.Split(';');
            if (stringNumbers.Length > 1 )
            {
                for (int i = 1; i < stringNumbers.Length; i++)
                {
                    var addition = int.Parse(stringNumbers[i]);
                    currentOrder = GetMyDecorator(addition, currentOrder);
                }
            }
            return currentOrder;
        }

        private static ICoffee GetMyDecorator(int number, ICoffee coffee)
        {
            switch (number)
            {
                case 2: return new MilkDecorator(coffee);
                case 3: return new ChoccolateDecorator(coffee);
                default: return null;
            }
        }
    }
}
