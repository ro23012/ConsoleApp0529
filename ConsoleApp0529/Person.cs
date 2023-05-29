using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0529
{
    internal class Person
    {
        //名前フィールド
        private string name;
        //年齢フィールド
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age; 
        }

        public void Show()
        {
            Console.WriteLine("名前:{0}　年齢{1}", this.name, this.age);
        }

    }
}
