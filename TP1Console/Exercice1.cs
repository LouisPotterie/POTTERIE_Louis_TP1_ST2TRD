using System;
namespace TP1Console
{
    public class Exercice1
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        public static void Run()
            {
                for (var i = 1; i < 11; i++)
                {
                    for (var j = 1; j < 11; j++)
                    {
                        Console.WriteLine($"{i}*{j}={i*j}");
                    }
                }
                
                Console.WriteLine("-------------- Affichage nombres impair ---------------");
                
                for (var i = 1; i < 11; i++)
                {
                    for (var j = 1; j < 11; j++)
                    {
                        var result = i * j;
                        if (result % 2 == 1)
                        { 
                            Console.WriteLine($"{i}*{j}={i*j}");
                        }
                    }
                }
                
                Console.WriteLine("-------------- Affichage Table d'un nombre choisi ---------------");

                var inputUser = AskUserForParameter();

                for (var i = 1; i < 11; i++)
                {
                    Console.WriteLine($"{inputUser}*{i}={inputUser*i}");
                }


            }
        
        
    }
}