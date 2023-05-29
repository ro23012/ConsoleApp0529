using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0529
{
    internal class Buy
    {
        public int unit_price; //単価

        public int Price(int number, int tax_rate)
        {
            int price = unit_price * number; //商品の総額
            price = price + (price * tax_rate) / 100;
            return price;
        }
    }
}
