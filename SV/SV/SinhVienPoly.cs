using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV
{
    public class SinhVienPoly
    {
        private List<SinhVien> sinhVienList;

        public SinhVienPoly()
        {
            sinhVienList = new List<SinhVien>();
        }

        // Thêm sinh viên vào danh sách
        public void AddSinhVien(SinhVien sv)
        {
            if (string.IsNullOrEmpty(sv.Tenlop) || sv.Tenlop.Any(char.IsSymbol) || sv.Tenlop.Any(char.IsPunctuation))
            {
                throw new ArgumentException("Tên lớp không được chứa ký tự đặc biệt.");
            }
            sinhVienList.Add(sv);
        }

        // Tìm sinh viên theo mã sinh viên
        public SinhVien FindByMaSV(string maSV)
        {
            return sinhVienList.FirstOrDefault(sv => sv.Masv.Equals(maSV, StringComparison.OrdinalIgnoreCase));
        }
    }
}
