namespace SpellParser
{
    internal class Teleport
    {
        public static string SpellTeleport(double teleport)
        {
            return teleport switch
            {
                52584 => "Primary Anchor",
                52585 => "Secondary Anchor",
                50874 => "Guild Anchor",
                _ => "UNKNOWN TELEPORT SPELL " + teleport,
            };

        }
    }
}
