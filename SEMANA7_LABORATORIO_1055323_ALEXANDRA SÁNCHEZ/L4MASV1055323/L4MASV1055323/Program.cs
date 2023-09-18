using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 1: Operaciones aritméticas");

        Console.WriteLine("Ingrese un número:");
        string numero1 = Console.ReadLine();
        int num1 = Convert.ToInt32(numero1);

        Console.WriteLine("Ingrese un segundo número:");
        string numero2 = Console.ReadLine();
        int num2 = Convert.ToInt32(numero2);

        Console.WriteLine("Ingrese un tercer número:");
        string numero3 = Console.ReadLine();
        int num3 = Convert.ToInt32(numero3);

        int suma = num1 + num2;
        int resta = num1 - num2;
        int mult = num1 * num2;
        int div = num1 / num2;

        Console.WriteLine("Suma: " + num1 + " + " + num2 + " = " + suma);
        Console.WriteLine("Resta: " + num1 + " - " + num2 + " = " + resta);
        Console.WriteLine("Multiplicación: " + num1 + " * " + num2 + " = " + mult);
        Console.WriteLine("División: " + num1 + " / " + num2 + " = " + div);

        Console.WriteLine("Ejercicio 2: Operaciones booleanas");

        if (num1 > num2)
        {
            Console.WriteLine(num1 + " es mayor que " + num2);
        }
        if (num1 < num2)
        {
            Console.WriteLine(num1 + " es menor que " + num2);
        }
        else
        {
            Console.WriteLine(num1 + " es igual que " + num2);
        }

        Console.WriteLine("Ejercicio 3: Jerarquia de operaciones");

        int i = num1 * num2 + num3;
        int iii = num1 / (num2*num3);

        Console.WriteLine("Resultado i: " + i);
        Console.WriteLine("Resultado iii: " + iii);

        Console.ReadKey();
    }
}