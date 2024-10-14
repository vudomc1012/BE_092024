using Solution_BE_092024.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution_BE_092024.Baitap.Buoi3;

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
				Console.WriteLine("7. Kiểm tra số nguyên tố");
				Console.WriteLine("8. In ra mảng sổ lẻ và mảng số chẵn");
				Console.WriteLine("9. Sắp xếp mảng");
				Console.WriteLine("10. Hiển thị số bằng chữ\n");
				Console.WriteLine("13. Trả về tham chiếu tới phần tử lớn nhất trong mảng");
				Console.WriteLine("14. Hoán đổi giá trị của hai biến nguyên sử dụng tham chiếu kép");
				Console.WriteLine("15. Thay đổi giá trị của một phần tử trong mảng sử dụng tham chiếu kép");
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
					case 7:
						Bai7();
						break;
					case 8:
						Bai8();
						break;
					case 9:
						Bai9();
						break;
					case 10:
						Bai10();
						break;
					case 13:
						Bai13();
						break;
					case 14:
						Bai14();
						break;
					case 15:
						Bai15();
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

		#region Bài 7: Kiểm tra số nguyên tố
		static void Bai7()
		{
			var bai7 = new Solution_BE_092024.Baitap.Buoi2.Bai7();
			bai7.KiemTraSoNguyenTo();
		}
		#endregion

		#region Bài 8: Cho một mảng số nguyên hãy in ra mảng sổ lẻ và mảng số chẵn
		static void Bai8()
		{
			var bai8 = new Solution_BE_092024.Baitap.Buoi2.Bai8();
			bai8.ChiaMangChanLe();
		}
		#endregion

		#region Bài 9: Sắp xếp mảng số nguyên tăng dần và giảm dần
		static void Bai9()
		{
			var bai9 = new Solution_BE_092024.Baitap.Buoi2.Bai9();
			bai9.SapXepMang();
		}
		#endregion

		#region Bài 10: Hiển thị số bằng chữ tương ứng
		static void Bai10()
		{
			var bai10 = new Solution_BE_092024.Baitap.Buoi2.Bai10();
			bai10.HienThiSoBangChu();
		}
		#endregion

		#region Bài 13: Trả về tham chiếu tới phần tử lớn nhất trong mảng
		static void Bai13()
		{			
			int[] numbers = { 5, 7, 3, 9, 2, 8 };
			Bai13 maxFinder = new Bai13();
			ref int max = ref maxFinder.FindMax(ref numbers);
			Console.WriteLine("Giá trị lớn nhất: \n" + max);
			Console.ReadKey();
		}
		#endregion

		#region Bài 14: Hoán đổi giá trị của hai biến nguyên sử dụng tham chiếu kép
		static void Bai14()
		{
			int x = 5;
			int y = 10;
			Bai14 swapper = new Bai14();
			swapper.Swap(ref x, ref y);
			Console.WriteLine($"Giá trị sau khi hoán đổi: x = {x}, y = {y}");
			Console.ReadKey();
		}
		#endregion

		#region Bài 15: Thay đổi giá trị của phần tử trong mảng
		static void Bai15()
		{
			int[] numbers = { 1, 2, 3, 4, 5 };
			Bai15 modifier = new Bai15();
			modifier.ChangeElement(ref numbers, 2, 100);
			Console.WriteLine("Mảng sau khi thay đổi: " + string.Join(", ", numbers));
			Console.ReadKey();
		}

		#endregion
	}
}
