using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzBuzzIF
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)

            {

                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.Write("FizzBuzz" + "\r\n");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.Write("Fizz" + "\r\n");
                    continue;
                }

                if (i % 5 == 0)
                {
                    Console.Write("Buzz" + "\r\n");
                    continue;
                }

                else

                { Console.WriteLine(i); }

            }

            Console.Read();
        }
    }
}
