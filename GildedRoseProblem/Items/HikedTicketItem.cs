using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseProblem
{
    public class HikedTicketItem : Item
    {
        public HikedTicketItem(string name, int sell_in, int quality) : base(name, sell_in, true, quality)
        {

        }

        protected override int GetNextQualityValueChange()
        {
            //ticket Quality hiking rules
            if (SellIn > 10)
                return 1;
            else if (SellIn <= 10 && SellIn >= 6)
                return 2;
            else if (SellIn <= 5 && SellIn >= 0)
                return 3;
            else
                return -Quality;
        }
    }
}
