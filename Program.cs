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
			//
			Indexable ix = new Indexable();
			Console.WriteLine(ix[10]);
			ix[42] = "Xyzzy";

			//
			ImmutableValue();

			//
			MutableValue();

			Console.ReadKey();
		}

		static void ImmutableValue()
		{
			ArrayAndIndexer<int> aai = new ArrayAndIndexer<int>();
			aai.TheArray[10] = 42;
			Console.WriteLine(aai[10]);
			aai[20] = 99;
			Console.WriteLine(aai.TheArray[20]);
		}

		static void MutableValue()
		{
			ArrayAndIndexer<CanChange> aai = new ArrayAndIndexer<CanChange>();
			aai.TheArray[10] = new CanChange { Number = 42 };
			Console.WriteLine(aai[10].Number);
			aai[20] = new CanChange { Number = 99, Name = "独自の要素"};
			Console.WriteLine(aai.TheArray[20].Number);

			aai.TheArray[10].Number = 123;
			Console.WriteLine(aai.TheArray[10].Number);

			//aai[20].Number = 456;
			CanChange elem = aai[20];
			elem.Number = 456;
			Console.WriteLine(aai.TheArray[20].Number);
		}
	}
}
