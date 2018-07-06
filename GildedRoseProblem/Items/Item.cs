using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseProblem
{
    public abstract class Item
    {
        public string Name { get; }                 //item name
        public bool ReduceSellIn { get; }           //determnies whether SellIn should be reduced as item ages
        public int SellIn { get; protected set; }   //the number of days we have to sell the item
        public int Quality { get; protected set; }  //how valuable the item is

        public Item(string name, int sell_in, bool reduce_sell_in, int quality)
        {
            if (quality < 0)
                throw new ArgumentOutOfRangeException("quality", "must be non-negative");

            Name = name;
            ReduceSellIn = reduce_sell_in;
            SellIn = sell_in;
            Quality = quality;
        }

        //implements quality change calculation logic in subclass
        protected abstract int GetNextQualityValueChange();

        public void Age()
        {
            //recalculate Quality
            Quality += GetNextQualityValueChange();

            //enforce Quality min/max
            if (Quality > 50)
                Quality = 50;
            else if (Quality < 0)
                Quality = 0;

            //reduce SellIn
            if (ReduceSellIn)
                SellIn--;
        }

        public override string ToString()
        {
            return $"{Name} {SellIn} {Quality}";
        }
    }
}
