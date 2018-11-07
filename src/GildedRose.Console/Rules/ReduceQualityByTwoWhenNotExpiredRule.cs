namespace GildedRose.Console.Rules
{
    class ReduceQualityByTwoWhenNotExpiredRule : Rule
    {
        public void Apply(Item item)
        {
            item.Quality -= 2;
        }

        public bool IsApplicable(Item item)
        {
            return item.SellIn > 0;
        }
    }
}
