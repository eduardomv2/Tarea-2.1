using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            do
            {
                Console.WriteLine("************************************************************************************************************************");
                Console.WriteLine("\n\t\t\t\t           Fecha " + DateTime.Now);
                Console.WriteLine("\n\t\t\t\t     Bienvenido a la Primer Tarea del 2do Parcial \n\t\t\t\t                          ");
                Console.WriteLine("\n\n\t1. Suma");
                Console.WriteLine("\n\t2. Resta");
                Console.WriteLine("\n\t3. Multiplicación");
                Console.WriteLine("\n\t4. Dividir");
                Console.WriteLine("\n\t5. Salir");
                Console.WriteLine("\n\n************************************************************************************************************************");
                Console.WriteLine("Opcion: ");
                respuesta = Console.ReadLine();

                if (respuesta == "1")
                {         
                    {
                        Suma();
                        Console.ReadKey();
                    }              
                }
                if (respuesta == "2")
                {
                    {
                        Resta();
                        Console.ReadKey();
                    }
                }
                if (respuesta == "3")
                {
                    {
                        Multiplicar();
                        Console.ReadKey();
                    }
                }
                if (respuesta == "4")
                {
                    {
                        Dividir();
                        Console.ReadKey();
                    }
                }
                if (respuesta == "5")
                {
                    {
                        Exit();
                        Console.ReadKey();
                        break;
                    }                  
                }

            } while (respuesta == "1" | respuesta == "2" | respuesta == "3" | respuesta == "4" | respuesta == "5");
        }
        static void Suma()
        {
            int NUM1, NUM2;
            double RESUL;
            string linea;
            Console.Write("NÚMERO 1: "); linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("NÚMERO 2: "); linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            RESUL = (NUM1 + NUM2);
            Console.WriteLine();
            Console.WriteLine("El resultado es : " + RESUL);
            Console.ReadLine();
            Console.Clear();
        }
        static void Resta()
        {
            int numR1, numR2;
            double RESUL;
            string linea;
            Console.Write("NÚMERO 1: "); linea = Console.ReadLine();
            numR1 = int.Parse(linea);
            Console.Write("NÚMERO 2: "); linea = Console.ReadLine();
            numR2 = int.Parse(linea);
            RESUL = (numR1 - numR2);
            Console.WriteLine();
            Console.WriteLine("El resultado es : " + RESUL);
            Console.ReadLine();
            Console.Clear();
        }
        static void Multiplicar()
        {
            int numM1, numM2;
            double RESUL;
            string linea;
            Console.Write("NÚMERO 1: "); linea = Console.ReadLine();
            numM1 = int.Parse(linea);
            Console.Write("NÚMERO 2: "); linea = Console.ReadLine();
            numM2 = int.Parse(linea);
            RESUL = (numM1 * numM2);
            Console.WriteLine();
            Console.WriteLine("El resultado es : " + RESUL);
            Console.ReadLine();
            Console.Clear();
        }
        static void Dividir()
        {
            int numD1, numD2;
            double RESUL;
            string linea;
            Console.Write("NÚMERO 1: "); linea = Console.ReadLine();
            numD1 = int.Parse(linea);
            Console.Write("NÚMERO 2: "); linea = Console.ReadLine();
            numD2 = int.Parse(linea);
            RESUL = (numD1 / numD2);
            Console.WriteLine();
            Console.WriteLine("El resultado es : " + RESUL);
            Console.ReadLine();
            Console.Clear();
        }
        static void Exit()
        {
            Console.WriteLine("Presiona ENTER para salir");             
        }    
    }
}
            
    

