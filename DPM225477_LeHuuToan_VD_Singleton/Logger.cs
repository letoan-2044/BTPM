using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225477_LeHuuToan_VD_Singleton
{
    using System;

    public sealed class Logger
    {
        // Biến tĩnh giữ thể hiện duy nhất của Logger
        private static Logger _instance = null;

        // Đảm bảo thread-safe khi nhiều luồng cùng truy cập
        private static readonly object _lock = new object();

        // Constructor private để ngăn tạo mới bên ngoài
        private Logger()
        {
            Console.WriteLine("Logger được khởi tạo!");
        }

        // Thuộc tính truy cập duy nhất đến thể hiện Logger
        public static Logger Instance
        {
            get
            {
                // Kiểm tra và khởi tạo nếu chưa có
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }
        }

        // Phương thức ghi log
        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
        }
    }

}
