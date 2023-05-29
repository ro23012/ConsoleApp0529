using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0529
{
    internal class EMoney
    {
        public int money = 0; // 金額
        public void Charge(int money)
        {
            this.money =  this.money +money; // お金をチャージ
            Console.WriteLine("残高:{0}円", this.money);
        }
        public void Spend(string product, int price)
        {
            this.money =　this.money - price;
            Console.WriteLine("商品:{0} 価格{1}円", product, price);
            Console.WriteLine("残高:{0}円", this.money);
        }
    }
}
