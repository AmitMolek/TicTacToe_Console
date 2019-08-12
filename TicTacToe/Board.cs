using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class Board {
        private char[,] board;
        private char positionSign;
        private byte positionSignX;
        private byte positionSignY;
        private byte populated;
        private bool showPositionSign;

        // Constructor
        public Board(char positionSign) {
            this.board = new char[3, 3];
            this.positionSign = positionSign;
            this.positionSignX = 0;
            this.positionSignY = 0;
            this.populated = 0;
            this.showPositionSign = true;
            InitalizeBoard();
        }

        // Draws the board of the game
        public void DrawBoard() {
            if (this.showPositionSign) {
                byte drawLineSpacers = 2;
                Helper.DrawTextCenter("-------------", ConsoleColor.White);
                for (byte i = 0; i < this.board.GetLength(0); i++) {
                    if (i != this.positionSignY) {
                        Helper.DrawTextCenter("| " + this.board[i, 0] + " | " + this.board[i, 1] + " | " + this.board[i, 2] + " |", ConsoleColor.White);
                        if (drawLineSpacers > 0) {
                            Helper.DrawTextCenter("-------------", ConsoleColor.White);
                            drawLineSpacers--;
                        }
                    } else {
                        switch (this.positionSignX) {
                            case 0:
                                Helper.DrawTextCenter("| " + this.positionSign.ToString() + " | " + this.board[i, 1] + " | " + this.board[i, 2] + " |", ConsoleColor.White);
                                Helper.DrawTextCenter("-------------", ConsoleColor.White);
                                break;
                            case 1:
                                Helper.DrawTextCenter("| " + this.board[i, 0] + " | " + this.positionSign.ToString() + " | " + this.board[i, 2] + " |", ConsoleColor.White);
                                Helper.DrawTextCenter("-------------", ConsoleColor.White);
                                break;
                            case 2:
                                Helper.DrawTextCenter("| " + this.board[i, 0] + " | " + this.board[i, 1] + " | " + this.positionSign.ToString() + " |", ConsoleColor.White);
                                Helper.DrawTextCenter("-------------", ConsoleColor.White);
                                break;
                        }
                    }
                }
            } else {
                Helper.DrawTextCenter("-------------", ConsoleColor.White);
                for (byte i = 0; i < this.board.GetLength(0); i++) {
                    Helper.DrawTextCenter("| " + this.board[i, 0] + " | " + this.board[i, 1] + " | " + this.board[i, 2] + " |", ConsoleColor.White);
                    Helper.DrawTextCenter("-------------", ConsoleColor.White);
                }
            }
        }

        // Sets the Position Sign position
        public void SetPositionSignInBoard(byte x, byte y) {
            this.positionSignX = x;
            this.positionSignY = y;
        }

        // Sets the player in the board
        public bool SetPlayerInBoard(Player player, byte x, byte y) {
            if (this.board[y, x] == ' ') {
                this.board[y, x] = player.GetSign();
                populated++;
                return true;
            }
            return false;
        }

        // Sets the computer player in the board
        public bool SetPlayerInBoard(ComputerPlayer computerPlayer, byte x, byte y) {
            if (this.board[y, x] == ' ') {
                this.board[y, x] = computerPlayer.GetSign();
                populated++;
                return true;
            }
            return false;
        }

        // Initalize the board with empty spaces
        public void InitalizeBoard() {
            this.populated = 0;
            for (int i = 0; i < this.board.GetLength(0); i++) {
                for (int j = 0; j < this.board.GetLength(1); j++) {
                    this.board[i, j] = ' ';
                }
            }
        }

        // Returns the value of 'board'
        public char[,] GetBoard() {
            return this.board;
        }

        // Sets the value of 'board'
        public void SetBoard(char[,] board) {
            this.board = board;
        }

        // Returns the value of 'showPositionSign'
        public bool GetShowPositionSign() {
            return this.showPositionSign;
        }

        // Sets the value of 'showPositionSign'
        public void SetShowPositionSign(bool showPositionSign) {
            this.showPositionSign = showPositionSign;
        }

        // Returns the value of 'populated'
        public byte GetPopulated() {
            return this.populated;
        }

        // Sets the value of 'populated'
        public void SetPopulated(byte populated) {
            this.populated = populated;
        }
    }
}
