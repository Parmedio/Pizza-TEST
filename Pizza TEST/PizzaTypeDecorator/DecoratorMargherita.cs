using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza_TEST.Model;

namespace Pizza_TEST.PizzaTypeDecorator
{
    public class DecoratorMargherita : PizzaTypePattern
    {
        public DecoratorMargherita(IPizza pizza) : base(pizza)
        {
            _type = "Margherita";
            _price = 7;
        }
    }
}
