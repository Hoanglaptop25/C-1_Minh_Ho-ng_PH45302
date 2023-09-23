using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1_Minh_Hoàng_PH45302
{
    internal class SinhVienUD : SinhVien
    {
        private int Kihoc;

        public SinhVienUD()
        {

        }
        public SinhVienUD(string maSV, string ten, int namSinh, double diem, int kihoc) : base(maSV, ten, namSinh, diem)
        {
            Kihoc = kihoc;
        }

        public int Kihoc1 { get => Kihoc; set => Kihoc = value; }

        public override void show()
        {
            Console.WriteLine("mã sinh viên: {0} ", masv);
            Console.WriteLine("tên sinh viên: {0}", ten);
            Console.WriteLine("năm sinh: {0}", namsinh);
            Console.WriteLine("điểm: {0}", diem);
        }
    }
}
