using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_PRoxy
{
    using System;

    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk(); // tải ảnh thật
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Đang tải ảnh '{_fileName}' từ ổ đĩa...");
        }

        public void Display()
        {
            Console.WriteLine($"Hiển thị ảnh: {_fileName}");
        }
    }

}
