using System;

public class Empleado
{
    //método CalcularSalario para empleados con salario fijo
    public double CalcularSalario(double salarioBase)
    {
        return salarioBase;
    }

    //método CalcularSalario para empleados con salario base y horas extras
    public double CalcularSalario(double salarioBase, double horasExtras, double tarifaHoraExtra)
    {
        return salarioBase + (horasExtras * tarifaHoraExtra);
    }

    // método CalcularSalario para empleados con salario base, horas extras y bonificación
    public double CalcularSalario(double salarioBase, double horasExtras, double tarifaHoraExtra, double bonificacion)
    {
        return salarioBase + (horasExtras * tarifaHoraExtra) + bonificacion;
    }
}

public class Program
{
    public static void Main()
    {
        Empleado emp = new Empleado();

        // Llamamos al método CalcularSalario con diferentes argumentos
        Console.WriteLine(emp.CalcularSalario(3000));                          // Output: 3000
        Console.WriteLine(emp.CalcularSalario(3000, 10, 20));                  // Output: 3200
        Console.WriteLine(emp.CalcularSalario(3000, 10, 20, 500));             // Output: 3700
    }
}
