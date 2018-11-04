namespace GildedRose.Console.ItemTypes
{
    internal class NormalItem : ItemType
    {
        public NormalItem(Item item) : base(item) {}

        protected override void UpdateQuality() => item.Quality -= (item.SellIn > 0 ? 1 : 2);
    }
}
