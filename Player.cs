using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WTF
{
    class Player
    {
        public int playerX = 2;
        public int playerY = Field.fieldWidth - 1;
        public char playerTile = 'O';

        public bool isGrounded = true;

        public void Jump()
        {           
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(50);
                Console.SetCursorPosition(playerX, playerY);
                Console.WriteLine(" ");
                if (i <= 1)
                {
                    playerY--;
                    playerX++;
                }
                else
                {
                    playerY++;
                    playerX++;
                }
                Console.SetCursorPosition(playerX, playerY);
                Console.WriteLine(playerTile);
            }
            isGrounded = true;
        }

        public bool GroundCheck()
        {
            if (playerX == 6 || playerX == 23 || playerX == 55 || playerX == 70)
            {
                return true;
            }
            else return false;
        }

        public bool Win()
        {
            if (playerX == 96)
            {
                return true;
            }
            else return false;
        }
    }
}
