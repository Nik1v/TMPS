public class YearsOfServiceReportVisitor : IReportVisitor
{
    public void Visit(Employee employee)
    {
        Console.WriteLine("Generating years of service report for employee: " + employee.Name);
        // Logica de generare a raportului de vechime în companie pentru angajat
    }
}