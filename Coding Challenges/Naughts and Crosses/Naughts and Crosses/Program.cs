using System;
using BoardLogicUsed;


namespace Naughts_and_Crosses
{
    class Program
    {

        public static bool IsAvailable(char pos)
        {
            if (pos == ' ')
            {
                return true;
            }
            else 
            {
                return false;            
            }
        }

        public static string DrawGrid(char[] blank0OrX)
        {
            Console.WriteLine(@"
                                   {0} | {1} | {2}
                                  _____|_____|____   
                                   {3} | {4} | {5}
                                  _____|_____|_____
                                   {6} | {7} | {8}
                                       |     |    

             ",blank0OrX[0], blank0OrX[1], blank0OrX[2], blank0OrX[3], blank0OrX[4], blank0OrX[5], blank0OrX[6], blank0OrX[7], blank0OrX[8]);

            
            string grid = Console.ReadLine();
            return grid;
        }

        //public static bool Playing()
        //{

//        }

        static void Main(string[] args)
        {

            char pos0 = ' ', pos1 = ' ', pos2 = ' ', pos3 = ' ', pos4 = ' ', pos5 = ' ', pos6 = ' ', pos7 = ' ', pos8 = ' ';
            //string CurrentPosCheck = " ";

            bool playing = true;
            char[] blank0OrX = { pos0, pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8 };
            char zeroOrX = ' ';
            Console.WriteLine("Welcome to my Naughts and Crosses game");

            //for each position check is available, and then draw the grid with updated pos values

            string player = ""; //this is either 1 or 2
            int count = 0;
            int turn = 0;
            Board game = new Board();

            //Playing();
            //draw the grid after each turn
            while (playing == true && turn < 9)
            {
                //check which user
                if (count%2 == 0)
                {
                    player = "player 1";
                    zeroOrX = 'X';
                }
                else
                {
                    player = "player 2";
                    zeroOrX = '0';
                }

                Console.WriteLine("Enter your position {0}", player);
                string ChosenPosition = Console.ReadLine();

                //check the user input
              
                //check that the position is available 
                if ((ChosenPosition == "pos0") && IsAvailable(pos0))
                {
                    blank0OrX[0] = zeroOrX; //n=32 is out of bounds;
                    DrawGrid(blank0OrX);
                    //n++;
                }
                if ((ChosenPosition == "pos1") && IsAvailable(pos1))
                {
                    blank0OrX[1] = zeroOrX; //out of bounds;
                    DrawGrid(blank0OrX);
                }
                if ((ChosenPosition == "pos2") && IsAvailable(pos2))
                {
                    blank0OrX[2] = zeroOrX; //out of bounds;
                    DrawGrid(blank0OrX);
                }
                if ((ChosenPosition == "pos3") && IsAvailable(pos3))
                {
                    blank0OrX[3] = zeroOrX; //n=32 is out of bounds;
                    DrawGrid(blank0OrX);
                    //n++;
                }
                if ((ChosenPosition == "pos4") && IsAvailable(pos4))
                {
                    blank0OrX[4] = zeroOrX; //out of bounds;
                    DrawGrid(blank0OrX);
                }
                if ((ChosenPosition == "pos5") && IsAvailable(pos5))
                {
                    blank0OrX[5] = zeroOrX; //out of bounds;
                    DrawGrid(blank0OrX);
                }
                if ((ChosenPosition == "pos6") && IsAvailable(pos6))
                {
                    blank0OrX[6] = zeroOrX; //out of bounds;
                    DrawGrid(blank0OrX);
                }
                if ((ChosenPosition == "pos7") && IsAvailable(pos7))
                {
                    blank0OrX[7] = zeroOrX; //out of bounds;
                    DrawGrid(blank0OrX);
                }
                if ((ChosenPosition == "pos8") && IsAvailable(pos8))
                {
                    blank0OrX[8] = zeroOrX; //out of bounds;
                    DrawGrid(blank0OrX);
                }

                if (game.hasWon(blank0OrX) == true)
                {
                    Console.WriteLine("{0} has won", player);
                    playing = false;

                }
                else
                {
                    turn++;
                    count++; // other player takes a turn
                }
                //draw grid with type: 

                }
                Console.WriteLine(DrawGrid(blank0OrX));
            

            }
        }
    }

