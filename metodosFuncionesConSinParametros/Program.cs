using System;

public class MetodosYParametrosSinYConParametros
{
    //Declaramos el método sin parametros
    public void mensajeCumpleaños()
    {
        Console.WriteLine("Hola, feliz cumpleaños :D");
    }

    //Declaramos la función de Resta con parametros
    public int Resta(int num1, int num2)
    {
        return num1 - num2;
    }
}

public class Program
{
    public static void Main()
    {
        MetodosYParametrosSinYConParametros var = new MetodosYParametrosSinYConParametros();

        //Imprimimos el mensaje
        var.mensajeCumpleaños();

        //Definimos una variable para guardar el resultado de nuestra resta
        int resultado;

        //Al resultado le asignamos la funcion de Resta y le damos dos numeros 
        resultado = var.Resta(5, 2);

        //Imprimimos el resultado
        Console.WriteLine(resultado);
    }
}