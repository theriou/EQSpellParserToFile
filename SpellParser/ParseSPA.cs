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
        public static string ParseSPAs(string spellFile)
        {
            string finalString = string.Empty,
                toParse = string.Empty;
            ulong slot = 0,
                spa = 0;
            double base1 = 0,
                base2 = 0,
                calc = 0,
                max = 0;


            if (spellFile != string.Empty)
            {
                var parseSpellsFile = File.ReadAllLines(spellFile);
                for (int i = 0; i < parseSpellsFile.Length; i++)
                {
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
                            slot = ulong.Parse(spaSlots[0]);
                            spa = ulong.Parse(spaSlots[1]);
                            base1 = double.Parse(spaSlots[2]);
                            base2 = double.Parse(spaSlots[3]);
                            calc = double.Parse(spaSlots[4]);
                            max = double.Parse(spaSlots[5]);

                            //Console.WriteLine(spellID + " - " + spa);
                        }
                    }
                    else if (!string.IsNullOrEmpty(spaField[165]))
                    {
                        toParse = "yes";
                        var spaSlots = spaField[165].Split("|");
                        slot = ulong.Parse(spaSlots[0]);
                        spa = ulong.Parse(spaSlots[1]);
                        base1 = double.Parse(spaSlots[2]);
                        base2 = double.Parse(spaSlots[3]);
                        calc = double.Parse(spaSlots[4]);
                        max = double.Parse(spaSlots[5]);

                        //Console.WriteLine(spellID + " - " + spa);
                    }

                    if (toParse == "yes")
                    {
                        double durationTicks1 = CalcDuration(durationTicks, durationTicks2, MaxLevel);
                        double value = CalcValue(calc, base1, max, 1, MaxLevel, spa, spellID);
                        string range = CalcValueRange(calc, base1, max, durationTicks1, MaxLevel, spa, spellID);
                        string repeating = (durationTicks1 > 1) ? " per Tick" : "";

                        string parsedSPA = ParseSPASlots(spellID, slot, spa, base1, base2, calc, max,
                            rank, value, range, repeating, MaxLevel, extraData, skill, target);

                        if (!string.IsNullOrEmpty(parsedSPA))
                        {
                            finalString = spellID + "^" + slot + "^" + parsedSPA;
                        }

                        Console.WriteLine(finalString);
                    }
                }
            }

            return finalString;
        }

        public static string ParseSPASlots(ulong spellID, ulong slot, ulong spa, double base1, double base2, double calc, double max,
            ulong rank, double value, string range, string repeating, double maxLevel, string extra, string skill, string target)
        {
            string finalString = string.Empty;

            switch (spa)
            {
                case 0:
                    if ((calc == 2060) || (calc == 2070) || (calc == 2090) || (calc == 2100))
                    {
                        finalString = FormatCount("Current Hit Points", base1) + repeating + range + (base2 > 0 ? " if " + SpellTargetRestrict(base2) : "") + " (Scale: " + (calc - 2000) + " per Item/Player Level)";
                    }
                    else
                    {
                        finalString = FormatCount("Current Hit Points", value) + repeating + range + (base2 > 0 ? " if " + SpellTargetRestrict(base2) : "");
                    }
                    break;
                case 1:
                    finalString = FormatCountRange("Armor Class", value, (double)Math.Round((decimal)(value / 4 * 0.265), 0, MidpointRounding.AwayFromZero), (double)Math.Round((decimal)(value / 4 * 0.35), 0, MidpointRounding.AwayFromZero)) + ", Based on Class";
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
                    if ((base1 <= 1) || (base1 >= 255))
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
                    finalString = "Invisibility (Unstable)" + (base1 > 1 ? " (Enhanced - " + base1 + ")" : "");
                    break;
                case 13:
                    finalString = "See Invisible" + (base1 > 1 ? " (Enhanced - " + base1 + ")" : "");
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
                    if (base1 < 1000)
                    {
                        finalString = "Interrupt Casting";
                    }
                    else if ((base2 != base1) && (base2 != 0))
                    {
                        finalString = "Stun NPC for " + (base1 / 1000) + "s (PC for " + (base2 / 1000) + "s)" + maxLevel;
                    }
                    else
                    {
                        finalString = "Stun NPC for " + (base1 / 1000) + "s" + maxLevel;
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
                    finalString = "Gate " + (base1 < 100 ? "(" + base1 + "% Chance) " : "") + "to" + (base2 > 1 ? " Secondary" : "") + " Bind Location";
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
                    double stackMax = Globals.parsedItems.Where(c => c.ID == base1).Select(c => c.StackSize).FirstOrDefault();
                    if (stackMax < 1) { stackMax = base2; }
                    else if (stackMax < base2) { }
                    else { stackMax = base2; }
                    if (stackMax == 0) { stackMax = 1; }
                    finalString = "Summon Item: [Item ID " + base1 + "] x " + stackMax;
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
                    finalString = "Absorb Damage: 100 %, Total: " + (calc == 2200 ? base1 + "(Scale: " + (calc - 2000) + " per Item / Player Level)" : value);
                    break;
                case 56:
                    finalString = "Face North";
                    break;
                case 57:
                    finalString = "Levitate" + (base2 == 1 ? " While Moving" : "");
                    break;
                case 58:
                    finalString = "Illusion: " + Illusion.SpellIllusion(base1, base2, max);
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
                    if ((base2 != base1) && (base2 != 0))
                    {
                        finalString = "Stun and Spin NPC for " + (base1 / 1000) + "s (PC for " + (base2 / 1000) + "s) " + maxLevel;
                    }
                    else
                    {
                        finalString = "Stun and Spin NPC for " + (base1 / 1000) + "s" + maxLevel;
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


                case 97:
                    finalString = FormatCount("Max Mana", value);
                    break;


                case 134:
                    finalString = "Limit Max Level: " + base1 + " (Lose " + (base2 == 0 ? 100 : base2) + "% per Level)";
                    break;



                case 148:
                    finalString = "Stacking: Block New Spell if Slot " + base2 + " is " + SpellEffects(base1) + " and Less Than " + max;
                    break;
                case 149:
                    finalString = "Stacking: Overwrite Existing Spell if Slot " + base2 + " is " + SpellEffects(base1) + " and Less Than " + max;
                    break;


                case 158:
                    finalString = FormatPercent("Chance to Reflect Spell", base1) + (max != 0 ? " for " + max + "% Base Damage" : "") + (base2 > 0 ? " with " + base2 + " Improved Resist Modifier" : "") + (base2 < 0 ? " with " + Math.Abs(base2) + " Reduced Resist Modifier" : "");
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


                case 189:
                    finalString = FormatCount("Current Endurance", value) + repeating + range;
                    break;
                case 190:
                    finalString = FormatCount("Max Endurance", value);
                    break;


                case 220:
                    finalString = FormatCount(SpellSkill(base2) + " Damage Bonus", base1);
                    break;


                case 233:
                    finalString = FormatPercent("Food Consumption", -value);
                    break;


                case 286:
                    finalString = FormatCount("Spell Damage", base1) + " (v286, After Crit)";
                    break;


                case 370:
                    finalString = FormatCount("Corruption Resist", value);
                    break;


                case 411:
                    finalString = "Limit Class: " + (SpellClassesMask)((int)base1 >> 1);
                    break;


                case 419:
                    finalString = "Add Melee Proc: [Spell " + base1 + "|" + Globals.spellBaseData.Where(c => c.ID == base1).Select(c => c.Name).FirstOrDefault() + "]" + (base2 != 0 ? " with " + base2 + "% Rate Mod" : "");
                    break;


                case 450:
                    finalString = "Absorb DoT Damage: " + base1 + "%" + (base2 > 0 ? ", Max per Hit: " + base2 : "") + (max > 0 ? ", Total: " + max : "");
                    break;


                case 467:
                    finalString = FormatCount("Damage Shield Taken", base1);
                    break;


                default:
                    finalString = "Unknown SPA (" + spa + ")";
                    break;
            }

            return finalString;
        }
    }
}
