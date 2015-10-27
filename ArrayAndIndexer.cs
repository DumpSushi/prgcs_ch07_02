using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch07_02
{
	class ArrayAndIndexer<T>
	{
		public T[] TheArray = new T[100];

		public T this[int index]
		{
			get
			{
				return TheArray[index];
			}
			set
			{
				TheArray[index] = value;
			}
		}
	}
}
