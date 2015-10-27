using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch07_02
{
	class Program
	{
		static void Main(string[] args)
		{
			Indexable ix = new Indexable();
			Console.WriteLine(ix[10]);
			ix[42] = "Xyzzy";

			Console.ReadKey();
		}
	}
}
