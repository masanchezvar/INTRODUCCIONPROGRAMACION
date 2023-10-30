using System;

//Alexandra Sánchez - 1055323

class Program
{
    public static void Main()
    {
        Console.WriteLine("Propiedades de un triángulo rectángulo");
        double catetoA, anguloOpuestoA;

        Console.WriteLine("Ingrese la longitud del cateto A en metros: ");
        if (double.TryParse(Console.ReadLine(), out catetoA) && catetoA > 0)
        {
            Console.WriteLine("Ingrese el ángulo opuesto al cateto A en grados: ");
            if (double.TryParse(Console.ReadLine(), out anguloOpuestoA) && anguloOpuestoA > 0 && anguloOpuestoA < 90)
            {
                TrianguloRectangulo triangulo = new TrianguloRectangulo(catetoA, anguloOpuestoA);

                Console.WriteLine("Resultados:");
                Console.WriteLine("Valor cateto A: " + triangulo.ObtenerCatetoA() + " metros");
                Console.WriteLine("Valor cateto B: " + triangulo.ObtenerCatetoB() + " metros");
                Console.WriteLine("Valor hipotenusa: " + triangulo.ObtenerHipotenusa() + " metros");
                Console.WriteLine("Valor ángulo opuesto de A: " + triangulo.ObtenerAnguloOpuestoA() + " grados");
                Console.WriteLine("Valor ángulo opuesto de B: " + triangulo.ObtenerAnguloOpuestoB() + " grados");
                Console.WriteLine("Valor área: " + triangulo.ObtenerArea() + " metros cuadrados");
            }
            else
            {
                Console.WriteLine("Ángulo no válido.");
            }
        }
        else
        {
            Console.WriteLine("Longitud del cateto A no válida.");
        }
        Console.ReadKey();
    }
    class TrianguloRectangulo
    {
        private double catetoA;
        private double anguloOpuestoA;

        public TrianguloRectangulo()
        {
            catetoA = 0;
            anguloOpuestoA = 0;
        }

        public TrianguloRectangulo(double catetoA, double anguloOpuestoA)
        {
            this.catetoA = catetoA;
            this.anguloOpuestoA = anguloOpuestoA;
        }

        public double ObtenerCatetoA()
        {
            return catetoA;
        }

        public double ObtenerCatetoB()
        {
            double catetoB = catetoA / Math.Tan(anguloOpuestoA * Math.PI / 180.0);
            return Math.Round(catetoB, 3);
        }

        public double ObtenerHipotenusa()
        {
            double catetoB = ObtenerCatetoB();
            double hipotenusa = Math.Sqrt(catetoA * catetoA + catetoB * catetoB);
            return Math.Round(hipotenusa, 3);
        }

        public double ObtenerAnguloOpuestoA()
        {
            return anguloOpuestoA;
        }

        public double ObtenerAnguloOpuestoB()
        {
            return 90 - anguloOpuestoA;
        }

        public double ObtenerArea()
        {
            double catetoB = ObtenerCatetoB();
            double area = 0.5 * catetoA * catetoB;
            return Math.Round(area, 3);
        }

    }

}

