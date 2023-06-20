public class PartTimeEmployee : Employee
{
    public override void Accept(IReportVisitor visitor)
    {
        visitor.Visit(this);
    }
}