using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class Player {
        private char sign;
        private byte points;

        // Constructor
        public Player(char sign) {
            this.sign = sign;
            this.points = 0;
        }

        // Gets the points of the player
        public byte GetPoints() {
            return this.points;
        }

        // Sets the points of the player
        public void SetPoints(byte points) {
            this.points = points;
        }

        // Adds points to the player
        public void AddPoints(byte points) {
            this.points += points;
        }

        // Gets the sign of the player
        public char GetSign() {
            return this.sign;
        }

        // Sets the sign of the player
        public void SetSign(char sign) {
            this.sign = sign;
        }
    }
}
