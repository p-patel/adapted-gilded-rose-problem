using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> inventory_items = new List<Item>();

            string[] test_input = {
                "Aged Brie 1 1",
                "Backstage passes -1 2",
                "Backstage passes 9 2",
                "Sulfuras 2 2",
                "Normal Item -1 55",
                "Normal Item 2 2",
                "INVALID ITEM 2 2",
                "Conjured 2 2",
                "Conjured -1 5"
            };

            //read test input and create list of items
            foreach (string item_data in test_input)
            {
                string name = "";
                int sell_in;
                int quality;

                string[] item_values = item_data.Split(' ');


                //parse quality value
                if (!int.TryParse(item_values[item_values.Length - 1], out quality))
                {
                    //***add suitable handling of invalid input data 'quality', for now the input item is just ignored...
                    continue;
                }

                //parse sellin value
                if (!int.TryParse(item_values[item_values.Length - 2], out sell_in))
                {
                    //***add suitable handling of invalid input data 'sellin', for now the input item is just ignored...
                    continue;
                }

                //reconstruct item name value
                name = item_values[0];

                for (int i = 1; i <= item_values.Length - 3; i++)
                    name += " " + item_values[i];

                //create item object and add to items list
                inventory_items.Add(ItemFactory.Get(name, sell_in, quality));
            }


            //update inventory after adjusting the quality and sellin days for each item after a day            
            foreach (Item item in inventory_items)
                item.Age();


            //output results
            foreach (Item item in inventory_items)
                Console.WriteLine(item.ToString());

            Console.WriteLine(Environment.NewLine + "Enter a value to end");
            Console.ReadLine();
        }
    }
}
