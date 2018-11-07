namespace GildedRose.Console.Rules
{
    class SetQualityToZeroWhenExpiredRule : Rule
    {
        public void Apply(Item item)
        {
            item.Quality = 0;
        }

        public bool IsApplicable(Item item)
        {
            return item.SellIn <= 0;
        }
    }
}
