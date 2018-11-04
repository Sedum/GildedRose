using System.Linq;
using System.Collections.Generic;

namespace GildedRose.Console.ItemTypes
{
    class BackstagePassItem
    {
        /*
        static private Dictionary<int, int> limits = new Dictionary<int, int>();

        static BackstagePassItem()
        {
            limits.Add(10, 1);
            limits.Add(5, 2);
            limits.Add(0, 3);
        }
        */
        internal static void Register(Dictionary<string, IList<Rule>> map)
        {
            map.Add(Inventory.BACKSTAGEPASS, new List<Rule>());
            map[Inventory.BACKSTAGEPASS].Add(Rule.BackstagePass);
            map[Inventory.BACKSTAGEPASS].Add(Rule.NeverGreaterThanFifty);
            map[Inventory.BACKSTAGEPASS].Add(Rule.ReduceSellInByOne);
        }
    }
}
