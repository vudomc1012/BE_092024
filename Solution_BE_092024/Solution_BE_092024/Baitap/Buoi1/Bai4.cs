using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_092024.Baitap.Buoi1
{
	public class Bai4
	{
		public void TinhGiaiThua()
		{
			var NhapSo = new Common.Validate();
			int so = (int)NhapSo.NhapSo("Nhập vào một số nguyên: ");
			long giaiThua = GiaiThua(so);
			Console.WriteLine($"Giai thừa của {so} là: {giaiThua}\n");
		}

		static long GiaiThua(int n)
		{
			if (n <= 1) return 1;
			return n * GiaiThua(n - 1);
		}
	}
}
