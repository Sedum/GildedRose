using System;
using System.Collections.Generic;

namespace GildedRose.Console
{
    static class RuleEngine
    {
        static public Dictionary<Rule, Action<Item>> Rules = new Dictionary<Rule, Action<Item>>();

        static RuleEngine()
        {
            Rules.Add(Rule.SubtractOneBeforeExipredAndTwoAfter, (Item item) => Delta(item, -1, -2));
            Rules.Add(Rule.SubtractTwoBeforeExipredAndFourAfter, (Item item) => Delta(item, -2, -4));
            Rules.Add(Rule.AddOneBeforeExipredAndTwoAfter, (Item item) => Delta(item, 1, 2));
            Rules.Add(Rule.BackstagePass, (Item item) => BackstagePassLogic(item));
            Rules.Add(Rule.NeverBelowZero, (Item item) => { item.Quality = Math.Max(0, item.Quality); });
            Rules.Add(Rule.NeverGreaterThanFifty, (Item item) => { item.Quality = Math.Min(50, item.Quality); });
            Rules.Add(Rule.ReduceSellInByOne, (Item item) => { item.SellIn--; });
        }

        private static void Delta(Item item, int v1, int v2)
        {
            item.Quality += item.SellIn > 0 ? v1 : v2;
        }

        private static void BackstagePassLogic(Item item)
        {
            switch (item.SellIn)
            {
                case int n when n > 10:
                    item.Quality++;
                    break;
                case int n when n <= 10 && n > 5:
                    item.Quality += 2;
                    break;
                case int n when n <= 5 && n > 0:
                    item.Quality += 3;
                    break;
                default:
                    item.Quality = 0;
                    break;
            }
        }
    }

    public enum Rule
    {
        SubtractOneBeforeExipredAndTwoAfter,
        SubtractTwoBeforeExipredAndFourAfter,
        AddOneBeforeExipredAndTwoAfter,
        BackstagePass,
        NeverBelowZero,
        NeverGreaterThanFifty,
        ReduceSellInByOne
    }
}
