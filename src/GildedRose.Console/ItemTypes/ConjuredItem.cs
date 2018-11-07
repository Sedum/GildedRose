using GildedRose.Console.Rules;

namespace GildedRose.Console.ItemTypes
{
    class ConjuredItem : ItemType
    {
        public ConjuredItem()
        {
            rules.Add(new ReduceQualityByTwoWhenNotExpiredRule());
            rules.Add(new ReduceQualityByFourWhenExpiredRule());
            rules.Add(new QualityMinZeroRule());
            rules.Add(new ReduceSellInRule());
        }
    }
}
