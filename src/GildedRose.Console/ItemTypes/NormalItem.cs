using GildedRose.Console.Rules;
namespace GildedRose.Console.ItemTypes
{
    internal class NormalItem : ItemType
    {
        public NormalItem()
        {
            rules.Add(new ReduceQualityByOneWhenNotExpiredRule());
            rules.Add(new ReduceQualityByTwoWhenExpiredRule());
            rules.Add(new QualityMinZeroRule());
            rules.Add(new ReduceSellInRule());
        }
    }
}
