using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_092024.Baitap.Buoi3
{
	public class Bai13
	{
		public ref int FindMax(ref int[] array)
		{
			int maxIndex = 0;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] > array[maxIndex])
				{
					maxIndex = i;
				}
			}
			return ref array[maxIndex];
		}
	}
}
