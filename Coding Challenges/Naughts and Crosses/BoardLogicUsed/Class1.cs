using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLogicUsed
{
    public class Board
    {
        public char[] Grid
        {
            get; set;
        }
        public Board()
        {
            Console.WriteLine("Hi");
            //Initialise the board and set squares to 0
        }

        //public bool isBoardFull()
      
        public bool hasWon(char[] blank0orX)
        {
            if (blank0orX[0] != ' ' && blank0orX[0] == blank0orX[1] && blank0orX[1] == blank0orX[2])
            {
                Console.WriteLine("The game ended");
                return true;
            }
            if (blank0orX[3] != ' ' && blank0orX[3] == blank0orX[4] && blank0orX[4] == blank0orX[5])
            {
                Console.WriteLine("The game ended");
                return true;
            }
            if (blank0orX[6] != ' ' && blank0orX[6] == blank0orX[7] && blank0orX[7] == blank0orX[8])
            {
                Console.WriteLine("The game ended");
                return true;
            }
            if (blank0orX[0] != ' ' && blank0orX[0] == blank0orX[3] && blank0orX[3] == blank0orX[6])
            {
                Console.WriteLine("The game ended");
                return true;
            }
            if (blank0orX[1] != ' ' && blank0orX[1] == blank0orX[4] && blank0orX[4] == blank0orX[7])
            {
                Console.WriteLine("The game ended");
                return true;
            }
            if (blank0orX[2] != ' ' && blank0orX[2] == blank0orX[5] && blank0orX[5] == blank0orX[8])
            {
                Console.WriteLine("The game ended");
                return true;
            }
            if (blank0orX[0] != ' ' && blank0orX[0] == blank0orX[4] && blank0orX[4] == blank0orX[8])
            {
                Console.WriteLine("The game ended");
                return true;
            }
            if (blank0orX[2] != ' ' && blank0orX[2] == blank0orX[4] && blank0orX[4] == blank0orX[6])
            {
                Console.WriteLine("The game ended");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

