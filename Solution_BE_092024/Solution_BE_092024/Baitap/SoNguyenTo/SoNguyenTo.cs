using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_092024.Baitap.SoNguyenTo
{
	public class SoNguyenTo
	{
		public bool LaSoNguyenTo(int so)
		{
			if (so < 2)return false;
			
			{
				for (int i = 2; i <= Math.Sqrt(so); i++)
				{
					if (so % i == 0) return false;
				}
				return true;
			}
		}

	}
}
