using System;
using static program;

class program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Semana 12 - Funciones y procedimientos");
        //Alexandra Sánchez - 1055323

        Console.WriteLine("Ingrese el radio de un circulo");
        double radio = Convert.ToDouble(Console.ReadLine());

        Circulo objCirculo = new Circulo(radio);

        double perimetro = 0, area = 0, volumen = 0;

        objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);

        Console.WriteLine("Perímetro del circulo: " + perimetro);
        Console.WriteLine("Área del circulo: " + area);
        Console.WriteLine("Volumen de la esfera: " + volumen);

        Console.ReadKey();
    }

    

    //creación clase calculadora
    public class Circulo
    {
        //Atributos de la clase 
        private double radio { get; set; }

        //constructor

        public Circulo(double r)
        {
            //definiendo datos por defecto
            this.radio = r;
        }

        private double ObtenerPerimetro(double r)
        {
            double perimetro =  2*3.1416*r;
            return perimetro;
        }

        private double ObtenerArea(double r)
        {
            double Area = 3.1416*r*r;
            return Area;
        }

        private double ObtenerVolumen (double r)
        {
            double Volumen = (4 / 3) * r * r * r * 3.1413;
            return Volumen;
        }

        public void CalcularGeometria(ref double perimetro, ref double area, ref double volumen)
        {
            perimetro = ObtenerPerimetro(radio);
            area = ObtenerArea(radio);
            volumen = ObtenerVolumen(radio);
        }


    }
}