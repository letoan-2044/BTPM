using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_Prototype
{
    using System;
    using System.Net;

    public class Employee : IPrototype
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public Address Address { get; set; }

        public Employee(string name, string position, Address address)
        {
            Name = name;
            Position = position;
            Address = address;
        }

        // Clone: tạo bản sao sâu (deep copy)
        public IPrototype Clone()
        {
            // Sao chép cả Address (đối tượng con)
            return new Employee(Name, Position, new Address(Address.City, Address.Street));
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Nhân viên: {Name}, Vị trí: {Position}, Địa chỉ: {Address.City} - {Address.Street}");
        }
    }

}
