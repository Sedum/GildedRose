namespace GildedRose.Console.ItemTypes
{
    class AgedBrieItem : ItemType
    {
        public AgedBrieItem(Item item) : base(item, Rule.AddOne, Rule.AddTwoWhenExpired, Rule.NeverGreaterThan50) { }
    }
}
