using System;
using System.Collections.Generic;
using System.Linq;
using GildedRose.Console.ItemTypes;

namespace GildedRose.Console
{
    static class ItemFactory
    {
        public const string AGED_BRIE = "Aged Brie";
        public const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        public const string BACKSTAGEPASS = "Backstage passes";
        public const string CONJURED = "Conjured";

        private static Dictionary<string, Type> map = new Dictionary<string, Type>();

        static ItemFactory()
        {
            Register<AgedBrieItem>(AGED_BRIE);
            Register<BackstagePassItem>(BACKSTAGEPASS);
            Register<ConjuredItem>(CONJURED);
            Register<SulfurasItem>(SULFURAS);
        }

        public static ItemType Wrap(Item item)
        {
            return (ItemType)Activator.CreateInstance(map.Where(k => item.Name.Contains(k.Key)).Select(v => v.Value).DefaultIfEmpty(typeof(NormalItem)).FirstOrDefault(), item);
        }

        private static void Register<T>(string name) => map.Add(name, typeof(T));
    }
}
