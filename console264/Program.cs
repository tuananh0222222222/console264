
using console264;
using System;



namespace Program
{

    class Program : teacher
    {
        public static void Main(string[] args)
        {
            //hello hl = new hello();
            // Console.WriteLine("nhap ten");
            //  hl.Name = Console.ReadLine();
            // Console.WriteLine("nhap tuoi");
            // hl.age = Console.ReadLine();
            // Console.WriteLine("nhap gioi tinh");
            // hl.gender = Console.ReadLine();

            // hl.addhello();

            // student std = new student();

            //std.ten = Console.ReadLine();
            // std.tuoi = int.Parse(Console.ReadLine());
            // std.gioitinh =Console.ReadLine();

            // std.HT();

            //double a = 12.30;
            //int b = (int)a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //double d = 100.5;



            //Console.WriteLine(Convert.ToInt32(d));

            int a = -10;
            double b = 29.999;

           
            Console.WriteLine(Math.Sqrt(b));// can bac 2
            Console.WriteLine(Math.Abs(a));// tri tuyet doi
            Console.WriteLine(Math.Max(a, b));// max
            Console.WriteLine(Math.Min(a, b));// min
            Console.WriteLine(Math.Round(b));// lam con so thap phan 1
            

        }
    }
}