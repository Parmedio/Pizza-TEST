using PizzaLibrary.DoughDecorator;
using PizzaLibrary.Model;
using PizzaLibrary.PizzaTypeDecorator;
using PizzaLibrary.ToppingDecorator;

namespace PizzaLibrary
{
    public class PizzaFactory
    {
        public static IPizza assemblePizzaOrder(string pizzaOrderString)
        {
            IPizza currentPizza = new Pizza();

            var splittedPizzaOrder = pizzaOrderString.Split(';');

            var pizzaTypeOrder = splittedPizzaOrder[0];
            var pizzaDoughOrder = splittedPizzaOrder[1];
            var pizzaTopping = splittedPizzaOrder.Length>2 ?  splittedPizzaOrder[2].Split(','): new []{""};

            currentPizza = GetOrderPizzaType(pizzaTypeOrder, currentPizza);
            currentPizza = GetOrderDough(pizzaDoughOrder, currentPizza);

            foreach (var topping in pizzaTopping)
            {
                currentPizza = GetOrderTopping(topping, currentPizza);
            }

            return
                pizzaTopping.Any(x => x.ToUpper().Equals("ANANAS"))
                    ? new DecoratorSpecialDiscount(currentPizza, currentPizza.GetPrice())
                    : currentPizza;
        }

        private static IPizza GetOrderPizzaType(string orderPart, IPizza pizza)
            => orderPart switch
            {
                "Bianca" => new DecoratorBianca(pizza),
                "Margherita" => new DecoratorMargherita(pizza),
                "Napoletana" => new DecoratorNapoletana(pizza),
                _ => null
            };


        private static IPizza GetOrderDough(string orderPart, IPizza pizza)
            => orderPart switch
            {
                "Normale" => new DecoratorNormale(pizza),
                "Integrale" => new DecoratorIntegrale(pizza),
                _ => null
            };

        private static IPizza GetOrderTopping(string orderPart, IPizza pizza)
         =>
            orderPart switch
            {
                "Ananas" => new DecoratorAnanas(pizza),
                "Funghi" => new DecoratorFunghi(pizza),
                "ProsciuttoCotto" => new DecoratorProsciuttoCotto(pizza),
                "ProsciuttoCrudo" => new DecoratorProsciuttoCrudo(pizza),
                "" => pizza,
                _ => null
            };
    }
}
