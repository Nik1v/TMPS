public class SalaryReportVisitor : IReportVisitor
{
    public void Visit(Employee employee)
    {
        Console.WriteLine("Generating salary report for employee: " + employee.Name);
        // Logica de generare a raportului de salariu pentru angajat
    }
}