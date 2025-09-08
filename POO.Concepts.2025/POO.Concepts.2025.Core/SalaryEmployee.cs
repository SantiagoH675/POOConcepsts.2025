using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts._2025.Core;

public class SalaryEmployee : Employee
{
    private const decimal MINIMUM_SALARY = 1500000;
    private decimal _Salary;

    public decimal Salary 
    { 
        get => _Salary;
        set => _Salary = ValidateSalary (value);
    }

    public override decimal GetValueToPay() => Salary;

    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
            $"Salary........: {GetValueToPay():C2}";
    }
    private decimal ValidateSalary (decimal salary)
    {
        if(salary < MINIMUM_SALARY)
        {
            throw new Exception($"The salary: {salary:C2}, is less the minimum ({MINIMUM_SALARY:C2}).");
        }
        return salary;
    }
}
