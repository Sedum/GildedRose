namespace GildedRose.Console.ItemTypes
{
    class AgedBrieItem : ItemType
    {
        public AgedBrieItem(Item item) : base(item) {}

        protected override void UpdateQuality() => item.Quality += (item.SellIn > 0 ? 1 : 2);
    }
}
