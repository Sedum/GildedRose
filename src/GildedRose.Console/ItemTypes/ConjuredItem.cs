using System;
using System.Collections.Generic;

namespace GildedRose.Console.ItemTypes
{
    class ConjuredItem
    {
        internal static void Register(Dictionary<string, IList<Rule>> map)
        {
            map.Add(Inventory.CONJURED, new List<Rule>());
            map[Inventory.CONJURED].Add(Rule.SubtractTwoBeforeExipredAndFourAfter);
            map[Inventory.CONJURED].Add(Rule.NeverBelowZero);
            map[Inventory.CONJURED].Add(Rule.ReduceSellInByOne);
        }
    }
}
