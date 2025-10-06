using DPM225477_LeHuuToan_VD_Prototype;
using System;

class Program
{
    static void Main()
    {
        // Tạo nhân viên gốc (prototype)
        Employee original = new Employee("An", "Developer", new Address("Hà Nội", "Trần Duy Hưng"));
        original.ShowInfo();

        // Tạo bản sao từ prototype
        Employee clone = (Employee)original.Clone();
        clone.Name = "Bình";
        clone.Address.City = "Đà Nẵng";

        Console.WriteLine("\nSau khi sao chép và chỉnh sửa:");
        original.ShowInfo(); // Gốc
        clone.ShowInfo();    // Bản sao
    }
}
