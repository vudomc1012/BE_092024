using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_092024.Baitap.Buoi2
{
	public class Bai5
	{
		//		Bài 5: Viết
		//chương trình C# liệt kê tất cả các số nguyên tố nhỏ hơn n.
		public void SoNguyenToNhoHonN()
		{
			var LaSoNguyenTo = new SoNguyenTo.SoNguyenTo();
			var NhapSo = new Common.Validate();
			int n = (int)NhapSo.NhapSo("Nhập vào một số nguyên dương: ");
			for (int i = 2; i < n; i++)
			{
				if (LaSoNguyenTo.LaSoNguyenTo(i))
				{
					Console.WriteLine("\nNhững số nguyên tố nhỏ hơn n: {0}\n",i);
					
				}
			}
		}
	}
}
