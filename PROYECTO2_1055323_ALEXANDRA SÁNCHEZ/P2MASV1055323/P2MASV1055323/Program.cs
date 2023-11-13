using System;
using System.Runtime.Remoting.Messaging;

class Programa
{
    // María Alexandra Sánchez Vargas - No. Carné 1055323
    static void Main(string[] args)
    {
        Random aleatorio = new Random();
        Console.WriteLine("PROYECTO No. 02");
        Console.WriteLine("BIENVENIDO A UN JUEGO DE DADOS ");
        Console.WriteLine();
        Console.Write("Ingrese el numero de partidas: ");
        int partidas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el numero de lanzamientos por partida: ");
        int lanzamientos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        for (int j = 1; j <= partidas; j++)
        {
            int numeroLanzamiento = 1;
            int puntosJugador = 0;
            int puntosCasa = 0;
            int[] lanzamientoDados = new int[0];
            int lanzamientosDiferentes = 0;
            int lanzamientosIguales = 0;
            int victoriasJugador = 0;

            for (int i = 1; i <= lanzamientos; i++)
            {
                int dado1 = aleatorio.Next(1, 7);
                int dado2 = aleatorio.Next(1, 7);
                int sumaDados = dado1 + dado2;

                if (dado1 == dado2)
                {
                    lanzamientosIguales++;
                }
                else
                {
                    lanzamientosDiferentes++;
                }

                if (sumaDados == 11)
                {
                    if (puntosJugador == 0)
                    {
                        puntosCasa = puntosCasa + 6;
                    }
                    else
                    {
                        puntosJugador = puntosJugador + sumaDados;
                        victoriasJugador = victoriasJugador + 1;
                    }
                }
                else if (numeroLanzamiento == 1 && (sumaDados == 12 || sumaDados == 6))
                {
                    puntosJugador = puntosJugador + 12;
                    victoriasJugador = victoriasJugador + 1;
                }
                else if (numeroLanzamiento == 1 && (sumaDados == 4 || sumaDados == 6 || sumaDados == 10))
                {
                    puntosCasa = puntosCasa + 12;
                } 
                else if (sumaDados == 2 || sumaDados == 3 || sumaDados == 5 || sumaDados == 7 || sumaDados == 8 || sumaDados == 9)
                {
                    puntosJugador = puntosJugador + sumaDados;
                    victoriasJugador = victoriasJugador + 1;
                }
                else
                {
                    puntosCasa = puntosCasa + sumaDados;
                }

                numeroLanzamiento++;
                Array.Resize(ref lanzamientoDados, lanzamientoDados.Length + 2);
                lanzamientoDados[lanzamientoDados.Length - 2] = dado1;
                lanzamientoDados[lanzamientoDados.Length - 1] = dado2;
            }

            double porcentajeVictoria = Math.Round(((double)victoriasJugador / lanzamientos) * 100);
            string mensajeFinal;

            if (puntosJugador == puntosCasa)
            {
                mensajeFinal = " Empate";
            }
            else if (puntosJugador > puntosCasa)
            {
                mensajeFinal = " El ganador es el jugador";
            }
            else
            {
                mensajeFinal = " El ganador es la casa";
            }
              

            Console.WriteLine();
            Console.WriteLine("- PARTIDA No. 0" + j +" -");
            Console.WriteLine();
            Console.WriteLine("Ganador: " + mensajeFinal);
            Console.WriteLine("Lanzamiento de dados: ");
            foreach (int d in lanzamientoDados)
            {
                Console.Write(d + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Porcentaje de victoria del jugador: " + porcentajeVictoria + "%");
            Console.WriteLine("El jugador gano puntos en " + victoriasJugador + " lanzamientos");
            Console.WriteLine("El jugador obtuvo numeros diferentes en " + lanzamientosDiferentes + " lanzamientos");
            Console.WriteLine("El jugador obtuvo numeros iguales en " + lanzamientosIguales + " lanzamientos");
            Console.WriteLine("Resultados: PuntosJugador = " + puntosJugador + ", PuntosCasa = " + puntosCasa);

            Console.ReadKey();
        }
    }
    
}

