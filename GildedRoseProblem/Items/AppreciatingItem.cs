using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseProblem
{
    public class AppreciatingItem : Item
    {
        public AppreciatingItem(string name, int sell_in, int quality) : base(name, sell_in, true, quality)
        {

        }

        protected override int GetNextQualityValueChange()
        {
            //increases in Quality the older it gets
            //???how does behaviour change once the sell by date has passed, e.g. does it appreciate twice as fast?
            return 1;
        }
    }
}
