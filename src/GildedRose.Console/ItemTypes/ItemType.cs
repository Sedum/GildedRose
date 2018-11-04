using System;
using System.Collections.Generic;

namespace GildedRose.Console.ItemTypes
{
    delegate void QualityAction(Item item, int delta);
    
    abstract class ItemType
    {
        protected Item item;
        protected List<Rule> rules = new List<Rule>();
        static protected Dictionary<Rule, Action<Item>> RuleEngine = new Dictionary<Rule, Action<Item>>();

        private static void Delta(Item item, int delta, int lower, int upper)
        {
            if (ApplyRule(item.SellIn, lower, upper)) item.Quality += delta;
        }
        private static bool ApplyRule(int SellIn, int lower, int upper) { return SellIn > lower && SellIn <= upper; }

        static ItemType()
        {
            RuleEngine.Add(Rule.SubtractOne, (Item item) => Delta(item, -1, 0, int.MaxValue));
            RuleEngine.Add(Rule.SubtractTwoWhenExpired, (Item item) => Delta(item, -2, int.MinValue, 0));
            RuleEngine.Add(Rule.AddOne, (Item item) => Delta(item ,1, 0, int.MaxValue));
            RuleEngine.Add(Rule.AddTwoWhenExpired, (Item item) => Delta(item, 2, int.MinValue, 0));
            RuleEngine.Add(Rule.ZeroWhenExpired, (Item item) => Delta(item, -item.Quality, int.MinValue, 0));
            RuleEngine.Add(Rule.NeverBelowZero, (Item item) => { item.Quality = Math.Max(0, item.Quality); });
            RuleEngine.Add(Rule.NeverGreaterThan50, (Item item) => { item.Quality = Math.Min(50, item.Quality); });
            RuleEngine.Add(Rule.BackstageAddOneWhenGreaterThen10Days, (Item item) => Delta(item, 1, 10, int.MaxValue));
            RuleEngine.Add(Rule.BackstageAddTwoBetween5and10Days, (Item item) => Delta(item, 2, 5, 10));
            RuleEngine.Add(Rule.BackstageAddThreeBetween0And5Days, (Item item) => Delta(item, 3, 0, 5));
        }

        public ItemType(Item item, params Rule[] rules)
        {
            this.item = item;
            this.rules.AddRange(rules);
        }

        public void Update()
        {
            UpdateQuality();
            UpdateSellIn();
        }

        virtual protected void UpdateSellIn()
        {
            item.SellIn--;
        }
        private void UpdateQuality()
        {
            foreach(var rule in rules)
            {
                RuleEngine[rule](item);
            }
        }
    }

    public enum Rule
    {
        SubtractOne,
        SubtractTwoWhenExpired,
        AddOne,
        AddTwoWhenExpired,
        ZeroWhenExpired,
        BackstageAddOneWhenGreaterThen10Days,
        BackstageAddTwoBetween5and10Days,
        BackstageAddThreeBetween0And5Days,
        NeverBelowZero,
        NeverGreaterThan50
    }
}
