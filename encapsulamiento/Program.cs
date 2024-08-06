using System;

public class Program
{
    public static void Main()
    {
        // Crear una instancia de CuentaBancaria
        CuentaBancaria cuenta = new CuentaBancaria("123456789", "Juan Pérez", 1000m);

        // Mostrar información de la cuenta
        cuenta.MostrarInformacion();

        // Realizar un depósito
        cuenta.Depositar(500m);

        // Realizar un retiro
        cuenta.Retirar(200m);

        // Intentar retirar una cantidad mayor al saldo
        cuenta.Retirar(2000m);

        // Mostrar saldo actual
        Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo():C}");
    }
}
