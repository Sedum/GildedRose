namespace GildedRose.Console.Rules
{
    class IncreaseQualityByOneWhenSellInGreaterThenTenRule : Rule
    {
        public void Apply(Item item)
        {
            item.Quality++;
        }

        public bool IsApplicable(Item item)
        {
            return item.SellIn > 10;
        }
    }
}
