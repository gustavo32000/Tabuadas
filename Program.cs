using System;

namespace Tabuadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            for (int numero=2 ; numero<=10 ;numero++){
                for (int x=0 ; x<=10 ; x++){
                    Console.WriteLine(numero + " X " + x + " = " + (numero*x));
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine();

            }
        }
    }
}
