using System;
using System.Text;

namespace lab7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var EmployeesManager = new EmployeeManager();
            while (true)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Tạo mới nhân viên.");
                Console.WriteLine("2. Hiển thị danh sách nhân viên.");
                Console.WriteLine("3. Sửa thông tin nhân viên.");
                Console.WriteLine("4. Xóa thông tin nhân viên.");
                Console.WriteLine("0. Đóng chương trình.");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Vui lòng nhập lựa chọn của bạn từ 0->4: ");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: EmployeesManager.Create();
                        break;
                    case 2: EmployeesManager.Display();
                        break;
                    case 3: EmployeesManager.Update();
                        break;
                    case 4:EmployeesManager.Delete();
                        break;
                }

                if (choice == 0)
                {
                    break;
                }
            }
        }
    }
}