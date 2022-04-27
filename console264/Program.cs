
using console264;
using System;



namespace Program
{

    class Program : student
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

            student std = new student();

           std.ten = Console.ReadLine();
            std.tuoi = int.Parse(Console.ReadLine());
            std.gioitinh =Console.ReadLine();

            std.HT();
            
        }
    }
}