using System;

public class figurasGeometricas
{
    public virtual void lados()
    {
        Console.WriteLine("Lados de una figura geometrica");
    }
}

public class Cuadrado : figurasGeometricas
{
    public override void lados()
    {
        Console.WriteLine("El cuadrado tiene 4 lados");
    }
}

public class Triangulo : figurasGeometricas
{
    public override void lados()
    {
        Console.WriteLine("El triangulo tiene 3 lados");
    }
}

public class Program
{
    public static void Main()
    {
        figurasGeometricas lasFigurasGeometricas = new figurasGeometricas();
        figurasGeometricas elCuadrado = new Cuadrado();
        figurasGeometricas elTriangulo = new Triangulo();

        lasFigurasGeometricas.lados();
        elCuadrado.lados();
        elTriangulo.lados();
    }
}

