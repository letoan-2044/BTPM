using System;

public class TeamLeader : Approver
{
    public override void ProcessRequest(LeaveRequest request)
    {
        if (request.Days <= 2)
        {
            Console.WriteLine($"[TeamLeader] Approved {request.Days} day(s) for {request.EmployeeName}.");
        }
        else if (NextApprover != null)
        {
            NextApprover.ProcessRequest(request);
        }
        else
        {
            Console.WriteLine($"[TeamLeader] Cannot process request from {request.EmployeeName}.");
        }
    }
}
