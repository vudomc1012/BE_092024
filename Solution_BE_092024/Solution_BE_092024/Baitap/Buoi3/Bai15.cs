using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_092024.Baitap.Buoi3
{
	public class Bai15
	{
		public void ChangeElement(ref int[] array, int index, int newValue)
		{
			if (index >= 0 && index < array.Length)
			{
				array[index] = newValue;
			}
			else
			{
				Console.WriteLine("Index không hợp lệ.");
				Console.ReadKey();
			}
		}
	}
}
