Car car = new Car();
car.Color = "Blue";

Car clonedCar = (Car)car.Clone();
clonedCar.Color = "Yellow";

Console.WriteLine("Original Car: " + car.Color);
Console.WriteLine("Cloned Car: " + clonedCar.Color);

Motorcycle motorcycle = new Motorcycle();
motorcycle.Color = "Green";

Motorcycle clonedMotorcycle = (Motorcycle)motorcycle.Clone();
clonedMotorcycle.Color = "Orange";

Console.WriteLine("Original Motorcycle: " + motorcycle.Color);
Console.WriteLine("Cloned Motorcycle: " + clonedMotorcycle.Color);

Console.ReadKey();