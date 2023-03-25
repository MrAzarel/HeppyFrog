using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeppyFrog
{
    internal class Player
    {
        public int playerX = 4;
        public int playerY = Field.fieldWidth - 1;
        public char playerTile = 'O';

        public bool isGrounded = true;

        public void Jump()
        {
            for (int i = 0; i < 24; i++)
            {
                Thread.Sleep(20);
                Console.SetCursorPosition(playerX, playerY);
                Console.WriteLine(" ");
                if (i <= 2)
                {
                    playerY--;
                }
                else if (i >= 21)
                {
                    playerY++;
                }
                Console.SetCursorPosition(playerX, playerY);
                Console.WriteLine(playerTile);
            }
            isGrounded = true;
        }

        public bool GroundCheck()
        {
            if (FieldMove.tiles[5].tile == '_' && playerY == Field.fieldWidth - 1)
            {
                return true;
            }
            else return false;
        }

        //public bool Win()
        //{
        //    if (playerX == 96)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
    }
}
