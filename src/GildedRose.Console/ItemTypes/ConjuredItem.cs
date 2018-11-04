namespace GildedRose.Console.ItemTypes
{
    class ConjuredItem : ItemType
    {
        public ConjuredItem(Item item) : base(item, Rule.SubtractOne, Rule.SubtractOne, Rule.SubtractTwoWhenExpired, Rule.SubtractTwoWhenExpired, Rule.NeverBelowZero) {}
    }
}
