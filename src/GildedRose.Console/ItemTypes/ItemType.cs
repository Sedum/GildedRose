using GildedRose.Console.Rules;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRose.Console.ItemTypes
{
    abstract class ItemType
    {
        protected readonly List<Rule> rules = new List<Rule>();

        public void Update(Item item)
        {
            rules.Where(r => r.IsApplicable(item)).ToList().ForEach(r => r.Apply(item));
        }
    }
}