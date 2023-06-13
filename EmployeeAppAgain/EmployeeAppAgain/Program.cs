using EmployeeAppAgain;

Employee jute = new Employee("Jute", 45, 23);
Console.WriteLine(jute);
Console.WriteLine(jute.CalculatePay().ToString("c"));

PermanentEmployee yute = new PermanentEmployee("Yute", 34, 40, 0.5m);
Console.WriteLine(yute);
Console.WriteLine(yute.CalculatePay().ToString("c"));