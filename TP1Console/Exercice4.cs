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
            int line = AskUserForParameter();
            int column = AskUserForParameter(); 
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
            array[column-1,0] = "0";
            array[0,line-1] = "0";
            array[column-1,line-1] = "0";
            
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            
        }
        
        private static void QuestionB()
        {
            int line = AskUserForParameter();
            int column = AskUserForParameter(); 
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
            array[column-1,0] = "0";
            array[0,line-1] = "0";
            array[column-1,line-1] = "0";
            
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
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