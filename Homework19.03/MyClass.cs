using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework19._03
{
    public delegate int MyDelegate(int num);
    internal class MyClass
    {
        public int MethA (int num)
        {
            if (num == 1 && num == 0)
            {
                return 1;
            }
            while (num > 1)
                return num * MethA(num - 1);
            return 1;
        }
        public int MethB(int num)
        {
            Console.WriteLine(num+1);
            return num;
        }
        public int MethC(int num)
        {
            Console.WriteLine(num + 2);
            return num;
        }
        public int MethD(int num)
        {
            Console.WriteLine(num + 3);
            return num;
        }
        public int MethE(int num)
        {
            Console.WriteLine(num + 4);
            return num;
        }
    }
}
