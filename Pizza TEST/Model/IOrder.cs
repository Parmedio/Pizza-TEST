using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_TEST.Model
{
    public interface IOrder
    {
        int GetOrderID();
        IPizza[] GetOrderPizzas();
        double GetOrderSubtotal();
    }
}
