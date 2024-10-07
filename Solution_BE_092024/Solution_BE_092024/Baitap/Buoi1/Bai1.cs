using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_BE_092024.Baitap.Buoi1
{
	public class Bai1
	{
		public void TimTongHieuTich()
		{
			var NhapSo = new Common.Validate();
			double soThuNhat = NhapSo.NhapSo("Nhập vào số thứ nhất: ");
			double soThuHai = NhapSo.NhapSo("Nhập vào số thứ hai: ");

			double tong = soThuNhat + soThuHai;
			double hieu = soThuNhat - soThuHai;
			double tich = soThuNhat * soThuHai;

			Console.WriteLine($"Tổng của {soThuNhat} và {soThuHai} là: {tong}");
			Console.WriteLine($"Hiệu của {soThuNhat} và {soThuHai} là: {hieu}");
			Console.WriteLine($"Tích của {soThuNhat} và {soThuHai} là: {tich}\n");
		}
	}
}
