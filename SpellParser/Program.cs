using SpellParser;

string dbstrFile = string.Empty,
    dbstrSource = string.Empty,
    spellsFile = string.Empty,
    spellsSource = string.Empty,
    itemFile = "data/itemlist.txt";

Console.WriteLine("Choose B-Beta, L-Live, T-Test.");
string? parseSection = Console.ReadLine();

if ((parseSection == "B") ||  (parseSection == "Beta"))
{
    dbstrFile = "data/dbstr_usB.txt";
    dbstrSource = "B";
    spellsFile = "data/spells_usB.txt";
    spellsSource = "B";
}
else if ((parseSection == "T") || (parseSection == "Test"))
{
    dbstrFile = "data/dbstr_usT.txt";
    dbstrSource = "T";
    spellsFile = "data/spells_usT.txt";
    spellsSource = "T";
}
else
{
    dbstrFile = "data/dbstr_usL.txt";
    dbstrSource = "L";
    spellsFile = "data/spells_usL.txt";
    spellsSource = "L";
}
if ((File.Exists(dbstrFile)) && (File.Exists(spellsFile)))
{
    Globals.dbstrData = SpellDBFiles.DbstrData(dbstrFile);
    Globals.parsedItems = SpellDBFiles.ParseItems(itemFile);

    Globals.spellBaseData = BaseData.SpellBaseData(spellsFile);
    Globals.spellSlotData = ParseSPA.ParseSPAs(spellsFile);

    foreach (var baseData in Globals.spellBaseData)
    {
        Console.WriteLine($"ID: {baseData.ID} - Name: {baseData.Name}");
    }

    foreach (var slotData in Globals.spellSlotData)
    {
        Console.WriteLine($"ID: {slotData.ID} - Slot: {slotData.Slot} - Data: {slotData.ParsedData}");
    }
    

    Console.WriteLine($"Spell Source: {spellsSource} - DBStr Source: {dbstrSource}");
}
else
{
    Console.WriteLine($"{dbstrFile} OR {spellsFile} Does Not Exist");
}

Console.ReadLine();
