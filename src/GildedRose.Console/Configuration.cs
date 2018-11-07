using GildedRose.Console.Rules;
using System;
using System.Collections.Generic;

namespace GildedRose.Console
{
    public static class Configuration
    {
        private static bool loaded = false;
        public static void ReadConfiguration()
        {
            if (loaded) return;
            var lines = System.IO.File.ReadAllLines("Config.txt");
            var ix = 0;
            if (lines[ix++] != "DefaultRules") throw new Exception("Config.txt not proper formatted");
            var ruleCount = int.Parse(lines[ix++]);
            var defaultRules = new List<Rule>();
            for (int iy = 0; iy < ruleCount; iy++)
            {
                defaultRules.Add((Rule)Activator.CreateInstance(Type.GetType("GildedRose.Console.Rules." + lines[ix++])));
            }
            RuleEngine.RegisterDefault(defaultRules);
            var specialItemCount = int.Parse(lines[ix++]);
            for(int iz = 0; iz<specialItemCount; iz++)
            {
                var name = lines[ix++];
                var count = int.Parse(lines[ix++]);
                var rules = new List<Rule>();
                for (int iy = 0; iy < count; iy++)
                {
                    rules.Add((Rule)Activator.CreateInstance(Type.GetType("GildedRose.Console.Rules." + lines[ix++])));
                }
                RuleEngine.Register(name, rules);
            }
            loaded = true;
        }
    }
}
