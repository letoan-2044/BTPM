using DPM225477_LeHuuToan_VD_PRoxy;
using System;

class Program
{
    static void Main()
    {
        IImage image1 = new ProxyImage("hoa.png");
        IImage image2 = new ProxyImage("bien.jpg");

        // Lần đầu hiển thị: ảnh được tải từ ổ đĩa
        image1.Display();
        Console.WriteLine();

        // Hiển thị lại ảnh cũ: dùng ảnh đã tải (không tải lại)
        image1.Display();
        Console.WriteLine();

        // Ảnh mới: tải lần đầu
        image2.Display();
    }
}
