using System.Collections.Generic;
using System.Linq;

namespace GildedRose.Console.ItemTypes
{
    class BackstagePassItem : ItemType
    {
        public BackstagePassItem(Item item) : base(item, Rule.BackstageAddOneWhenGreaterThen10Days, Rule.BackstageAddTwoBetween5and10Days, Rule.BackstageAddThreeBetween0And5Days, Rule.ZeroWhenExpired, Rule.NeverGreaterThan50) {}
    }
}
