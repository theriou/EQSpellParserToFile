namespace SpellParser
{
    internal class Category
    {
        public static string SpellCategory(double category)
        {
            return category switch
            {
                1 => "Beneficial",
                2 => "Cures",
                3 => "Damage",
                4 => "Detrimental",
                5 => "Heals",
                6 => "Heals and Damage",
                7 => "Summons",
                8 => "Transportations",
                _ => "UNKNOWN SPELL CLASS " + category,
            };

        }

        public static string SpellSubCategory(double subCategory)
        {
            return subCategory switch
            {
                5 => "Ethereal Nukes",
                8 => "Group Cures",
                36 => "Mana Regens",
                _ => "UNKNOWN SPELL SUB CLASS " + subCategory,
            };

        }
    }
}
