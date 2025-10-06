public class LeaveRequest
{
    public string EmployeeName { get; set; }
    public int Days { get; set; }

    public LeaveRequest(string employeeName, int days)
    {
        EmployeeName = employeeName;
        Days = days;
    }
}
