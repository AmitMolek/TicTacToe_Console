using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class Menu {
        private List<String> menu;
        public byte position;

        // Constructor
        public Menu() {
            this.menu = new List<string>();
        }

        // Constructor
        public Menu(List<string> menu) {
            this.menu = menu;
        }

        public void DrawMenu(ConsoleColor drawColor, ConsoleColor selectColor) {
            for (byte i = 0; i < this.menu.Count; i++) {
                if(i == position)
                    Helper.DrawTextCenter(this.menu[i], selectColor);
                else Helper.DrawTextCenter(this.menu[i], drawColor);
            }
        }

        // Return the value of 'menu'
        public List<string> GetMenuList() {
            return this.menu;
        }

        // Sets the value of 'menu'
        public void SetMenuList(List<string> menu) {
            this.menu = menu;
        }

        // Add values to 'menu'
        public void AddMenu(string entry) {
            this.menu.Add(entry);
        }
    }
}
