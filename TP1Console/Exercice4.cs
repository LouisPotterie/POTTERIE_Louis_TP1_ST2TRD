using System;

namespace TP1Console
{
    public class Exercice4
    {
        
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        private static void QuestionA()
        {
            
            Console.WriteLine("------- Exercice 4 Square QA  -------");
            Console.WriteLine("Dimension du Rectangle");
            
            int line = 0;
            int column = 0; 
            
            while (line < 1)
            { 
                Console.WriteLine("Choose number of lines");
                line = AskUserForParameter();
            }
            
            while (column < 1)
            { 
                Console.WriteLine("Choose number of columns");
                column = AskUserForParameter();
            }
            
            string[,] array = new string[line, column];

            
            
            for (var i = 0; i < line; i++)
            {
                for (var j = 0; j < column; j++)
                {

                    if (j == 0 || j == column-1)
                    {
                        array[i, j] = "|";
                    }
                    
                    else if (i == 0 || i == line-1)
                    {
                        array[i, j] = "-";
                    }
                    else
                    {
                        array[i, j] = " ";
                    }
                    
                }
            }
            
            array[0,0] = "0";
            array[0, column-1] = "0";
            array[line-1,0] = "0";
            array[line-1, column-1] = "0";
            
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            
        }
        
        private static void QuestionB()
        {
            Console.WriteLine("------- Exercice 4 Square QB  -------");
            Console.WriteLine("Dimension du Rectangle");
            
            int line = 0;
            int column = 0; 
            
            while (line < 1)
            { 
                Console.WriteLine("Choose number of lines");
                line = AskUserForParameter();
            }
            
            while (column < 1)
            { 
                Console.WriteLine("Choose number of columns");
                column = AskUserForParameter();
            }
            
            string[,] array = new string[line, column];

            
            
            for (var i = 0; i < line; i++)
            {
                for (var j = 0; j < column; j++)
                {

                    if (j == 0 || j == column-1)
                    {
                        array[i, j] = "|";
                    }
                    
                    else if (i == 0 || i == line-1)
                    {
                        array[i, j] = "-";
                    }
                    else
                    {
                        var position = 1;

                        for (var a = 1; a < line - 1; a++)
                        {
                            for (var b = 1; b < column - 1; b++)
                            {
                                array[a, b] = " ";
                            }
                        }


                        for (var n = 1; n < column - 1; n++)
                        {
                            for (var m = position; m < line - 1; m += 3)
                            {
                                array[m, n] = "*";
                            }
                            position++;
                            if (position == 4)
                            {
                                position = 1;
                            }
                            
                        }
                        
                    }
                    
                }
            }
            
            array[0,0] = "0";
            array[0, column-1] = "0";
            array[line-1,0] = "0";
            array[line-1, column-1] = "0";
            
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            
        }
        
        public static void Run()
        {
            
            QuestionA();
            QuestionB();


        }
    }
}