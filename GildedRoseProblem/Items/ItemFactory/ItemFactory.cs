using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseProblem
{
    public static class ItemFactory
    {
        private const int _NORMAL_ITEM_PERISHING_FACTOR = 1;
        private const int _CONJURED_ITEM_PERISHING_FACTOR = 2;

        //creates and returns concrete Item subclass type for given name and populated by sell_in and quality
        public static Item Get(string name, int sell_in, int quality)
        {
            switch (name)
            {
                case "Normal Item":
                    return new PerishingItem(name, sell_in, quality, _NORMAL_ITEM_PERISHING_FACTOR);
                case "Conjured":
                    return new PerishingItem(name, sell_in, quality, _CONJURED_ITEM_PERISHING_FACTOR);
                case "Aged Brie":
                    return new AppreciatingItem(name, sell_in, quality);
                case "Backstage passes":
                    return new HikedTicketItem(name, sell_in, quality);
                case "Sulfuras":
                    return new TimelessItem(name, sell_in, quality);
                default:
                    return new InvalidItem(name, sell_in, quality);
            }
    }
    }
}
