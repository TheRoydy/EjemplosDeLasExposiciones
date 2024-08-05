using System;

public class Auto
{
    //Atributos
    public string nombreAuto { get; set; }
    public string color { get; set; }
    public int ruedas { get; set; }
    public string motor { get; set; }

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
        //Se crea la instancia del auto
        Auto auto = new Auto()
        {
            nombreAuto = "BWM",
            color = "Negro",
            ruedas = 4,
            motor = "v8"
        };

        //Mostramos la información del auto
        Console.WriteLine($"Nombre del Auto: {auto.nombreAuto}");
        Console.WriteLine($"Color: {auto.color}");
        Console.WriteLine($"Ruedas: {auto.ruedas}");
        Console.WriteLine($"Motor: {auto.motor}");

        //llamamos a los metodos que tiene el auto
        auto.avanzar();
        auto.retoceder();
        auto.estacionar();
    }
}
