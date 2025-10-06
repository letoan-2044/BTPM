
using System;

class Program
{
    static void Main(string[] args)
    {
        // Tạo các đối tượng xử lý
        Approver teamLeader = new TeamLeader();
        Approver manager = new Manager();
        Approver director = new Director();

        // Thiết lập chuỗi xử lý
        teamLeader.SetNext(manager);
        manager.SetNext(director);

        // Một số yêu cầu nghỉ phép
        var requests = new[]
        {
            new LeaveRequest("Alice", 1),
            new LeaveRequest("Bob", 4),
            new LeaveRequest("Charlie", 7),
            new LeaveRequest("David", 12)
        };

        // Xử lý từng yêu cầu
        foreach (var req in requests)
        {
            teamLeader.ProcessRequest(req);
        }

        Console.ReadKey();
    }
}
