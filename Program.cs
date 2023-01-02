// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

Test C1 = new Test();
C1.Booleen = true;
Test C2 = C1;

C1.Booleen = false;

Console.WriteLine(C2.Booleen);
public class Test
{
    public bool Booleen;
}*/

/*
using System;
namespace ConsoleApp{    
    internal static class Program{
        public static void Main(string[] args){
            Console.WriteLine("Hello, World");
        
        
        JourdeSemaine Aujourdhui = JourdeSemaine.Lundi;
        JourdeSemaine AujourdhuiB = 0;

        Console.WriteLine(AujourdhuiB);
        Console.WriteLine(Aujourdhui);
        
        
        int [,] Tableau = new int[1,2];// deux dimensions, une ligne deux colonnes
        int [,,] Tableau1 = new int[5,2,3]; // trois dimensions

        int[][] Tableau2 = new int[3][];
        Tableau2[0] = new int[] {45, 2};
        Tableau2[1] = new int[] {34, 34, 4, 67};
        Console.WriteLine(Tableau2[1]);
        Console.WriteLine(Tableau2);
        }
    }
}

enum JourdeSemaine{
    Lundi,
    Mardi,
    Mercredi,
    Jeudi,
    Vendredi,
    Samedi,
    Dimanche
}
 */

 using System;
namespace ConsoleApp{    
    internal static class Program{
        public static void Main(string[] args){
        
           /* Console.WriteLine("Entrer un nombre");
            int nb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer un autre nombre");
            int nb2 =Convert.ToInt32(Console.ReadLine());
            if (nb1 > nb2){
                Console.WriteLine(nb1 + " est plus grand");
            }else{
                Console.WriteLine(nb2 + " est plus grand");
            }*/

           
           
            /*
           int note = 101; 
           while(note > 100) { 
                Console.WriteLine("Entrer la note");
                 note = Convert.ToInt32(Console.ReadLine());
            }
            if (note >= 60){
                 Console.WriteLine("pass");
            }else{
                Console.WriteLine("fail");
            }*/


            /*
            Random rnd = new Random();
            int numberRandom = rnd.Next(1, 100);
            Console.WriteLine(numberRandom);
            Console.WriteLine("Entrer un nombre");
            int numberUser = Convert.ToInt32(Console.ReadLine());
            while(numberUser != numberRandom) { 
                Console.WriteLine("Incorrect, try again");
                numberUser = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Correct!");*/
          
          
          /*  
            Console.WriteLine("Entrer un nombre");
            int numberUser = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(numberUser);
           for (int i = 1; i < 13; i++){
            Console.Write( numberUser+"x"+i+"=" + i*numberUser+"\n");
           }
           */

        
             Console.WriteLine("Entrer un nombre");
            int nb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer un autre nombre");
            int nb2 = Convert.ToInt32(Console.ReadLine());
            int result = nb2 * nb1;
            Console.WriteLine("Le resultat est de "+result);
            while(result <= 1000){
                Console.WriteLine("Entrer un multiplicateur");
               int nbx = Convert.ToInt32(Console.ReadLine());
              result = result * nbx;  
            Console.WriteLine("Le resultat est de "+result);
            }
        

        
        }
    }
}