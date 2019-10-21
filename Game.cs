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
                Console.WriteLine("1: Equip weapon");
                Console.WriteLine("2: Unequip weapon");
                Console.WriteLine("3: Add gold");
                Console.WriteLine("4: Subtract gold");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    EquipWeapon();

                }
                else if (choice == "2")
                {
                    UnEquipWeapon();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("How much gold?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if (choice == "4")
                {
                    Console.WriteLine("How much gold?");
                    float subtractedGold = Convert.ToSingle(Console.ReadLine());
                    SubtractGold(subtractedGold);
                }
            }
        }
        //this function should be called when the program begins
        //that way your shop will have item sin it when the game begins
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
