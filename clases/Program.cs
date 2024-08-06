using clases;
using System;

public class Auto : IAuto
{
    // Implementar las propiedades
    public string nombreAuto { get; set; }
    public string color { get; set; }
    public int ruedas { get; set; }
    public string motor { get; set; }

    object IAuto.nombreAuto => throw new NotImplementedException();

    object IAuto.color => throw new NotImplementedException();

    object IAuto.ruedas => throw new NotImplementedException();

    object IAuto.motor => throw new NotImplementedException();

    // Implementar los métodos
    public void avanzar()
    {
        Console.WriteLine($"{nombreAuto} {color} avanza 100 metros");
    }

    public void retoceder()
    {
        Console.WriteLine($"{nombreAuto} {color} retrocede 200 metros");
    }

    public void estacionar()
    {
        Console.WriteLine($"{nombreAuto} {color} estaciona en el parque");
    }
}

public class Program
{
    public static void Main()
    {
        // Crear una instancia de Auto que implementa IAuto
        IAuto auto = new Auto()
        {
            nombreAuto = "BMW",
            color = "Negro",
            ruedas = 4,
            motor = "v8"
        };

        // Mostrar la información del auto
        Console.WriteLine($"Nombre del Auto: {auto.nombreAuto}");
        Console.WriteLine($"Color: {auto.color}");
        Console.WriteLine($"Ruedas: {auto.ruedas}");
        Console.WriteLine($"Motor: {auto.motor}");

        // Llamar a los métodos que tiene el auto
        auto.avanzar();
        auto.retoceder();
        auto.estacionar();
    }
}
