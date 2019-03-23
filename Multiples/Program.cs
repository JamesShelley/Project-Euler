using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>();
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    values.Add(i);
                    sum += i;
                }

            }
            Console.WriteLine("Final sum is: " + sum);
            Console.ReadKey();
        }
    }
}
