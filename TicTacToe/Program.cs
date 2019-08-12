using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class Program {
        static void Main(string[] args) {

            Menu menu = new Menu();
            menu.AddMenu("Player vs Player");
            menu.AddMenu("Player vs Computer");
            menu.AddMenu("Computer vs Computer");
            Input input = new Input();

            switch (input.GetInputFromPlayerForMenu(menu, "Tic Tac Toe | By Amit Molek", ConsoleColor.Green, ConsoleColor.DarkGray, ConsoleColor.White)) {
                case 0:
                    TicTacToe2Players twoPlayers = new TicTacToe2Players('X', 'O', '^');
                    twoPlayers.StartGame();
                    break;
                case 1:
                    TicTacToe1Player1ComputerPlayer onePlayerOneComputerPlayer = new TicTacToe1Player1ComputerPlayer('X', 'P', '^');
                    onePlayerOneComputerPlayer.StartGame();
                    break;
                case 2:
                    TicTacToe2ComputerPlayers twoComputerPlayers = new TicTacToe2ComputerPlayers('O', 'X');
                    twoComputerPlayers.StartGame();
                    break;
            }

        }
    }
}
