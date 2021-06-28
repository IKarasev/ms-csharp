using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Init list
            var names = new List<String> { "Ilay","Tania","Yarik","Anton" };
            ShowList(names);

            // Remove from and add to list
            Console.WriteLine("\n__ Remove and Add");
            names.Remove("Anton");
            names.Add("Alex");
            ShowList(names);


            // Acces by key
            Console.WriteLine("\n__Acces list item by key");
            Console.WriteLine($"Items in names: {names.Count}");
            Console.WriteLine($"Item 1: {names[0]}");
            Console.WriteLine($"Name 2 is {names[1]} and name 4 in {names[3]}");

            // Search
            Console.WriteLine("\n__Search in lists");
            var ind = names.IndexOf("Yarik");
            Console.WriteLine($"Index of Yarik is {ind}");
            ind = names.IndexOf("NNN");
            Console.WriteLine($"Index of NNN (not present in list) is {ind}");

            // Sorting
            Console.WriteLine("\n__Sort lists");
            names.Sort();
            ShowList(names);

            // Fibonachi list exersize
            Console.WriteLine("\n__Count fibonachi with list");
            Console.Write("Enter number: ");
            int numFibo = Convert.ToInt32(Console.ReadLine());
            var fibo = new List<int> { 1, 1 };

            if ((numFibo == 1) || (numFibo == 2))
            {
                Console.WriteLine($"Fibonachi of {numFibo} = 1");
            } else
            {
                while (fibo.Count < numFibo)
                {
                    int p1 = fibo[fibo.Count - 1];
                    int p2 = fibo[fibo.Count - 2];
                    fibo.Add(p1 + p2);
                }
                Console.WriteLine($"Fibonachi of {numFibo} = {fibo[fibo.Count - 1]}");
            }

            Console.Write("\nDo you want to list all fibo numbers? (y\\n):");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                ShowList(fibo);
            }

            Console.ReadKey();
        }

        private static void ShowList<T>(List<T> strList)
        {
            // Iterate the list
            int num = 1;
            foreach (var li in strList)
            {
                Console.WriteLine($"[{num}] {li}");
                num++;
            }
        }
    }
}
