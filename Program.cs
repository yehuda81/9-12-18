using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise1
{
    class Program
    {
        static void Main(string[] args)

        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            bool module = printmodule(num1, num2);
            {
                if (module)
                {
                    Console.WriteLine("no module");
                }
                else
                {
                    Console.WriteLine("some module");
                }
                
            }
        }

        private static bool printmodule(int a, int b)
        {
            if (a % b == 0)
            {
                return true;
            }
            {
                return false;
            }
            
            
                
            
        }
    }
}
