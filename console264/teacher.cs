using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console264
{
    class teacher
    {
        protected string? name;
        protected string? gender;
        protected string? age;
        public teacher()
        {
        }
        public teacher(string _name,string _age,string _gender)
        {
            name = _name;
            gender = _gender;   
            age = _age;
        }
        void nofi()
        {
            Console.WriteLine("Ten giao vien la :" + name);
            Console.WriteLine("gioi tinh giao vien la :" + gender);
            Console.WriteLine("tuoi giao vien la :" + age);
        }
    }
}
