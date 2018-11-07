using System;
using System.Collections.Generic;
using System.Linq;
using GildedRose.Console.Rules;

namespace GildedRose.Console
{
    static class RuleEngine
    {
        private static Dictionary<string, List<Rule>> map = new Dictionary<string, List<Rule>>();
        private static List<Rule> defaultRules = new List<Rule>();

        public static List<Rule> GetRules(Item item)
        {
            return map.Where(k => item.Name.StartsWith(k.Key))
                .Select(v => v.Value)
                .DefaultIfEmpty(defaultRules)
                .FirstOrDefault()
                .Where(r => r.IsApplicable(item)).ToList();
        }

        internal static void Register(string name, List<Rule> rules) => map.Add(name, rules);

        internal static void RegisterDefault(List<Rule> rules) => defaultRules = rules;
    }
}
