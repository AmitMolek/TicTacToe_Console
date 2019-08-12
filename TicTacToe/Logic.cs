using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class Logic {

        // Return true if someone won
        public bool CheckBoard(Player player1, Board board) {
            if (CheckWhoIsTheWinner(player1, board)) {
                board.InitalizeBoard();
                return true;
            } 
            CheckFullboard(board);

            return false;
        }

        // Return true if someone won
        public bool CheckBoard(ComputerPlayer player, Board board) {
            if (CheckWhoIsTheWinner(player, board)) {
                board.InitalizeBoard();
                return true;
            }
            CheckFullboard(board);

            return false;
        }

        // Go over the lines and checks if there is a winner
        private string CheckLinesForWinner(Board board) {
            for (byte i = 0; i < board.GetBoard().GetLength(0); i++) {
                if (board.GetBoard()[i, 0] == board.GetBoard()[i, 1] && board.GetBoard()[i, 0] == board.GetBoard()[i, 2] && board.GetBoard()[i, 0] != ' ')
                    return board.GetBoard()[i, 0].ToString();
            }
            return "none";
        }

        // Go over the colums and checks if there is a winner
        private string CheckColumsForWinner(Board board) {
            for (byte i = 0; i < board.GetBoard().GetLength(1); i++) {
                if (board.GetBoard()[0, i] == board.GetBoard()[1, i] && board.GetBoard()[0, i] == board.GetBoard()[2, i] && board.GetBoard()[0, i] != ' ')
                    return board.GetBoard()[0, i].ToString();
            }
            return "none";
        }

        // Go over the crosses and checks if there is a winner
        private string CheckCrossesForWinner(Board board) {
            if (board.GetBoard()[0, 0] == board.GetBoard()[1, 1] && board.GetBoard()[0, 0] == board.GetBoard()[2, 2] && board.GetBoard()[0, 0] != ' ')
                return board.GetBoard()[0, 0].ToString();
            if (board.GetBoard()[0, 2] == board.GetBoard()[1, 1] && board.GetBoard()[0, 2] == board.GetBoard()[2, 0])
                return board.GetBoard()[0, 2].ToString();
            return "none";
        }

        // Calls all the checks and cheks if indeed there is a winner
        private string CallAllChecks(Board board) {
            string saveSign = CheckLinesForWinner(board);
            if (saveSign != "none") return saveSign;
            saveSign = CheckColumsForWinner(board);
            if (saveSign != "none") return saveSign;
            saveSign = CheckCrossesForWinner(board);
            if (saveSign != "none") return saveSign;
            return "none";
        }

        // Check who is the player that won
        private bool CheckWhoIsTheWinner(Player player, Board board) {
            if (player.GetSign().ToString() == CallAllChecks(board))
                return true;
            return false;
        }

        // Check who is the player that won
        private bool CheckWhoIsTheWinner(ComputerPlayer player, Board board) {
            if (player.GetSign().ToString() == CallAllChecks(board))
                return true;
            return false;
        }

        // Check if the board is full, if full than reset it
        private void CheckFullboard(Board board) {
            if (board.GetPopulated() >= 9)
                board.InitalizeBoard();
        }

    }
}
