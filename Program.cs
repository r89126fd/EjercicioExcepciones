using System;

namespace EjercicioExcepciones
{
    class Operaciones
    {
        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Error: No se puede dividir entre cero.");
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Seleccione una operación:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");

                try
                {
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 5)
                    {
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        continue;
                    }

                    Console.WriteLine("Ingrese el primer número:");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo número:");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = operaciones.Sumar(num1, num2);
                            Console.WriteLine($"Resultado de la suma: {resultado}");
                            break;
                        case 2:
                            resultado = operaciones.Restar(num1, num2);
                            Console.WriteLine($"Resultado de la resta: {resultado}");
                            break;
                        case 3:
                            resultado = operaciones.Multiplicar(num1, num2);
                            Console.WriteLine($"Resultado de la multiplicación: {resultado}");
                            break;
                        case 4:
                            resultado = operaciones.Dividir(num1, num2);
                            Console.WriteLine($"Resultado de la división: {resultado}");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Entrada no válida. Por favor, ingrese un número.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }

                Console.WriteLine();
            }
        }
    }
}
