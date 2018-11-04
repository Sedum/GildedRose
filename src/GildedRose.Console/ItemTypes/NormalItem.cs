using System.Collections.Generic;
using System.Linq;

namespace GildedRose.Console.ItemTypes
{
    class NormalItem : ItemType
    {
        public NormalItem(Item item) : base(item, Rule.SubtractOne, Rule.SubtractTwoWhenExpired, Rule.NeverBelowZero) { }
    }
}
