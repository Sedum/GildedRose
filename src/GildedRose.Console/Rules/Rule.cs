namespace GildedRose.Console.Rules
{
    interface Rule
    {
        void Apply(Item item);
        bool IsApplicable(Item item);
    }
}
