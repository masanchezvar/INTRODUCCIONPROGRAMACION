using System;

class program
{
   static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio No. 2");
        Console.WriteLine("Por favor ingrese el número día");
        string entrada = Console.ReadLine();
        int Día = Int32.Parse(entrada);    

        if(Día >= 1 && Día <=7)
        {
            if (Día == 1)
            {
                Console.WriteLine("Día: Lunes");
            }
            if (Día == 2)
            {
                Console.WriteLine("Día: Martes");
            }
            if (Día == 3)
            {
                Console.WriteLine("Día: Miercoles");
            }
            if (Día == 4)
            {
                Console.WriteLine("Día: Jueves");
            }
            if (Día == 5)
            {
                Console.WriteLine("Día: Viernes");
            }
            if (Día == 6)
            {
                Console.WriteLine("Día: Sabado");
            }
            if (Día == 7)
            {
                Console.WriteLine("Día: Domingo");
            }
        }
        else
        {
            Console.WriteLine("Error, por favor ingresar un número entre 1 a 7");
        }
        
        Console.ReadKey();
    }
}
