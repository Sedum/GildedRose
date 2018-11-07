using System;
using System.Collections.Generic;
using System.Linq;
using GildedRose.Console.ItemTypes;

namespace GildedRose.Console
{
    static class ItemFactory
    {
        public const string AGED_BRIE = "Aged Brie";
        public const string SULFURAS = "Sulfuras";
        public const string BACKSTAGEPASS = "Backstage passes";
        public const string CONJURED = "Conjured";

        private static Dictionary<string, ItemType> map = new Dictionary<string, ItemType>();
        private static ItemType defaultType = new NormalItem();

        static ItemFactory()
        {
            Register<AgedBrieItem>(AGED_BRIE);
            Register<BackstagePassItem>(BACKSTAGEPASS);
            Register<ConjuredItem>(CONJURED);
            Register<SulfurasItem>(SULFURAS);
        }

        public static ItemType Wrap(Item item)
        {
            return map.Where(k => item.Name.StartsWith(k.Key)).Select(v => v.Value).DefaultIfEmpty(defaultType).FirstOrDefault();
        }

        private static void Register<T>(string name) => map.Add(name, (ItemType)Activator.CreateInstance(typeof(T)));
    }
}
