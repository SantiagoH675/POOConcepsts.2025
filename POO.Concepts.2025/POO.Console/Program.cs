using POO.Concepts._2025.Core;

try 
{ 
    var employee1 = new SalaryEmployee { Id = 1010, Firstname = "Sandra", Lastname = "Lopez", BornDate = new Date(1980, 12, 2), HireDate = new Date(2023, 2, 12), IsActive = true, Salary = 2000000};
    var employee2 = new HourlyEmployee { Id = 2020, Firstname = "Hector", Lastname = "Rosales", BornDate = new Date(1974, 9, 21), HireDate = new Date(2021, 2, 10), IsActive = true, HourValue = 34679, WorkingHours = 127 };
    var employee3 = new CommisionEmployee { Id = 3030, Firstname = "Vanessa", Lastname = "Zapata", BornDate = new Date(1984, 4, 11), HireDate = new Date(2023, 11, 1), IsActive = true, CommisionPercentaje = 0.03f, Sales = 527000000 };
    var employee4 = new BaseCommisionEmployee { Id = 4030, Firstname = "Vanessa", Lastname = "Zapata", BornDate = new Date(1984, 4, 11), HireDate = new Date(2023, 11, 1), IsActive = true, CommisionPercentaje = 0.01f, Sales =  89568000, Salary = 500000};
    var employes = new List <Employee> { employee1, employee2, employee3, employee4 };
    decimal total = 0;
    foreach(var employee in employes)
    {
        Console.WriteLine(employee);
        Console.WriteLine();
        total += employee.GetValueToPay();
    }
    Console.WriteLine("                        ====================");
    Console.WriteLine($"Total:                  {total,20:C2}");

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);

}