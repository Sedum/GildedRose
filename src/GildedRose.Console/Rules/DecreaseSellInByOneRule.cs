namespace GildedRose.Console.Rules
{
    class DecreaseSellInByOneRule : Rule
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
