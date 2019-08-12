using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    public class Helper {
        // Draw the text in the center of the screen
        public static void DrawTextCenter(string Text, ConsoleColor TextColor) {
            int lengthOf = Text.Length;
            int Width = Console.WindowWidth;

            Console.ForegroundColor = TextColor;
            Console.WriteLine(Text.PadLeft((Width / 2) + (lengthOf / 2)));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
