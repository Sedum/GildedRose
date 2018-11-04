using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Inventory
    {
        public const string AGED_BRIE = "Aged Brie";
        public const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        public const string BACKSTAGEPASS = "Backstage passes to a TAFKAL80ETC concert";
        public const string CONJURED = "Conjured Mana Cake";

        IList<Item> Items;

        public Inventory(List<Item> items)
        {
            Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items) ItemFactory.Wrap(item).Update();
        }
    }
}
