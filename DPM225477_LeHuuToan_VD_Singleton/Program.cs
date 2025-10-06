using DPM225477_LeHuuToan_VD_Singleton;
using System;

class Program
{
    static void Main()
    {
        // Lấy thể hiện đầu tiên của Logger
        Logger logger1 = Logger.Instance;
        logger1.Log("Khởi động hệ thống.");

        // Lấy thể hiện khác (nhưng thật ra là cùng một)
        Logger logger2 = Logger.Instance;
        logger2.Log("Đang xử lý dữ liệu...");

        // So sánh xem 2 biến có trỏ cùng một đối tượng không
        Console.WriteLine("\nHai logger có cùng đối tượng không? " + (logger1 == logger2));
    }
}
