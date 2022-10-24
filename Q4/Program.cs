using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int int1 = 300;
			int int2 = 200;

			if (int1 > int2)
			{
				int temp = int1;
				int1 = int2;
				int2 = temp;
			}

			Console.WriteLine($"{int1} ~ {int2}");
		}
	}
}
