namespace SV
{
    public class Tests
    {
        private SinhVienPoly _sinhvienpoly;
        [SetUp]
        public void Setup()
        {
            _sinhvienpoly = new SinhVienPoly();
            _sinhvienpoly.AddSinhVien(new SinhVien("1", "Nguyen Van A", "ML01", "Dai Hoc CNTT", "SV01"));
            _sinhvienpoly.AddSinhVien(new SinhVien("2", "Le Thi B", "ML02", "Dai Hoc Kinh Te", "SV02"));
            _sinhvienpoly.AddSinhVien(new SinhVien("3", "Tran Van C", "ML03", "Dai Hoc Y Duoc", "SV03"));
        }

        [Test]
        [TestCase("1", "Nguyen Van A", "ML01", "Dai Hoc CNTT", "SV01")]
        [TestCase("2", "Le Thi B", "ML02", "Dai Hoc Kinh Te", "SV02")]
        [TestCase("3", "Tran Van C", "ML03", "Dai Hoc Y Duoc", "SV03")]
        [TestCase("4", "Pham Thi D", "ML04", "Dai Hoc Khoa Hoc Xa Hoi", "SV04")]
        [TestCase("5", "Nguyen Thi E", "ML05", "Dai Hoc Bach Khoa", "SV05")]
        [TestCase("6", "Le Van F", "ML06", "Dai Hoc Su Pham", "SV06")]
        [TestCase("7", "Tran Thi G", "ML07", "Dai Hoc Kien Truc", "SV07")]
        [TestCase("8", "Pham Van H", "ML08", "Dai Hoc Luat", "SV08")]
        [TestCase("9", "Nguyen Van I", "ML09", "Dai Hoc Nong Lam", "SV09")]
        [TestCase("10", "Le Thi K", "ML10", "Dai Hoc My Thuat", "SV10")]
        public void AddSinhvie(string id, string hoten, string malop, string tenlop, string masv)
        {
            var sinhvien = new SinhVien(id, hoten, malop, tenlop, masv);
            _sinhvienpoly.AddSinhVien(sinhvien);

            var result = _sinhvienpoly.FindByMaSV(masv);
            Assert.NotNull(result);
            Assert.AreEqual(hoten, result.Hoten);
        }
        [Test]
        [TestCase("SV01", "Nguyen Van A")]
        [TestCase("SV02", "Le Thi B")]
        [TestCase("SV03", "Tran Van C")]
        [TestCase("SV05", "Le Thi C")]
        [TestCase("SV04", null)] // Không tìm thấy sinh viên
        [TestCase("", null)] // Mã sinh viên trống
        public void FindByMasv(string masv, string expectedHoten)
        {
            var result = _sinhvienpoly.FindByMaSV(masv);

            if (expectedHoten != null)
            {
                Assert.NotNull(result);
                Assert.AreEqual(expectedHoten, result.Hoten);
            }
            else
            {
                Assert.Null(result);
            }
        }
    }
}