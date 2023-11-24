using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Edades = new int[1000];
            bool[] Vacunado = new bool[1000];
            int Contador = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Encuesta Covid-19");
                Console.WriteLine("================================");
                Console.WriteLine("1: Realizar Encuesta");
                Console.WriteLine("2: Mostrar Datos de la encuesta");
                Console.WriteLine("3: Mostrar Resultados");
                Console.WriteLine("4: Buscar Personas por edad");
                Console.WriteLine("5: Salir");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");
                int opción = int.Parse(Console.ReadLine());

                switch (opción)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Encuesta de vacunación");
                        Console.WriteLine("===================================");
                        Console.Write("¿Qué edad tienes?: ");
                        int edad = int.Parse(Console.ReadLine());
                        Edades[Contador] = edad;

                        Console.WriteLine("Te has vacunado");
                        Console.WriteLine("1: Sí");
                        Console.WriteLine("2: No");
                        Console.WriteLine("===================================");
                        Console.Write("Ingrese una opción: ");
                        int OpcionVacuna = int.Parse(Console.ReadLine());
                        Vacunado[Contador] = OpcionVacuna == 1;

                        Contador++;

                        Console.Clear();
                        Console.WriteLine("================================");
                        Console.WriteLine("Encuesta de vacunación");
                        Console.WriteLine("================================");
                        Console.WriteLine();
                        Console.WriteLine("¡Gracias por participar!");
                        Console.WriteLine();
                        Console.WriteLine("================================");
                        Console.WriteLine("Presione una tecla ...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("=================================");
                        Console.WriteLine("Datos de la encuesta");
                        Console.WriteLine("=================================");
                        Console.WriteLine();
                        Console.WriteLine("ID    | Edad | Vacunado");
                        Console.WriteLine("=======================");
                        for (int i = 0; i < Contador; i++)
                        {
                            Console.WriteLine($"{i.ToString("D4")}  |  {Edades[i].ToString("D2")}  |   {(Vacunado[i] ? "Si" : "No")}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("=================================");
                        Console.WriteLine("Resultados de la encuesta");
                        Console.WriteLine("=================================");
                        Console.WriteLine();
                        int vacunados = 0;
                        int noVacunados = 0;
                        int[] CategoriasEdad = new int[6];

                        for (int i = 0; i < Contador; i++)
                        {
                            if (Vacunado[i])
                                vacunados++;
                            else
                                noVacunados++;

                            if (Edades[i] >= 1 && Edades[i] <= 20)
                                CategoriasEdad[0]++;
                            else if (Edades[i] >= 21 && Edades[i] <= 30)
                                CategoriasEdad[1]++;
                            else if (Edades[i] >= 31 && Edades[i] <= 40)
                                CategoriasEdad[2]++;
                            else if (Edades[i] >= 41 && Edades[i] <= 50)
                                CategoriasEdad[3]++;
                            else if (Edades[i] >= 51 && Edades[i] <= 60)
                                CategoriasEdad[4]++;
                            else if (Edades[i] > 60)
                                CategoriasEdad[5]++;
                        }

                        Console.WriteLine($"{vacunados} personas se han vacunado");
                        Console.WriteLine($"{noVacunados} personas no se han vacunado");
                        Console.WriteLine();
                        Console.WriteLine("Existen:");
                        Console.WriteLine($"{CategoriasEdad[0]} Personas entre 01 y 20 años");
                        Console.WriteLine($"{CategoriasEdad[1]} Personas entre 21 y 30 años");
                        Console.WriteLine($"{CategoriasEdad[2]} Personas entre 31 y 40 años");
                        Console.WriteLine($"{CategoriasEdad[3]} Personas entre 41 y 50 años");
                        Console.WriteLine($"{CategoriasEdad[4]} Personas entre 51 y 60 años");
                        Console.WriteLine($"{CategoriasEdad[5]} Personas de más de 61 años");
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("=================================");
                        Console.WriteLine("Buscar a personas por edad");
                        Console.WriteLine("=================================");
                        Console.Write("¿Qué edad quieres buscar?: ");
                        int edadBusqueda = int.Parse(Console.ReadLine());

                        int vacunadosBusqueda = 0;
                        int noVacunadosBusqueda = 0;

                        for (int i = 0; i < Contador; i++)
                        {
                            if (Edades[i] == edadBusqueda)
                            {
                                if (Vacunado[i])
                                    vacunadosBusqueda++;
                                else
                                    noVacunadosBusqueda++;
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine($"{vacunadosBusqueda} se vacunaron");
                        Console.WriteLine($"{noVacunadosBusqueda} no se vacunaron");
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para continuar ...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
