using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRose.Console.ItemTypes
{
    class NormalItem
    {
        internal static void Register(IList<Rule> list)
        {
            list.Add(Rule.SubtractOneBeforeExipredAndTwoAfter);
            list.Add(Rule.NeverBelowZero);
            list.Add(Rule.ReduceSellInByOne);
        }
    }
}
