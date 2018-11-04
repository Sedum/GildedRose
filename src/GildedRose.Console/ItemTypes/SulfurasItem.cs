namespace GildedRose.Console.ItemTypes
{
    class SulfurasItem : ItemType
    {
        public SulfurasItem(Item item) : base(item) {}

        protected override void UpdateQuality() {}

        protected override void UpdateSellIn() {}

        protected override void ValidateQualityLimits() {}
    }
}
