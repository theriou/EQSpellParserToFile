using static SpellParser.Classes;

namespace SpellParser
{
    internal class Globals
    {
        public static string LoadData = string.Empty;

        public static List<SpellSlots> spellSlotData = new();
        public static string spellSlotSave = string.Empty;
        public static string baseSpellSave = string.Empty;

        public static string[] SpellFile = SpellDBFiles.SpellFiles(); //dbstrFile0, dbstrSource1, spellsFile2, spellsSource3

        public static List<DbstrList> dbstrData = SpellDBFiles.DbstrData(SpellFile[0]);

        public static List<SpellBaseData> spellBaseData = BaseData.SpellBaseData(SpellFile[2]);

        public static List<ItemData> parsedItems = SpellDBFiles.ParseItems();
    }
}
