public class ManagerFactory : EmployeeFactory
{
    public override IEmployee CreateEmployee()
    {
        return new Manager();
    }
}