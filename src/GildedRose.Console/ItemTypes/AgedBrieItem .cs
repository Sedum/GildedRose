using System.Collections.Generic;

namespace GildedRose.Console.ItemTypes
{
    class AgedBrieItem
    {
        internal static void Register(Dictionary<string, IList<Rule>> map)
        {
            map.Add(Inventory.AGED_BRIE, new List<Rule>());
            map[Inventory.AGED_BRIE].Add(Rule.AddOneBeforeExipredAndTwoAfter);
            map[Inventory.AGED_BRIE].Add(Rule.NeverGreaterThanFifty);
            map[Inventory.AGED_BRIE].Add(Rule.ReduceSellInByOne);
        }
    }
}
