using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class Input {

        // Constructor
        public Input() {

        }

        // Gets the input from the player and apply it to the game
        public void GetInputFromPlayer(Player player, Board board, Hud hud) {
            sbyte x = 1, y = 1;

            bool pressedEnter = false;
            while (!pressedEnter) {
                Console.Clear();
                hud.DrawHud();
                Console.WriteLine();
                board.SetPositionSignInBoard((byte)y, (byte)x);
                board.DrawBoard();
                switch (Console.ReadKey().Key) {
                    case ConsoleKey.UpArrow:
                        x--;
                        break;
                    case ConsoleKey.DownArrow:
                        x++;
                        break;
                    case ConsoleKey.RightArrow:
                        y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        y--;
                        break;
                    case ConsoleKey.Enter:
                        if (board.SetPlayerInBoard(player, (byte)y, (byte)x))
                            pressedEnter = true;
                        break;
                }
                if (x > 2) x = 0;
                if (x < 0) x = 2;
                if (y > 2) y = 0;
                if (y < 0) y = 2;
            }
        }

        // Gets the input from the player for the menu
        public byte GetInputFromPlayerForMenu(Menu menu, string headline, ConsoleColor headlineColor, ConsoleColor drawColor, ConsoleColor selectColor) {
            sbyte y = 0;

            while (true) {
                Console.Clear();
                Helper.DrawTextCenter(headline, headlineColor);
                Console.WriteLine();
                menu.DrawMenu(drawColor, selectColor);
                switch (Console.ReadKey().Key) {
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.Enter:
                        return (byte)y;

                }
                if (y > menu.GetMenuList().Count - 1) y = 0;
                if (y < 0) y = (sbyte)(menu.GetMenuList().Count - 1);
                menu.position = (byte)y;
            }
        }
    }
}
