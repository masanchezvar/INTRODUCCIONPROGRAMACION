using System;
using System.Security.Cryptography.X509Certificates;

//clase principal
class program
{
    static void Main(string[] args)
    {
        Automovil automovil_1 = new Automovil ();


        Console.WriteLine("Modelo:" + automovil_1.modelo);
        Console.WriteLine("Precio: Q" + automovil_1.precio);
        Console.WriteLine("Marca:" + automovil_1.marca);
        Console.WriteLine("Disponibilidad:" + automovil_1.disponible);
        Console.WriteLine("Tipo de cambio de dólares a quetzales: Q" + automovil_1.tipoCambioDolar);
        Console.WriteLine("Descuento aplicado:" + automovil_1.descuentoAplicado);
        Console.ReadKey();
    }
}

//creación clase Estudiante
public class Automovil
{
    //atributos de la clase
    public int modelo { get; set; }
    public double precio { get; set; }
    public string marca { get; set; }
    public bool disponible { get; set; }
    public double tipoCambioDolar { get; set; }
    public double descuentoAplicado { get; set; }

    //constructor
    public Automovil()
    {
        this.modelo = 2019;
        this.precio = 10000.00;
        this.marca = "";
        this.disponible = false;
        this.tipoCambioDolar = 7.50;
        this.descuentoAplicado = 0.00;
    }
}
