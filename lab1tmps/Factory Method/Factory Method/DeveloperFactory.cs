public class DeveloperFactory : EmployeeFactory
{
    public override IEmployee CreateEmployee()
    {
        return new Developer();
    }
}