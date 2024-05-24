using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Control_Ventas_Partidos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables
            int numFactura=0;
            int numCedula = 0;
            string nombreEmpleado = "";
            int localidad = 0;
            double precioEntrada = 0;
            int cantidadEntrada = 0;
            double subtotal = 0;
            double cargoServicio = 0;
            double totalEntrada = 0;



            //contadores

            int Cantidad_localidad_Sol_Norte_Suros = 0;
            double Acumulador_Dinero_Sol_Norte_Suros = 0;
         
            int Cantidad_localidad_Sombra_Este_Oeste = 0;
            double Acumulador_Dinero_Sombra_Este_Oeste = 0;
     
            int Cantidad_localidad_preferencial = 0;
            double Acumulador_Dinero_preferencial = 0;
          



            bool salida = true;
            while (salida)
            {

                Console.WriteLine("╔═══════════════════════════════════════╗");
                Console.WriteLine("║          Entradas Partidos            ║");
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
                        //se solicita los datos al usuario
                        Console.Clear();


                        //numero de factura
                        Console.WriteLine("Digite el numero de factura: ");
                        numFactura = int.Parse(Console.ReadLine());
                        Console.Clear();



                        //numero de cedula
                        Console.WriteLine("Digite el numero de cédula: ");
                        numCedula = int.Parse(Console.ReadLine());
                        Console.Clear();

                        //nombre
                        Console.WriteLine("Digite el nombre: ");
                        nombreEmpleado = Console.ReadLine();
                        Console.Clear();

                        //tipo de empleado

                        Console.WriteLine("Digite la localidad (1- Sol Norte/Sur   2- Sombra Este/Oeste   3-Preferencial): ");
                        localidad = int.Parse(Console.ReadLine());

                        try
                        {
                            if (localidad == 1)
                            {
                                //cantidad entrada
                                Console.WriteLine("Digite la cantidad de entradas: ");
                                cantidadEntrada = int.Parse(Console.ReadLine());

                                precioEntrada = 10500;
                                subtotal = cantidadEntrada * precioEntrada;
                                cargoServicio = cantidadEntrada * 1000;
                                totalEntrada = subtotal + cargoServicio;


                                Console.Clear();
                            }
                            else
                            {
                                if (localidad == 2)
                                {
                                    //cantidad entrada
                                    Console.WriteLine("Digite la cantidad de entradas: ");
                                    cantidadEntrada = int.Parse(Console.ReadLine());

                                    precioEntrada = 20500;
                                    subtotal = cantidadEntrada * precioEntrada;
                                    cargoServicio = cantidadEntrada * 1000;
                                    totalEntrada = subtotal + cargoServicio;


                                    Console.Clear();
                                }
                                else
                                {
                                    if (localidad == 3)
                                    {
                                        //cantidad entrada
                                        Console.WriteLine("Digite la cantidad de entradas: ");
                                        cantidadEntrada = int.Parse(Console.ReadLine());

                                        precioEntrada = 25500;
                                        subtotal = cantidadEntrada * precioEntrada;
                                        cargoServicio = cantidadEntrada * 1000;
                                        totalEntrada = subtotal + cargoServicio;


                                        Console.Clear();
                                    }
                                    else
                                    {
                                        throw new Exception("Opción no válida");
                                    }
                                }

                            }

                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Opcion invalida , digite una opcion correcta");
                            Thread.Sleep(3000); // 3000 milisegundos = 3 segundos
                            Console.Clear();

                            Console.WriteLine("Digite la localidad (1- Sol Norte/Sur   2- Sombra Este/Oeste   3-Preferencial): ");
                            localidad = int.Parse(Console.ReadLine());

                        } // salida tipo de empleado



                        //acumuladores 
                        if (localidad == 1)
                        {
                            Cantidad_localidad_Sol_Norte_Suros = Cantidad_localidad_Sol_Norte_Suros + 1;
                            Acumulador_Dinero_Sol_Norte_Suros = Acumulador_Dinero_Sol_Norte_Suros + subtotal;
                           
                        }
                        else
                        {
                            if (localidad == 2)
                            {
                                Cantidad_localidad_Sombra_Este_Oeste = Cantidad_localidad_Sombra_Este_Oeste + 1;
                                Acumulador_Dinero_Sombra_Este_Oeste = Acumulador_Dinero_Sombra_Este_Oeste + subtotal;
                            }
                            else
                            {
                                if (localidad == 3)
                                {
                                    Cantidad_localidad_preferencial = Cantidad_localidad_preferencial + 1;
                                    Acumulador_Dinero_preferencial = Acumulador_Dinero_preferencial + subtotal;
                                }
                            }
                        }
                        Console.Clear();
                        // Mostrar el registro realizado
                        Console.WriteLine("===========================================");
                        Console.WriteLine("       Detalle de registro realizado       ");
                        Console.WriteLine("===========================================");
                        Console.WriteLine("");

                        //Detalle del registro
                        Console.WriteLine("Numero de factura: " + numFactura);
                        Console.WriteLine("Cedula: " + numCedula);
                        Console.WriteLine("Nombre comprador: " + nombreEmpleado);
                        Console.WriteLine("Localidad: " + localidad);
                        Console.WriteLine("cantidad entrada: " + cantidadEntrada);
                        Console.WriteLine("Subtotal: " + subtotal);
                        Console.WriteLine("Cargos de Servicios: " + cargoServicio);
                        Console.WriteLine("Total a pagar: " + totalEntrada);

                        Console.WriteLine(" ");

                        // Mensaje para que el usuario presione una tecla para continuar
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey(); // Espera a que el usuario presione una tecla
                        Console.Clear();


                    }

                    else
                    {
                        if (opcion == 2)
                        {
                            Console.Clear();
                            // Mostrar el resumen de registros realizados
                            Console.WriteLine("===========================================");
                            Console.WriteLine("       Resumen de registros realizados      ");
                            Console.WriteLine("===========================================");
                            Console.WriteLine("");

                            // Mostrar la información con formato
                            Console.WriteLine($"Cantidad Entradas Localidad Sol Norte/Sur:   {Cantidad_localidad_Sol_Norte_Suros,5}");
                            Console.WriteLine($"Acumulado Dinero Localidad Sol Norte/Sur:   {Acumulador_Dinero_Sol_Norte_Suros,10:C}");
                            Console.WriteLine();
                            Console.WriteLine($"Cantidad Entradas Localidad Sombra Este/Oeste: {Cantidad_localidad_Sombra_Este_Oeste,5}");
                            Console.WriteLine($"Acumulado Dinero Localidad Sombra Este/Oeste: {Acumulador_Dinero_Sombra_Este_Oeste,10:C}");
                            Console.WriteLine();
                            Console.WriteLine($"Cantidad Entradas Localidad Preferencial:   {Cantidad_localidad_preferencial,5}");
                            Console.WriteLine($"Acumulado Dinero Localidad Preferencial:   {Acumulador_Dinero_preferencial,10:C}");
                            Console.WriteLine();

                            // Mensaje para que el usuario presione una tecla para continuar
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey(); // Espera a que el usuario presione una tecla

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

            // Console.WriteLine("Salio del ciclo");
            //Thread.Sleep(3000); // 3000 milisegundos = 3 segundos
        }
    }
}
