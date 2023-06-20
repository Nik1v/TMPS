public class FullTimeEmployee : Employee
{
    public override void Accept(IReportVisitor visitor)
    {
        visitor.Visit(this);
    }
}