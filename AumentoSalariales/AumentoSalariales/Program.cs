using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AumentoSalariales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // programa para calcular aumentos salariales

            bool salida= true;
            while (salida)
            {

                Console.WriteLine("╔═══════════════════════════════════════╗");
                Console.WriteLine("║          Proyecto Programación 1      ║");
                Console.WriteLine("╠═══════════════════════════════════════╣");
                Console.WriteLine("║ [1] Insertar un Registro              ║");
                Console.WriteLine("║ [2] Salir del Sistema                 ║");
                Console.WriteLine("╚═══════════════════════════════════════╝");
                Console.WriteLine();
                
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Seleccione una Opcion: ");
                    int opcion = int.Parse(Console.ReadLine());
                    if (opcion == 1)
                    {
                        
                    }
                    else
                    {
                        if (opcion == 2)
                        {
                            Console.WriteLine("haz terminado de realizar los aumentos, saludos");
                            Thread.Sleep(3000); // 2000 milisegundos = 3 segundos
                            //salida = false;
                            break;
                        }
                        else
                        {
                            throw new Exception("Opción no válida"); 
                        }
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("La opcion no esta en el menu, digite una opcion correcta");
                    Thread.Sleep(3000); // 3000 milisegundos = 3 segundos
                    Console.Clear();
                }


            }
            
            Console.WriteLine("Salio del ciclo");
            Thread.Sleep(3000); // 3000 milisegundos = 3 segundos

        }
    }
}
