public abstract class Approver
{
    protected Approver NextApprover;

    public void SetNext(Approver next)
    {
        NextApprover = next;
    }

    public abstract void ProcessRequest(LeaveRequest request);
}
