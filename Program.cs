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


using System.Collections.Generic;
using System;
namespace ConsoleApp
{
               enum JourdeSemaine{
                    Lundi,
                    Mardi,
                    Mercredi,
                    Jeudi,
                    Vendredi,
                    Samedi,
                    Dimanche
                }
    public class Voiture
    {
        public string marque;
        public string modele;
        public int nbPortes;
        public string couleur;

        public Voiture(string marque, string modele, int nbPortes, string couleur){
            this.marque = marque;
            this.modele = modele;
            this.nbPortes = nbPortes;
            this.couleur = couleur;
        }
        public void Description()
        {
            Console.WriteLine("La voiture est une "+marque+" "+modele+" avec "+ nbPortes +" portes de couleur "+couleur+".");
        }
        /*
        public int Sum(int a, int b) 
        {
            return a + b;
        }*/ 
        // Voiture maBugati = new Voiture("Chiron", 5);
        // maBugati.Description()
        // int FourPlusSix = maBugati.Sum(4, 6);
    }
    
    public class Etudiant{
        public string nom;
        public string prenom;
        public int age;
         public Etudiant(string nom, string prenom, int age){
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }
         public void Saluer()
        {
            Console.WriteLine("Bonjour, je m'appelle "+nom+" "+prenom+" et j'ai "+age+" ans.");
        }
    }

    public class CompteBancaire{
        public string nomTitulaire;
        public float solde;

        public CompteBancaire(string nomTitulaire, float solde){
            this.nomTitulaire = nomTitulaire;
            this.solde = solde;
        }
        public void Deposer(float versement){
            solde =+ versement;
        }
        public void Retirer(float retrait){
            solde =- retrait;
        }
    }

    public class Calculatrice{
        public int a;
        public int b;
        public int Additionner(int a, int b){
            return a+b;
        }
        public int Multiplier(int a, int b){
            return a*b;
        }
    }
    public class Rectangle{
        public float largeur;
        public float hauteur;
        public float Aire(float largeur, float hauteur){
            return largeur*hauteur;
        }
        public float Perimetre(float largeur, float hauteur){
            return largeur*2 + hauteur*2;
        }
    }
    public interface Volant{
        public string Voler(){  
            return "Je suis en train de voler!";
        }
    }
    public class Oiseau : Volant{
       public string nom;
       public Oiseau(string nom){
            this.nom = nom;
       }
       public string Description(string nom){
         return "Je suis un oiseau de nom"+nom;
       }
    }

    internal static class Program
    {
        public static void Main(string[] args)
        {


            // Exercices de base
            void Exercice1()
            {

                Console.WriteLine("Entrer un nombre");
                int nb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entrer un autre nombre");
                int nb2 = Convert.ToInt32(Console.ReadLine());
                if (nb1 > nb2)
                {
                    Console.WriteLine(nb1 + " est plus grand");
                }
                else
                {
                    Console.WriteLine(nb2 + " est plus grand");
                }
            }

            void Exercice2()
            {
                int note = 101;

                while (note > 100)
                {
                    Console.WriteLine("Entrer la note");
                    note = Convert.ToInt32(Console.ReadLine());
                }
                if (note >= 60)
                {
                    Console.WriteLine("pass");
                }
                else
                {
                    Console.WriteLine("fail");
                }
            }

            void Exercice3()
            {

                Random rnd = new Random();
                int numberRandom = rnd.Next(1, 100);

                Console.WriteLine(numberRandom);
                Console.WriteLine("Entrer un nombre");
                int numberUser = Convert.ToInt32(Console.ReadLine());
                while (numberUser != numberRandom)
                {
                    Console.WriteLine("Incorrect, try again");
                    numberUser = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Correct!");
            }

            void Exercice4()
            {
                Console.WriteLine("Entrer un nombre");
                int numberUser = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numberUser);
                for (int i = 1; i < 13; i++)
                {
                    Console.Write(numberUser + "x" + i + "=" + i * numberUser + "\n");
                }
            }

            void Exercice5()
            {

                Console.WriteLine("Entrer un nombre");
                int nb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entrer un autre nombre");
                int nb2 = Convert.ToInt32(Console.ReadLine());
                int result = nb2 * nb1;
                Console.WriteLine("Le resultat est de " + result);
                while (result <= 1000)
                {
                    Console.WriteLine("Entrer un multiplicateur");
                    int nbx = Convert.ToInt32(Console.ReadLine());
                    result = result * nbx;
                    Console.WriteLine("Le resultat est de " + result);
                }
            }

            void Exercice6()
            {
                int[] tableau = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                for (int i = 0; i < 11; i++)
                {
                    Console.Write(i);
                }
            }

            void Exercice7(){
                int[] tableau = new int[10];
                Console.WriteLine("Entrer 10 nombres");
                for (int i = 0; i < 10; i++)
                {
                    tableau[i] = int.Parse(Console.ReadLine());
                }

                foreach (int a in tableau)
                {
                    Console.Write(a);
                }
            }

            void Exercice8(){
                string[] couleurs = {"bleu", "jaune", "rouge", "marron", "vert"};
                int i = 0;
                while (i < couleurs.Length){
                Console.WriteLine(couleurs[i]);
                i++;
                }
            }

            void Exercice9(){
                double[] nombres = { 1.5, 2.5, 3.5, 4.5, 5.5 };
                double somme = 0;
                int i = 0;
                    do{
                        somme += nombres[i];
                        i++;
                    }
                    while (i < nombres.Length);
                        Console.WriteLine("La somme est de: "+somme);

            }

            void Exercice10(){
                int[] nombres = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            for (int i = 0; i < nombres.Length; i++){
                if (nombres[i] % 3 == 0 && nombres[i] % 5 == 0){
                    Console.WriteLine("Le premier nombre divisible est: " + nombres[i]);
                }
            }
            }
            void Exercice11(){
                const int maxjours = 365;

                Console.WriteLine("Entrez votre age");
                int age = Convert.ToInt32(Console.ReadLine());

                int joursaccumule = age * maxjours;
                Console.WriteLine("vous avez "+joursaccumule );
            }

            void Exercice12(){
                const int scdparmin = 60;

            Console.Write("Entrez le temps en min et sec");
            string tempsUser = Console.ReadLine();

            string[] TabTemps = tempsUser.Split(',');
            int minutes = int.Parse(TabTemps[0]);
            int secondes = int.Parse(TabTemps[1]);
            int totalScd = minutes * scdparmin + secondes;
            Console.WriteLine($"{minutes} minutes et {secondes} secondes = {totalScd} secondes");
            }
            
            void Exercice13(){
                Console.WriteLine("Saisir une température:");
                int temperature = Convert.ToInt32(Console.ReadLine());

                switch (temperature){
                    case int n when (n > 30):
                    Console.WriteLine("Chaude");
                    break;
                    case int n when (n >= 21 && n <= 30):
                    Console.WriteLine("Tiede");
                    break;
                    case int n when (n >= 10 && n < 21):
                    Console.WriteLine("Fraiche");
                    break;
                    case int n when (n < 10):
                    Console.WriteLine("Froide");
                    break;
                    }
            }

            void Program1(){
                Console.WriteLine("Entrez votre nom");
                string nom = Console.ReadLine();

                Console.WriteLine("Entrez votre age");
                int age = Convert.ToInt32(Console.ReadLine());

                int anne = 100 - age;
                Console.WriteLine(nom+",il vous reste "+anne+" ans avant d'avoir 100 ans");
            }

            void Pendu()
            {

                string motATrouver;
                string joueur1;
                string joueur2;
                char lettreentre;
                string motCache = "";
                List<char> Lettres = new List<char>();
                int essai = 0;
                bool gagne = false;

                Console.WriteLine("Nom du joueur 1 ?");
                joueur1 = Console.ReadLine();


                Console.WriteLine("Nom du joueur 2 ?");
                joueur2 = Console.ReadLine();


                Console.WriteLine(joueur1 + " ,veuillez entrer un mot pour " + joueur2);
                motATrouver = Console.ReadLine();
                Console.Clear();
                int tailleMot = motATrouver.Length;

                for (int a = 0; a < tailleMot; a++)
                {
                    motCache = motCache + "*";
                }
                Console.WriteLine("Mot à trouver : \n" + motCache);

                foreach (char c in motATrouver)
                {
                    Lettres.Add(c);
                }
                //Lettres.ForEach(Console.WriteLine); //console.LOG

                Console.WriteLine(joueur2 + " A vous de jouez");


                while (essai <= 6 && gagne == false)
                {
                    Console.WriteLine("Entrer une lettre");
                    lettreentre = Console.ReadLine()[0];

                    if (Lettres.Contains(lettreentre))
                    {
                        Lettres.RemoveAll(e => e == lettreentre); // Enleve toutes les lettres de ma liste
                    }
                    else
                    {
                        essai++;
                    }
                    foreach (char p in motATrouver)
                    {
                        if (Lettres.Contains(p))
                        {
                            Console.Write(" _ ");
                        }
                        else
                        {
                            Console.Write(p);
                        }
                    }
                    Console.WriteLine("\n Il vous reste " + (6 - essai) + " essais restants");

                    if (Lettres.Count == 0)
                    {
                        gagne = true;
                        Console.WriteLine("Bravo, vous avez gagné");
                    }
                    if (essai == 6)
                    {
                        Console.WriteLine("Dommage, vous avez perdu");
                        return;
                    }
                }
            }


            //Pendu();
        Voiture maBugati = new Voiture("Peugeot","Ibiza",10,"bleu");
        maBugati.Description();
        Etudiant unEtudiant = new Etudiant("Pierre","Paul",10);
        unEtudiant.Saluer();
        }
    }
}