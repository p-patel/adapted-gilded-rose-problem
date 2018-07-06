using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseProblem
{
    public class InvalidItem : Item
    {
        public InvalidItem(string name, int sell_in, int quality) : base(name, sell_in, false, quality)
        {
            //SellInReduced is set to false for InvalidItems so that they retain all original values
        }

        protected override int GetNextQualityValueChange()
        {
            //no change is required in Quality of an invalid item
            return 0;
        }

        public override string ToString()
        {
            //set InvalidItem-specific output
            return "NO SUCH ITEM";
        }
    }
}
