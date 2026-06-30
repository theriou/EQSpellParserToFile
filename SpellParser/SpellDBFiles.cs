using static SpellParser.Classes;

namespace SpellParser
{
    internal class SpellDBFiles
    {
        public static List<ItemData> ParseItems(string itemFile)
        {
            List<ItemData> parsedItems = new();

            var parseItemFile = File.ReadAllLines(itemFile);
            for (int i = 0; i < parseItemFile.Length; i++)
            {
                var itemField = parseItemFile[i].Split("^");
                parsedItems.Add(new ItemData()
                {
                    ID = ulong.Parse(itemField[0]),
                    Name = itemField[1],
                    StackSize = double.Parse(itemField[2])
                });
                //Console.WriteLine($"ID: {ulong.Parse(itemField[0])} - Name: {itemField[1]}");
            }

            return parsedItems;
        }

        public static List<DbstrList> DbstrData(string dbstrFile)
        {
            List<DbstrList> dbstrData = new();

            if (dbstrFile != string.Empty)
            {
                var parseDbstr = File.ReadAllLines(dbstrFile);

                for (int i = 0; i < parseDbstr.Length; i++)
                {
                    var dbstrFields = parseDbstr[i].Split("^");
                    if (ulong.Parse(dbstrFields[1]) is 5 or 6 or 27 or 45)
                    {
                        dbstrData.Add(new DbstrList()
                        {
                            ID = ulong.Parse(dbstrFields[0]),
                            ID2 = ulong.Parse(dbstrFields[1]),
                            Description = dbstrFields[2]
                        });
                        //Console.WriteLine($"ID: {ulong.Parse(dbstrFields[0])} - Description: {dbstrFields[2]}");
                    }
                }
            }

            return dbstrData;
        }

    }
}
