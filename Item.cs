using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop3
{
    class Item
    {
        public string name;
        public string description;
        public int cost;
        public void PrintItem()
        {
            Console.WriteLine(description);
        }
        public void ProcessInput(string input)
        {

        }
    }
}
