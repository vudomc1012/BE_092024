using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_092024.Baitap.Buoi2
{
	public class Bai9
	{
		public void SapXepMang()
		{
			var NhapSo = new Common.Validate();
			int n = (int)NhapSo.NhapSo("Nhập vào số lượng phần tử của mảng: ");
			int[] mangSo = new int[n];

			for (int i = 0; i < n; i++)
			{
				mangSo[i] = (int)NhapSo.NhapSo($"Nhập phần tử thứ {i + 1}: ");
			}

			Array.Sort(mangSo);
			Console.WriteLine("Mảng số nguyên sau khi sắp xếp tăng dần: " + string.Join(", ", mangSo));

			Array.Reverse(mangSo);
			Console.WriteLine("Mảng số nguyên sau khi sắp xếp giảm dần: " + string.Join(", ", mangSo));
		}
	}
}
