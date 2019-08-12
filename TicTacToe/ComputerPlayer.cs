using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class ComputerPlayer {
        private byte points;
        private char computerSign;
        private Board board;

        // Constructor
        public ComputerPlayer(char sign, Board board) {
            this.computerSign = sign;
            this.board = board;
            this.points = 0;
        }

        // The computer player turn
        public bool ComputerPlayMove() {
            if (CheckWinLines()) return true;
            if (CheckWinColums()) return true;
            if (CheckWinCrosses()) return true;
            if (CheckLines()) return true;
            if (CheckColums()) return true;
            if (CheckCrosses()) return true;
            if (RandomMove()) return true;
            return false;
        }

        // Checks if the opponent has populate two spots in a line
        private bool CheckLines() {
            for (byte i = 0; i < this.board.GetBoard().GetLength(0); i++) {
                if (this.board.GetBoard()[i, 0] == this.board.GetBoard()[i, 1] && this.board.GetBoard()[i, 0] != ' ') {
                    if(this.board.SetPlayerInBoard(this, 2, i))
                        return true;
                }
                else if (this.board.GetBoard()[i, 0] == this.board.GetBoard()[i, 2] && this.board.GetBoard()[i, 0] != ' ') {
                    if(this.board.SetPlayerInBoard(this, 1, i))
                        return true;
                }
                else if (this.board.GetBoard()[i, 1] == this.board.GetBoard()[i, 2] && this.board.GetBoard()[i, 1] != ' ') {
                    if(this.board.SetPlayerInBoard(this, 0, i))
                        return true;
                }
            }
            return false;
        }

        // Checks if the opponent has populate two spots in a colum
        private bool CheckColums() {
            for (byte i = 0; i < this.board.GetBoard().GetLength(1); i++) {
                if (this.board.GetBoard()[0, i] == this.board.GetBoard()[1, i] && this.board.GetBoard()[0, i] != ' ') {
                    if(this.board.SetPlayerInBoard(this, i, 2))
                        return true;
                }
                if (this.board.GetBoard()[0, i] == this.board.GetBoard()[2, i] && this.board.GetBoard()[0, i] != ' ') {
                    if(this.board.SetPlayerInBoard(this, i, 1))
                        return true;
                }
                if (this.board.GetBoard()[1, i] == this.board.GetBoard()[2, i] && this.board.GetBoard()[2, i] != ' ') {
                    if(this.board.SetPlayerInBoard(this, i, 0))
                        return true;
                }
            }
            return false;
        }

        // Checks if the opponent has populate two spots in a cross
        private bool CheckCrosses() {
            if (this.board.GetBoard()[0, 0] == this.board.GetBoard()[1, 1] && this.board.GetBoard()[0, 0] != ' ') {
                if(this.board.SetPlayerInBoard(this, 2, 2))
                    return true;
            }
            if (this.board.GetBoard()[0, 0] == this.board.GetBoard()[2, 2] && this.board.GetBoard()[0, 0] != ' ') {
                if(this.board.SetPlayerInBoard(this, 1, 1))
                    return true;
            }
            if (this.board.GetBoard()[1, 1] == this.board.GetBoard()[2, 2] && this.board.GetBoard()[1, 1] != ' ') {
                if(this.board.SetPlayerInBoard(this, 0, 0))
                    return true;
            }
            if (this.board.GetBoard()[0, 2] == this.board.GetBoard()[1, 1] && this.board.GetBoard()[0, 2] != ' ') {
                if(this.board.SetPlayerInBoard(this, 2, 0))
                    return true;
            }
            if (this.board.GetBoard()[0, 2] == this.board.GetBoard()[2, 0] && this.board.GetBoard()[0, 2] != ' ') {
                if(this.board.SetPlayerInBoard(this, 1, 1))
                    return true;
            }
            if (this.board.GetBoard()[2, 0] == this.board.GetBoard()[1, 1] && this.board.GetBoard()[2, 0] != ' ') {
                if(this.board.SetPlayerInBoard(this, 0, 2))
                    return true;
            }
            return false;
        }

        // Checks if the computer can win lines
        private bool CheckWinLines() {
            for (byte i = 0; i < this.board.GetBoard().GetLength(0); i++) {
                if (this.board.GetBoard()[i, 0] == this.board.GetBoard()[i, 1] && this.board.GetBoard()[i, 0] == this.computerSign) {
                    if (this.board.SetPlayerInBoard(this, 2, i))
                        return true;
                } else if (this.board.GetBoard()[i, 0] == this.board.GetBoard()[i, 2] && this.board.GetBoard()[i, 0] == this.computerSign) {
                    if (this.board.SetPlayerInBoard(this, 1, i))
                        return true;
                } else if (this.board.GetBoard()[i, 1] == this.board.GetBoard()[i, 2] && this.board.GetBoard()[i, 1] == this.computerSign) {
                    if (this.board.SetPlayerInBoard(this, 0, i))
                        return true;
                }
            }
            return false;
        }

        // Checks if the computer can win colums
        private bool CheckWinColums() {
            for (byte i = 0; i < this.board.GetBoard().GetLength(1); i++) {
                if (this.board.GetBoard()[0, i] == this.board.GetBoard()[1, i] && this.board.GetBoard()[0, i] == this.computerSign) {
                    if (this.board.SetPlayerInBoard(this, i, 2))
                        return true;
                }
                if (this.board.GetBoard()[0, i] == this.board.GetBoard()[2, i] && this.board.GetBoard()[0, i] == this.computerSign) {
                    if (this.board.SetPlayerInBoard(this, i, 1))
                        return true;
                }
                if (this.board.GetBoard()[1, i] == this.board.GetBoard()[2, i] && this.board.GetBoard()[2, i] == this.computerSign) {
                    if (this.board.SetPlayerInBoard(this, i, 0))
                        return true;
                }
            }
            return false;
        }

        // Checks if the computer can win crosses
        private bool CheckWinCrosses() {
            if (this.board.GetBoard()[0, 0] == this.board.GetBoard()[1, 1] && this.board.GetBoard()[0, 0] == this.computerSign) {
                if (this.board.SetPlayerInBoard(this, 2, 2))
                    return true;
            }
            if (this.board.GetBoard()[0, 0] == this.board.GetBoard()[2, 2] && this.board.GetBoard()[0, 0] == this.computerSign) {
                if (this.board.SetPlayerInBoard(this, 1, 1))
                    return true;
            }
            if (this.board.GetBoard()[1, 1] == this.board.GetBoard()[2, 2] && this.board.GetBoard()[1, 1] == this.computerSign) {
                if (this.board.SetPlayerInBoard(this, 0, 0))
                    return true;
            }
            if (this.board.GetBoard()[0, 2] == this.board.GetBoard()[1, 1] && this.board.GetBoard()[0, 2] == this.computerSign) {
                if (this.board.SetPlayerInBoard(this, 2, 0))
                    return true;
            }
            if (this.board.GetBoard()[0, 2] == this.board.GetBoard()[2, 0] && this.board.GetBoard()[0, 2] == this.computerSign) {
                if (this.board.SetPlayerInBoard(this, 1, 1))
                    return true;
            }
            if (this.board.GetBoard()[2, 0] == this.board.GetBoard()[1, 1] && this.board.GetBoard()[2, 0] == this.computerSign) {
                if (this.board.SetPlayerInBoard(this, 0, 2))
                    return true;
            }
            return false;
        }

        // Makes the computer player make a random move
        private bool RandomMove() {
            if (this.board.SetPlayerInBoard(this, (byte)new Random().Next(0, 3), (byte)new Random().Next(0, 3)))
                return true;
            return false;
        }

        // Returns the 'points' value
        public byte GetPoints() {
            return this.points;
        }

        // Sets the 'points' value
        public void SetPoints(byte points) {
            this.points = points;
        }

        // Adds the the value of 'points'
        public void AddPoints(byte points) {
            this.points += points;
        }

        // Gets the computer player sign
        public char GetSign() {
            return this.computerSign;
        }

        // Sets the computer player sign
        public void SetSign(char sign) {
            this.computerSign = sign;
        }
    }
}
