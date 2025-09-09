using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts._2025.Core;

public class HourlyEmployee : Employee
{
    private decimal _hourValue;
    private float _workingHours;

    public decimal HourValue 
    { 
        get => _hourValue; 
        set => _hourValue = ValidateHourValue (value); 
    }
    public float WorkingHours 
    { 
        get => _workingHours; 
        set => _workingHours = ValidateWorkingHours (value); 
    }

    public override decimal GetValueToPay() => HourValue * (decimal)WorkingHours;
    
    private decimal ValidateHourValue(decimal hourValue)
    {
        if (hourValue <= 0)
        {
            throw new Exception($"The hour value: {hourValue:C2}, is less or equals than zero.");
        }
        return hourValue;
    }
    private float ValidateWorkingHours (float workingHours)
    {
        if (workingHours <= 0)
        {
            throw new Exception($"The working hours: {workingHours:N2}, is less or equals than the zero.");
        }
        return workingHours;
    }
}
