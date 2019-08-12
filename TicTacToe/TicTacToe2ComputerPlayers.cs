using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TicTacToe {
    class TicTacToe2ComputerPlayers {
        private Board board;
        private ComputerPlayer pc1;
        private ComputerPlayer pc2;
        private Input input;
        private Logic logic;
        private Hud hud;

        // Constructor
        public TicTacToe2ComputerPlayers(char computerPlayer1Sign, char computerPlayer2Sign) {
            this.board = new Board('^');
            this.board.SetShowPositionSign(false);
            this.pc1 = new ComputerPlayer(computerPlayer1Sign, board);
            this.pc2 = new ComputerPlayer(computerPlayer2Sign, board);
            this.input = new Input();
            this.logic = new Logic();
            this.hud = new Hud(this.pc1, this.pc2);
        }

        // The Game Master
        public void StartGame() {
            while (true) {

                Console.Clear();
                this.hud.DrawHud();
                Console.WriteLine();
                this.board.DrawBoard();

                Thread.Sleep(1000);

                bool pc1Moved = false;
                while (!pc1Moved) {
                    pc1Moved = this.pc1.ComputerPlayMove();
                }
                if (this.logic.CheckBoard(this.pc1, this.board))
                    this.pc1.AddPoints(1);

                Console.Clear();
                this.hud.DrawHud();
                Console.WriteLine();
                this.board.DrawBoard();

                Thread.Sleep(1000);

                bool pc2Moved = false;
                while (!pc2Moved) {
                    pc2Moved = this.pc2.ComputerPlayMove();
                }
                if (this.logic.CheckBoard(this.pc2, this.board))
                    this.pc2.AddPoints(1);

            }
        }
    }
}
