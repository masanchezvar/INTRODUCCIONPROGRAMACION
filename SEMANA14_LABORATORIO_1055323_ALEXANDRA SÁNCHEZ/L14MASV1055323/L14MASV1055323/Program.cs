using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Threading;

class program
{
    static void Main(string[] args)
    {

        int numero = 0;

        while (true)
        {
            Console.WriteLine("Ingrese un número entero:");
            Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los números ingresados fueron: " + numero );
        }






        Console.ReadKey();
    }
}
