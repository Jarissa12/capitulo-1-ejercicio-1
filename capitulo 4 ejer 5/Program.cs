using System;

namespace capitulo_4_ejer_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" digite la cantida de persona ");
            int cantidad, num_mayor=0,num_menor=0;
            cantidad= int.Parse(Console.ReadLine());

            for (int i =0 ; i<= cantidad; i++){

                Console.WriteLine("digite la edad de la persona" );
                int edad;
                edad = int.Parse(Console.ReadLine());

                if (i== 1){

                   num_mayor =edad ;
                   num_menor =edad ;

                }
                else{
                    if (edad > num_mayor){

                        num_mayor= edad;


                    }
                    if (edad < num_menor){

                        num_menor= edad;

                        
                    }


                }



            }

            Console.WriteLine(" el numero mayor es :" + num_mayor);
             Console.WriteLine(" el numero mayor es :" + num_menor);


        }
    }
}
