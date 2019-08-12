using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class TicTacToe2Players {
        private Board board;
        private Player player1;
        private Player player2;
        private Input input;
        private Logic logic;
        private Hud hud;

        // Constructor
        public TicTacToe2Players(char player1Sign, char player2Sign, char boardPositionSign) {
            this.board = new Board(boardPositionSign);
            this.player1 = new Player(player1Sign);
            this.player2 = new Player(player2Sign);
            this.input = new Input();
            this.logic = new Logic();
            this.hud = new Hud(this.player1, this.player2);
        }

        // The Game Master
        public void StartGame() {
            while (true) {
                this.input.GetInputFromPlayer(this.player1, this.board, this.hud);
                if (this.logic.CheckBoard(this.player1, this.board))
                    this.player1.AddPoints(1);
                input.GetInputFromPlayer(player2, board, hud);
                if (logic.CheckBoard(player2, board))
                    player2.AddPoints(1);
            }
        }

    }
}
