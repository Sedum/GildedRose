namespace GildedRose.Console.ItemTypes
{
    class ConjuredItem : ItemType
    {
        public ConjuredItem(Item item) : base(item) {}

        protected override void UpdateQuality() => item.Quality -= (item.SellIn > 0 ? 2 : 4);
    }
}
