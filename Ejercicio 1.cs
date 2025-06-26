using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[1000];
            int cantNumeros = 0;
            int cantidadIngresada = 0;

            int opcion;

            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Ingresar un número");
                Console.WriteLine("2. Ingresar varios números");
                Console.WriteLine("3. Mostrar máximo y mínimo");
                Console.WriteLine("4. Mostrar promedio");
                Console.WriteLine("5. Mostrar cantidad ingresada");
                Console.WriteLine("6. Ordenar y mostrar listado");
                Console.WriteLine("7. Mostrar los que superan el promedio");
                Console.WriteLine("0. Salir");
                Console.Write("Elegí una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Escriba el número:");
                        numeros[cantidadIngresada] = Convert.ToInt32(Console.ReadLine());
                        cantidadIngresada++;
                        break;

                    case 2:
                        Console.WriteLine("¿Cuántos números desea ingresar?");
                        int numerosIngresa = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < numerosIngresa; i++)
                        {
                            Console.WriteLine("Ingrese un número:");
                            numeros[cantidadIngresada] = Convert.ToInt32(Console.ReadLine());
                            cantidadIngresada++;
                        }
                        break;

                    case 3:
                        if (cantidadIngresada == 0)
                        {
                            Console.WriteLine("No se ingresaron números aún.");
                        }
                        else
                        {
                            int max = numeros[0];
                            int min = numeros[0];

                            for (int i = 1; i < cantidadIngresada; i++)
                            {
                                if (numeros[i] > max) max = numeros[i];
                                if (numeros[i] < min) min = numeros[i];
                            }

                            Console.WriteLine("Máximo: " + max);
                            Console.WriteLine("Mínimo: " + min);
                        }
                        break;

                    case 4:
                        if (cantidadIngresada == 0)
                        {
                            Console.WriteLine("No se ingresaron números aún.");
                        }
                        else
                        {
                            int suma = 0;
                            for (int i = 0; i < cantidadIngresada; i++)
                            {
                                suma += numeros[i];
                            }

                            double promedio = (double)suma / cantidadIngresada;
                            Console.WriteLine($"El promedio es: {promedio}");
                        }
                        break;

                    case 5:
                        Console.WriteLine($"Cantidad de números ingresados: {cantidadIngresada}");
                        break;

                    case 6:
                        if (cantidadIngresada == 0)
                        {
                            Console.WriteLine("No se ingresaron números aún.");
                        }
                        else
                        {
                            int[] copia = new int[cantidadIngresada];
                            Array.Copy(numeros, copia, cantidadIngresada);
                            Array.Sort(copia);

                            Console.WriteLine("Listado ordenado:");
                            for (int i = 0; i < copia.Length; i++)
                            {
                                Console.Write(copia[i] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 7:
                        if (cantidadIngresada == 0)
                        {
                            Console.WriteLine("No se ingresaron números aún.");
                        }
                        else
                        {
                            int suma = 0;
                            for (int i = 0; i < cantidadIngresada; i++)
                            {
                                suma += numeros[i];
                            }

                            double promedio = (double)suma / cantidadIngresada;

                            Console.WriteLine($"Promedio: {promedio}");
                            Console.WriteLine("Números que superan el promedio:");

                            for (int i = 0; i < cantidadIngresada; i++)
                            {
                                if (numeros[i] > promedio)
                                {
                                    Console.Write(numeros[i] + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 0);

        }
    }
}