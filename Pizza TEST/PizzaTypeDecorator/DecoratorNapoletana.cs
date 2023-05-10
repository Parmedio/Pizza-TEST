using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_TEST.PizzaTypeDecorator
{
    internal class DecoratorNapoletana : PizzaTypePattern
    {
        public DecoratorNapoletana(IPizza pizza) : base(pizza)
        {
            _type = "Napoletana";
            _price = 3;
        }
    }
}
