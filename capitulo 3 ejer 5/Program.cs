using System;

namespace capitulo_3_ejer_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1.triangulo   ");
            Console.WriteLine(" 2.cuadrado   ");
            Console.WriteLine(" 3. pentagono  ");
            Console.WriteLine(" 4. hexagono    ");
            Console.WriteLine(" 5. heptagono   ");
            Console.WriteLine(" 6  octogano    ");
            Console.WriteLine(" 7. eneagono    ");
            Console.WriteLine(" 8 .decagono ");
            Console.WriteLine(" 9. undecagono   ");
            Console.WriteLine(" 10.dodecagogono  "); 

            Console.WriteLine("  elija el poligono que desea calcular el perimetro y el area  "); 
            short opcion  ;

            opcion  = short.Parse(Console.ReadLine());

            switch(opcion){


                case 1:
                Console.WriteLine(" haz eligido el triangulo   ");
                Console.WriteLine(" digite la base   ");
                Console.WriteLine(" digite la altura    ");

                int b;
                int h;
                b = int .Parse (Console.ReadLine());
                 h = int .Parse (Console.ReadLine());

                int area, perimetro ;
                area = b*h/2;
                perimetro= h+h +b;
                
                Console.WriteLine(" El area es    "+ area );
                Console.WriteLine(" El perimetro es    "+ perimetro );

                  
                break ;
                case 2 :

                Console.WriteLine(" haz eligido cuadrado ");

                Console.WriteLine(" digite un lado  ");
            

                int L;
                
                L= int .Parse (Console.ReadLine());
                 int resul,perime;
                 resul = L*L;
                 perime= L*4;


                 Console.WriteLine(" El area es    "+ resul );
                Console.WriteLine(" El perimetro es    "+ perime);

                break ;
                case 3:
                Console.WriteLine(" haz eligido pentagono ");

                Console.WriteLine(" digite  un lado del pentagono   ");
                Console.WriteLine( " dddigite la apotema del pentagono");
                int apotema ;
                apotema=int.Parse (Console.ReadLine());
            

                int lado;
                
                 lado= int .Parse (Console.ReadLine());
                 int area3,p3;
                 
                 p3= lado+lado+lado+lado+lado;
                 area3 = p3*apotema/2;


                 Console.WriteLine(" El area es :   "+ area3 );
                 Console.WriteLine(" El perimetro es:    "+ p3);

                break ;
                case 4:
                Console.WriteLine(" haz elegido hexagono   ");


                Console.WriteLine(" digite  un lado del hexagono   ");
                Console.WriteLine( " digite la apotema del hexagono");
                int apotema2 ;
                apotema2=int.Parse (Console.ReadLine());
            

                int lado2;
                
                 lado2= int .Parse (Console.ReadLine());
                 int area4,p4;
                 
                 p4= lado2*6;
                 area4 = p4*apotema2/2;


                 Console.WriteLine(" El area es :   "+ area4 );
                 Console.WriteLine(" El perimetro es:    "+ p4);
                break ;
                case 5 :
                     Console.WriteLine(" haz elegido heptagono");

                    Console.WriteLine(" digite  un lado del hexagono   ");
                    Console.WriteLine( " digite la apotema del hexagono");
                    int apotema3 ;
                    apotema3=int.Parse (Console.ReadLine());
                

                    int lado3;
                    
                    lado3= int .Parse (Console.ReadLine());
                    int area5,p5;
                    
                    p5= lado3*7;
                    area5 = p5*apotema3/2;


                    Console.WriteLine(" El area es :   "+ area5 );
                    Console.WriteLine(" El perimetro es:  "+ p5);



                break ;
                case 6:
                Console.WriteLine(" haz elegido octogano   ");
                Console.WriteLine(" digite  un lado del hexagono   ");
                Console.WriteLine( " digite la apotema del hexagono");
                    int apotema4 ;
                    apotema4=int.Parse (Console.ReadLine());
                

                    int lado4;
                    
                    lado4= int .Parse (Console.ReadLine());
                    int area6,p6;
                    
                    p6= lado4*8;
                    area6 = p6*apotema4/2;


                    Console.WriteLine(" El area es :   "+ area6 );
                    Console.WriteLine(" El perimetro es:  "+ p6);


                 
                break ;

                case 7:

                Console.WriteLine(" haz elegido eneagono  ");

                Console.WriteLine(" digite  un lado del eneagono   ");
                Console.WriteLine( " digite la apotema del eneagono ");
                    int apotema5 ;
                    apotema5=int.Parse (Console.ReadLine());
                

                    int lado5;
                    
                    lado5= int .Parse (Console.ReadLine());
                    int area7,p7;
                    
                    p7= lado5*9;
                    area7 = p7*apotema5/2;


                    Console.WriteLine(" El area es :   "+ area7 );
                    Console.WriteLine(" El perimetro es:  "+ p7);

                break ;

                case 8:

                Console.WriteLine(" haz elegido decagono   ");

                Console.WriteLine(" digite  un lado del decagono :");
                Console.WriteLine( " digite la apotema del decagono: ");
                    int apotema7 ;
                    apotema7=int.Parse (Console.ReadLine());
                

                    int lado7;
                    
                    lado7= int .Parse (Console.ReadLine());
                    int area9,p9;
                    
                    p9= lado7*10;
                    area9 = p9*apotema7/2;


                    Console.WriteLine(" El area es :   "+ area9);
                    Console.WriteLine(" El perimetro es:  "+ p9);

                  
                break ;
                case 9:

                Console.WriteLine(" haz elegido undecagono ");


                Console.WriteLine(" digite  un lado del undecagono   ");
                Console.WriteLine( " digite la apotema del undecagono ");
                    int apotema8 ;
                    apotema8=int.Parse (Console.ReadLine());
                

                    int lado8;
                    
                    lado8= int .Parse (Console.ReadLine());
                    int area10,p10;
                    
                    p10= lado8*11;
                    area10 = p10*apotema8/2;


                    Console.WriteLine(" El area es :   "+ area10 );
                    Console.WriteLine(" El perimetro es:  "+ p10);
                break ;
                case 10:

                Console.WriteLine(" haz elegido docecagono ");
                Console.WriteLine(" digite  un lado del eneagono   ");
                Console.WriteLine( " digite la apotema del eneagono ");
                    int apotema9 ;
                    apotema9=int.Parse (Console.ReadLine());
                

                    int lado9;
                    
                    lado9= int .Parse (Console.ReadLine());
                    int area11,p11;
                    
                    p11= lado9*12;
                    area11 = p11*apotema9/2;


                    Console.WriteLine(" El area es :   "+ area11 );
                    Console.WriteLine(" El perimetro es:  "+ p11);
                break ;




                default:

                      Console.WriteLine(" No existe  ");
                break;

            }
        }
    }
}
