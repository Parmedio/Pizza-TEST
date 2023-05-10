using Pizza_TEST.DoughDecorator;
using Pizza_TEST.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_TEST.PizzaTypeDecorator
{
    public class DecoratorBianca : PizzaTypePattern
    {
        public DecoratorBianca(IPizza pizza) : base(pizza)
        {
            _type = "Bianca";
            _price = 5;
        }
    }
}
