using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condloop
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditions
            int a = 5;
            int c = 10;
            Console.Write("Enter number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                Console.WriteLine("it is too big");
            else if (a < b)
                Console.WriteLine("it is too small");
            else
            {
                Console.WriteLine("it is 5");
                Console.WriteLine("Goot guess!");
            }


            // log op
            if ((b > a) && (b < c))
            {
                Console.WriteLine("It's in range 5 to 10");
            } else if ((b < a) || (b > c))
            {
                Console.WriteLine("You miised it!");
            } else
            {
                Console.WriteLine("Walking on the edge!");
            }

            // loops
            Console.WriteLine("\n__while loop__");
            int b1 = b;
            while (b1 > 0)
            {
                Console.Write($"{b1} ");
                b1--;
            }
           
            Console.WriteLine("\n__do-while loop__");
            b1 = b;
            do
            {
                Console.Write($"{b1} ");
                b1--;
            } while (b1 > 0);

            Console.WriteLine("\n__for loop__");
            for (int i = 0;i <= b; i++)
            {
                Console.Write($"{i} ");
            }

            int[] ar = { 1, 2, 3, 4 };
            Console.WriteLine("\n__foreach loop__");
            foreach (int i in ar)
            {
                Console.Write($"{i} ");
            }

            // creating board with loop-in-loop
            Console.WriteLine();
            Console.Write("   ");
            for (char column = 'A'; column < 'K'; column++)
            {
                Console.Write($"{column} ");
            }
            string sp = "";

            for (int row = 1; row < b; row++)
            {
                Console.WriteLine();
                sp = "";
                if (row < 10)
                {
                    sp = " ";
                }

                Console.Write($"{row}{sp} ");
                for (char column = 'A'; column < 'K'; column++)
                {
                    Console.Write("0 ");
                }
            }
            Console.ReadKey();
        }
    }
}
