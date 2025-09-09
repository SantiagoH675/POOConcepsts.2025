﻿
namespace POO.Concepts._2025.Core;

public class Invoice : Ipay
{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public float Quantity { get; set; }

    public decimal GetValueToPay() => Price * (decimal)Quantity;

    public override string ToString() =>
        $"{Id}\t{Description}\n\t" +
        $"Quantity......: {Quantity,20:N2}\n\t" +
        $"Price.........: {Price,20:C2}\n\t" +
        $"Value to pay..: {GetValueToPay(),20:C2}";
}