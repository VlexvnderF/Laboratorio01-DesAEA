using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicación de dos números");
                Console.WriteLine("[4] División de dos números");
                Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Comversión de temperatura CELSIUS A FAHRENHEIT");
                Console.WriteLine("[8] Comversión de temperatura FAHRENHEIT A CELSIUS");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", a1,b1, Resta(a1,b1));
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", a2, b2, Multiplicacion(a2, b2));
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int a3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", a3, b3, Division(a3, b3));
                        Console.ReadKey();
                        break;



                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Los primeros 10 números primos son: ");
                        Primos();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("Ingrese la temperatura en Celsius: ");
                        double c5 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Conversión de temperatura de {0} Celsius a Fahrenheit es : {1} F", c5, CeltoFah(c5));
                        
                        Console.ReadKey();
                        break;

                    case "8":
                        Console.WriteLine("Ingrese la temperatura en Fahrenheit: ");
                        double f5 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Conversión de temperatura de {0} Fahrenheit a Celsius es: {1} C", f5, FahToCel(f5));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));


        }
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Procedimiento de resta

        static int Resta(int a1, int b1) 
        {
            return a1 - b1;
        }


        static double Multiplicacion(double a2, double b2) 
        {
            return a2 * b2;
        }

        static double Division(double a3, double b3)
        {
            return (a3 / b3);
        }

        

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }


        static void Primos()
        {
            int count = 0;
            int num = 2;

            while (count < 10)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(num + " ");
                    count++;
                }
                num++;
            }

        }


        static double CeltoFah(double c5)
        {
            return ((c5 * 9) / 5) + 32;
        }

        static double FahToCel(double f5) 
        {
            return (5 * (f5 - 32) )/ 9;
        }

    }
}
