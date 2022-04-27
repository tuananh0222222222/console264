using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console264
{
    public class student 
    {
       protected string? ten;
       protected int tuoi;
       protected string? gioitinh;

        public student()
        {
        }

        public student(string _ten,int _tuoi,string _gioitinh)
        {
            this.ten = _ten;
            this.tuoi = _tuoi;
            this.gioitinh = _gioitinh;
        }

        public void HT()
        {
            Console.WriteLine("ten la :" + ten);
            Console.WriteLine("tuoi la :" + tuoi);
            Console.WriteLine("gioi tinh la :" + gioitinh);
        }
    }
}
