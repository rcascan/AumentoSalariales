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

            //variables
            int numCedula = 0;
            string nombreEmpleado = "";
            int tipoEmpleado = 0;
            double cantidadHorasLaboradas = 0;
            double precioXhora=0;
            double aumento=0;
            double salarioOrdinario = 0;
            double salarioBruto = 0;
            double deduccionesCCSS = 0.0917;
            double deducciones = 0;
            double SalarioNeto = 0;

            //contadores

            int Cantidad_EmpleadosTipo_Operarios = 0;
            double Acumulado_SalarioNeto_Operarios = 0;
            double PromedioSalarioNeto_Operarios = 0;
            int CantidadEmpleadosTipo_Tecnicos = 0;
            double AcumuladoSalarioNeto_Tecnicos = 0;
            double PromedioSalarioNeto_Tecnicos = 0;
            int CantidadEmpleadosTipo_Profesional = 0;
            double AcumuladoSalarioNeto_Profesional=0;
            double PromedioSalarioNeto_Profesional = 0;



            bool salida = true;
            while (salida)
            {

                Console.WriteLine("╔═══════════════════════════════════════╗");
                Console.WriteLine("║          Aumento Salariales           ║");
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

                        //numero de cedula
                        Console.WriteLine("Digite el numero de cédula: ");
                        numCedula = int.Parse(Console.ReadLine());
                        Console.Clear();

                        //nombre
                        Console.WriteLine("Digite el nombre: ");
                        nombreEmpleado = Console.ReadLine();
                        Console.Clear();

                        //tipo de empleado

                        Console.WriteLine("Digite el tipo de empleado (1-Operario 2-Tecnico  3-Profesional): ");
                        tipoEmpleado = int.Parse(Console.ReadLine());

                        try
                        {
                            if (tipoEmpleado==1)
                            {
                                aumento = 0.15;
                                Console.Clear();
                            }   
                            else
                            {
                                if (tipoEmpleado == 2) 
                                {
                                    aumento = 0.10;
                                    Console.Clear();
                                }
                                else
                                {
                                    if (tipoEmpleado == 3)
                                    {
                                        aumento = 0.05;
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
                            
                            Console.WriteLine("Digite el tipo de empleado (1-Operario 2-Tecnico  3-Profesional): ");
                            tipoEmpleado = int.Parse(Console.ReadLine());

                        } // salida tipo de empleado


                        //Precio x hora
                        Console.WriteLine("Digite el precio por hora : ");
                        precioXhora = double.Parse(Console.ReadLine());
                        Console.Clear();

                        //cantidad horas
                        Console.WriteLine("Digite la cantidad de horas laboradas : ");
                        cantidadHorasLaboradas = double.Parse(Console.ReadLine());
                        Console.Clear();

                        //salario Ordinario
                        salarioOrdinario= cantidadHorasLaboradas * precioXhora;

                        //Salario Bruto
                        salarioBruto = (salarioOrdinario + (salarioOrdinario * aumento));

                        //deducciones por ley
                        deducciones = (salarioBruto*deduccionesCCSS);

                        //salario neto
                        SalarioNeto = salarioBruto - deducciones;

                        //acumuladores 
                        if (tipoEmpleado==1)
                        {
                            Cantidad_EmpleadosTipo_Operarios = Cantidad_EmpleadosTipo_Operarios+1;
                            Acumulado_SalarioNeto_Operarios = Acumulado_SalarioNeto_Operarios+SalarioNeto;
                            PromedioSalarioNeto_Operarios = Acumulado_SalarioNeto_Operarios/ Cantidad_EmpleadosTipo_Operarios;
                        }
                        else
                        {
                            if (tipoEmpleado == 2)
                            {   CantidadEmpleadosTipo_Tecnicos = CantidadEmpleadosTipo_Tecnicos + 1;
                                AcumuladoSalarioNeto_Tecnicos = AcumuladoSalarioNeto_Tecnicos + SalarioNeto;
                                PromedioSalarioNeto_Tecnicos = AcumuladoSalarioNeto_Tecnicos / CantidadEmpleadosTipo_Tecnicos;
                            }
                            else
                            {
                                if (tipoEmpleado == 3)
                                {
                                    CantidadEmpleadosTipo_Profesional = CantidadEmpleadosTipo_Profesional + 1;
                                    AcumuladoSalarioNeto_Profesional = AcumuladoSalarioNeto_Profesional + SalarioNeto;
                                    PromedioSalarioNeto_Profesional = AcumuladoSalarioNeto_Profesional / CantidadEmpleadosTipo_Profesional;
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
                        Console.WriteLine("Cedula: " + numCedula);
                        Console.WriteLine("Nombre de empleado: " + nombreEmpleado);
                        Console.WriteLine("Salario por hora: " + precioXhora);
                        Console.WriteLine("Cantidad de horas: " + cantidadHorasLaboradas);
                        Console.WriteLine("Salario Ordinario: " + salarioOrdinario);
                        Console.WriteLine("aumento: " + (aumento*100)+"%");
                        Console.WriteLine("Salario Bruto: " + salarioBruto);
                        Console.WriteLine("Deducciones CCSS: " + deducciones);
                        Console.WriteLine("Salario Neto: " + SalarioNeto);
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
                            Console.WriteLine("Cantidad Empleados Tipo Operarios:           " + Cantidad_EmpleadosTipo_Operarios);
                            Console.WriteLine("Acumulado Salario Neto para Operarios:       " + Acumulado_SalarioNeto_Operarios);
                            Console.WriteLine("Promedio Salario Neto para Operarios:        " + PromedioSalarioNeto_Operarios);
                            Console.WriteLine("");
                            Console.WriteLine("Cantidad Empleados Tipo Técnico:             " + CantidadEmpleadosTipo_Tecnicos);
                            Console.WriteLine("Acumulado Salario Neto para Técnicos:        " + AcumuladoSalarioNeto_Tecnicos);
                            Console.WriteLine("Promedio Salario Neto para Técnicos:         " + PromedioSalarioNeto_Tecnicos);
                            Console.WriteLine("");
                            Console.WriteLine("Cantidad Empleados Tipo Profesional:         " + CantidadEmpleadosTipo_Profesional);
                            Console.WriteLine("Acumulado Salario Neto para Profesional:     " + AcumuladoSalarioNeto_Profesional);
                            Console.WriteLine("Promedio Salario Neto para Profesionales:    " + PromedioSalarioNeto_Profesional);
                            Console.WriteLine("");

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
