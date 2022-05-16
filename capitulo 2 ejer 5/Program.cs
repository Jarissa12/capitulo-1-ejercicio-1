using System;

namespace capitulo_2_ejer_1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
           

            
             String m1;

             int cambiar_dolar ;
             int cambiar_euro;
             int precio_dolar;
             int precio_euro;


               Console.WriteLine(" Digite  el nombre de la moneda a cambiar a dolar o euro ");
               m1= Console.ReadLine();
               Console.WriteLine("Digite  la cantidad de moneda a cambiar a euro ");
               cambiar_euro = int.Parse(Console.ReadLine());
               Console.WriteLine("Digite  la cantidad de moneda a cambiar a dolar ");
               cambiar_dolar = int.Parse(Console.ReadLine());
                
               Console.WriteLine("Digite  el precio de la moneda a cambiar a euro ");
               precio_dolar= int.Parse(Console.ReadLine());
               Console.WriteLine("Digite el precio de la moneda a cambiar a dolar ");
               precio_euro = int.Parse(Console.ReadLine());
                

                int r1;
                int r2 ;
                
                
                r2 = cambiar_euro * precio_euro;

                r1 =cambiar_dolar * precio_dolar;
                



               Console.WriteLine(" El cambio en euro es de: "+ r2);
               Console.WriteLine(" El cambio en dolar es de: "+ r1);

               Console.WriteLine(" La moneda a cambiar del dia de hoy es "+ m1);
               
            

        }
    }
}
