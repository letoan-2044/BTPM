using System;

public class Manager : Approver
{
    public override void ProcessRequest(LeaveRequest request)
    {
        if (request.Days <= 5)
        {
            Console.WriteLine($"[Manager] Approved {request.Days} day(s) for {request.EmployeeName}.");
        }
        else if (NextApprover != null)
        {
            NextApprover.ProcessRequest(request);
        }
        else
        {
            Console.WriteLine($"[Manager] Cannot process request from {request.EmployeeName}.");
        }
    }
}
