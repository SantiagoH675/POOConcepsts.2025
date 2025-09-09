using POO.Concepts._2025.Core;

try 
{ 
    var employee1 = new SalaryEmployee { Id = 1010, Firstname = "Sandra", Lastname = "Lopez", BornDate = new Date(1980, 12, 2), HireDate = new Date(2023, 2, 12), IsActive = true, Salary = 2000000};
    var employee2 = new HourlyEmployee { Id = 2020, Firstname = "Hector", Lastname = "Rosales", BornDate = new Date(1974, 9, 21), HireDate = new Date(2021, 2, 10), IsActive = true, HourValue = 34679, WorkingHours = 127 };

    var employes = new List <Employee> { employee1, employee2 };
    decimal total = 0;
    foreach(var employee in employes)
    {
        Console.WriteLine(employee);
        total += employee.GetValueToPay();
    }
    Console.WriteLine("                        ====================");
    Console.WriteLine($"Total:                  {total,20:C2}");

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);

}