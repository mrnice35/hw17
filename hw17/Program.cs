using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw17
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartment<int,int> apartment1 = new Apartment<int,int>();
            apartment1.Num = 1;
            int next =apartment1.Num;
            Apartment<string,int> apartment2 = new Apartment<string,int>();
            apartment2.Num = "01";

        }
    }
    class Apartment<T,U>
    {
        public U level { get; set; }
        public T Num { get; set; }
    }
}
