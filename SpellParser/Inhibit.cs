namespace SpellParser
{
    internal class Inhibit
    {
        public static string SpellInhibit(double inhibit)
        {
            return inhibit switch
            {
                1 => "Buff",
                2 => "Worn",
                3 => "Buff, Worn",
                4 => "AA",
                5 => "Buff, AA",
                6 => "Worn, AA",
                _ => "UNKNOWN INHIBIT " + inhibit,
            };

        }
    }
}
