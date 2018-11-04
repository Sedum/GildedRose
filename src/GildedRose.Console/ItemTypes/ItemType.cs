using System;

namespace GildedRose.Console.ItemTypes
{
    abstract class ItemType
    {
        protected Item item;

        public ItemType(Item item) => this.item = item;

        public void Update()
        {
            UpdateQuality();
            ValidateQualityLimits();
            UpdateSellIn();
        }

        protected virtual void ValidateQualityLimits()
        {
            item.Quality = Math.Min(50, item.Quality);
            item.Quality = Math.Max(0, item.Quality);
        }

        protected virtual void UpdateSellIn() => item.SellIn--;

        protected abstract void UpdateQuality();
    }
}