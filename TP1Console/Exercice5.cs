using System;

namespace TP1Console
{
    public class Exercice5
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        
        public static void Run()
        {
            
            Console.WriteLine("------- Exercice 5 Christmas Tree -------");

            Random number = new Random();
            
            var treeWidth = 1;
            var treeHeight =0;
            var decoChoice =0;

            while (treeHeight < 3 || treeHeight > 20)
            { 
                Console.WriteLine("Choose a size between 3 and 20");
                treeHeight = AskUserForParameter();
            }
            
            while (decoChoice != 1 && decoChoice != 2)
            { 
                Console.WriteLine("Choose 1 for NO deco or 2 for deco");
                decoChoice = AskUserForParameter();
            }


            var spaces = treeHeight;

            var countO = 0;
            var countI = 0;
            

            for (var i = 0; i < treeHeight; i++)
            {
                
                for (var j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (var j = 0; j < treeWidth; j++)
                {
                    if(decoChoice == 2)
                    {
                        if (countO < countI)
                        {
                            var rand = number.Next(3);
                            if (rand == 0)
                            { 
                                Console.Write("* ");
                            }
                            else if (rand == 1)
                            { 
                                Console.Write("0 ");
                                countO++;
                            }
                            else if (rand == 2)
                            { 
                                Console.Write("i ");
                                countI++;
                            }
                        }
                        else
                        {
                            var rand = number.Next(2);
                            if (rand == 0)
                            { 
                                Console.Write("* ");
                            }
                            else if (rand == 1)
                            { 
                                Console.Write("i ");
                                countI++;
                            }
                        
                        } 
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                    
                    
                    
                }
                Console.WriteLine();
                treeWidth++;
                spaces--;
            }

            var spacesTronc = treeHeight / 2;

            for (var j = 0; j < spacesTronc; j++)
            {
                Console.Write("  ");
            }
            
            Console.Write("| ");
            Console.Write("|");
           

        } 
    }
}