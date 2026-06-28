namespace SpellParser
{
    internal class BodyType
    {
        public static string SpellBodyType(double bodyType)
        {
            return bodyType switch
            {
            0 => "",
            1 => "Humanoid",
            2 => "Werewolf",
            3 => "Undead",
            4 => "Giant",
            5 => "Golem",
            6 => "Extraplanar",
            8 => "Undead Pet",
            9 => "Raid Giant",
            12 => "Vampire",
            13 => "Aten Ha Ra",
            14 => "Greater Akheva",
            15 => "Khati Sha",
            16 => "Seru",
            18 => "Draz Nurakk",
            19 => "Zek",
            20 => "Luggald",
            21 => "Animal",
            22 => "Insect",
            24 or 28 => "Construct/Elemental",
            25 => "Plant",
            26 => "Dragon",
            31 => "Familiar",
            34 => "Lightning Warrior",
            _ => "UNKNOWN BODY TYPE " + bodyType,
            };

        }
    }
}
