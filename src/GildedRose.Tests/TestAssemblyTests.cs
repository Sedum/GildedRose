using GildedRose.Console;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        private const string NORMAL = "foo";
        private const string AGED_BRIE = "Aged Brie";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        private const string BACKSTAGEPASS = "Backstage passes to a TAFKAL80ETC concert";
        private const string CONJURED = "Conjured Mana Cake";

        public TestAssemblyTests()
        {
            Configuration.ReadConfiguration();
        }

        [Fact]
        public void TestSulfuras()
        {
            var items = new List<Item>() { new Item() { Name = SULFURAS, SellIn = 5, Quality = 80 } };
            var app = new Inventory(items);
            app.UpdateQuality();
            Assert.Equal(80, items[0].Quality);
        }

        [Theory]
        [InlineData(10, 10, 9, 9)]
        [InlineData(1, 10, 0, 9)]
        [InlineData(0, 10, -1, 8)]
        [InlineData(10, 1, 9, 0)]
        [InlineData(0, 1, -1, 0)]
        public void TestNormal(int sellIn, int quality, int expected_sellIn, int expected_quality)
        {
            var items = new List<Item>() { new Item() { Name = NORMAL, SellIn = sellIn, Quality = quality } };
            var app = new Inventory(items);
            app.UpdateQuality();
            Assert.Equal(NORMAL, items[0].Name);
            Assert.Equal(expected_sellIn, items[0].SellIn);
            Assert.Equal(expected_quality, items[0].Quality);
        }

        [Theory]
        [InlineData(10, 10, 9, 11)]
        [InlineData(1, 10, 0, 11)]
        [InlineData(0, 10, -1, 12)]
        [InlineData(10, 50, 9, 50)]
        [InlineData(0, 49, -1, 50)]
        [InlineData(-2, 50, -3, 50)]
        public void TestAgedBrie(int sellIn, int quality, int expected_sellIn, int expected_quality)
        {
            var items = new List<Item>() { new Item() { Name = AGED_BRIE, SellIn = sellIn, Quality = quality } };
            var app = new Inventory(items);
            app.UpdateQuality();
            Assert.Equal(AGED_BRIE, items[0].Name);
            Assert.Equal(expected_sellIn, items[0].SellIn);
            Assert.Equal(expected_quality, items[0].Quality);
        }

        [Theory]
        [InlineData(11, 10, 10, 11)]
        [InlineData(10, 10, 9, 12)]
        [InlineData(6, 10, 5, 12)]
        [InlineData(5, 10, 4, 13)]
        [InlineData(1, 49, 0, 50)]
        [InlineData(0, 25, -1, 0)]
        public void TestBackstagepass(int sellIn, int quality, int expected_sellIn, int expected_quality)
        {
            var items = new List<Item>() { new Item() { Name = BACKSTAGEPASS, SellIn = sellIn, Quality = quality } };
            var app = new Inventory(items);
            app.UpdateQuality();
            Assert.Equal(BACKSTAGEPASS, items[0].Name);
            Assert.Equal(expected_sellIn, items[0].SellIn);
            Assert.Equal(expected_quality, items[0].Quality);
        }
        
        [Theory]
        [InlineData(10, 10, 9, 8)]
        [InlineData(1, 10, 0, 8)]
        [InlineData(0, 10, -1, 6)]
        [InlineData(10, 2, 9, 0)]
        [InlineData(0, 3, -1, 0)]
        public void TestConjured(int sellIn, int quality, int expected_sellIn, int expected_quality)
        {
            var items = new List<Item>() { new Item() { Name = CONJURED, SellIn = sellIn, Quality = quality } };
            var app = new Inventory(items);
            app.UpdateQuality();
            Assert.Equal(CONJURED, items[0].Name);
            Assert.Equal(expected_sellIn, items[0].SellIn);
            Assert.Equal(expected_quality, items[0].Quality);
        }
    }
}