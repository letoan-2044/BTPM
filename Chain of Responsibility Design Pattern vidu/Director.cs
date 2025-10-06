using System;

public class Director : Approver
{
    public override void ProcessRequest(LeaveRequest request)
    {
        if (request.Days <= 10)
        {
            Console.WriteLine($"[Director] Approved {request.Days} day(s) for {request.EmployeeName}.");
        }
        else
        {
            Console.WriteLine($"[Director] Denied {request.EmployeeName}'s request for {request.Days} day(s). Too long!");
        }
    }
}
