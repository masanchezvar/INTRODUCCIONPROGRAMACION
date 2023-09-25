using System;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Laboratorio semana 8");
        Console.WriteLine("\nIngresar un número");

        int n = Convert.ToInt32(Console.ReadLine());

        string resultado = "";
        int a = 0;
        int b = 1;
        int c = 0;
        int i = 2;


        if (n > 0)
        {
            resultado = a.ToString();
            Console.WriteLine("Resultado = " + a);
            if (n > 1)
            {
                resultado += b.ToString();

                while (i < n)
                {
                    c = a + b;
                    resultado += c.ToString();
                    a = b;
                    b = c;
                    i++;

                }
                Console.WriteLine("Resultado: " + resultado);
            }
            else
            {
                Console.WriteLine("Resultado: " + resultado);
            }
        }
        else
        {
            Console.WriteLine("Resultado: " + resultado);
        }

        Console.ReadKey();
    }
}
