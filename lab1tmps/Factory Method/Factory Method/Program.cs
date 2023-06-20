// Creăm o instanță a fabricii de angajați de tip Manager
EmployeeFactory managerFactory = new ManagerFactory();
// Folosim fabrica pentru a crea un angajat de tip Manager
IEmployee manager = managerFactory.CreateEmployee();
// Executăm sarcina specifică managerului
manager.PerformTask();

// Creăm o instanță a fabricii de angajați de tip Developer
EmployeeFactory developerFactory = new DeveloperFactory();
// Folosim fabrica pentru a crea un angajat de tip Developer
IEmployee developer = developerFactory.CreateEmployee();
// Executăm sarcina specifică dezvoltatorului
developer.PerformTask();

Console.ReadKey();