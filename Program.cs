using System;

class Program
{
    static void Main(string[] args)
    {
        int bucle = 0;

        while(bucle != 5)
        {
            Console.WriteLine("¿Cuál de estos subprogramas desea correr (1-4)?");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1. Mostrar números descendentes del 1 al 100 de dos en dos.");
            Console.WriteLine("2. Mostrar la tabla de multiplicar de un número deseado.");
            Console.WriteLine("3. Calcular sumatoria y promedio de una cantidad de montos.");
            Console.WriteLine("4. Que pida un nombre y se repita mientras no sea \"jose\" o la cantidad de nombre ingresado sea menor 7.");
            Console.WriteLine("5. Salir.");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion >= 5)
            {             
                break;
            }

            Console.WriteLine("¿Y qué tipo de bucle desea utilizar para dicho subprograma? (1-For, 2-While, 3-Do/while)");
            int tipoBucle = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("1. Mostrar números descendentes del 1 al 100 de dos en dos.");
                    Console.WriteLine("-----------------------------------------------------------");
                    switch (tipoBucle)
                    {
                        case 1:
                            for (int i = 100; i >= 1; i -= 2)
                            {
                                Console.WriteLine(i);
                            }
                            break;
                        case 2:
                            int j = 100;
                            while (j >= 1)
                            {
                                Console.WriteLine(j);
                                j -= 2;
                            }
                            break;
                        case 3:
                            int k = 100;
                            do
                            {
                                Console.WriteLine(k);
                                k -= 2;
                            } while (k >= 1);
                            break;
                        default:
                            Console.WriteLine("Esa opción no es válida");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("2. Mostrar la tabla de multiplicar de un número deseado.");
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Ingrese el número para el cual desee ver su tabla de mutiplicar del 1 al 12.");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Tabla de multiplicar del {num} del 1 al 12:");
                    switch (tipoBucle)
                    {
                        case 1:
                            for (int i = 1; i <= 12; i++)
                            {
                                Console.WriteLine($"{num} x {i} = {num * i}");
                            }
                            Console.ReadLine();
                            break;
                        case 2:
                            int j = 1;
                            while (j <= 12)
                            {
                                Console.WriteLine($"{num} x {j} = {num * j}");
                                j++;
                            }
                            break;
                        case 3:
                            int k = 1;
                            do
                            {
                                Console.WriteLine($"{num} x {k} = {num * k}");
                                k++;
                            } while (k <= 12);
                            break;
                        default:
                            Console.WriteLine("Esa opción no es válida");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("3. Calcular sumatoria y promedio de una cantidad de montos.");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("¿Cuántos montos hay?");
                    int cantidadMontos = int.Parse(Console.ReadLine());
                    int sumatoria = 0;
                    switch (tipoBucle)
                    {
                        case 1:
                            for (int i = 1; i <= cantidadMontos; i++)
                            {
                                Console.WriteLine($"Ingrese el monto {i}");
                                int monto = int.Parse(Console.ReadLine());
                                sumatoria += monto;
                            }
                            Console.WriteLine($"La sumatoria de los montos es: {sumatoria}");
                            Console.WriteLine($"El promedio de los montos es: {(double)sumatoria / cantidadMontos}");
                            break;
                        case 2:
                            int j = 1;
                            while (j <= cantidadMontos)
                            {
                                Console.WriteLine($"Ingrese el monto {j}");
                                int monto = int.Parse(Console.ReadLine());
                                sumatoria += monto;
                                j++;
                            }
                            Console.WriteLine($"La sumatoria de los montos es: {sumatoria}");
                            Console.WriteLine($"El promedio de los montos es: {(double)sumatoria / cantidadMontos}");
                            break;
                        case 3:
                            int k = 1;
                            do
                            {
                                Console.WriteLine($"Ingrese el monto {k}");
                                int monto = int.Parse(Console.ReadLine());
                                sumatoria += monto;
                                k++;
                            } while (k <= cantidadMontos);
                            break;
                        default:
                            Console.WriteLine("Esa opción no es válida");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("4. Que pida un nombre y se repita mientras no sea \"jose\" o la cantidad de nombre ingresado sea menor de 7.");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                    string nombre = "";
                    int numnombres = 0;
                    switch (tipoBucle)
                    {
                        case 1:
                            for (; ; )
                            {
                                Console.WriteLine("Ingrese un nombre:");
                                nombre = Console.ReadLine().ToLower();
                                if (nombre == "jose" || numnombres == 6)
                                {
                                    break;
                                }
                                numnombres++;
                            }
                            break;
                        case 2:
                            while (true)
                            {
                                Console.WriteLine("Ingrese un nombre: ");
                                nombre = Console.ReadLine().ToLower();
                                if (nombre == "jose" || numnombres == 6)
                                {
                                    break;
                                }
                                numnombres++;
                            }
                            break;
                        case 3:
                            do
                            {
                                Console.WriteLine("Ingrese un nombre: ");
                                nombre = Console.ReadLine().ToLower();
                                if (nombre == "jose" || numnombres == 6)
                                {
                                    break;
                                }
                                numnombres++;
                            } while (true);

                            break;
                        default:
                            Console.WriteLine("Esa opción no es válida");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Esa opción no es válida");
                    break;
            }
            Console.WriteLine("\nPresione cualquier tecla para volver al menú principal...");
            Console.ReadKey();
            Console.Clear();
            Main(args);
        }        
    }
}