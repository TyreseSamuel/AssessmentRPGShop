﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop3
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.menu();
            inventory.player();
            inventory.shop();
        }
    }
}
