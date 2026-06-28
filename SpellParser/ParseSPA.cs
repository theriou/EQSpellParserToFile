using static SpellParser.Calc;
using static SpellParser.Classes;
using static SpellParser.ClassLimit;
using static SpellParser.Effects;
using static SpellParser.Format;
using static SpellParser.Skill;
using static SpellParser.Target;

namespace SpellParser
{
    internal class ParseSPA
    {
        public static List<SpellSlotData> ParseSPAs(string spellFile)
        {
            string toParse = string.Empty;
            List<SpellSlotData> spellSlotData = new();

            if (spellFile != string.Empty)
            {
                var parseSpellsFile = File.ReadAllLines(spellFile);
                for (int i = 0; i < parseSpellsFile.Length; i++)
                {
                    List<ulong> slot = new(),
                        spa = new();
                    List<double> base1 = new(),
                        base2 = new(),
                        calc = new(),
                        max = new();
                    var spaField = parseSpellsFile[i].Split("^");

                    ulong spellID = ulong.Parse(spaField[0]);
                    string extraData = spaField[3];
                    double durationTicks = double.Parse(spaField[11]);
                    double durationTicks2 = double.Parse(spaField[12]);
                    string target = SpellTarget(double.Parse(spaField[30]));
                    string skill = SpellSkill(double.Parse(spaField[32]));
                    ulong rank = ulong.Parse(spaField[133]);

                    if (spaField[165].Contains('$'))
                    {
                        toParse = "yes";
                        var spaSlotSplit = spaField[165].Split("$");
                        foreach (var spas in spaSlotSplit)
                        {
                            var spaSlots = spas.Split("|");
                            slot.Add(ulong.Parse(spaSlots[0]));
                            spa.Add(ulong.Parse(spaSlots[1]));
                            base1.Add(double.Parse(spaSlots[2]));
                            base2.Add(double.Parse(spaSlots[3]));
                            calc.Add(double.Parse(spaSlots[4]));
                            max.Add(double.Parse(spaSlots[5]));

                            //Console.WriteLine(spellID + " - " + spa);
                        }
                    }
                    else if (!string.IsNullOrEmpty(spaField[165]))
                    {
                        toParse = "yes";
                        var spaSlots = spaField[165].Split("|");
                        slot.Add(ulong.Parse(spaSlots[0]));
                        spa.Add(ulong.Parse(spaSlots[1]));
                        base1.Add(double.Parse(spaSlots[2]));
                        base2.Add(double.Parse(spaSlots[3]));
                        calc.Add(double.Parse(spaSlots[4]));
                        max.Add(double.Parse(spaSlots[5]));

                        //Console.WriteLine(spellID + " - " + spa);
                    }

                    if (toParse == "yes")
                    {
                        for (int x = 0; x < slot.Count; x++)
                        {
                            double durationTicks1 = CalcDuration(durationTicks, durationTicks2, MaxLevel);
                            double value = CalcValue(calc[x], base1[x], max[x], 1, MaxLevel, spa[x], spellID);
                            string range = CalcValueRange(calc[x], base1[x], max[x], durationTicks1, MaxLevel, spa[x], spellID);
                            string repeating = (durationTicks1 > 1) ? " per Tick" : "";
                            string maxLevel = (max[x] > 0 ? " up to Level " + max[x] : "");
                            extraData = (extraData == "same" ? "Safe Spot in Zone" : extraData);
                            if (rank == 5) { rank = 2; }
                            if (rank == 10) { rank = 3; }

                            string parsedSPA = ParseSPASlots(spellID, slot[x], spa, base1, base2[x], calc[x], max[x],
                                rank, value, range, repeating, maxLevel, extraData, skill, target, x);

                            if (!string.IsNullOrEmpty(parsedSPA))
                            {
                                spellSlotData.Add(new SpellSlotData()
                                {
                                    ID = spellID,
                                    Slot = slot[x],
                                    ParsedData = parsedSPA,
                                });
                            }
                        }
                    }

                }
            }

            return spellSlotData;
        }

        public static string ParseSPASlots(ulong spellID, ulong slot, List<ulong> spa, List<double> base1, double base2, double calc, double max,
            ulong rank, double value, string range, string repeating, string maxLevel, string extra, string skill, string target, int x)
        {
            string finalString = string.Empty, 
                location = string.Empty;

            switch (spa[x])
            {
                case 0:
                    if ((calc == 2060) || (calc == 2070) || (calc == 2090) || (calc == 2100))
                    {
                        finalString = FormatCount("Current Hit Points", base1[x]) + repeating + range + (base2 > 0 ? " if " + SpellTargetRestrict(base2) : "") + " (Scale: " + (calc - 2000) + " per Item/Player Level)";
                    }
                    else
                    {
                        finalString = FormatCount("Current Hit Points", value) + repeating + range + (base2 > 0 ? " if " + SpellTargetRestrict(base2) : "");
                    }
                    break;
                case 1:
                    finalString = FormatCountRange("Armor Class", value, (double)Math.Round((decimal)(Math.Abs(value / 4) * 0.265), 0, MidpointRounding.AwayFromZero), (double)Math.Round((decimal)(Math.Abs(value / 4) * 0.35), 0, MidpointRounding.AwayFromZero)) + ", Based on Class";
                    break;
                case 2:
                    finalString = FormatCount("Attack", value) + range;
                    break;
                case 3:
                    finalString = FormatPercent("Movement Speed", value) + range;
                    break;
                case 4:
                    finalString = FormatCount("Strength", value);
                    break;
                case 5:
                    finalString = FormatCount("Dexterity", value);
                    break;
                case 6:
                    finalString = FormatCount("Agility", value);
                    break;
                case 7:
                    finalString = FormatCount("Stamina", value);
                    break;
                case 8:
                    finalString = FormatCount("Intelligence", value);
                    break;
                case 9:
                    finalString = FormatCount("Wisdom", value);
                    break;
                case 10:
                    if ((base1[x] <= 1) || (base1[x] >= 255))
                    {
                        finalString = "";
                    }
                    else
                    {
                        finalString = FormatCount("Charisma", value);
                    }
                    break;
                case 11:
                    if ((value < 100) && (max > 0) && (value < max)) { value = max; }
                    finalString = FormatPercent("Melee Haste", value - 100);
                    break;
                case 12:
                    finalString = "Invisibility (Unstable)" + (base1[x] > 1 ? " (Enhanced - " + base1[x] + ")" : "");
                    break;
                case 13:
                    finalString = "See Invisible" + (base1[x] > 1 ? " (Enhanced - " + base1[x] + ")" : "");
                    break;
                case 14:
                    finalString = "Enduring Breath";
                    break;
                case 15:
                    finalString = FormatCount("Current Mana", value) + repeating + range;
                    break;
                case 18:
                    finalString = "Pacify";
                    break;
                case 19:
                    finalString = FormatCount("Faction", (value > 300 ? 300 : value));
                    break;
                case 20:
                    finalString = "Blind";
                    break;
                case 21:
                    if (base1[x] < 1000)
                    {
                        finalString = "Interrupt Casting";
                    }
                    else if ((base2 != base1[x]) && (base2 != 0))
                    {
                        finalString = "Stun NPC for " + (base1[x] / 1000) + "s (PC for " + (base2 / 1000) + "s)" + maxLevel;
                    }
                    else
                    {
                        finalString = "Stun NPC for " + (base1[x] / 1000) + "s" + maxLevel;
                    }
                    break;
                case 22:
                    finalString = "Charm" + maxLevel + (base2 > 0 ? " with " + base2 + "% Chance of Memory Blur" : "");
                    break;
                case 23:
                    finalString = "Fear" + maxLevel;
                    break;
                case 24:
                    finalString = FormatCount("Stamina Loss", value);
                    break;
                case 25:
                    finalString = "Set Bind Spot to Current Location";
                    break;
                case 26:
                    finalString = "Gate " + (base1[x] < 100 ? "(" + base1[x] + "% Chance) " : "") + "to" + (base2 > 1 ? " Secondary" : "") + " Bind Location";
                    break;
                case 27:
                    finalString = "Dispel (" + value + ")";
                    break;
                case 28:
                    finalString = "Invisibility to Undead (Not Fixed)";
                    break;
                case 29:
                    finalString = "Invisibility to Animals (Not Fixed)";
                    break;
                case 30:
                    finalString = "Decrease Aggro Radius to " + value + maxLevel;
                    break;
                case 31:
                    finalString = "Mesmerize" + maxLevel;
                    break;
                case 32:
                    double stackMax = Globals.parsedItems.Where(c => c.ID == base1[x]).Select(c => c.StackSize).FirstOrDefault();
                    string itemName = Globals.parsedItems.Where(c => c.ID == base1[x]).Select(c => c.Name).FirstOrDefault();
                    if (stackMax < 1) 
                    { 
                        stackMax = base2; 
                    }
                    else if (stackMax < base2) { }
                    else 
                    { 
                        stackMax = base2; 
                    }
                    if (stackMax == 0) 
                    { 
                        stackMax = 1; 
                    }
                    if (string.IsNullOrEmpty(itemName))
                    {
                        finalString = "Summon Item: [Item ID " + base1[x] + "] x " + stackMax;
                    }
                    else
                    {
                        finalString = "Summon Item: [IName " + base1[x] + "|" + itemName + "] x " + stackMax;
                    }
                    break;
                case 33:
                    finalString = "Summon Pet: " + extra;
                    break;
                case 35:
                    finalString = FormatCount("Disease Counter", value);
                    break;
                case 36:
                    finalString = FormatCount("Poison Counter", value);
                    break;
                case 39:
                    finalString = "Limit: No Twincast";
                    break;
                case 40:
                    finalString = "Invulnerability";
                    break;
                case 41:
                    finalString = "Destroy the Target";
                    break;
                case 42:
                    finalString = "Warp a Short Distance in a Random Direction(Shadowstep)";
                    break;
                case 44:
                    finalString = "Stacking: Delayed Heal Marker (" + value + ")";
                    break;
                case 46:
                    finalString = FormatCount("Fire Resist", value);
                    break;
                case 47:
                    finalString = FormatCount("Cold Resist", value);
                    break;
                case 48:
                    finalString = FormatCount("Poison Resist", value);
                    break;
                case 49:
                    finalString = FormatCount("Disease Resist", value);
                    break;
                case 50:
                    finalString = FormatCount("Magic Resist", value);
                    break;
                case 52:
                    finalString = "Face the Direction of an Undead NPC";
                    break;
                case 53:
                    finalString = "Face the Direction of a Summoned NPC";
                    break;
                case 54:
                    finalString = "Face the Direction of an Animal NPC";
                    break;
                case 55:
                    finalString = "Absorb Damage: 100%, Total: " + (calc == 2200 ? base1[x] + "(Scale: " + (calc - 2000) + " per Item / Player Level)" : value);
                    break;
                case 56:
                    finalString = "Face North";
                    break;
                case 57:
                    finalString = "Levitate" + (base2 == 1 ? " While Moving" : "");
                    break;
                case 58:
                    finalString = "Illusion: " + Illusion.SpellIllusion(base1[x], base2, max);
                    break;
                case 59:
                    finalString = FormatCount("Damage Shield", -value);
                    break;
                case 61:
                    finalString = "Identify Item";
                    break;
                case 63:
                    finalString = "Memory Blur (" + Math.Min((value + 40), 100) + "% Chance)";
                    break;
                case 64:
                    if ((base2 != base1[x]) && (base2 != 0))
                    {
                        finalString = "Stun and Spin NPC for " + (base1[x] / 1000) + "s (PC for " + (base2 / 1000) + "s) " + maxLevel;
                    }
                    else
                    {
                        finalString = "Stun and Spin NPC for " + (base1[x] / 1000) + "s" + maxLevel;
                    }
                    break;
                case 65:
                    finalString = "Infravision";
                    break;
                case 66:
                    finalString = "Ultravision";
                    break;
                case 67:
                    finalString = "Eye of Zomm";
                    break;
                case 68:
                    finalString = "Reclaim Pet";
                    break;
                case 69:
                    finalString = FormatCount("Max Hit Points", value) + range;
                    break;
                case 71:
                    finalString = "Summon Pet: " + extra;
                    break;
                case 73:
                    finalString = "Bind Sight";
                    break;
                case 74:
                    finalString = "Feign Death" + (value < 100 ? " (" + value + "% Chance)" : "");
                    break;
                case 75:
                    finalString = "Talk as Pet";
                    break;
                case 76:
                    finalString = "Sentinel";
                    break;
                case 77:
                    finalString = "Locate Corpse";
                    break;
                case 78:
                    finalString = "Absorb Spell Damage: 100%, Total " + value;
                    break;
                case 79:
                    finalString = FormatCount("Current Hit Points", value) + range + (base2 > 0 ? " if " + SpellTargetRestrict(base2) : "");
                    break;
                case 81:
                    finalString = "Resurrect with " + value + "% Experience Recovered";
                    break;
                case 82:
                    finalString = "Summon Target Player to Current Location";
                    break;
                case 83:
                    if ((spa[1] == 146) && (spa[2] == 146))
                    {
                        location = ", Location: " + base1[0] + ", " + base1[1] + ", " + base1[2];
                    }
                    finalString = "Teleport to " + extra + location;
                    break;
                case 84:
                    finalString = "Gravity Flux";
                    break;
                case 85:
                    finalString = "Add Melee Proc: [Spell " + base1[x] + "|" + Globals.spellBaseData.Where(c => c.ID == base1[x]).Select(c => c.Name).FirstOrDefault() + "]" + (base2 != 0 ? " with " + base2 + "% Rate Mod" : "");
                    break;
                case 86:
                    finalString = "Decrease Social Radius to " + value + maxLevel;
                    break;
                case 87:
                    finalString = FormatPercent("Magnification", value);
                    break;
                case 88:
                    if ((spa[1] == 146) && (spa[2] == 146))
                    {
                        location = ", Location: " + base1[0] + ", " + base1[1] + ", " + base1[2];
                    }
                    finalString = "Evacuate to " + extra + location;
                    break;
                case 89:
                    if (base2 <= 0)
                    {
                        finalString = "Multiply Model Height by " + (base1[x] / 100) + "x";
                    }
                    else
                    {
                        x = (x > 0 ? (x - 1) : 0);
                        value = (base1[x] / 100) * base2;
                        if ((spa[x]) == 58) { }
                        else
                        { 
                            if (value > 7) { value = 7; }
                            if (value < 3) { value = 3; }
                        }
                        finalString = "Set Model Height: " + value + (max != 0 ? ", Offset Camera: " + max : "") + (calc != 100 ? ", Animation Speed: " + Math.Round((100 / calc), 2) + "x" : "");
                    }
                    break;
                case 90:
                    finalString = "Ignore Pet (Pet Invisibility)";
                    break;
                case 91:
                    finalString = "Summon Corpse, Max Level: " + value;
                    break;
                case 92:
                    if ((calc == 2400) || (calc == 2800))
                    {
                        finalString = FormatCount("Hate", base1[x]) + " (Scale: " + (calc - 2000) + " per Item/Player Level)";
                    }
                    else
                    {
                        finalString = FormatCount("Hate", value);
                    }
                    break;
                case 93:
                    finalString = "Stop Rain";
                    break;
                case 94:
                    finalString = "Cancel if Combat Initiated";
                    break;
                case 95:
                    finalString = "Sacrifice";
                    break;
                case 96:
                    finalString = "Inhibit Spell Casting (Spell Silence)";
                    break;
                case 97:
                    finalString = FormatCount("Max Mana", value);
                    break;
                case 98:
                    finalString = FormatPercent("Melee Haste", (value - 100)) + " (v98)";
                    break;
                case 99:
                    finalString = "Root";
                    break;
                case 100:
                    finalString = FormatCount("Current Hit Points", value) + repeating + range + (base2 > 0 ? " if " + SpellTargetRestrict(base2) : "");
                    break;
                case 101:
                    finalString = "Increase Current Hit Points by 7500";
                    break;
                case 102:
                    finalString = "Fear Immunity";
                    break;
                case 103:
                    finalString = "Summon Pet";
                    break;



                case 134:
                    finalString = "Limit Max Level: " + base1[x] + " (Lose " + (base2 == 0 ? 100 : base2) + "% per Level)";
                    break;



                case 148:
                    finalString = "Stacking: Block New Spell if Slot " + base2 + " is " + SpellEffects(base1[x]) + " and Less Than " + max;
                    break;
                case 149:
                    finalString = "Stacking: Overwrite Existing Spell if Slot " + base2 + " is " + SpellEffects(base1[x]) + " and Less Than " + max;
                    break;



                case 158:
                    finalString = FormatPercent("Chance to Reflect Spell", base1[x]) + (max != 0 ? " for " + max + "% Base Damage" : "") + (base2 > 0 ? " with " + base2 + " Improved Resist Modifier" : "") + (base2 < 0 ? " with " + Math.Abs(base2) + " Reduced Resist Modifier" : "");
                    break;



                case 161:
                    finalString = "Absorb Spell Damage: " + value + "%" + (base2 > 0 ? ", Max per Hit: " + base2 : "") + (max > 0 ? ", Total: " + max : "");
                    break;
                case 162:
                    finalString = "Absorb Melee Damage: " + value + "%" + (base2 > 0 ? ", Max per Hit: " + base2 : "") + (max > 0 ? ", Total: " + max : "");
                    break;



                case 174:
                    finalString = FormatPercent("Chance to Dodge", value);
                    break;



                case 177:
                    finalString = FormatPercent("Chance to Double Attack", value);
                    break;



                case 183:
                    finalString = "";
                    break;



                case 189:
                    finalString = FormatCount("Current Endurance", value) + repeating + range;
                    break;
                case 190:
                    finalString = FormatCount("Max Endurance", value);
                    break;



                case 220:
                    finalString = FormatCount(SpellSkill(base2) + " Damage Bonus", base1[x]);
                    break;



                case 233:
                    finalString = FormatPercent("Food Consumption", -value);
                    break;



                case 254:
                    finalString = "";
                    break;



                case 286:
                    finalString = FormatCount("Spell Damage", base1[x]) + " (v286, After Crit)";
                    break;



                case 370:
                    finalString = FormatCount("Corruption Resist", value);
                    break;



                case 411:
                    finalString = "Limit Class: " + (SpellClassesMask)((int)base1[x] >> 1);
                    break;



                case 419:
                    finalString = "Add Melee Proc: [Spell " + base1[x] + "|" + Globals.spellBaseData.Where(c => c.ID == base1[x]).Select(c => c.Name).FirstOrDefault() + "]" + (base2 != 0 ? " with " + base2 + "% Rate Mod" : "");
                    break;



                case 450:
                    finalString = "Absorb DoT Damage: " + base1[x] + "%" + (base2 > 0 ? ", Max per Hit: " + base2 : "") + (max > 0 ? ", Total: " + max : "");
                    break;



                case 467:
                    finalString = FormatCount("Damage Shield Taken", base1[x]);
                    break;



                default:
                    finalString = "Unknown SPA (" + spa[x] + ")";
                    break;
            }

            return finalString;
        }
    }
}
