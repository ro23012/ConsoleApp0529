using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0529
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int a = 10;
            //if(a >= 3 )
            //{
            //    Console.WriteLine("aの値は3以上です！");
            //}else if(a == 2 )
            //{
            //    Console.WriteLine("aの値は2です！");
            //}
            //else
            //{
            //    Console.WriteLine("aの値は2未満です！");
            //}

            //int num = 3;
            //switch (num)
            //{
            //    case 3:
            //        Console.WriteLine("numの値は3です！");
            //        break;

            //    case 4:
            //        Console.WriteLine("numの値は4です！");
            //        break;

            //    case 5:
            //        Console.WriteLine("numの値は5です！");
            //        break;

            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 3 )
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //Random rnd = new Random();
            //while (true)
            //{
            //    int dice = rnd.Next(1, 7);
            //    Console.WriteLine(dice);
            //    if (dice == 6)
            //    {
            //        break;
            //    }
            //}

            //int[] n = { 2, 85, 77 };
            //foreach (int i in n)
            //{
            //    Console.WriteLine(i);
            //}

            //Person p = new Person();
            //p.name = "太郎";
            //p.age = 18;
            //p.Show();
            //Console.WriteLine("名前:{0} 年齢:{1}", p.name, p.age);

            //Person p2 = new Person();
            //p2.name = "花子";
            //p2.age = 16;
            //p2.Show();
            //Console.WriteLine("名前:{0} 年齢:{1}", p2.name, p2.age);


            //演習問題

            //Student s = new Student();
            //s.name = "鈴木ひまり";
            //s.grade = 3;
            //Console.WriteLine("名前:{0} 学年{1}", s.name, s.grade);

            //Student s2 = new Student();
            //s2.name = "おいかわりんと";
            //s2.grade = 1;
            //Console.WriteLine("名前{0} 年学年{1}", s2.name, s2.grade);

            //Product pr = new Product();
            //pr.price = 1000;
            //pr.tax_rate = 10;
            //Console.WriteLine("税込み価格:{0}円",pr.CalcPrice());

            //EMoney em = new EMoney();
            //em.Charge(5000);
            //em.Spend("パスタ",1000);
            //em.Spend("ラーメン", 1000);

            //Buy pro = new Buy();
            //pro.unit_price = 100;
            //int price = pro.Price(152, 10);
            //Console.WriteLine("商品価格は{0}円です",price);


            //Person p3 = new Person("太郎", 18);
            //p3.Show();
            //p3.name = "花子";
            //p3.age = 16;
            //p3.Show();

            //Car c = new Car();
            //c.SetFuel(10);
            //Console.WriteLine("燃料：{0}", c.GetFuel());

            //Car c = new Car();
            //c.Fuel = 10;
            //Console.WriteLine("燃料：{0}", c.Fuel);


            //演習問題

            //Calc cl = new Calc(0,0);
            //cl.Setnum1(10);
            //cl.Setnum2(20);
            //Console.WriteLine("{0}+{1}={2}",cl.Getnum1(), cl.Getnum2(),cl.Add());
            //Console.WriteLine("{0}-{1}={2}", cl.Getnum1(), cl.Getnum2(), cl.Sub());
            //Console.WriteLine("{0}*{1}={2}", cl.Getnum1(), cl.Getnum2(), cl.Mul());


            //演習問題
            //GameChar gc = new GameChar("スライム", 100);
            //gc.Attack(100);
            //gc.ShowHp();

            Console.WriteLine("RPGゲーム");
            //インスタンスの作成
            GameChar yusya = new GameChar("勇者", 100);
            GameChar god = new GameChar("神", 100);
            //HPの確認
            yusya.ShowHp();
            god.ShowHp();

            //乱数の生成
            Random ran = new Random();



            //繰り返し処理　yusyaのHPが０より大きいなら繰り返す
            while (yusya.Hp  > 0 || god.Hp > 0 )
            {
                int r = ran.Next(1, 10);
                //攻撃
                yusya.Attack(r);

                int ra = ran.Next(1, 10);
                god.Attack(ra);
                //HP確認
                yusya.ShowHp();
                god.ShowHp();

            }
            Console.WriteLine("GAME OVER");












        }
    }
}
