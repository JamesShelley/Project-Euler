using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 4000000;
            int num1 = 1;
            int num2 = 2;
            int sum;
            List<int> evenFib = new List<int>();

            do
            {
                sum = num1 + num2;
                if(sum % 2 == 0)
                {
                    evenFib.Add(sum);
                }
                num1 = num2;
                num2 = sum;

            } while (num2 < maxValue);

            Console.WriteLine(evenFib.Sum() + 2);
            Console.ReadKey();

        }
    }
}
