using static SpellParser.Calc;
using static SpellParser.Category;
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
                            string varmax = string.Empty;
                            if (max[x] > 1000)
                            {
                                varmax = ", Max Level: " + (max[x] - 1000);
                            }
                            else
                            {
                                if (max[x] == 0)
                                {
                                    varmax = " up to your Level";
                                }
                                else
                                {
                                    varmax = ", Max Level: Yours " + (max[x] < 0 ? " - " + Math.Abs(max[x]) : " + " + max[x]);
                                }
                            }

                            string parsedSPA = ParseSPASlots(spellID, slot[x], spa, base1, base2[x], calc[x], max[x],
                                rank, value, range, repeating, maxLevel, extraData, skill, target, x, varmax);

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
            ulong rank, double value, string range, string repeating, string maxLevel, string extra, string skill, string target, int x, string varmax)
        {
            string location = string.Empty,
                itemName = string.Empty;
            double stackMax;

            switch (spa[x])
            {
                case 0:
                    if ((calc == 2060) || (calc == 2070) || (calc == 2090) || (calc == 2100))
                    {
                        return FormatCount("Current Hit Points", base1[x]) + repeating + range + (base2 > 0 ? " if " + SpellTargetRestrict(base2) : "") + " (Scale: " + (calc - 2000) + " per Item/Player Level)";
                    }
                    else
                    {
                        return FormatCount("Current Hit Points", value) + repeating + range + (base2 > 0 ? " if " + SpellTargetRestrict(base2) : "");
                    }
                case 1:
                    return FormatCountRange("Armor Class", value, (double)Math.Round((decimal)(Math.Abs(value / 4) * 0.265), 0, MidpointRounding.AwayFromZero), (double)Math.Round((decimal)(Math.Abs(value / 4) * 0.35), 0, MidpointRounding.AwayFromZero)) + ", Based on Class";
                case 2:
                    return FormatCount("Attack", value) + range;
                case 3:
                    return FormatPercent("Movement Speed", value) + range;
                case 4:
                    return FormatCount("Strength", value);
                case 5:
                    return FormatCount("Dexterity", value);
                case 6:
                    return FormatCount("Agility", value);
                case 7:
                    return FormatCount("Stamina", value);
                case 8:
                    return FormatCount("Intelligence", value);
                case 9:
                    return FormatCount("Wisdom", value);
                case 10:
                    if ((base1[x] <= 1) || (base1[x] >= 255))
                    {
                        return "";
                    }
                    else
                    {
                        return FormatCount("Charisma", value);
                    }
                case 11:
                    if ((value < 100) && (max > 0) && (value < max)) { value = max; }
                    return FormatPercent("Melee Haste", value - 100);
                case 12:
                    return "Invisibility (Unstable)" + (base1[x] > 1 ? " (Enhanced - " + base1[x] + ")" : "");
                case 13:
                    return "See Invisible" + (base1[x] > 1 ? " (Enhanced - " + base1[x] + ")" : "");
                case 14:
                    return "Enduring Breath";
                case 15:
                    return FormatCount("Current Mana", value) + repeating + range;
                case 18:
                    return "Pacify";
                case 19:
                    return FormatCount("Faction", (value > 300 ? 300 : value));
                case 20:
                    return "Blind";
                case 21:
                    if (base1[x] < 1000)
                    {
                        return "Interrupt Casting";
                    }
                    else if ((base2 != base1[x]) && (base2 != 0))
                    {
                        return "Stun NPC for " + (base1[x] / 1000) + "s (PC for " + (base2 / 1000) + "s)" + maxLevel;
                    }
                    else
                    {
                        return "Stun NPC for " + (base1[x] / 1000) + "s" + maxLevel;
                    }
                case 22:
                    return "Charm" + maxLevel + (base2 > 0 ? " with " + base2 + "% Chance of Memory Blur" : "");
                case 23:
                    return "Fear" + maxLevel;
                case 24:
                    return FormatCount("Stamina Loss", value);
                case 25:
                    return "Set Bind Spot to Current Location";
                case 26:
                    return "Gate " + (base1[x] < 100 ? "(" + base1[x] + "% Chance) " : "") + "to" + (base2 > 1 ? " Secondary" : "") + " Bind Location";
                case 27:
                    return "Dispel (" + value + ")";
                case 28:
                    return "Invisibility to Undead (Not Fixed)";
                case 29:
                    return "Invisibility to Animals (Not Fixed)";
                case 30:
                    return "Decrease Aggro Radius to " + value + maxLevel;
                case 31:
                    return "Mesmerize" + maxLevel;
                case 32:
                    stackMax = Globals.parsedItems.Where(c => c.ID == base1[x]).Select(c => c.StackSize).FirstOrDefault();
                    itemName = Globals.parsedItems.Where(c => c.ID == base1[x]).Select(c => c.Name).FirstOrDefault();
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
                        return "Summon Item: [Item ID " + base1[x] + "] x " + stackMax;
                    }
                    else
                    {
                        return "Summon Item: [IName " + base1[x] + "|" + itemName + "] x " + stackMax;
                    }
                case 33:
                    return "Summon Pet: " + extra;
                case 35:
                    return FormatCount("Disease Counter", value);
                case 36:
                    return FormatCount("Poison Counter", value);
                case 39:
                    return "Limit: No Twincast";
                case 40:
                    return "Invulnerability";
                case 41:
                    return "Destroy the Target";
                case 42:
                    return "Warp a Short Distance in a Random Direction(Shadowstep)";
                case 44:
                    return "Stacking: Delayed Heal Marker (" + value + ")";
                case 46:
                    return FormatCount("Fire Resist", value);
                case 47:
                    return FormatCount("Cold Resist", value);
                case 48:
                    return FormatCount("Poison Resist", value);
                case 49:
                    return FormatCount("Disease Resist", value);
                case 50:
                    return FormatCount("Magic Resist", value);
                case 52:
                    return "Face the Direction of an Undead NPC";
                case 53:
                    return "Face the Direction of a Summoned NPC";
                case 54:
                    return "Face the Direction of an Animal NPC";
                case 55:
                    return "Absorb Damage: 100%, Total: " + (calc == 2200 ? base1[x] + "(Scale: " + (calc - 2000) + " per Item / Player Level)" : value);
                case 56:
                    return "Face North";
                case 57:
                    return "Levitate" + (base2 == 1 ? " While Moving" : "");
                case 58:
                    return "Illusion: " + Illusion.SpellIllusion(base1[x], base2, max);
                case 59:
                    return FormatCount("Damage Shield", -value);
                case 61:
                    return "Identify Item";
                case 63:
                    return "Memory Blur (" + Math.Min((value + 40), 100) + "% Chance)";
                case 64:
                    if ((base2 != base1[x]) && (base2 != 0))
                    {
                        return "Stun and Spin NPC for " + (base1[x] / 1000) + "s (PC for " + (base2 / 1000) + "s) " + maxLevel;
                    }
                    else
                    {
                        return "Stun and Spin NPC for " + (base1[x] / 1000) + "s" + maxLevel;
                    }
                case 65:
                    return "Infravision";
                case 66:
                    return "Ultravision";
                case 67:
                    return "Eye of Zomm";
                case 68:
                    return "Reclaim Pet";
                case 69:
                    return FormatCount("Max Hit Points", value) + range;
                case 71:
                    return "Summon Pet: " + extra;
                case 73:
                    return "Bind Sight";
                case 74:
                    return "Feign Death" + (value < 100 ? " (" + value + "% Chance)" : "");
                case 75:
                    return "Talk as Pet";
                case 76:
                    return "Sentinel";
                case 77:
                    return "Locate Corpse";
                case 78:
                    return "Absorb Spell Damage: 100%, Total " + value;
                case 79:
                    return FormatCount("Current Hit Points", value) + range + (base2 > 0 ? " if " + SpellTargetRestrict(base2) : "");
                case 81:
                    return "Resurrect with " + value + "% Experience Recovered";
                case 82:
                    return "Summon Target Player to Current Location";
                case 83:
                    if ((spa[1] == 146) && (spa[2] == 146))
                    {
                        location = ", Location: " + base1[0] + ", " + base1[1] + ", " + base1[2];
                    }
                    return "Teleport to " + extra + location;
                case 84:
                    return "Gravity Flux";
                case 85:
                    return "Add Melee Proc: [Spell " + base1[x] + "|" + Globals.spellBaseData.Where(c => c.ID == base1[x]).Select(c => c.Name).FirstOrDefault() + "]" + (base2 != 0 ? " with " + base2 + "% Rate Mod" : "");
                case 86:
                    return "Decrease Social Radius to " + value + maxLevel;
                case 87:
                    return FormatPercent("Magnification", value);
                case 88:
                    if ((spa[1] == 146) && (spa[2] == 146))
                    {
                        location = ", Location: " + base1[0] + ", " + base1[1] + ", " + base1[2];
                    }
                    return "Evacuate to " + extra + location;
                case 89:
                    if (base2 <= 0)
                    {
                        return "Multiply Model Height by " + (base1[x] / 100) + "x";
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
                        return "Set Model Height: " + value + (max != 0 ? ", Offset Camera: " + max : "") + (calc != 100 ? ", Animation Speed: " + Math.Round((100 / calc), 2) + "x" : "");
                    }
                case 90:
                    return "Ignore Pet (Pet Invisibility)";
                case 91:
                    return "Summon Corpse, Max Level: " + value;
                case 92:
                    if ((calc == 2400) || (calc == 2800))
                    {
                        return FormatCount("Hate", base1[x]) + " (Scale: " + (calc - 2000) + " per Item/Player Level)";
                    }
                    else
                    {
                        return FormatCount("Hate", value);
                    }
                case 93:
                    return "Stop Rain";
                case 94:
                    return "Cancel if Combat Initiated";
                case 95:
                    return "Sacrifice";
                case 96:
                    return "Inhibit Spell Casting (Spell Silence)";
                case 97:
                    return FormatCount("Max Mana", value);
                case 98:
                    return FormatPercent("Melee Haste", (value - 100)) + " (v98)";
                case 99:
                    return "Root";
                case 100:
                    return FormatCount("Current Hit Points", value) + repeating + range + (base2 > 0 ? " if " + SpellTargetRestrict(base2) : "");
                case 101:
                    return "Increase Current Hit Points by 7500";
                case 102:
                    return "Fear Immunity";
                case 103:
                    return "Summon Pet";
                case 104:
                    if ((spa[1] == 146) && (spa[2] == 146))
                    {
                        location = ", Location: " + base1[0] + ", " + base1[1] + ", " + base1[2];
                    }
                    return "Translocate to " + extra + location;
                case 105:
                    return "Inhibit Gate Spells";
                case 106:
                    return "Summon Warder: " + extra;
                case 108:
                    return "Summon Familiar: " + extra + (base2 > 0 ? " (Ignore Auto Leave)" : "");
                case 109:
                    stackMax = Globals.parsedItems.Where(c => c.ID == base1[x]).Select(c => c.StackSize).FirstOrDefault();
                    itemName = Globals.parsedItems.Where(c => c.ID == base1[x]).Select(c => c.Name).FirstOrDefault();
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
                        return "Summon into Bag: [Item ID " + base1[x] + "] x " + stackMax;
                    }
                    else
                    {
                        return "Summon into Bag: [IName " + base1[x] + "|" + itemName + "] x " + stackMax;
                    }
                case 111:
                    return FormatCount("All Resists", value);
                case 112:
                    return FormatCount("Effective Casting Level", value);
                case 113:
                    return "Summon Mount: " + extra;
                case 114:
                    return FormatPercent("Hate Generated", value);
                case 115:
                    return "Reset Hunger Counter";
                case 116:
                    return FormatCount("Curse Counter", value);
                case 117:
                    return "Make Weapon Magical";
                case 118:
                    return FormatPercent("Singing Amplification", (value * 10));
                case 119:
                    return FormatPercent("Melee Haste", value) + " (v119)";
                case 120:
                    return FormatPercent("Healing Taken", value) + " (v120, Before Crit)";
                case 121:
                case 122:
                case 123:
                    return "Screech";
                case 124:
                case 125:
                case 126:
                case 127:
                case 128:
                case 129:
                case 130:
                case 131:
                case 132:
                case 134:
                    return "Limit Max Level: " + base1[x] + " (Lose " + (base2 == 0 ? 100 : base2) + "% per Level)";
                case 135:
                case 136:
                case 137:
                case 138:
                case 139:
                case 140:
                case 141:
                    return "Limit Max Duration: Instant Spells Only";
                case 142:
                case 143:
                case 144:
                case 145:
                    if ((spa[1] == 146) && (spa[2] == 146))
                    {
                        location = ", Location: " + base1[0] + ", " + base1[1] + ", " + base1[2];
                    }
                    return "Teleport to " + extra + location;
                case 146:
                    return "";
                case 147:
                case 148:
                    return "Stacking: Block New Spell if Slot " + base2 + " is " + SpellEffects(base1[x]) + " and Less Than " + max;
                case 149:
                    return "Stacking: Overwrite Existing Spell if Slot " + base2 + " is " + SpellEffects(base1[x]) + " and Less Than " + max;
                case 150:
                case 151:
                    return "Suspend Pet";
                case 152:
                case 153:
                case 154:
                case 155:
                case 156:
                    return "Illusion: Target";
                case 157:
                case 158:
                    return FormatPercent("Chance to Reflect Spell", base1[x]) + (max != 0 ? " for " + max + "% Base Damage" : "") + (base2 > 0 ? " with " + base2 + " Improved Resist Modifier" : "") + (base2 < 0 ? " with " + Math.Abs(base2) + " Reduced Resist Modifier" : "");
                case 159:
                    return FormatCount("Base Stats", value);
                case 160:
                    return "Intoxicate if Alcohol Tolerance Less Than " + base1[x];
                case 161:
                    return "Absorb Spell Damage: " + value + "%" + (base2 > 0 ? ", Max per Hit: " + base2 : "") + (max > 0 ? ", Total: " + max : "");
                case 162:
                    return "Absorb Melee Damage: " + value + "%" + (base2 > 0 ? ", Max per Hit: " + base2 : "") + (max > 0 ? ", Total: " + max : "");
                case 163:
                case 164:
                case 165:
                case 166:
                case 167:
                case 168:
                case 169:
                case 170:
                case 171:
                case 172:
                case 173:
                case 174:
                    return FormatPercent("Chance to Dodge", value);
                case 175:
                    return FormatPercent("Chance to Parry", value);
                case 176:
                    return FormatPercent("Chance to Dual Wield", value);
                case 177:
                    return FormatPercent("Chance to Double Attack", value);
                case 178:
                    return "Return " + (base1[x] / 10) + "% of Melee Damage as " + (base2 == 0 ? "Hit Points" : (base2 == 2 ? "Endurance" : "Mana")) + (max != 0 ? ", Max per Hit: " + max : "");
                case 179:
                    return "Instrument Modifier: " + skill + " " + value;
                case 180:
                case 181:
                case 182:
                case 183:
                    return "";
                case 184:
                case 185:
                case 186:
                case 187:
                case 188:
                case 189:
                    return FormatCount("Current Endurance", value) + repeating + range;
                case 190:
                    return FormatCount("Max Endurance", value);
                case 191:
                    return "Melee and Skill Silence";
                case 192:
                case 193:
                case 194:
                case 195:
                case 196:
                case 197:
                case 198:
                case 199:
                case 200:
                case 201:
                case 202:
                    return "Project Illusion on Next Spell";
                case 203:
                    return "Mass Group Buff on Next Spell";
                case 204:
                case 205:
                case 206:
                case 207:
                    return "Turn Flesh into Bone Chips";
                case 208:
                case 209:
                case 210:
                case 211:
                case 212:
                case 213:
                case 214:
                case 215:
                case 216:
                case 217:
                case 218:
                case 219:
                case 220:
                    return FormatCount(SpellSkill(base2) + " Damage Bonus", base1[x]);
                case 221:
                case 222:
                case 223:
                case 224:
                case 225:
                case 226:
                    return "Add Two-Handed Bash Ability";
                case 227:
                case 228:
                case 229:
                case 230:
                case 231:
                case 232:
                case 233:
                    return FormatPercent("Food Consumption", -value);
                case 234:
                case 237:
                    return "Enable Pet Ability: Receive Group Buffs";
                case 238:
                case 239:
                case 241:
                case 242:
                case 243:
                case 244:
                case 245:
                case 246:
                case 247:
                case 248:
                case 249:
                case 250:
                case 251:
                case 252:
                case 253:
                case 254:
                    return "";
                case 255:
                case 256:
                case 257:
                    return "Enable Pet Ability: Hold";
                case 258:
                case 259:
                case 260:
                case 262:
                case 263:
                case 264:
                case 265:
                case 266:
                case 267:
                case 268:
                case 269:
                case 270:
                case 271:
                case 272:
                case 273:
                case 274:
                case 275:
                case 276:
                case 277:
                case 278:
                case 279:
                case 280:
                case 281:
                case 282:
                case 283:
                case 284:
                case 285:
                case 286:
                    return FormatCount("Spell Damage", base1[x]) + " (v286, After Crit)";
                case 287:
                case 288:
                case 289:
                case 290:
                case 291:
                case 292:
                case 293:
                case 294:
                case 295:
                case 296:
                case 297:
                case 298:
                case 299:
                case 300:
                case 301:
                case 302:
                case 303:
                case 304:
                case 305:
                case 306:
                case 307:
                    return "Estimate Vendor Value of Item on Cursor(Appraisal)";
                case 308:
                    return "Suspend Minion";
                case 309:
                    return "Teleport to Caster's Bind";
                case 310:
                case 311:
                case 312:
                    return "Sanctuary";
                case 313:
                case 314:
                case 315:
                case 316:
                case 317:
                case 318:
                case 319:
                case 320:
                case 321:
                case 322:
                    return "Gate to Home City";
                case 323:
                case 324:
                case 325:
                case 326:
                case 327:
                case 328:
                case 329:
                case 330:
                case 331:
                case 332:
                    return "Summon to Corpse";
                case 333:
                case 334:
                case 335:
                case 336:
                case 337:
                case 338:
                    return "Summon and Resurrect All Corpses";
                case 339:
                case 340:
                case 341:
                case 342:
                    return "Prevent NPC from Running at Low Health";
                case 343:
                case 344:
                case 345:
                case 346:
                case 347:
                case 348:
                case 349:
                case 350:
                case 351:
                case 353:
                case 357:
                case 358:
                case 359:
                case 360:
                case 361:
                case 362:
                case 363:
                case 364:
                case 365:
                case 366:
                case 367:
                case 368:
                case 369:
                case 370:
                    return FormatCount("Corruption Resist", value);
                case 371:
                case 372:
                case 373:
                case 374:
                case 375:
                case 376:
                    return "Fling";
                case 377:
                case 378:
                case 379:
                case 380:
                case 381:
                case 382:
                case 383:
                case 384:
                    return "Fling to Target";
                case 385:
                case 386:
                case 387:
                case 388:
                    return "Summon All Corpses (From Any Zone)";
                case 389:
                    return "Reset Recast Timers";
                case 390:
                case 391:
                case 392:
                case 393:
                case 394:
                case 395:
                case 396:
                case 397:
                case 398:
                case 399:
                case 400:
                case 401:
                case 402:
                case 403:
                case 404:
                case 405:
                case 406:
                case 407:
                case 408:
                case 409:
                case 410:
                case 411:
                    return "Limit Class: " + (SpellClassesMask)((int)base1[x] >> 1);
                case 412:
                case 413:
                case 414:
                case 415:
                case 416:
                    return FormatCountRange("Armor Class", value, (double)Math.Round((decimal)(Math.Abs(value / 4) * 0.265), 0, MidpointRounding.AwayFromZero), (double)Math.Round((decimal)(Math.Abs(value / 4) * 0.35), 0, MidpointRounding.AwayFromZero)) + ", Based on Class (v416)";
                case 417:
                case 418:
                case 419:
                    return "Add Melee Proc: [Spell " + base1[x] + "|" + Globals.spellBaseData.Where(c => c.ID == base1[x]).Select(c => c.Name).FirstOrDefault() + "]" + (base2 != 0 ? " with " + base2 + "% Rate Mod" : "");
                case 420:
                case 421:
                case 422:
                case 423:
                case 424:
                case 425:
                    return "Flying Animation";
                case 426:
                case 427:
                case 428:
                case 429:
                case 430:
                case 431:
                case 432:
                case 433:
                case 434:
                case 435:
                case 436:
                    return "Toggle: Freeze Buffs";
                case 437:
                case 438:
                case 439:
                case 440:
                case 441:
                case 442:
                case 443:
                case 444:
                case 445:
                case 446:
                case 447:
                case 448:
                case 449:
                case 450:
                    return "Absorb DoT Damage: " + base1[x] + "%" + (base2 > 0 ? ", Max per Hit: " + base2 : "") + (max > 0 ? ", Total: " + max : "");
                case 451:
                case 452:
                case 453:
                case 454:
                case 455:
                case 456:
                case 457:
                case 458:
                case 459:
                case 460:
                    return "Limit Type: Include Non-Focusable";
                case 461:
                case 462:
                case 463:
                case 464:
                case 465:
                case 466:
                case 467:
                    return FormatCount("Damage Shield Taken", base1[x]);
                case 468:
                    return FormatPercent("Damage Shield Taken", base1[x]);
                case 469:
                    return (base1[x] < 100 ? base1[x] + "% Chance to " : "") + "Cast Highest Rank Known: [Group " + base2 + "|" + Globals.spellBaseData.Where(c => c.GroupID == base2).OrderBy(c => c.ID).Select(c => c.Name).FirstOrDefault() + "] (v469)";
                case 470:
                    return (base1[x] < 100 ? base1[x] + "% Chance to " : "") + "Cast Highest Rank Known: [Group " + base2 + "|" + Globals.spellBaseData.Where(c => c.GroupID == base2).OrderBy(c => c.ID).Select(c => c.Name).FirstOrDefault() + "] (v470)";
                case 471:
                    return base1[x] + "% Chance to Repeat Primary Weapon Round at " + base2 + "% Damage";
                case 472:
                    return "Buy AA Rank(" + base1[x] + ")";
                case 473:
                    return FormatPercent("Chance to Double Backstab from Front", base1[x]);
                case 474:
                    return FormatPercent("Pet Critical Hit Damage", base1[x]) + " of Base Damage";
                case 475:
                    return "If Not Item Click: Also Cast [Spell " + base2 + "|" + Globals.spellBaseData.Where(c => c.ID == base2).Select(c => c.Name).FirstOrDefault() + "]";
                case 476:
                    return "Weapon Stance: [Spell " + base2 + "|" + Globals.spellBaseData.Where(c => c.ID == base2).Select(c => c.Name).FirstOrDefault() + "] (" + base1[x] + ")";
                case 477:
                    return "Set to Top of NPC Rampage List (" + base1[x] + "% Chance)";
                case 478:
                    return "Set to Bottom of NPC Rampage List (" + base1[x] + "% Chance)";
                case 479:
                    return "Limit " + (base1[x] < 0 ? "Max" : "Min") + " Value: " + Math.Abs(base1[x]) + " (" + SpellEffects(base2) + " [SPA " + base2 + "])";
                case 480:
                    return "Limit " + (base1[x] < 0 ? "Min" : "Max") + " Value: " + Math.Abs(base1[x]) + " (" + SpellEffects(base2) + " [SPA " + base2 + "])";
                case 481:
                    return "Cast: [Spell " + base2 + "|" + Globals.spellBaseData.Where(c => c.ID == base2).Select(c => c.Name).FirstOrDefault() + "] if Hit by Spell and Conditions are Met" + (base1[x] < 100 ? " (" + base1[x] + "% Chance)" : "");
                case 482:
                    return FormatPercent("Base " + SpellSkill(base2) + " Damage", value);
                case 483:
                    return FormatPercentRange("Spell and DoT Damage Taken", base1[x], base2, false) + " (v483, After Crit)";
                case 484:
                    return FormatCount("Spell Damage Taken", base1[x]) + " (v484, After Crit)";
                case 485:
                    return "Limit Caster Class: " + (SpellClassesMask)((int)base1[x] >> 1);
                case 486:
                    return "Limit: " + (base1[x] == 0 ? "Different" : "Same") + " Caster";
                case 487:
                    return FormatCount(SpellSkill(base2) + " Skill Cap with Recipes", base1[x]);
                case 488:
                    return FormatPercent("Push Taken", -base1[x]);
                case 489:
                    return FormatCount("Endurance Regen Cap", base1[x]);
                case 490:
                    return "Limit Min Recast " + (base1[x] / 1000) + "s";
                case 491:
                    return "Limit Max Recast " + (base1[x] / 1000) + "s";
                case 492:
                    return "Limit Min Endurance Cost: " + base1[x];
                case 493:
                    return "Limit Max Endurance Cost: " + base1[x];
                case 494:
                    return FormatCount("Pet Attack", base1[x]);
                case 495:
                    return "Limit Max Duration: " + (base1[x] * 6) + "s";
                case 496:
                    return FormatPercent("Critical " + SpellSkill(base2) + " Damage", value) + " of Base Damage (Non Stacking)";
                case 497:
                    return (base1[x] == 1 ? "Exclude" : "Include") + " Spells that are Additionally Cast";
                case 498:
                    return FormatPercent("Chance of Additional 1h Primary Attack", value);
                case 499:
                    return FormatPercent("Chance of Additional 1h Secondary Attack", value);
                case 500:
                    return FormatPercent("Spell Haste", value) + " (v500)";
                case 501:
                    return (base1[x] < 0 ? "Increase" : "Decrease") + " Cast Time by " + Math.Abs(base1[x] / 1000) + "s";
                case 502:
                    if ((base2 != base1[x]) && (base2 != 0))
                    {
                        return "Fear Stun NPC for " + (base1[x] / 1000) + "s (PC for " + (base2 / 1000) + "s) " + varmax;
                    }
                    else
                    {
                        return "Fear Stun NPC for " + (base1[x] / 1000) + "s" + varmax;
                    }
                case 503:
                    return FormatPercent((base2 == 0 ? "Rear" : "Frontal") + " Arc Melee Damage", (base1[x] / 10));
                case 504:
                    return FormatCount((base2 == 0 ? "Rear" : "Frontal") + " Arc Melee Damage", base1[x]);
                case 505:
                    return FormatPercent((base2 == 0 ? "Rear" : "Frontal") + " Arc Melee Damage Taken", (base1[x] / 10));
                case 506:
                    return FormatCount((base2 == 0 ? "Rear" : "Frontal") + " Arc Melee Damage Taken", base1[x]);
                case 507:
                    return FormatPercentRange("Spell Damage", (base1[x] / 10), (base2 / 10), false) + " (v507, After Crit)";
                case 509:
                    return "Consume " + (base1[x] / 10) + "% of Hit Points to " + (base2 >= 0 ? "Heal" : "Damage") + " for " + Math.Abs(base2 / 10) + "% of Hit Points";
                case 510:
                    return "Improve Resist Modifier by " + base1[x];
                case 511:
                    return "Limit: 1 Proc per " + (base2 / 1000) + "s (v511)";
                case 512:
                    return "Limit: 1 Proc per " + (base2 / 1000) + "s (v512)";
                case 513:
                    return FormatPercent("Max Mana", (base1[x] / 100));
                case 514:
                    return FormatPercent("Max Endurance", (base1[x] / 100));
                case 515:
                    return FormatPercent("Avoidance", (base1[x] / 100));
                case 516:
                    return FormatPercent("Mitigation", (base1[x] / 100));
                case 517:
                    return FormatPercent("Attack", (base1[x] / 100));
                case 518:
                    return FormatPercent("Accuracy", (base1[x] / 100));
                case 519:
                    return FormatCount("Luck", (base1[x] / 100));
                case 520:
                    return FormatPercent("Luck", (base1[x] / 100));
                case 521:
                    return "Absorb Damage using Endurance: " + (base1[x] / 100) + "%" + (base2 != 10000 ? ", " + (base2 / 10000) + " Endurance per Hit Point" : "") + (max > 0 ? ", Max per Hit: " + max : "");
                case 522:
                    return FormatPercent("Current Mana", (base1[x] / 100)) + " of Total Mana, Max: " + max;
                case 523:
                    return FormatPercent("Current Endurance", (base1[x] / 100)) + " of Total Endurance, Max: " + max;
                case 524:
                    return FormatPercent("Current Hit Points", base1[x]) + " of Total Hit Points per Tick, Max: " + max;
                case 525:
                    return FormatPercent("Current Mana", (base1[x] / 100)) + " of Total Mana per Tick, Max: " + max;
                case 526:
                    return FormatPercent("Current Endurance", (base1[x] / 100)) + " of Total Endurance per Tick, Max: " + max;
                case 527:
                    return FormatCount("Current Hit Points", value) + repeating + range + (base2 > 0 ? " if " + SpellTargetRestrict(base2) : "") + " (v527)";
                case 528:
                    return FormatPercent("Base Spell Effectiveness", value) + " (v528)";
                case 529:
                    return "Limit Spell Line: " + (base1[x] > 0 ? "" : "Exclude ") + "[Line " + Math.Abs(base1[x]) + "|" + Globals.dbstrData.Where(c => c.ID == Math.Abs(base1[x]) && c.ID2 == 27).Select(c => c.Description).FirstOrDefault() + "]";
                case 530:
                    return "Limit Spell Sub Category: " + (base1[x] > 0 ? "" : "Exclude ") + SpellSubCategory(Math.Abs(base1[x])) + " (v530)";
                case 531:
                    return "Use Graphic" + (base1[x] > 0 ? ", Primary: [ITFile " + base1[x] + "]" : "") + (base2 > 0 ? ", Secondary: [ITFile " + base2 + "]" : "") + (max > 0 ? ", Tint: " + max : "");
                case 532:
                    return "Increase Duration by " + (base1[x] * 6) + "s (v532)";
                case 533:
                    return (base1[x] < 0 ? "Increase" : "Decrease") + " Timer by " + (Math.Abs(base1[x] / 1000)) + "s (v533)";
                case 534:
                    return FormatPercentRange("Spell Damage", base1[x], base2, false) + " (v534, Before Crit)";
                case 535:
                    return FormatCount("Spell Damage", base1[x]) + " (v535, Before Crit)";
                case 536:
                    return FormatCount("Healing", base1[x]) + " (v536, Before Crit)";
                default:
                    return "Unknown SPA (" + spa[x] + ")";
            }

        }
    }
}
