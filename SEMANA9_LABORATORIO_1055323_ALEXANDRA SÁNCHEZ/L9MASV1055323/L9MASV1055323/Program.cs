using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laboratorio semana 9");

        Console.WriteLine("Ejercicio No. 01");
        Console.WriteLine("Ingresar un número");
        int numero = Convert.ToInt32(Console.ReadLine());
        int contador = 1;
        int sumatoria = 0;

        while (contador <= numero)
        {
            sumatoria = sumatoria + contador;
            contador++;
        }

        Console.WriteLine("La sumatoria es: " + sumatoria);

        Console.WriteLine("Ejercicio No. 02");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("\nTabla del " + i + ":\t");
            for (int n = 1; n <= numero; n++)
            {
                Console.Write(i * n + "\t");
            }
        }

        Console.ReadKey();

    }
}

