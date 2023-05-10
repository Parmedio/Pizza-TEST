using Pizza_TEST.AdditionDecorator;
using Pizza_TEST.DoughDecorator;
using Pizza_TEST.PizzaTypeDecorator;

namespace Pizza_TEST
{
    internal class PizzaFactory
    {
        public static IPizza assemblePizzaOrder(string orderString)
        {
            IPizza currentOrder = new Pizza();

            var splittedOrder = orderString.Split(';');

            var pizzaTypeOrder = splittedOrder[0];
            var pizzaDoughOrder = splittedOrder[1];
            var pizzaAdditions = splittedOrder[2].Split(',');

            currentOrder = GetOrderPizzaType(pizzaTypeOrder, currentOrder);
            currentOrder = GetOrderDough(pizzaDoughOrder, currentOrder);

            for (int i = 0; i < pizzaAdditions.Length; i++)
            {
                var addition = pizzaAdditions[i];
                currentOrder = GetOrderAdditions(addition, currentOrder);
            }

            if (ContainSpecialItem(pizzaAdditions, "Ananas")) 
            {
                var specialDiscount = currentOrder.GetPrice();
                var discountedOrder = new DecoratorSpecialDiscount(currentOrder, specialDiscount);
                currentOrder = discountedOrder;
            }

            return currentOrder;
        }

        private static IPizza GetOrderPizzaType(string orderPart, IPizza pizza)
        {
            switch (orderPart)
            {
                case "Bianca": return new DecoratorBianca(pizza);
                case "Margherita": return new DecoratorMargherita(pizza);
                case "Napoletana": return new DecoratorNapoletana(pizza);
                default: return null;
            }
        }
        private static IPizza GetOrderDough(string orderPart, IPizza pizza)
        {
            switch (orderPart)
            {
                case "Normale": return new DecoratorNormale(pizza);
                case "Integrale": return new DecoratorIntegrale(pizza);
                default: return null;
            }
        }

        private static IPizza GetOrderAdditions(string orderPart, IPizza pizza)
        {
            switch (orderPart)
            {
                case "Ananas": return new DecoratorAnanas(pizza);
                case "Funghi": return new DecoratorFunghi(pizza);
                case "ProsciuttoCotto": return new DecoratorProsciuttoCotto(pizza);
                case "ProsciuttoCrudo": return new DecoratorProsciuttoCrudo(pizza);
                default: return null;
            }
        }

        private static bool ContainSpecialItem(string[] array, string special)
        {
            foreach (string str in array)
            {
                if (str.Equals(special, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
