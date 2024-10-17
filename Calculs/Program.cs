using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            bool correct;

            correct = false;

            // boucle sur le menu
            choix = 1;
            reponse = 1;
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                correct = false;
                while (!correct)
                {
                    try
                    {
                        choix = int.Parse(Console.ReadLine());
                        Console.Write("Choix :                          ");
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Entrer un caractère valide !");
                    }
                }
                // traitement des choix
                if (choix != 0)
                {
                    if (choix == 1)
                    {
                        // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        Console.Write(val1 + " + " + val2 + " = ");
                        // saisie de la réponse
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Entrer un caractère valide !");
                            }
                        }
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                    }
                    else if (choix == 2)
                    {
                        // choix de la multiplication
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        Console.Write(val1 + " x " + val2 + " = ");
                        reponse = int.Parse(Console.ReadLine());
                        // comparaison avec la bonne réponse
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Entrer un caractère valide !");
                            }
                        }
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Veuillez mettre une valeur valide !");
                    }
                }
            }
        }
    }
}
