using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch07_02
{
	class Indexable
	{
		public string this[int index]
		{
			get
			{
				return "要素 " + index;
			}
			set
			{
				Console.WriteLine("要素 " + index + "を" + value + "に設定しました");
			}
		}
	}
}
