Employee fullTimeEmployee = new FullTimeEmployee { Name = "John Doe", Salary = 5000, YearsOfService = 5 };
Employee partTimeEmployee = new PartTimeEmployee { Name = "Jane Smith", Salary = 2000, YearsOfService = 2 };

IReportVisitor salaryReportVisitor = new SalaryReportVisitor();
fullTimeEmployee.Accept(salaryReportVisitor);
partTimeEmployee.Accept(salaryReportVisitor);

Console.WriteLine();

IReportVisitor yearsOfServiceReportVisitor = new YearsOfServiceReportVisitor();
fullTimeEmployee.Accept(yearsOfServiceReportVisitor);
partTimeEmployee.Accept(yearsOfServiceReportVisitor);

Console.ReadKey();
