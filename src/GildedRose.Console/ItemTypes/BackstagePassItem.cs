namespace GildedRose.Console.ItemTypes
{
    class BackstagePassItem : ItemType
    {
        public BackstagePassItem(Item item) : base(item) {}

        protected override void UpdateQuality() => item.Quality += (item.SellIn > 10 ? 1 : (item.SellIn > 5 ? 2 : (item.SellIn > 0 ? 3 : -item.Quality)));
    }
}
