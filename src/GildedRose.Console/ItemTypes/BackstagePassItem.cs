using GildedRose.Console.Rules;

namespace GildedRose.Console.ItemTypes
{
    class BackstagePassItem : ItemType
    {
        public BackstagePassItem()
        {
            rules.Add(new IncreaseQualityByOneWhenSellInGreaterThenTenRule());
            rules.Add(new IncreaseQualityByTwoWhenSellInBetweenFiveAndTenRule());
            rules.Add(new IncreaseQualityByThreeWhenSellInBetweenZeroAndFiveRule());
            rules.Add(new SetQualityToZeroWhenExpiredRule());
            rules.Add(new QualityMaxFiftyRule());
            rules.Add(new ReduceSellInRule());
        }
    }
}
