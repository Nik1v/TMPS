public abstract class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public int YearsOfService { get; set; }

    public abstract void Accept(IReportVisitor visitor);
}