// Coded 23.08.2018. Still Progress.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_One
{
    class Program
    { 
        public static char[,] Field =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' }
        };

        static void Main(string[] args)
        {
            bool player = true;
            bool win = false;

            SetField();
            
            while(win == false)
            {
            Console.WriteLine("\n");
            if (player == true)
            {
                Console.WriteLine("Player 1, your turn.");
            } else if (player == false)
            {
                Console.WriteLine("Player 2, your turn.");
            }
            
            Console.Write("Which number? ");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out int userInput))
                {
                if (player == true)
                {
                    if (userInput == 1 && Field[0, 0] != 'O' && Field[0, 0] != 'X')
                    {
                        Field[0, 0] = 'X';
                        player = false;
                        Console.Clear();
                        SetField();
                    }
                    else if (userInput == 2 && Field[0, 1] != 'O' && Field[0, 1] != 'X')
                    {
                        Console.Clear();
                        Field[0, 1] = 'X';
                        player = false;
                        SetField();
                    }
                    else if (userInput == 3 && Field[0, 2] != 'O' && Field[0, 2] != 'X')
                    {
                        Console.Clear();
                        Field[0, 2] = 'X';
                        player = false;
                        SetField();
                    }
                    else if (userInput == 4 && Field[1, 0] != 'O' && Field[1, 0] != 'X')
                    {
                        Console.Clear();
                        Field[1, 0] = 'X';
                        player = false;
                        SetField();
                    }
                    else if (userInput == 5 && Field[1, 1] != 'O' && Field[1, 1] != 'X')
                    {
                        Console.Clear();
                        Field[1, 1] = 'X';
                        player = false;
                        SetField();
                    }
                    else if (userInput == 6 && Field[1, 2] != 'O' && Field[1, 2] != 'X')
                    {
                        Console.Clear();
                        Field[1, 2] = 'X';
                        player = false;
                        SetField();
                    }
                    else if (userInput == 7 && Field[2, 0] != 'O' && Field[2, 0] != 'X')
                    {
                        Console.Clear();
                        Field[2, 0] = 'X';
                        player = false;
                        SetField();
                    }
                    else if (userInput == 8 && Field[2, 1] != 'O' && Field[2, 1] != 'X')
                    {
                        Console.Clear();
                        Field[2, 1] = 'X';
                        player = false;
                        SetField();
                    }
                    else if (userInput == 9 && Field[2, 2] != 'O' && Field[2, 2] != 'X')
                    {
                        Console.Clear();
                        Field[2, 2] = 'X';
                        player = false;
                        SetField();
                    }
                } else if (player == false)
                {
                    if (userInput == 1 && Field[0, 0] != 'X' && Field[0, 0] != 'O')
                    {
                        Console.Clear();
                        Field[0, 0] = 'O';
                        player = true;
                        SetField();
                        
                    } else if (userInput == 2 && Field[0, 1] != 'X' && Field[0, 1] != 'O')
                    {
                        Console.Clear();
                        Field[0, 1] = 'O';
                        player = true;
                        SetField();
                    }
                    else if (userInput == 3 && Field[0, 2] != 'X' && Field[0, 2] != 'O')
                    {
                        Console.Clear();
                        Field[0, 2] = 'O';
                        player = true;
                        SetField();
                    }
                    else if (userInput == 4 && Field[1, 0] != 'X' && Field[1, 0] != 'O')
                    {
                        Console.Clear();
                        Field[1, 0] = 'O';
                        player = true;
                        SetField();
                    }
                    else if (userInput == 5 && Field[1, 1] != 'X' && Field[1, 1] != 'O')
                    {
                        Console.Clear();
                        Field[1, 1] = 'O';
                        player = true;
                        SetField();
                    }
                    else if (userInput == 6 && Field[1, 2] != 'X' && Field[1, 2] != 'O')
                    {
                        Console.Clear();
                        Field[1, 2] = 'O';
                        player = true;
                        SetField();
                    }
                    else if (userInput == 7 && Field[2, 0] != 'X' && Field[2, 0] != 'O')
                    {
                        Console.Clear();
                        Field[2, 0] = 'O';
                        player = true;
                        SetField();
                    }
                    else if (userInput == 8 && Field[2, 1] != 'X' && Field[2, 1] != 'O')
                    {
                        Console.Clear();
                        Field[2, 1] = 'O';
                        player = true;
                        SetField();
                    }
                    else if (userInput == 9 && Field[2, 2] != 'X' && Field[2, 2] != 'O')
                    {
                        Console.Clear();
                        Field[2, 2] = 'O';
                        player = true;
                        SetField();
                    }
                }
                } else
                {
                    Console.WriteLine("Wrong. It's taken or format exception.");
                }
                // Win check on Player 1
                if (Field[0, 0] == 'X' && Field[0, 1] == 'X' && Field[0, 2] == 'X')
                {
                    win = true;
                    Console.WriteLine("Player 1 wins!");
                    Console.ReadKey();
                }
                else if (Field[0, 0] == 'X' && Field[1, 0] == 'X' && Field[2, 0] == 'X')
                {
                    win = true;
                    Console.WriteLine("Player 1 wins!");
                    Console.ReadKey();
                }
                else if (Field[0, 0] == 'X' && Field[1, 0] == 'X' && Field[2, 0] == 'X')
                {
                    win = true;
                    Console.WriteLine("Player 1 wins!");
                    Console.ReadKey();
                }
                else if (Field[0, 1] == 'X' && Field[1, 1] == 'X' && Field[2, 1] == 'X')
                {
                    win = true;
                    Console.WriteLine("Player 1 wins!");
                    Console.ReadKey();
                }
                else if (Field[0, 2] == 'X' && Field[1, 2] == 'X' && Field[2, 2] == 'X')
                {
                    win = true;
                    Console.WriteLine("Player 1 wins!");
                    Console.ReadKey();
                }
                else if (Field[2, 0] == 'X' && Field[2, 1] == 'X' && Field[2, 2] == 'X')
                {
                    win = true;
                    Console.WriteLine("Player 1 wins!");
                    Console.ReadKey();
                }
                else if (Field[0, 0] == 'X' && Field[1, 1] == 'X' && Field[2, 2] == 'X')
                {
                    win = true;
                    Console.WriteLine("Player 1 wins!");
                    Console.ReadKey();
                }
                else if (Field[0, 2] == 'X' && Field[1, 1] == 'X' && Field[2, 0] == 'X')
                {
                    win = true;
                    Console.WriteLine("Player 1 wins!");
                    Console.ReadKey();
                }

                // Checks if Player 2 wins
                 else if (Field[0, 0] == 'O' && Field[0, 1] == 'O' && Field[0, 2] == 'O')
                {
                    win = true;
                    Console.WriteLine("Player 2 wins!");
                    Console.ReadKey();
                }
                else if (Field[0, 0] == 'O' && Field[1, 0] == 'O' && Field[2, 0] == 'O')
                {
                    win = true;
                    Console.WriteLine("Player 2 wins!");
                    Console.ReadKey();
                }
                else if (Field[0, 0] == 'O' && Field[1, 0] == 'O' && Field[2, 0] == 'O')
                {
                    win = true;
                    Console.WriteLine("Player 2 wins!");
                    Console.ReadKey();
                }
                else if (Field[0, 1] == 'O' && Field[1, 1] == 'O' && Field[2, 1] == 'O')
                {
                    win = true;
                    Console.WriteLine("Player 2 wins!");
                    Console.ReadKey();
                }
                else if (Field[0, 2] == 'O' && Field[1, 2] == 'O' && Field[2, 2] == 'O')
                {
                    win = true;
                    Console.WriteLine("Player 2 wins!");
                    Console.ReadKey();
                }
                else if (Field[2, 0] == 'O' && Field[2, 1] == 'O' && Field[2, 2] == 'O')
                {
                    win = true;
                    Console.WriteLine("Player 2 wins!");
                    Console.ReadKey();
                }
                else if (Field[0, 0] == 'O' && Field[1, 1] == 'O' && Field[2, 2] == 'O')
                {
                    win = true;
                    Console.WriteLine("Player 2 wins!");
                    Console.ReadKey();
                }
                else if (Field[0, 2] == 'O' && Field[1, 1] == 'O' && Field[2, 0] == 'O')
                {
                    win = true;
                    Console.WriteLine("Player 2 wins!");
                    Console.ReadKey();
                }


            }


        }


        public static void SetField()
        {
            Console.WriteLine("    |     |     ");
            Console.WriteLine(" {0}  |  {1}  |  {2}", Field[0, 0], Field[0, 1], Field[0, 2]);
            Console.WriteLine("____|_____|_____");
            Console.WriteLine("    |     |     ");
            Console.WriteLine(" {0}  |  {1}  |  {2}", Field[1, 0], Field[1, 1], Field[1, 2]);
            Console.WriteLine("____|_____|_____");
            Console.WriteLine("    |     |     ");
            Console.WriteLine(" {0}  |  {1}  |  {2}", Field[2, 0], Field[2, 1], Field[2, 2]);
            Console.WriteLine("____|_____|_____");
            Console.WriteLine("    |     |     ");

            

            
        }
    }
}

