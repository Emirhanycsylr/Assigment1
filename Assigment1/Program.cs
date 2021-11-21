using System;

namespace Assigment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int inputNumber;
            int turn = 0;
            char put;

            Console.WriteLine("   |   |   \n"
               + "---+---+---\n"
               + "   |   |   \n"
               + "---+---+---\n"
               + "   |   |    \n");

            char f1 = ' ', f2 = ' ', f3 = ' ', f4 = ' ', f5 = ' ', f6 = ' ', f7 = ' ', f8 = ' ', f9 = ' ';

            while (turn < 9)
            {
                if (turn % 2 == 0)
                {
                    put = 'X';
                }

                else
                {
                    put = 'O';
                }

                input = Console.ReadLine();
                if (!int.TryParse(input, out inputNumber))
                {
                    Console.WriteLine("Illegal move! Try again please");
                    continue;
                }

                if (inputNumber == 1)
                {
                    if (f1.Equals('X') || f1.Equals('O'))
                    {
                        Console.WriteLine("Illegal move! Try again please");
                        continue;
                    }
                    f1 = put;
                }

                if (inputNumber == 2)
                {
                    if (f2.Equals('X') || f2.Equals('O'))
                    {
                        Console.WriteLine("Illegal move! Try again please");
                        continue;
                    }
                    f2 = put;
                }

                if (inputNumber == 3)
                {
                    if (f3.Equals('X') || f3.Equals('O'))
                    {
                        Console.WriteLine("Illegal move! Try again please");
                        continue;
                    }
                    f3 = put;
                }

                if (inputNumber == 4)
                {
                    if (f4.Equals('X') || f4.Equals('O'))
                    {
                        Console.WriteLine("Illegal move! Try again please");
                        continue;
                    }
                    f4 = put;
                }

                if (inputNumber == 5)
                {
                    if (f5.Equals('X') || f5.Equals('O'))
                    {
                        Console.WriteLine("Illegal move! Try again please");
                        continue;
                    }
                    f5 = put;
                }

                if (inputNumber == 6)
                {
                    if (f6.Equals('X') || f6.Equals('O'))
                    {
                        Console.WriteLine("Illegal move! Try again please");
                        continue;
                    }
                    f6 = put;
                }

                if (inputNumber == 7)
                {
                    if (f7.Equals('X') || f7.Equals('O'))
                    {
                        Console.WriteLine("Illegal move! Try again please");
                        continue;
                    }
                    f7 = put;
                }

                if (inputNumber == 8)
                {
                    if (f8.Equals('X') || f8.Equals('O'))
                    {
                        Console.WriteLine("Illegal move! Try again please");
                        continue;
                    }
                    f8 = put;
                }

                if (inputNumber == 9)
                {
                    if (f9.Equals('X') || f9.Equals('O'))
                    {
                        Console.WriteLine("Illegal move! Try again please");
                        continue;
                    }
                    f9 = put;
                }

                Console.WriteLine($" {f1} | {f2} | {f3} \n"
                              + "---|---|---\n"
                              + $" {f4} | {f5} | {f6} \n"
                              + "---|---|---\n"
                              + $" {f7} | {f8} | {f9} ");// +(char)9553 + (int) '|' +  " " + (char)('a" -32));

                turn++;
            }

            Console.WriteLine("Game Over!");
        }
    }
}
