using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class Hud {
        private Player player1;
        private Player player2;
        private ComputerPlayer computerPlayer1;
        private ComputerPlayer computerPlayer2;

        // Constructor with 2 Players
        public Hud(Player player1, Player player2) {
            this.player1 = player1;
            this.player2 = player2;
        }

        // Constructor with 1 Player 1 ComputerPlayer
        public Hud(Player player1, ComputerPlayer computerPlayer) {
            this.player1 = player1;
            this.computerPlayer1 = computerPlayer;
        }

        // Constructor with 2 ComputerPlayers
        public Hud(ComputerPlayer computerPlayer1, ComputerPlayer computerPlayer2) {
            this.computerPlayer2 = computerPlayer1;
            this.computerPlayer1 = computerPlayer2;
        }

        // Draws the HUD
        public void DrawHud() {
            if(this.player2 != null)
                Helper.DrawTextCenter("Player 1 [" + player1.GetSign() + "]: " + this.player1.GetPoints() + "| Player 2 [" + player2.GetSign() + "]: " + this.player2.GetPoints(), ConsoleColor.Green);
            else if(this.computerPlayer1 != null && this.computerPlayer2 == null)
                Helper.DrawTextCenter("Player 1 [" + player1.GetSign() + "]: " + this.player1.GetPoints() + "| Computer [" + computerPlayer1.GetSign() + "]: " + this.computerPlayer1.GetPoints(), ConsoleColor.Green);
            else if(this.computerPlayer1 != null && this.computerPlayer2 != null)
                Helper.DrawTextCenter("Computer 1 [" + computerPlayer1.GetSign() + "]: " + this.computerPlayer1.GetPoints() + "| Computer 2 [" + computerPlayer2.GetSign() + "]: " + this.computerPlayer2.GetPoints(), ConsoleColor.Green);
        }
    }
}
