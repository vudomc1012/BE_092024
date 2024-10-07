using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_092024.Baitap.Buoi1
{
	public class Bai3
	{
		public void ChuyenDoiNhietDo()
		{
			var NhapSo = new Common.Validate();
			double doC = NhapSo.NhapSo("Nhập vào nhiệt độ (°C): ");

			double doK = doC + 273.15;
			double doF = doC * 1.8 + 32;

			Console.WriteLine($"Nhiệt độ Kelvin (K): {doK}");
			Console.WriteLine($"Nhiệt độ Fahrenheit (°F): {doF}\n");
		}
	}
}
