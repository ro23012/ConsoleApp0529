using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0529
{
    internal class Calc
    {
        private int num1;
        private int num2;

        //コンストラクタ
        //----------------------------
        public Calc(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        //---------------------------

        public void Setnum1(int num1)
        {
            this.num1 = num1;
        }
        public int Getnum1()
        {
            return this.num1;
        }

        public void Setnum2(int num2)
        {
            this.num2 = num2;
        }

        public int Getnum2()
        {
            return this.num2;
        }

        public int Add()
        {
            return this.num1 + this.num2;
        }
        public int Sub()
        {
            return this.num1 - this.num2;
        }

        public int Mul()
        {
            return this.num1 * this.num2;
        }

    }
}
