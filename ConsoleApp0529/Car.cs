using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0529
{
    internal class Car
    {

        //一般的なClassの書き方
        private int fuel;
        public int Fuel
        {
            set { fuel = value; }
            get { return fuel; }
        }



        //public void SetFuel(int fuel)
        //{
        //    this.fuel = fuel;
        //}
        //public int GetFuel()
        //{
        //    return this.fuel;
        //}
    }
}
