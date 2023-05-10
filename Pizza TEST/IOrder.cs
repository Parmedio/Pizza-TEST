using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_TEST
{
    internal interface IOrder
    {
        int GetOrderID();
        (string, int)[] GetOrderPizzasAndPrices();
        double GetOrdersubtotal();
    }
}
