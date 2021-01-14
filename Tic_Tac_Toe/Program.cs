using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordinate = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
            bool UserStroke = false;
            int UserCoordinate = 0;
            int test = 1; // дэбаг
            int counter = 0;

            Console.WriteLine("Coordinates on board:");
            Console.WriteLine(" " + coordinate[0] + " | " + coordinate[1] + " | " + coordinate[2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" " + coordinate[3] + " | " + coordinate[4] + " | " + coordinate[5]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" " + coordinate[6] + " | " + coordinate[7] + " | " + coordinate[8]);


            while (test == 1)
            {
                counter++;
                
                
                if ((coordinate[0] == "X" && coordinate[1] == "X" && coordinate[2] == "X" && counter >= 3)||(coordinate[0] == "0" && coordinate[1] == "0" && coordinate[2] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[0]+" wins!");
                    break;
                }
                else if ((coordinate[3] == "X" && coordinate[4] == "X" && coordinate[5] == "X" && counter >= 3)||(coordinate[3] == "0" && coordinate[4] == "0" && coordinate[5] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[3]+" wins!");
                    break;
                }
                else if ((coordinate[6] == "X" && coordinate[7] == "X" && coordinate[8] == "X" && counter >= 3)||(coordinate[6] == "0" && coordinate[7] == "0" && coordinate[8] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[6]+" wins!");
                    break;
                }
                else if ((coordinate[0] == "X" && coordinate[3] == "X" && coordinate[6] == "X" && counter >= 3)||(coordinate[0] == "0" && coordinate[3] == "0" && coordinate[6] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[0]+" wins!");
                    break;
                }
                else if ((coordinate[1] == "X" && coordinate[4] == "X" && coordinate[7] == "X" && counter >= 3)||(coordinate[1] == "0" && coordinate[4] == "0" && coordinate[7] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[1]+" wins!");
                    break;
                }
                else if ((coordinate[2] == "X" && coordinate[5] == "X" && coordinate[8] == "X" && counter >= 3)||(coordinate[2] == "0" && coordinate[5] == "0" && coordinate[8] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[2]+" wins!");
                    break;
                }
                else if ((coordinate[0] == "X" && coordinate[4] == "X" && coordinate[8] == "X" && counter >= 3)||(coordinate[0] == "0" && coordinate[4] == "0" && coordinate[8] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[0]+" wins!");
                    break;
                }
                else if ((coordinate[6] == "X" && coordinate[4] == "X" && coordinate[2] == "X" && counter >= 3)||(coordinate[6] == "0" && coordinate[4] == "0" && coordinate[2] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[6]+" wins!");
                    break;
                }
                
                
                while (UserStroke == false)
                { 
                    Console.WriteLine("Write coordinate!");
                    Console.WriteLine("You are X");
                    string FirstUserCoordinate = Console.ReadLine();
                    UserCoordinate = Convert.ToInt32(FirstUserCoordinate);
                    if (UserCoordinate > 9 || UserCoordinate < 1)
                    {
                         Console.WriteLine("It is not good...");
                         UserStroke = false;
                    }
                    else if (coordinate[UserCoordinate-1] != "X" && coordinate[UserCoordinate-1] != "0")
                    {
                        coordinate[UserCoordinate-1] = "X";
                        Console.WriteLine(" " + coordinate[0] + " | " + coordinate[1] + " | " + coordinate[2]);
                        Console.WriteLine("---|---|---");
                        Console.WriteLine(" " + coordinate[3] + " | " + coordinate[4] + " | " + coordinate[5]);
                        Console.WriteLine("---|---|---");
                        Console.WriteLine(" " + coordinate[6] + " | " + coordinate[7] + " | " + coordinate[8]);
                        UserStroke = true;
                    }
                    else
                    {
                        Console.WriteLine("So the cell is already occupied! Choose another cell.");
                        UserStroke = false;
                    }
                }
                UserStroke = false;
                
                
                if ((coordinate[0] == "X" && coordinate[1] == "X" && coordinate[2] == "X" && counter >= 3)||(coordinate[0] == "0" && coordinate[1] == "0" && coordinate[2] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[0]+" wins!");
                    break;
                }
                else if ((coordinate[3] == "X" && coordinate[4] == "X" && coordinate[5] == "X" && counter >= 3)||(coordinate[3] == "0" && coordinate[4] == "0" && coordinate[5] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[3]+" wins!");
                    break;
                }
                else if ((coordinate[6] == "X" && coordinate[7] == "X" && coordinate[8] == "X" && counter >= 3)||(coordinate[6] == "0" && coordinate[7] == "0" && coordinate[8] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[6]+" wins!");
                    break;
                }
                else if ((coordinate[0] == "X" && coordinate[3] == "X" && coordinate[6] == "X" && counter >= 3)||(coordinate[0] == "0" && coordinate[3] == "0" && coordinate[6] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[0]+" wins!");
                    break;
                }
                else if ((coordinate[1] == "X" && coordinate[4] == "X" && coordinate[7] == "X" && counter >= 3)||(coordinate[1] == "0" && coordinate[4] == "0" && coordinate[7] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[1]+" wins!");
                    break;
                }
                else if ((coordinate[2] == "X" && coordinate[5] == "X" && coordinate[8] == "X" && counter >= 3)||(coordinate[2] == "0" && coordinate[5] == "0" && coordinate[8] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[2]+" wins!");
                    break;
                }
                else if ((coordinate[0] == "X" && coordinate[4] == "X" && coordinate[8] == "X" && counter >= 3)||(coordinate[0] == "0" && coordinate[4] == "0" && coordinate[8] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[0]+" wins!");
                    break;
                }
                else if ((coordinate[6] == "X" && coordinate[4] == "X" && coordinate[2] == "X" && counter >= 3)||(coordinate[6] == "0" && coordinate[4] == "0" && coordinate[2] == "0" && counter >= 3))
                {
                    Console.WriteLine(coordinate[6]+" wins!");
                    break;
                }
                
                
                Console.WriteLine("Computer stroke:");
                
                bool ComputerStroke = false;
                while (ComputerStroke == false)
                {
                    Random rnd = new Random();
                    int rnd0 = rnd.Next(0, 9);
                    if (coordinate[rnd0] != "X" && coordinate[rnd0] != "0")
                    {
                        coordinate[rnd0] = "0";
                        ComputerStroke = true;
                        Console.WriteLine(" " + coordinate[0] + " | " + coordinate[1] + " | " + coordinate[2]);
                        Console.WriteLine("---|---|---");
                        Console.WriteLine(" " + coordinate[3] + " | " + coordinate[4] + " | " + coordinate[5]);
                        Console.WriteLine("---|---|---");
                        Console.WriteLine(" " + coordinate[6] + " | " + coordinate[7] + " | " + coordinate[8]);
                    }
                }
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}