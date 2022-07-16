using System;

namespace T05Ejercicio10
{
    class Program
    {
        static void Main()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] tabla = new int[11];

            Console.WriteLine("Escriba el numero del que desea ver la tabla de multiplicar (de 1 a 10): ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMostrando contenido de la tabla: ");
            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = numero * array[i];
                Console.WriteLine(numero + " por " + i + " = " + tabla[i]);
            }
        }
    }
}