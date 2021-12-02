using System;

namespace TP1Console
{
    public class Exercice3
    {
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }
        public static void Run()
        {
            
            Console.WriteLine("------- Exercice 3 Try & Catch -------");
            
            try
            {
                var number = -3;
                
                while (number != 4)
                {
                    var resultat = 10 / PowerFunction(number);
                    Console.WriteLine(resultat);
                    number++;
                }
                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                
            }

            try
            {
                var number = -1;
                
                while (number != 4)
                {
                    var resultat = 10 / PowerFunction(number);
                    Console.WriteLine(resultat);
                    number++;
                }

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);

            }

            finally
            {
                var number = 3; 
                var resultat = 10 / PowerFunction(number);
                Console.WriteLine(resultat);
            }
            
            
            
            
          

        }
    }
}