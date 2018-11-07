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
                ItemFactory.Wrap(item).Update(item);
            }
        }
    }
}
