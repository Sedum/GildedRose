using System.Collections.Generic;
using System.Linq;
using GildedRose.Console.ItemTypes;

namespace GildedRose.Console
{
    static class ItemFactory
    {
        private static Dictionary<string, IList<Rule>> map = new Dictionary<string, IList<Rule>>();
        private static IList<Rule> normalRules = new List<Rule>();

        static ItemFactory()
        {
            AgedBrieItem.Register(map);
            BackstagePassItem.Register(map);
            ConjuredItem.Register(map);
            SulfurasItem.Register(map);
            NormalItem.Register(normalRules);
        }

        public static void Update(Item item)
        {
            foreach (var rule in GetRules(item))
            {
                RuleEngine.Rules[rule](item);
            }
        }

        private static IList<Rule> GetRules(Item item)
        {
            return map.Where(k => item.Name.Contains(k.Key)).Select(v => v.Value).DefaultIfEmpty(normalRules).FirstOrDefault();
        }
    }
}
