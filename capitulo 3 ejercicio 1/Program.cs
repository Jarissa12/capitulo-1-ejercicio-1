using System;

namespace capitulo_3_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero ");
            float num ;
            num = float.Parse(Console.ReadLine());

           if ((num % 2) == 0){
               
               Console.WriteLine(" Este numero es par  ");

           }
           else {

               Console.WriteLine(" Este numero es impar ");

           }
 
        }
    }
}
