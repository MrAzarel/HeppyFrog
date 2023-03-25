using System;
using System.Linq;
using System.Threading;

namespace WTF
{
    class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field();
            field.CreateField();
            Player player = new Player();
            while (true)
            {
                Console.SetCursorPosition(player.playerX, player.playerY);
                Console.WriteLine(player.playerTile);
                Thread.Sleep(10);

                
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.W:
                        if (player.playerX <= Field.fieldLength - 5)
                        {
                            player.isGrounded = false;
                            while (!player.isGrounded)
                            {
                                player.Jump();
                            }
                        }
                            break;
                    case ConsoleKey.A:
                        if (player.playerX != 1)
                        {
                            Console.SetCursorPosition(player.playerX, player.playerY);
                            Console.WriteLine(" ");
                            player.playerX--;
                        }
                        break;

                    case ConsoleKey.D:
                        if (player.playerX != Field.fieldLength-1)
                        {
                            Console.SetCursorPosition(player.playerX, player.playerY);
                            Console.WriteLine(" ");
                            player.playerX++;
                        }
                        break;
                }
                if (player.GroundCheck())
                {
                    Console.SetCursorPosition(Field.fieldLength / 2, Field.fieldWidth / 2);
                    Console.WriteLine("Вы проиграли");
                    break;
                }
                if (player.Win())
                {
                    Console.SetCursorPosition(Field.fieldLength / 2, Field.fieldWidth / 2);
                    Console.WriteLine("Вы выиграли!");
                    break;
                }
            }
        }
    }
}
