using DPM225477_LeHuuToan_VD_Builder;
using System;

class Program
{
    static void Main()
    {
        // Tạo builder cho máy tính chơi game
        IComputerBuilder gamingBuilder = new GamingComputerBuilder();
        Director director = new Director(gamingBuilder);

        director.ConstructComputer();
        Computer gamingPC = director.GetComputer();

        Console.WriteLine("=== Gaming PC ===");
        Console.WriteLine(gamingPC);
        Console.WriteLine();

        // Tạo builder cho máy tính văn phòng
        IComputerBuilder officeBuilder = new OfficeComputerBuilder();
        director = new Director(officeBuilder);

        director.ConstructComputer();
        Computer officePC = director.GetComputer();

        Console.WriteLine("=== Office PC ===");
        Console.WriteLine(officePC);
    }
}
