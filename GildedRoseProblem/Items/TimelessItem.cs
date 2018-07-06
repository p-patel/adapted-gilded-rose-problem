using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseProblem
{
    public class TimelessItem : Item
    {
        public TimelessItem(string name, int sell_in, int quality) : base(name, sell_in, false, quality)
        {
            //SellInReduced is set to false for TimelessItems
        }

        protected override int GetNextQualityValueChange()
        {
            //Quality is never changed
            return 0;
        }
    }
}
