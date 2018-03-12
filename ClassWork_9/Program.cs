using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_9
{
    class Program
    {
        //факториал методом
        static int GetFactorial(int x)  
        {
            int result = 1;
            for (int i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(GetFactorial(10));
           
            
        }
    }
}
