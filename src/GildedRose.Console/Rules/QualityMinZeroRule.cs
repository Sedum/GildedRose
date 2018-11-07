using System;

namespace GildedRose.Console.Rules
{
    class QualityMinZeroRule : Rule
    {
        public void Apply(Item item)
        {
            item.Quality = Math.Max(0, item.Quality);
        }

        public bool IsApplicable(Item item)
        {
            return true;
        }
    }
}
