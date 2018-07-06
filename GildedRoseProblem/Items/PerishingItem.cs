using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseProblem
{
    public class PerishingItem : Item
    {
        public int PerishingFactor { get; }

        public PerishingItem(string name, int sell_in, int quality, int perishing_factor) : base(name, sell_in, true, quality)
        {
            PerishingFactor = perishing_factor;
        }

        protected override int GetNextQualityValueChange()
        {
            //once the sell by date has passed, Quality degrades twice as fast
            if (SellIn < 0)
                return -(PerishingFactor * 2);

            return -PerishingFactor;
        }
    }
}
