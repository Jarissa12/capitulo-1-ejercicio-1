using System;

namespace capitulo_3_ejer_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite un numero del 1 al 7 dependiendo el orden de la semana   ");
            short num ;

            num = short.Parse(Console.ReadLine());

            switch(num){


                case 1:
                Console.WriteLine(" Lunes  ");
                  
                break ;
                case 2 :

                Console.WriteLine(" Martes  ");
                break ;
                case 3:
                Console.WriteLine(" Miercoles ");
                break ;
                case 4:
                Console.WriteLine(" Jueves  ");
                break ;
                case 5 :
                     Console.WriteLine(" Vierne  ");
                break ;
                case 6:
                Console.WriteLine(" Sabado   ");
                break ;

                case 7:

                Console.WriteLine(" Domingo  ");
                break ;

                default:

                      Console.WriteLine(" No existe , solo exite 7 dias  ");
                break;

            }
        }
    }
}
