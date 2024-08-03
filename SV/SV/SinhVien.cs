using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV
{
    public class SinhVien
    {
        [Key]
        public string Id { get; set; }
        public string Hoten { get; set; }
        public string Malop {  get; set; }
        public string Tenlop { get; set; }
        public string Masv { get; set; }

        public SinhVien(string id, string hoten, string malop, string tenlop, string masv)
        {
            Id = id;
            Hoten = hoten;
            Malop = malop;
            Tenlop = tenlop;
            Masv = masv;
        }
    }
}
