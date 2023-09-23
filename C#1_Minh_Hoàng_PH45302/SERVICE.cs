using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1_Minh_Hoàng_PH45302
{
    internal static class SERVICE
    {
        static List<SinhVien> list = new List<SinhVien>();

        public static void Nhap()
        {
            do
            {
                SinhVien sv = new SinhVien();
                sv.inThongTin();
                list.Add(sv);
                Console.WriteLine("Nhập y để tiếp tục");
                string str = Console.ReadLine();
                if (str != "y")
                {
                    break;
                }
            } while (true);
        }

        public static void Xoa()
        {
            Console.WriteLine("Danh sách sinh viên không được tham gia HappyBee nếu không được tặng ");
            foreach (SinhVien sv in list)
            {
                if (2023 - sv.namsinh > 25)
                {
                    list.Remove(sv);
                    break;
                }
            }
        }

        public static void XuatDS()
        {
            Console.WriteLine("Danh sách sinh viên :");
            foreach (SinhVien sv in list)
            {
                sv.show();
            }
        }

        public static void DSSVHappyBee()
        {
            
            Console.WriteLine("Danh sách sinh viên được tặng vé HappyBee :");
            foreach (SinhVien sv in list)
            {
                if (sv.diem >= 8)
                {
                    sv.show();
                }
            }
        }
    }
}

