using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class TicTacToe1Player1ComputerPlayer {
        private Board board;
        private Player player1;
        private ComputerPlayer pc;
        private Input input;
        private Logic logic;
        private Hud hud;
        
        // Constructor
        public TicTacToe1Player1ComputerPlayer(char player1Sign, char computerPlayerSign, char boardPositionSign) {
            this.board = new Board(boardPositionSign);
            this.player1 = new Player(player1Sign);
            this.input = new Input();
            this.logic = new Logic();
            this.pc = new ComputerPlayer(computerPlayerSign, board);
            this.hud = new Hud(this.player1, this.pc);
        }

        // The Game Master
        public void StartGame() {
            while (true) {
                this.input.GetInputFromPlayer(this.player1, this.board, this.hud);
                if (this.logic.CheckBoard(this.player1, this.board))
                    this.player1.AddPoints(1);
                bool pcMoved = false;
                while (!pcMoved) {
                    pcMoved = this.pc.ComputerPlayMove();
                }
                if (this.logic.CheckBoard(this.pc, this.board))
                    this.pc.AddPoints(1);
            }
        }
    }
}
