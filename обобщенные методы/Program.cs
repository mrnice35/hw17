using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace обобщенные_методы
{
    class Program
    {
        static void Main(string[] args)
        {
            print<int>(12);
            print<string>("Hello");
            Console.ReadKey();
        }
        static void print<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}
