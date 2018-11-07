namespace GildedRose.Console.Rules
{
    class IncreaseQualityByThreeWhenSellInBetweenZeroAndFiveRule : Rule
    {
        public void Apply(Item item)
        {
            item.Quality += 3;
        }

        public bool IsApplicable(Item item)
        {
            return item.SellIn > 0 && item.SellIn <= 5;
        }
    }
}
