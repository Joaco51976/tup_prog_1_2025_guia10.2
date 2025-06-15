using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[1000];
            int cantidad = 0;
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Ingresar un número");
                Console.WriteLine("2 - Ingresar varios números");
                Console.WriteLine("3 - Mostrar Numero Máximo y Mínimo");
                Console.WriteLine("4 - Mostrar Promedio");
                Console.WriteLine("5 - Mostrar Cantidad de Números");
                Console.WriteLine("6 - Ordenar y Mostrar");
                Console.WriteLine("7 - Mostrar mayores al promedio");
                Console.WriteLine("8 - Salir");
                Console.Write("Opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingresá un número válido.");
                    Console.ReadKey();
                    continue;
                }
                switch (opcion)
                {
                    case 1:
                        if (cantidad < numeros.Length)
                        {
                            Console.Write("Ingresá un número: ");
                            if (int.TryParse(Console.ReadLine(), out int num))
                            {
                                numeros[cantidad] = num;
                                cantidad++;
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ya se ingresó el máximo de números.");
                        }
                        break;

                    case 2:
                        Console.Write("¿Cuántos números querés ingresar?: ");
                        if (int.TryParse(Console.ReadLine(), out int cant))
                        {
                            for (int i = 0; i < cant && cantidad < numeros.Length; i++)
                            {
                                Console.Write($"Número {i + 1}: ");
                                if (int.TryParse(Console.ReadLine(), out int n))
                                {
                                    numeros[cantidad] = n;
                                    cantidad++;
                                }
                                else
                                {
                                    Console.WriteLine("Entrada no válida, se salta.");
                                }
                            }
                        }
                        break;

                    case 3:
                        if (cantidad > 0)
                        {
                            int max = numeros.Take(cantidad).Max();
                            int min = numeros.Take(cantidad).Min();
                            Console.WriteLine($"Máximo: {max}");
                            Console.WriteLine($"Mínimo: {min}");
                        }
                        else
                        {
                            Console.WriteLine("No hay datos.");
                        }
                        break;

                    case 4:
                        if (cantidad > 0)
                        {
                            double promedio = numeros.Take(cantidad).Average();
                            Console.WriteLine($"Promedio: {promedio:F2}");
                        }
                        else
                        {
                            Console.WriteLine("No hay datos.");
                        }
                        break;

                    case 5:
                        Console.WriteLine($"Total de números ingresados: {cantidad}");
                        break;

                    case 6:
                        if (cantidad > 0)
                        {
                            var ordenados = numeros.Take(cantidad).OrderBy(x => x);
                            Console.WriteLine("Números ordenados:");
                            foreach (var item in ordenados)
                                Console.Write($"{item} ");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("No hay datos.");
                        }
                        break;

                    case 7:
                        if (cantidad > 0)
                        {
                            double prom = numeros.Take(cantidad).Average();
                            Console.WriteLine($"Promedio: {prom:F2}");
                            Console.WriteLine("Números que superan el promedio:");
                            foreach (var x in numeros.Take(cantidad))
                            {
                                if (x > prom)
                                    Console.Write($"{x} ");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("No hay datos.");
                        }
                        break;

                    case 8:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("\nPresioná una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 0);
        }
    }
}
