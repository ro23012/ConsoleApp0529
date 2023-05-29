using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0529
{
    internal class Product
    {
        public int price;
        public int tax_rate;
        public int CalcPrice()
        {
            return price + price * tax_rate /100;
        }
    }
}
