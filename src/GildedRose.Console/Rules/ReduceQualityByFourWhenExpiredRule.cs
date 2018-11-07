namespace GildedRose.Console.Rules
{
    class ReduceQualityByFourWhenExpiredRule : Rule
    {
        public void Apply(Item item)
        {
            item.Quality -= 4;
        }

        public bool IsApplicable(Item item)
        {
            return item.SellIn <= 0;
        }
    }
}
