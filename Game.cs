using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop3
{
    class Game
    {
        Player player = new Player();
        Shop shop = new Shop();

        public void Menu()
        {
            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Buy Item");
                Console.WriteLine("3: Sell Item");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    buyPotion();
                }
                else if (choice == "2")
                {
                    buyWeapon();
                }
                else if (choice == "3")
                {
                    sellPotion();
                }
                else if (choice == "4")
                {
                    sellWeapon();
                }
            }
        }
        public void buyPotion()
        {

        }
        //this function should be called when the program begins
        //that way your shop will have items in it when the game begins
        public void load()
        {
            shop.load();
        }
        public void save()
        {
            shop.save();
            player.save();
        }
    }
}
