namespace GildedRose.Console.Rules
{
    class ReduceSellInRule : Rule
    {
        public void Apply(Item item)
        {
            item.SellIn--;
        }

        public bool IsApplicable(Item item)
        {
            return true;
        }
    }
}
