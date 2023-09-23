using C_1_Minh_Hoàng_PH45302;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1_Minh_Hoàng_PH45302
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();
        }
        static void Menu()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            do
            {
                Console.WriteLine("Sinh viên tham gia HappyBee");
                Console.WriteLine("1.Nhập danh sách đối tượng");
                Console.WriteLine("2.Xuất danh sách đối tượng");
                Console.WriteLine("3.Xuất danh sách sinh viên được tặng vé HappyBee");
                Console.WriteLine("4.Xóa sinh viên không được tham gia HappyBee nếu không được tặng");
                Console.WriteLine("5.Kế Thừa");
                Console.WriteLine("Thoát");
                Console.Write("Vui lòng chọn chức năng :");
                string ch = Console.ReadLine();
                if (ch == "0")
                {
                    break;
                }
                switch (ch)
                {
                    case "1":
                        SERVICE.Nhap();
                        break;
                    case "2":
                        SERVICE.XuatDS();
                        break;
                    case "3":
                        SERVICE.DSSVHappyBee();
                        break;
                    case "4":
                        SERVICE.Xoa();
                        break;
                    case "5":
                        KeThua();
                        break;
                    default:
                        break;

                }

            } while (true);
            Console.ReadLine();
        }
        static void KeThua()
        {
            SinhVienUD svUD = new SinhVienUD();


            Console.WriteLine("Nhập mã sinh viên: ");
            svUD.masv = Console.ReadLine();
            Console.WriteLine("Nhập tên: ");
            svUD.ten = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh: ");
            svUD.namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập điểm: ");
            svUD.diem = Convert.ToInt32(Console.ReadLine());

            svUD.show();
        }
    }
}


