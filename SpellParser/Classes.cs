namespace SpellParser
{
    internal class Classes
    {
        public static double MaxLevel = 130;
        public class DbstrList
        {
            public ulong ID { get; set; }
            public ulong ID2 { get; set; }
            public string? Description { get; set; }
        }

        public class SpellSlots
        {
            public ulong ID { get; set; }
            public ulong Slot { get; set; }
            public ulong SPA { get; set; }
            public double Base1 { get; set; }
            public double Base2 { get; set; }
            public double Calc { get; set; }
            public double Max { get; set; }
        }

        public class SpellSlotData
        {
            public ulong ID { get; set; }
            public ulong Slot { get; set; }
            public string? ParsedData { get; set; }
        }

        public class SpellBaseData
        {
            public ulong ID { get; set; }
            public string? Name { get; set; }
            public double DurationTicks { get; set; }
        }

        public class ItemData
        {
            public ulong ID { get; set; }
            public string? Name { get; set; }
            public double StackSize { get; set; }
        }
    }
}
