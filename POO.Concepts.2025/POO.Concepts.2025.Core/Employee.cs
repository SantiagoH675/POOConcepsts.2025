﻿
namespace POO.Concepts._2025.Core;

public abstract class Employee
{
    public int Id { get; set; }
    public string Firstname { get; set; } = null!;
    public string Lastname { get; set; } = null!;
    public bool IsActive { get; set; }
    public Date BornDate { get; set; } = null!;
    public Date HireDate { get; set; } = null!;

    public abstract decimal GetValueToPay();

    public override string ToString() =>
        $"{Id}\t{Firstname} {Lastname}\n\t" +
        $"Born date.....: {BornDate}\n\t" +
        $"Hire date.....: {HireDate}";
        
        
}

