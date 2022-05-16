using System;

namespace capitulo_4_ejerc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite un numero");
            double num ;
             num = double.Parse(Console.ReadLine());
             Console.WriteLine("digite un numero para la potencia ");
              double p;
             p = double.Parse(Console.ReadLine());

              double resul;
              resul = Math.Pow(num,p);
              Console.WriteLine(resul);


        }
        
    }
}
