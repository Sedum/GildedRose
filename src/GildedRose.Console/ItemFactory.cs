using System;
using System.Collections.Generic;
using GildedRose.Console.ItemTypes;

namespace GildedRose.Console
{
    static class ItemFactory
    {
        private static Dictionary<string, Type> map = new Dictionary<string, Type>();

        static ItemFactory()
        {
            Register<AgedBrieItem>(Inventory.AGED_BRIE);
            Register<BackstagePassItem>(Inventory.BACKSTAGEPASS);
            Register<ConjuredItem>(Inventory.CONJURED);
            Register<SulfurasItem>(Inventory.SULFURAS);
        }

        public static ItemType Wrap(Item item)
        {
            map.TryGetValue(GetKey(item.Name), out Type type);
            return (ItemType)Activator.CreateInstance(type ?? typeof(NormalItem), item);
        }

        private static string GetKey(string key)
        {
            return (key.Contains(Inventory.CONJURED) ? Inventory.CONJURED : key);
        }

        private static void Register<T>(string name) => map.Add(name, typeof(T));
    }
}
