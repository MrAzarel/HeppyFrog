using System;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Timers;

namespace HeppyFrog
{
    class Program
    {
        private static System.Timers.Timer aTimer;
        static Player player = new Player();    
        static void Main(string[] args)
        {
            Thread thread = new Thread(() => FieldMove.Movment());
            thread.Start();
            SetTimer();
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
                    default:
                        break;
                }
            }
        }

        private static void Check(Object source, ElapsedEventArgs e) 
        {
            if (player.GroundCheck())
            {
                Console.SetCursorPosition(Field.fieldLength / 2, Field.fieldWidth / 2);
                Console.WriteLine("Вы проиграли");
                Environment.Exit(0);
            }
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(1);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += Check;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
    }
}