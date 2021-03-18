using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoCongruencialMixto
{
    class Program
    {
        public static double Resi;

        public static bool Detener = false;

        public static List<double> ArraySemilla = new List<double>();

        public static void operacion(double X, double a, double c, double m)
        {

            Resi = ((a * X) + c) % m;//Residuo

        }

        public static void Recursivo(double X0, double a, double c, double m, int conta)
        {

            foreach (double semilla in ArraySemilla)
            {
                if (X0 == semilla)
                {
                    Detener = true;
                }
            }

            if (Detener == true)
            {
                Console.WriteLine("Los numeros se repiten, se detiene");
            }
            else
            {
                operacion(X0, a, c, m);
                Console.WriteLine("|" + (conta) + "|" + X0 + "|" + Resi + "|" + Resi / m + "|");
                conta++;

                ArraySemilla.Add(X0);
                Recursivo(Resi, a, c, m, conta);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\t--Metodo Congruencial Mixto--\n");
            int contador = 0;
            double X0, a, c, m;

            Console.Write("Inserte el valor de X0 (Semilla): ");
            X0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserte el valor de a (Multiplicador): ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserte el valor de c (Constante aditiva): ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserte el valor de m (Modulo): ");
            m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\t--Resultados--\n");


            Console.WriteLine("|" + "n" + "|" + "Xn" + "|" + "Xn + 1" + "|" + "Rn" + "|");

            Recursivo(X0, a, c, m, contador);

            Console.ReadKey();
        }
    }
}
