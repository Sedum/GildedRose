using GildedRose.Console.Rules;

namespace GildedRose.Console.ItemTypes
{
    class AgedBrieItem : ItemType
    {
        public AgedBrieItem()
        {
            rules.Add(new IncreaseQualityByOneWhenNotExpiredRule());
            rules.Add(new IncreaseQualityByTwoWhenExpiredRule());
            rules.Add(new QualityMaxFiftyRule());
            rules.Add(new ReduceSellInRule());
        }
    }
}
