using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
	class Program
	{
		static void Main(string[] args)
		{
			String world = "World";
			Console.WriteLine("Hello "+world);
			Console.WriteLine($"Hello {world}");

			String teststr = "Это тестовая строка";
			Console.WriteLine($"\nString \"{teststr}\" contains {teststr.Length} chars");

			// Trimming string
			Console.WriteLine("\n__Trimming string");
			String trimstr = "    hello    ";
			Console.WriteLine($"String: \"{trimstr}\"");
			Console.WriteLine($"Trim start: {trimstr.TrimStart()} ;");
			Console.WriteLine($"Trim end: {trimstr.TrimEnd()} ;");
			Console.WriteLine($"Trim start-end: {trimstr.TrimStart().TrimEnd()} ;");

			// Replacing string
			Console.WriteLine("\n__Replacing text in string");
			string repstr = "New hard string";
			Console.WriteLine($"String: [{repstr}]");
			repstr = repstr.Replace("hard", "soft");
			Console.WriteLine($"Replace hard with sof: [{repstr}]\n");

			// Upper and Lower
			Console.WriteLine($"ToUpper: [{world.ToUpper()}]");
			Console.WriteLine($"ToLower: [{world.ToLower()}]");

			// Search in string
			string srchstr = "Hello darkness my old friend";
			Console.WriteLine($"\n_Search in string\nString [{srchstr}]");
			Console.WriteLine($"Search [old]: {srchstr.Contains("old")}");
			Console.WriteLine($"Search [new]: {srchstr.Contains("new")}");
			Console.WriteLine($"StartWith [hello]: {srchstr.StartsWith("hello")}");
			Console.WriteLine($"EndsWith [friend]: {srchstr.EndsWith("friend")}");

			Console.ReadKey();
		}
	}
}
