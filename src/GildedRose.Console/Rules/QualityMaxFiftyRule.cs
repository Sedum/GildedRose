using System;

namespace GildedRose.Console.Rules
{
    class QualityMaxFiftyRule : Rule
    {
        public void Apply(Item item)
        {
            item.Quality = Math.Min(50, item.Quality);
        }

        public bool IsApplicable(Item item)
        {
            return true;
        }
    }
}
