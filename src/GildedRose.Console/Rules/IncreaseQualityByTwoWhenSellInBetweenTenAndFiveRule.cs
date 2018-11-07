namespace GildedRose.Console.Rules
{
    class IncreaseQualityByTwoWhenSellInBetweenTenAndFiveRule : Rule
    {
        public void Apply(Item item)
        {
            item.Quality += 2;
        }

        public bool IsApplicable(Item item)
        {
            return item.SellIn > 5 && item.SellIn <= 10;
        }
    }
}
