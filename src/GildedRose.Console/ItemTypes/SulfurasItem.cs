using System;
using System.Collections.Generic;

namespace GildedRose.Console.ItemTypes
{
    class SulfurasItem
    {
        internal static void Register(Dictionary<string, IList<Rule>> map)
        {
            map.Add(Inventory.SULFURAS, new List<Rule>());
        }
    }
}
