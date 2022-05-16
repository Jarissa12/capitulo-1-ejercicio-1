using System;

namespace capitulo_4_ejer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero "+ "\n");

            long num ;
            Console.WriteLine("\n");

            num = long.Parse(Console.ReadLine());
            Console.WriteLine( " Tabla de multiplicacion  de " + num );
             Console.WriteLine( "---------------------------------");
             Console.WriteLine("\n");

            for (int i = 1; i<= 10; i++){

            
            
               Console.WriteLine( i+ " * "+ num +" = " + i*num +"\n");
               

            }
        }
    }
}
