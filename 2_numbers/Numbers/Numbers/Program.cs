using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // arifmetics
            int a = 5;
            int b = 18;
            int c = a + b;
            Console.WriteLine(c);
            Console.WriteLine($"{a - b}");
            Console.WriteLine($"{a * b}");
            Console.WriteLine($"{b / a}");
            Console.WriteLine($"{a}+{b}*{c}: {a + b * c}");
            Console.WriteLine($"{b}\\{a}:");
            Console.WriteLine($"\tquotient: {b / a}");
            Console.WriteLine($"\treminder: {b % a}");

            // int min and max
            Console.WriteLine($"\nInt max: {int.MaxValue}");
            Console.WriteLine($"Int min: {int.MinValue}");
            int iMax = int.MaxValue;
            Console.WriteLine($"Int max + 5: {iMax + 5}");

            // double numbers
            double d1 = 5;
            double d2 = 2;
            double d3 = 3;
            double d4 = (d1 + d2) / d3;
            Console.WriteLine($"\n__Double numbers:\n({d1}+{d2})\\{d3} = {d4}");
            Console.WriteLine($"Double between [{double.MinValue};{double.MaxValue}]");

            // DEC numbers
            // Суффикс M возле чисел указывает, что для константы должен использоваться тип decimal.
            // В противном случае компилятор предполагает тип double.
            decimal de1 = 1.0M;
            decimal de2 = 3.5M;
            Console.WriteLine("\n__Decimal numbers:");
            Console.WriteLine($"{de1} \\ {de2} = {de1 / de2}");
            
            // Calc area by radius
            Console.WriteLine("Calculate area of circle. Endter radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double area = r * r * Math.PI;
            Console.WriteLine($"Area of circle with r={r} is {area}");
            
            Console.ReadKey();
        }
    }
}
