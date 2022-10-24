using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string result1 = (9 % 2 == 0) ? "他是偶數" : "他是奇數";
			string result2 = (202 % 2 == 0) ? "他是偶數" : "他是奇數";

			Console.WriteLine($"9 {result1}");
			Console.WriteLine($"202 {result2}");
		}
	}
}
