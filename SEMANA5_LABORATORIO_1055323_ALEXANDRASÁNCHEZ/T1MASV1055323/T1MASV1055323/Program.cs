using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mi segundo programa");

        Console.WriteLine("Ingrese su nombre: ");
        string Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad: ");
        string Edad = Console.ReadLine();

        Console.WriteLine("Ingrese su carrera: ");
        string Carrera = Console.ReadLine();

        Console.WriteLine("Ingrese su carné: ");
        string Carne = Console.ReadLine();

        Console.WriteLine("Mi segundo programa");
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad: " + Edad);
        Console.WriteLine("Carrera: " + Carrera);
        Console.WriteLine("Carné: " + Carne);

        Console.WriteLine("Soy " + Nombre + ", tengo " + Edad + " años y estudio la carrera de " + Carrera + ". Mi número de carné es; " + Carne);

        Console.ReadKey();
    }
}
