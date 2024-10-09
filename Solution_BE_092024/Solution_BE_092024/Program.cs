using Solution_BE_092024.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_092024
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			#region Switch Case
			while (true)
			{
				Console.WriteLine("Chọn một bài tập để thực hiện:");
				Console.WriteLine("0.Thoát chương trình\n");
				Console.WriteLine("1. Tìm tổng, tích, hiệu của hai số");
				Console.WriteLine("2. Giải phương trình bậc 1 và bậc 2");
				Console.WriteLine("3. Chuyển đổi độ C thành độ K và độ F");
				Console.WriteLine("4. Tính giai thừa của một số");
				Console.WriteLine("5. Kiểm tra số nguyên tố nhỏ hơn N");
				Console.WriteLine("6. Kiểm tra chẵn lẻ ");
				Console.Write("\nNhập lựa chọn của bạn: ");
				var NhapSo = new Validate();
				int luaChon = (int)NhapSo.NhapSo("");

				switch (luaChon)
				{
					case 0:
						return;
					case 1:
						Bai1();
						break;
					case 2:
						Bai2();
						break;
					case 3:
						Bai3();
						break;
					case 4:
						Bai4();
						break;
					case 5:
						Bai5();
						break;
					case 6:
						Bai6();
						break;
					default:
						Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
						break;
				}
				#endregion
			}

		}
		#region Bài 1: Tìm tổng, tích, hiệu của hai số
		static void Bai1()
		{
			var bai1 = new Solution_BE_092024.Baitap.Buoi1.Bai1();
			bai1.TimTongHieuTich();
		}
		#endregion

		#region Bài 2: Giải phương trình bậc 1 và bậc 2
		static void Bai2()
		{
			var bai2 = new Solution_BE_092024.Baitap.Buoi1.Bai2();
			bai2.GiaiPhuongTrinh();

		}
		#endregion

		#region Bài 3: Chuyển đổi độ C thành độ K và độ F
		static void Bai3()
		{
			var bai3 = new Solution_BE_092024.Baitap.Buoi1.Bai3();
			bai3.ChuyenDoiNhietDo();

		}
		#endregion

		#region Bài 4: Tính giai thừa của một số
		static void Bai4()
		{
			var bai4 = new Solution_BE_092024.Baitap.Buoi1.Bai4();
			bai4.TinhGiaiThua();

		}
		#endregion

		#region Bài 5: Liệt kê tất cả các số nguyên tố nhỏ hơn n
		static void Bai5()
		{
			var bai5 = new Solution_BE_092024.Baitap.Buoi2.Bai5();
			bai5.SoNguyenToNhoHonN();
		}
		#endregion

		#region Bài 6: Kiểm tra số chẵn hay lẻ
		static void Bai6()
		{
			var bai6 = new Solution_BE_092024.Baitap.Buoi2.Bai6();
			bai6.KiemTraChanLe();
		}
		#endregion

		
	}
}
