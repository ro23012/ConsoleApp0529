using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0529
{
    internal class GameChar
    {
        private string name;
        private int hp;

        public GameChar(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }
        public string Name
        {
            get { return name; }
        }
        public int Hp
        {
            get { return hp; }
        }

        public void Attack(int attack)
        {
            this.hp = this.hp - attack;
            Console.WriteLine("{0}は{1}のダメージを受けた",this.name,attack);
            if (this.hp <= 0)
            {
                Console.WriteLine("{0}は倒れた", this.name);
            }
        }

        public void ShowHp()
        {
            if(this.Hp > 0)
            {
                Console.WriteLine("{0}の残りのHPは{1}", this.name, this.hp);
            }
            else if(this.Hp <= 0)
            {
                Console.WriteLine("{0}の残りのHPは0", this.name);
                //Console.WriteLine("{0}は死んだ", this.name);
            }
        }











    }
}
