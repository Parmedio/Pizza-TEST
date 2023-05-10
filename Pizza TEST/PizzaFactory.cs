using Pizza_TEST.AdditionDecorator;
using Pizza_TEST.DoughDecorator;
using Pizza_TEST.Model;
using Pizza_TEST.PizzaTypeDecorator;

namespace Pizza_TEST
{
    public class PizzaFactory
    {
        public static IPizza assemblePizzaOrder(string pizzaOrderString)
        {
            IPizza currentPizza = new Pizza();

            var splittedPizzaOrder = pizzaOrderString.Split(';');

            var pizzaTypeOrder = splittedPizzaOrder[0];
            var pizzaDoughOrder = splittedPizzaOrder[1];
            var pizzaAdditions = splittedPizzaOrder[2].Split(',');

            currentPizza = GetOrderPizzaType(pizzaTypeOrder, currentPizza);
            currentPizza = GetOrderDough(pizzaDoughOrder, currentPizza);

            for (int i = 0; i < pizzaAdditions.Length; i++)
            {
                var addition = pizzaAdditions[i];
                currentPizza = GetOrderTopping(addition, currentPizza);
            }

            if (ContainSpecialItem(pizzaAdditions, "Ananas")) 
            {
                var specialDiscount = currentPizza.GetPrice();
                var discountedOrder = new DecoratorSpecialDiscount(currentPizza, specialDiscount);
                currentPizza = discountedOrder;
            }

            return currentPizza;
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

        private static IPizza GetOrderTopping(string orderPart, IPizza pizza)
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
