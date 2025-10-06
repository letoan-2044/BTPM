using DPM225477_LeHuuToan_VD_Factory_Method;
using System;

class Program
{
    static void Main()
    {
        DeliveryFactory factory;

        Console.Write("Nhập loại giao hàng (Road/Air/Sea): ");
        string type = Console.ReadLine();

        if (type.Equals("Road", StringComparison.OrdinalIgnoreCase))
            factory = new RoadDeliveryFactory();
        else if (type.Equals("Air", StringComparison.OrdinalIgnoreCase))
            factory = new AirDeliveryFactory();
        else
            factory = new SeaDeliveryFactory();

        IDelivery delivery = factory.CreateDelivery();
        delivery.Deliver("Hộp quà Tết 🎁");
    }
}
