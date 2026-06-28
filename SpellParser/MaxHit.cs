namespace SpellParser
{
    internal class MaxHit
    {
        public static string SpellMaxHit(double maxHit)
        {
            return maxHit switch
            {
                0 => "None",
                1 => "Incoming Hit Attempts",
                2 => "Outgoing Hit Attempts",
                3 => "Incoming Spells",
                4 => "Outgoing Spells",
                5 => "Outgoing Hit Successes",
                6 => "Incoming Hit Successes",
                7 => "Matching Spells",
                8 => "Incoming Hits or Spells",
                9 => "Reflected Spells",
                10 => "Defensive Procs",
                11 => "Offensive Procs",
                13 => "All Incoming Hits, Detrimental Spells and DS",
                14 => "Outgoing Hits Boosted by Buff",
                15 => "Tradeskill Combines",
                _ => "UNKNOWN MAX HIT TYPE " + maxHit,
            };

        }
    }
}
