using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LeCalculateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         Le calculateur            ");
            Calculateur leCalculateur = new Calculateur("leCalculateur");
            Console.WriteLine("Veuillez entrez un premier nombre entier");
            bool estValideNbre1 = false;
            int n1 = 0;
            do
            {
                try
                {
                    
                    string entree1 = Console.ReadLine();
                    if (!int.TryParse(entree1, out n1))
                    {
                        throw new CalculateurException("Ce que vous avez entré n'est pas un nombre");

                    }
                    else
                    {
                        estValideNbre1  = true;

                    }
                }
                catch(CalculateurException PremException)
                {
                    Console.WriteLine(PremException.Message);
                }
                finally
                {
                    if (!estValideNbre1)
                    {
                        Console.WriteLine("Veuillez réessayer");

                    }


                }


            }
            while (!estValideNbre1);

            Console.WriteLine("Veuillez entrez un deuxième nombre entier");
            bool estValideNbre2 = false;
            int n2 = 0;
            do
            {
                try
                {
                    
                    string entree2 = Console.ReadLine();
                    if (!int.TryParse(entree2, out n2))
                    {
                        throw new CalculateurException("Ce que vous avez entré n'est pas un nombre");

                    }
                    else
                    {
                        estValideNbre2 = true;

                    }
                }
                catch (CalculateurException DeuxiException)
                {
                    Console.WriteLine(DeuxiException.Message);
                }
                finally
                {
                    if (!estValideNbre2)
                    {
                        Console.WriteLine("Veuillez réessayer");

                    }


                }


            }
            while (!estValideNbre2);
           Console.WriteLine("         Le calculateur            ");
            Console.WriteLine("Première opération : Division");
            int resultat1 = 0;
                try
                {
                     
                     resultat1 = leCalculateur.Diviser(n1, n2);
                   
                }
                catch(DivideByZeroException ex1)
                {
                        Console.WriteLine("La division par zéro n'est pas possible");
                Console.WriteLine(ex1.Message);
                }
                catch (Exception ex2)
                {
                        Console.WriteLine("Une erreur s'est produite");
                        Console.WriteLine(ex2.Message);
                }

                Console.WriteLine(resultat1);
                Console.WriteLine();
                Console.WriteLine("Deuxième opération : Multiplication");
                Console.WriteLine("Veuillez entrez un premier nombre entier");
                int resultat2 = 0;
                try
                {
                        resultat2 = leCalculateur.Multiplier(n1, n2);
                        Console.WriteLine("Veuillez entrez un deuxième nombre entier");

                  }
                catch (Exception ex)
                {
                    Console.WriteLine("Une erreur s'est produite");
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(resultat1);
                Console.ReadKey();

        }
    }
}
