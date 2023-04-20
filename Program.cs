using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 170;
            int b = 175;
            int c = 180;

            int ag = 58;
            int bg = 60;
            int cg = 65;


            Console.WriteLine("aさんのBMIは" + ag % a * a + "、適正体重は" + a * a * 22);
            Console.WriteLine("bさんのBMIは" + bg % b * b + "、適正体重は" + b * b * 22);
            Console.WriteLine("cさんのBMIは" + cg % c * c + "、適正体重は" + c * c * 22);

            //int r = 0;

            //for (int i = 0; i <= 100000; i++)
            //{
            //    r++;
            //    if (r % 2 == 0)
            //    {
            //        Console.WriteLine(r + "は偶数");
            //    }
            //    Console.WriteLine(r + "は奇数");
            //}
        }
    }
}
