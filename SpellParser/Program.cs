using SpellParser;
using static SpellParser.ParseSPA;

string loadData = Globals.LoadData;
string dbstrFile = String.Empty,
    dbstrSource = String.Empty,
    spellsFile = String.Empty,
    spellsSource = String.Empty,
    finalString = string.Empty;

Console.WriteLine("Choose B-Beta, L-Live, T-Test.");
string? parseSection = Console.ReadLine();

if ((parseSection == "B") ||  (parseSection == "Beta"))
{
    dbstrFile = "dbstr_usB.txt";
    dbstrSource = "B";
    spellsFile = "spells_usB.txt";
    spellsSource = "B";
}
else if ((parseSection == "T") || (parseSection == "Test"))
{
    dbstrFile = "dbstr_usT.txt";
    dbstrSource = "T";
    spellsFile = "spells_usT.txt";
    spellsSource = "T";
}
else
{
    dbstrFile = "dbstr_usL.txt";
    dbstrSource = "L";
    spellsFile = "spells_usL.txt";
    spellsSource = "L";
}
if ((File.Exists(dbstrFile)) && (File.Exists(spellsFile)))
{
    Globals.dbstrData = SpellDBFiles.DbstrData(dbstrFile);
    Globals.spellBaseData = BaseData.SpellBaseData(spellsFile);

    finalString += ParseSPAs(spellsFile);

    Console.WriteLine(finalString);

    Console.WriteLine($"Spell Source: {spellsSource} - DBStr Source: {dbstrSource}");
}
else
{
    Console.WriteLine($"{dbstrFile} OR {spellsFile} Does Not Exist");
}

Console.ReadLine();
