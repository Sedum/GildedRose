using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Inventory
    {
        private readonly IList<Item> items;

        public Inventory(List<Item> items) => this.items = items;

        public void UpdateQuality()
        {
            foreach (var item in items)
            {
                RuleEngine.GetRules(item).ForEach(r => r.Apply(item));
            }
        }
    }
}
