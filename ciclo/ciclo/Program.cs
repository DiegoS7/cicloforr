using System;

namespace ciclofor
{
    class Program
    {
        static void Main(string[] args)
        {
            //ooooooh yea.
            int x, y, z;
            Console.WriteLine("Imprime los numeros del X hasta Y de -1");

            Console.WriteLine("De donde arrancamos el ciclo (Mayor): ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("De donde Terminamos el ciclo (Menor): ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("De cuanto en cuanto: ");
            z = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i > y; i -= z)
            {
                Console.WriteLine("i = " + i);

            }
        }
    }
}