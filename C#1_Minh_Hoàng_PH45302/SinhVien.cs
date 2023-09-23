using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1_Minh_Hoàng_PH45302
{
    internal class SinhVien
    {
        private string MaSV;
        private string Ten;
        private int Namsinh;
        private double Diem;

        public SinhVien()
        {

        }
        public SinhVien(string Masv, string Ten, int Namsinh, double Diem)
        {
            masv = Masv;
            ten = Ten;
            namsinh = Namsinh;
            diem = Diem;
        }

        public string masv { get => MaSV; set => MaSV = value; }
        public string ten { get => Ten; set => Ten = value; }
        public int namsinh { get => Namsinh; set => Namsinh = value; }
        public double diem { get => Diem; set => Diem = value; }

        public virtual void show()
        {
            Console.WriteLine("mã sinh viên: {0} ", masv);
            Console.WriteLine("tên sinh viên: {0}", ten);
            Console.WriteLine("năm sinh: {0}", namsinh);
            Console.WriteLine("điểm: {0}", diem);
        }
        public void inThongTin()
        {
            Console.WriteLine("Nhập mã sinh viên: ");
            masv = Console.ReadLine();
            Console.WriteLine("Nhập tên: ");
            ten = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh: ");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập điểm: ");
            diem = Convert.ToInt32(Console.ReadLine());
        }
    }
}
