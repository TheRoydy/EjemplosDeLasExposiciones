using System;

public class CuentaBancaria
{
    // Atributos privados
    private string numeroCuenta;
    private string titular;
    private decimal saldo;

    // Constructor
    public CuentaBancaria(string numeroCuenta, string titular, decimal saldoInicial)
    {
        this.numeroCuenta = numeroCuenta;
        this.titular = titular;
        this.saldo = saldoInicial;
    }

    // Método público para obtener el saldo
    public decimal ObtenerSaldo()
    {
        return saldo;
    }

    // Método público para depositar dinero
    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            saldo += cantidad;
            Console.WriteLine($"Se han depositado {cantidad:C}. Saldo actual: {saldo:C}");
        }
        else
        {
            Console.WriteLine("La cantidad a depositar debe ser positiva.");
        }
    }

    // Método público para retirar dinero
    public void Retirar(decimal cantidad)
    {
        if (cantidad > 0 && cantidad <= saldo)
        {
            saldo -= cantidad;
            Console.WriteLine($"Se han retirado {cantidad:C}. Saldo actual: {saldo:C}");
        }
        else
        {
            Console.WriteLine("La cantidad a retirar debe ser positiva y no exceder el saldo disponible.");
        }
    }

    // Método público para obtener la información de la cuenta
    public void MostrarInformacion()
    {
        Console.WriteLine($"Número de Cuenta: {numeroCuenta}");
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo:C}");
    }
}
