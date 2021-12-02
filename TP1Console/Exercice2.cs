using System;


namespace TP1Console
{
    public class Exercice2
    {
        private static bool Prime(int number)
        {
            for (var i = 2; i < number; i++)
            {
                if (number % i == 0 && i != number) return false;
            }
            return true;
        }
        
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        private static void Fibo(int nombre)
        {
            int resultat = 0;
            int precedent = 1;

            if (nombre != 1 && nombre != 0)
            {
                for (int i = 0; i < nombre; i++)
                {
                    int temp = resultat;
                    resultat = precedent;
                    precedent = temp + precedent;
                }
            }

            Console.WriteLine(resultat);
        }

        private static int Fact(int nombre)
        {
            if (nombre == 0)
            {
                return 1; 
            }
            else
            {
                return nombre * Fact(nombre - 1);
            }
        }
        
        
        
        public static void Run()
        {
            
            Console.WriteLine("------- Exercice 2 Nombres premiers -------");
            
            for (var i = 1; i < 1001; i++)
            {
                if (Prime(i))
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.WriteLine("------- Exercice 2 Fibonnaci -------");
            
            var inputUser = AskUserForParameter();
            
            Fibo(inputUser);
            
            Console.WriteLine("------- Exercice 2 Factorielle -------");
            
            var nombreChoisi = AskUserForParameter();

            var resultat = Fact(nombreChoisi);
            
            Console.WriteLine(resultat);



        }

        
    }
}