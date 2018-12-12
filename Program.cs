using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sum(a:4,c:7));
        }

        private static int sum(int a,int b = 1,int c = -1)
        {
            int mul = a * b * c;
            return mul;

        }
    }
}
