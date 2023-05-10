using Pizza_TEST;

var firstPizza = PizzaFactory.assemblePizzaOrder("Bianca;Integrale;Funghi,ProsciuttoCotto,Ananas");
Console.WriteLine($"{firstPizza.GetPizzaType()}\n{firstPizza.GetDough()}\n{firstPizza.GetAddition()}\n{firstPizza.GetPrice()}");
