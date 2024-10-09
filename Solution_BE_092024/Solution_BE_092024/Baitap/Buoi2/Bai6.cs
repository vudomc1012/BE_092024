using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_092024.Baitap.Buoi2
{
	public class Bai6
	{
		public void KiemTraChanLe()
		{
			var nhapSo = new Common.Validate();
			int so;
			so = (int)nhapSo.NhapSo("Nhập vào số nguyên ");
			if (so % 2 == 0)
			{
				Console.WriteLine($"{so} là số chẵn.");
			}
			else
			{
				Console.WriteLine($"{so} là số lẻ.");
			}
		}
	}
}
