namespace SpellParser
{
    internal class Resist
    {
        public static string SpellResist(double resist)
        {
            return resist switch
            {
                -1 => "None", // This doesn"t appear in the RESISTTYPE field but spells will be modified to this value if RESISTTYPE=0 and NO_RESIST
                0 => "Unresistable", // Unresistable except for SPA 180
                1 => "Magic",
                2 => "Fire",
                3 => "Cold",
                4 => "Poison",
                5 => "Disease",
                6 => "Lowest", // Chromatic/lowest
                7 => "Average", // Prismatic/average
                8 => "Physical",
                9 => "Corruption",
                _ => "UNKNOWN RESIST " + resist,
            };

        }
    }
}
