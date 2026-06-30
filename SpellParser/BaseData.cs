using static SpellParser.Classes;
using static SpellParser.Skill;
using static SpellParser.Target;

namespace SpellParser
{
    internal class BaseData
    {
        public static List<SpellBaseData> SpellBaseData(string spellFile)
        {
            List<SpellBaseData> spellBaseData = new();

            if (spellFile != string.Empty)
            {
                var parseSpellsFile = File.ReadAllLines(spellFile);
                for (int i = 0; i < parseSpellsFile.Length; i++)
                {
                    var spaField = parseSpellsFile[i].Split("^");

                    ulong spellID = ulong.Parse(spaField[0]);
                    string name = spaField[1];
                    string extraData = spaField[3];
                    ulong spellRange = ulong.Parse(spaField[4]);
                    ulong aeRange = ulong.Parse(spaField[5]);
                    decimal pushBack = decimal.Parse(spaField[6]);
                    decimal pushUp = decimal.Parse(spaField[7]);
                    decimal castingTime = decimal.Parse(spaField[8]) / 1000;
                    decimal restTime = decimal.Parse(spaField[9]) / 1000;
                    decimal recastTime = decimal.Parse(spaField[10]) / 1000;
                    double durationTicks = double.Parse(spaField[11]);
                    double durationTicks2 = double.Parse(spaField[12]);
                    ulong aeDuration = ulong.Parse(spaField[13]);
                    ulong mana = ulong.Parse(spaField[14]);
                    double consumeId = double.Parse(spaField[15]);
                    double consumeId2 = double.Parse(spaField[16]);
                    double consumeid3 = double.Parse(spaField[17]);
                    double consumeid4 = double.Parse(spaField[18]);
                    double consumeCount = double.Parse(spaField[19]);
                    double consumeCount2 = double.Parse(spaField[20]);
                    double consumeCount3 = double.Parse(spaField[21]);
                    double consumeCount4 = double.Parse(spaField[22]);
                    double focusId = double.Parse(spaField[23]);
                    double focusid2 = double.Parse(spaField[24]);
                    double focusid3 = double.Parse(spaField[25]);
                    double focusId4 = double.Parse(spaField[26]);
                    ulong lightType = ulong.Parse(spaField[27]);
                    string beneficial = spaField[28];
                    string resistType = spaField[29];
                    string target = SpellTarget(double.Parse(spaField[30]));
                    string skill = SpellSkill(double.Parse(spaField[32]));
                    string zone = spaField[33];
                    string environment = spaField[34];
                    string timeOfDay = spaField[35];
                    ulong warLvl = ulong.Parse(spaField[36]);
                    ulong clrLvl = ulong.Parse(spaField[37]);
                    ulong palLvl = ulong.Parse(spaField[38]);
                    ulong rngLvl = ulong.Parse(spaField[39]);
                    ulong shdlvl = ulong.Parse(spaField[40]);
                    ulong druLvl = ulong.Parse(spaField[41]);
                    ulong mnkLvl = ulong.Parse(spaField[42]);
                    ulong brdLvl = ulong.Parse(spaField[43]);
                    ulong rogLvl = ulong.Parse(spaField[44]);
                    ulong shmLvl = ulong.Parse(spaField[45]);
                    ulong necLvl = ulong.Parse(spaField[46]);
                    ulong wizLvl = ulong.Parse(spaField[47]);
                    ulong magLvl = ulong.Parse(spaField[48]);
                    ulong encLvl = ulong.Parse(spaField[49]);
                    ulong bstLvl = ulong.Parse(spaField[50]);
                    ulong berLvl = ulong.Parse(spaField[51]);
                    string castingAnimation = spaField[52];
                    string targetAnimation = spaField[53];
                    string travelType = spaField[54];
                    string cancelOnSit = spaField[56];
                    string agnostic = spaField[57];
                    string bertox = spaField[58];
                    string brell = spaField[59];
                    string cazic = spaField[60];
                    string erollisi = spaField[61];
                    string bristlebane = spaField[62];
                    string innoruuk = spaField[63];
                    string karana = spaField[64];
                    string mithanial = spaField[65];
                    string prexus = spaField[66];
                    string quellious = spaField[67];
                    string rallos = spaField[68];
                    string rodcet = spaField[69];
                    string solusek = spaField[70];
                    string tribunal = spaField[71];
                    string tunare = spaField[72];
                    string veeshan = spaField[73];
                    double icon3 = double.Parse(spaField[75]);
                    string interruptable = spaField[77];
                    string resistMod = spaField[78];
                    string deletable = spaField[80];
                    double recourseId = double.Parse(spaField[81]);
                    string partialResist = spaField[82];
                    double shortDuration = double.Parse(spaField[84]);
                    ulong descId = ulong.Parse(spaField[85]);
                    string mainCat = spaField[86];
                    string subCat1 = spaField[87];
                    string subCat2 = spaField[88];
                    string npcNoLos = spaField[89];
                    string reflectable = spaField[91];
                    double hateMod = double.Parse(spaField[92]);
                    double endurance = double.Parse(spaField[96]);
                    double timerId = double.Parse(spaField[97]);
                    string combatSkill = spaField[98];
                    double hateOverride = double.Parse(spaField[99]);
                    double enduranceUpKeep = double.Parse(spaField[100]);
                    string maxHitsType = spaField[101];
                    ulong maxHits = ulong.Parse(spaField[102]);
                    string mgbable = spaField[110];
                    string dispelable = spaField[111];
                    double minResist = double.Parse(spaField[114]);
                    double maxResist = double.Parse(spaField[115]);
                    ulong minViralTime = ulong.Parse(spaField[116]);
                    ulong maxViralTime = ulong.Parse(spaField[117]);
                    ulong particleDuration = ulong.Parse(spaField[118]);
                    double coneStartAngle = double.Parse(spaField[119]);
                    double coneEndAngle = double.Parse(spaField[120]);
                    string sneaking = spaField[121];
                    double durationExtendable = double.Parse(spaField[122]);
                    string durationFrozen = spaField[125];
                    ulong viralRange = ulong.Parse(spaField[126]);
                    decimal songCap = ulong.Parse(spaField[127]);
                    string beneficialBlockable = spaField[130];
                    ulong groupId = ulong.Parse(spaField[132]);
                    ulong rank = ulong.Parse(spaField[133]);
                    string targetRestrict = spaField[136];
                    string allowFastRegen = spaField[137];
                    string castOutOfCombat = spaField[138];
                    string castInCombat = spaField[139];
                    double critChanceCap = double.Parse(spaField[141]);
                    ulong maxTargets = ulong.Parse(spaField[142]);
                    string casterRestrict = spaField[144];
                    string persistAfterDeath = spaField[148];
                    double rangeModCloseDist = double.Parse(spaField[151]);
                    double rangeModCloseMult = double.Parse(spaField[152]);
                    double rangeModFarDist = double.Parse(spaField[153]);
                    double rangeModFarMult = double.Parse(spaField[154]);
                    double minRange = double.Parse(spaField[155]);
                    string cannotRemove = spaField[156];
                    string castInFastRegen = spaField[158];
                    string betaOnly = spaField[159];
                    if (string.IsNullOrEmpty(spaField[164])) 
                    { 
                        double spellLines = 0; 
                    }
                    else
                    {
                        double spellLines = double.Parse(spaField[164]);
                    }

                    spellBaseData.Add(new SpellBaseData()
                    {
                        ID = spellID, //0
                        Name = name, //1
                        DurationTicks = durationTicks, //11
                        GroupID = groupId //132
                    });

                }
            }

            return spellBaseData;
        }

    }
}
