namespace SpellParser
{
    internal class Illusion
    {
        public static string SpellIllusion(double base1, double base2, double max)
        {
            string finalIllusion = string.Empty;

            switch (base1)
            {
                case -1:
                    if (max == 1) { finalIllusion = "Male"; }
                    else if (max == 2) { finalIllusion = "Female"; }
                    else { finalIllusion = "Swap Gender"; }
                    break;
                case 1:
                    finalIllusion = "Human";
                    break;
                case 2:
                    finalIllusion = "Barbarian";
                    break;
                case 3:
                    finalIllusion = "Erudite";
                    break;
                case 4:
                    finalIllusion = "Wood Elf";
                    break;
                case 5:
                    finalIllusion = "High Elf";
                    break;
                case 6:
                    finalIllusion = "Dark Elf";
                    break;
                case 7:
                    finalIllusion = "Half Elf";
                    break;
                case 8:
                    finalIllusion = "Dwarf";
                    break;
                case 9:
                    finalIllusion = "Troll";
                    break;
                case 10:
                    finalIllusion = "Ogre";
                    break;
                case 11:
                    finalIllusion = "Halfling";
                    break;
                case 12:
                    finalIllusion = "Gnome";
                    break;
                case 13:
                    finalIllusion = "Old Aviak";
                    break;
                case 14:
                    finalIllusion = "Old Werewolf";
                    break;
                case 15:
                    finalIllusion = "Old Brownie";
                    break;
                case 16:
                    finalIllusion = "Old Centaur";
                    break;
                case 18:
                    finalIllusion = "Ice Giant";
                    break;
                case 19:
                    finalIllusion = "Trakanon";
                    break;
                case 20:
                    finalIllusion = "Venril Sathir";
                    break;
                case 21:
                    finalIllusion = "Old Evil Eye";
                    break;
                case 22:
                    finalIllusion = "Old Beetle";
                    break;
                case 23:
                    finalIllusion = "Kerran";
                    break;
                case 24:
                    finalIllusion = "Fish";
                    break;
                case 25:
                    finalIllusion = "Old Fairy";
                    break;
                case 27:
                    finalIllusion = "Froglok";
                    break;
                case 28:
                    finalIllusion = "Fungusman";
                    break;
                case 29:
                    finalIllusion = "Old Gargoyle";
                    break;
                case 31:
                    finalIllusion = "Gelatinous Cube";
                    break;
                case 33:
                    finalIllusion = "Ghoul";
                    break;
                case 36:
                    if (base2 == 2) { finalIllusion = "Infected Rat"; }
                    else { finalIllusion = "Rat"; }
                    break;
                case 38:
                    if (base2 == 2) { finalIllusion = "Jungle Spider"; }
                    else { finalIllusion = "Spider"; }
                    break;
                case 39:
                    finalIllusion = "Old Gnoll";
                    break;
                case 40:
                    finalIllusion = "Old Goblin";
                    break;
                case 42:
                    if (base2 == 1) { finalIllusion = "Black Spirit Wolf"; }
                    else if (base2 == 2) { finalIllusion = "White Spirit Wolf"; }
                    else { finalIllusion = "Old Wolf"; }
                    break;
                case 43:
                    if (base2 == 0) { finalIllusion = "Old Bear"; }
                    else if (base2 == 2) { finalIllusion = "Polar Bear"; }
                    else { finalIllusion = "Bear"; }
                    break;
                case 44:
                    finalIllusion = "Freeport Militia";
                    break;
                case 46:
                    finalIllusion = "Imp";
                    break;
                case 48:
                    finalIllusion = "Kobold";
                    break;
                case 51:
                    finalIllusion = "Lizard Man";
                    break;
                case 52:
                    finalIllusion = "Mimic";
                    break;
                case 54:
                    finalIllusion = "Old Orc";
                    break;
                case 56:
                    finalIllusion = "Pixie";
                    break;
                case 57:
                    finalIllusion = "Old Drachnid";
                    break;
                case 58:
                    finalIllusion = "Solusek Ro";
                    break;
                case 62:
                    finalIllusion = "Tunare";
                    break;
                case 63:
                    finalIllusion = "Tiger";
                    break;
                case 65:
                    finalIllusion = "Mayong";
                    break;
                case 66:
                    finalIllusion = "Rallos Zek";
                    break;
                case 68:
                    finalIllusion = "Tentacle Terror";
                    break;
                case 69:
                    finalIllusion = "Will-O-Wisp";
                    break;
                case 70:
                    if (base2 == 0) { finalIllusion = "Female Zombie"; }
                    else if (base2 == 1) { finalIllusion = "Mummy Zombie"; }
                    else { finalIllusion = "Zombie"; }
                    break;
                case 74:
                    finalIllusion = "Piranha";
                    break;
                case 75:
                    if (base2 == 0) { finalIllusion = "Earth Elemental"; }
                    else if (base2 == 1) { finalIllusion = "Fire Elemental"; }
                    else if (base2 == 2) { finalIllusion = "Water Elemental"; }
                    else if (base2 == 3) { finalIllusion = "Air Elemental"; }
                    else { finalIllusion = "Elemental"; }
                    break;
                case 76:
                    if (base2 == 1) { finalIllusion = "Snow Leopard"; }
                    else { finalIllusion = "Puma"; }
                    break;
                case 80:
                    finalIllusion = "Reanimated Hand";
                    break;
                case 81:
                    finalIllusion = "Rivervale Guard";
                    break;
                case 82:
                    finalIllusion = "Old Scarecrow";
                    break;
                case 83:
                    finalIllusion = "Skunk";
                    break;
                case 85:
                    finalIllusion = "Old Skeleton";
                    break;
                case 87:
                    finalIllusion = "Armadillo";
                    break;
                case 89:
                    finalIllusion = "Old Drake";
                    break;
                case 91:
                    finalIllusion = "Old Alligator";
                    break;
                case 94:
                    finalIllusion = "Kaladim Guard";
                    break;
                case 95:
                    finalIllusion = "Old Cazic-Thule";
                    break;
                case 96:
                    finalIllusion = "Cockatrice";
                    break;
                case 98:
                    finalIllusion = "Old Vampire";
                    break;
                case 99:
                    finalIllusion = "Old Amygdalan";
                    break;
                case 100:
                    finalIllusion = "Old Dervish";
                    break;
                case 102:
                    finalIllusion = "Tadpole";
                    break;
                case 103:
                    finalIllusion = "Old Kedge";
                    break;
                case 107:
                    finalIllusion = "Mammoth";
                    break;
                case 109:
                    finalIllusion = "Wasp";
                    break;
                case 110:
                    finalIllusion = "Mermaid";
                    break;
                case 113:
                    finalIllusion = "Drixie";
                    break;
                case 116:
                    finalIllusion = "Seahorse";
                    break;
                case 118:
                    finalIllusion = "Ghost";
                    break;
                case 119:
                    finalIllusion = "Sabertooth";
                    break;
                case 120:
                    finalIllusion = "Spirit Wolf";
                    break;
                case 121:
                    finalIllusion = "Gorgon";
                    break;
                case 122:
                    finalIllusion = "Old Dragon";
                    break;
                case 123:
                    finalIllusion = "Innoruuk";
                    break;
                case 124:
                    finalIllusion = "Unicorn";
                    break;
                case 125:
                    finalIllusion = "Pegasus";
                    break;
                case 126:
                    finalIllusion = "Djinn";
                    break;
                case 127:
                    finalIllusion = "Invisible Man";
                    break;
                case 128:
                    finalIllusion = "Iksar";
                    break;
                case 129:
                    finalIllusion = "Scorpion";
                    break;
                case 130:
                    finalIllusion = "Vah Shir";
                    break;
                case 131:
                    finalIllusion = "Old Sarnak";
                    break;
                case 133:
                    finalIllusion = "Old Drolvarg";
                    break;
                case 134:
                    finalIllusion = "Mosquito";
                    break;
                case 135:
                    finalIllusion = "Rhinoceros";
                    break;
                case 136:
                    finalIllusion = "Xalgoz";
                    break;
                case 137:
                    finalIllusion = "Kunark Goblin";
                    break;
                case 138:
                    finalIllusion = "Yeti";
                    break;
                case 139:
                    finalIllusion = "Iksar2";
                    break;
                case 140:
                    finalIllusion = "Kunark Giant";
                    break;
                case 142:
                    finalIllusion = "Nearby Object";
                    break;
                case 143:
                    finalIllusion = "Tree";
                    break;
                case 145:
                    finalIllusion = "Goo";
                    break;
                case 150:
                    finalIllusion = "Erollisi Marr";
                    break;
                case 151:
                    finalIllusion = "Tribunal";
                    break;
                case 153:
                    finalIllusion = "Bristlebane";
                    break;
                case 155:
                    finalIllusion = "Sarnak Skeleton";
                    break;
                case 156:
                    finalIllusion = "Ratman";
                    break;
                case 161:
                    finalIllusion = "Old Iksar Skeleton";
                    break;
                case 162:
                    finalIllusion = "Man-Eating Plant";
                    break;
                case 163:
                    finalIllusion = "Old Raptor";
                    break;
                case 175:
                    finalIllusion = "Enchanted Armor";
                    break;
                case 176:
                    finalIllusion = "Snow Rabbit";
                    break;
                case 177:
                    finalIllusion = "Walrus";
                    break;
                case 178:
                    finalIllusion = "Geonid";
                    break;
                case 181:
                    finalIllusion = "Tizmak";
                    break;
                case 183:
                    if (base2 == 2) { finalIllusion = "Coldain Citizen"; }
                    else { finalIllusion = "Coldain"; }
                    break;
                case 185:
                    finalIllusion = "Hag";
                    break;
                case 190:
                    finalIllusion = "Othmir";
                    break;
                case 191:
                    finalIllusion = "Ulthork";
                    break;
                case 194:
                    finalIllusion = "Sea Turtle";
                    break;
                case 199:
                    finalIllusion = "Shik`Nar";
                    break;
                case 200:
                    finalIllusion = "Rockhopper";
                    break;
                case 201:
                    finalIllusion = "Underbulk";
                    break;
                case 202:
                    finalIllusion = "Grimling";
                    break;
                case 203:
                    finalIllusion = "Worm";
                    break;
                case 205:
                    finalIllusion = "Shadel";
                    break;
                case 206:
                    finalIllusion = "Owlbear";
                    break;
                case 207:
                    finalIllusion = "Rhino Beetle";
                    break;
                case 209:
                    finalIllusion = "Earth Elemental2";
                    break;
                case 210:
                    finalIllusion = "Air Elemental2";
                    break;
                case 211:
                    finalIllusion = "Water Elemental2";
                    break;
                case 212:
                    finalIllusion = "Fire Elemental2";
                    break;
                case 214:
                    finalIllusion = "Thought Horror";
                    break;
                case 217:
                    finalIllusion = "Shissar";
                    break;
                case 218:
                    finalIllusion = "Fungal Fiend";
                    break;
                case 220:
                    finalIllusion = "Stonegrabber";
                    break;
                case 221:
                    finalIllusion = "Scarlet Cheetah";
                    break;
                case 222:
                    finalIllusion = "Zelniak";
                    break;
                case 223:
                    finalIllusion = "Lightcrawler";
                    break;
                case 224:
                    finalIllusion = "Shadow";
                    break;
                case 225:
                    finalIllusion = "Sunflower";
                    break;
                case 226:
                    finalIllusion = "Sun Revenant";
                    break;
                case 227:
                    finalIllusion = "Shrieker";
                    break;
                case 228:
                    finalIllusion = "Galorian";
                    break;
                case 229:
                    finalIllusion = "Netherbian";
                    break;
                case 230:
                    finalIllusion = "Akheva";
                    break;
                case 232:
                    finalIllusion = "Sonic Wolf";
                    break;
                case 235:
                    finalIllusion = "Wretch";
                    break;
                case 239:
                    finalIllusion = "Guard";
                    break;
                case 261:
                    finalIllusion = "Hraquis";
                    break;
                case 266:
                    finalIllusion = "Knight of Pestilence";
                    break;
                case 267:
                    finalIllusion = "Lepertoloth";
                    break;
                case 279:
                    finalIllusion = "Blood Raven";
                    break;
                case 280:
                    finalIllusion = "Nightmare Gargoyle";
                    break;
                case 285:
                    if (base2 == 1) { finalIllusion = "Boar Beast"; }
                    else { finalIllusion = "Tormentor"; }
                    break;
                case 303:
                    finalIllusion = "Phoenix";
                    break;
                case 314:
                    finalIllusion = "Wrulon";
                    break;
                case 316:
                    finalIllusion = "Poison Frog";
                    break;
                case 319:
                    finalIllusion = "War Boar";
                    break;
                case 323:
                    finalIllusion = "Animated Armor";
                    break;
                case 326:
                    finalIllusion = "Arachnid";
                    break;
                case 330:
                    finalIllusion = "Guktan";
                    break;
                case 331:
                    if (max == 0) { finalIllusion = "Troll Pirate"; }
                    else if (max == 1) { finalIllusion = "Male Troll Pirate"; }
                    else if (max == 2) { finalIllusion = "Female Troll Pirate"; }
                    break;
                case 338:
                    if (max == 0) { finalIllusion = "Gnome Pirate"; }
                    else if (max == 1) { finalIllusion = "Male Gnome Pirate"; }
                    else if (max == 2) { finalIllusion = "Female Gnome Pirate"; }
                    break;
                case 339:
                    if (max == 0) { finalIllusion = "Dark Elf Pirate"; }
                    else if (max == 1) { finalIllusion = "Male Dark Elf Pirate"; }
                    else if (max == 2) { finalIllusion = "Female Dark Elf Pirate"; }
                    break;
                case 340:
                    if (max == 0) { finalIllusion = "Ogre Pirate"; }
                    else if (max == 1) { finalIllusion = "Male Ogre Pirate"; }
                    else if (max == 2) { finalIllusion = "Female Ogre Pirate"; }
                    break;
                case 341:
                    if (max == 0) { finalIllusion = "Human Pirate"; }
                    else if (max == 1) { finalIllusion = "Male Human Pirate"; }
                    else if (max == 2) { finalIllusion = "Female Human Pirate"; }
                    break;
                case 342:
                    if (max == 0) { finalIllusion = "Erudite Pirate"; }
                    else if (max == 1) { finalIllusion = "Male Erudite Pirate"; }
                    else if (max == 2) { finalIllusion = "Female Erudite Pirate"; }
                    break;
                case 344:
                    finalIllusion = "Troll Zombie";
                    break;
                case 349:
                    finalIllusion = "Froglok Skeleton";
                    break;
                case 350:
                    finalIllusion = "Undead Froglok";
                    break;
                case 353:
                    finalIllusion = "Veksar";
                    break;
                case 356:
                    finalIllusion = "Scaled Wolf";
                    break;
                case 360:
                    if (base2 == 1) { finalIllusion = "Nightrage Orphan"; }
                    else { finalIllusion = "Vampire"; }
                    break;
                case 367:
                    if (base2 == 0) { finalIllusion = "Skeleton"; }
                    else if (base2 == 1) { finalIllusion = "Drybone Skeleton"; }
                    else if (base2 == 2) { finalIllusion = "Frostbone Skeleton"; }
                    else if (base2 == 3) { finalIllusion = "Firebone Skeleton"; }
                    else if (base2 == 4) { finalIllusion = "Scorched Skeleton"; }
                    else { finalIllusion = "Skeleton"; }
                    break;
                case 368:
                    finalIllusion = "Mummy";
                    break;
                case 371:
                    finalIllusion = "Froglok Ghost";
                    break;
                case 373:
                    finalIllusion = "Shade";
                    break;
                case 374:
                    if (base2 == 0) { finalIllusion = "Golem"; }
                    else if (base2 == 1) { finalIllusion = "Ice Golem"; }
                    else if (base2 == 3) { finalIllusion = "Crystal Golem"; }
                    else { finalIllusion = "Golem " + base2; }
                    break;
                case 384:
                    finalIllusion = "Jokester";
                    break;
                case 385:
                    finalIllusion = "Nihil";
                    break;
                case 386:
                    finalIllusion = "Trusik";
                    break;
                case 388:
                    finalIllusion = "Hynid";
                    break;
                case 389:
                    finalIllusion = "Turepta";
                    break;
                case 390:
                    finalIllusion = "Cragbeast";
                    break;
                case 391:
                    finalIllusion = "Stonemite";
                    break;
                case 392:
                    finalIllusion = "Ukun";
                    break;
                case 394:
                    finalIllusion = "Ikaav";
                    break;
                case 395:
                    finalIllusion = "Aneuk";
                    break;
                case 396:
                    finalIllusion = "Kyv";
                    break;
                case 397:
                    finalIllusion = "Noc";
                    break;
                case 398:
                    finalIllusion = "Ra`tuk";
                    break;
                case 399:
                    finalIllusion = "Taneth";
                    break;
                case 400:
                    finalIllusion = "Huvul";
                    break;
                case 401:
                    finalIllusion = "Mutna";
                    break;
                case 402:
                    finalIllusion = "Mastruq";
                    break;
                case 403:
                    finalIllusion = "Taelosian";
                    break;
                case 405:
                    finalIllusion = "Stone Worker";
                    break;
                case 406:
                    finalIllusion = "Mata Muram";
                    break;
                case 407:
                    finalIllusion = "Lightning Warrior";
                    break;
                case 409:
                    finalIllusion = "Bazu";
                    break;
                case 410:
                    finalIllusion = "Feran";
                    break;
                case 411:
                    finalIllusion = "Pyrilen";
                    break;
                case 412:
                    finalIllusion = "Chimera";
                    break;
                case 413:
                    finalIllusion = "Dragorn";
                    break;
                case 414:
                    finalIllusion = "Murkglider";
                    break;
                case 415:
                    finalIllusion = "Rat";
                    break;
                case 416:
                    finalIllusion = "Bat";
                    break;
                case 417:
                    finalIllusion = "Gelidran";
                    break;
                case 419:
                    finalIllusion = "Girplan";
                    break;
                case 425:
                    finalIllusion = "Crystal Shard";
                    break;
                case 430:
                    finalIllusion = "Vergalid Drake";
                    break;
                case 431:
                    finalIllusion = "Dervish";
                    break;
                case 432:
                    finalIllusion = "Drake";
                    break;
                case 433:
                    if (base2 == 1) { finalIllusion = "Solusek Goblin"; }
                    else if (base2 == 2) { finalIllusion = "Dagnor Goblin"; }
                    else if (base2 == 3) { finalIllusion = "Valley Goblin"; }
                    else if (base2 == 7) { finalIllusion = "Aqua Goblin"; }
                    else if (base2 == 8) { finalIllusion = "Goblin King"; }
                    else if (base2 == 11) { finalIllusion = "Rallosian Goblin"; }
                    else if (base2 == 12) { finalIllusion = "Frost Goblin"; }
                    else { finalIllusion = "Goblin"; }
                    break;
                case 434:
                    finalIllusion = "Kirin";
                    break;
                case 436:
                    finalIllusion = "Basilisk";
                    break;
                case 439:
                    if (base2 == 9) { finalIllusion = "Domain Prowler"; }
                    else if (base2 == 11) { finalIllusion = "Spectral Tiger"; }
                    else { finalIllusion = "Puma"; }
                    break;
                case 440:
                    finalIllusion = "Spider";
                    break;
                case 441:
                    finalIllusion = "Spider Queen";
                    break;
                case 442:
                    finalIllusion = "Animated Statue";
                    break;
                case 450:
                    finalIllusion = "Lava Spider";
                    break;
                case 451:
                    finalIllusion = "Lava Spider Queen";
                    break;
                case 445:
                    finalIllusion = "Dragon Egg";
                    break;
                case 454:
                    if (base2 == 0) { finalIllusion = "Werewolf"; }
                    else if (base2 == 9) { finalIllusion = "White Werewolf"; }
                    else { finalIllusion = "Werewolf " + base2; }
                    break;
                case 455:
                    if (base2 == 0) { finalIllusion = "Kobold"; }
                    else if (base2 == 2) { finalIllusion = "Kobold King"; }
                    else { finalIllusion = "Kobold " + base2; }
                    break;
                case 456:
                    if (base2 == 0) { finalIllusion = "Sporali"; }
                    else if (base2 == 2) { finalIllusion = "Violet Sporali"; }
                    else if (base2 == 11) { finalIllusion = "Azure Sporali"; }
                    else { finalIllusion = "Sporali " + base2; }
                    break;
                case 457:
                    finalIllusion = "Gnomework";
                    break;
                case 458:
                    if (base2 == 0) { finalIllusion = "Orc"; }
                    else if (base2 == 4) { finalIllusion = "Bloodmoon Orc"; }
                    else { finalIllusion = "Orc " + base2; }
                    break;
                case 461:
                    finalIllusion = "Drachnid";
                    break;
                case 462:
                    finalIllusion = "Drachnid Cocoon";
                    break;
                case 463:
                    finalIllusion = "Fungus Patch";
                    break;
                case 464:
                    if (base2 == 0) { finalIllusion = "Gargoyle"; }
                    else if (base2 == 1) { finalIllusion = "Runed Gargoyle"; }
                    else { finalIllusion = "Gargoyle " + base2; }
                    break;
                case 467:
                    if (base2 == 0) { finalIllusion = "Undead Shiliskin"; }
                    else if (base2 == 5) { finalIllusion = "Armored Shiliskin"; }
                    else { finalIllusion = "Shiliskin " + base2; }
                    break;
                case 468:
                    finalIllusion = "Snake";
                    break;
                case 469:
                    finalIllusion = "Evil Eye";
                    break;
                case 470:
                    finalIllusion = "Minotaur";
                    break;
                case 471:
                    finalIllusion = "Zombie";
                    break;
                case 472:
                    finalIllusion = "Clockwork Boar";
                    break;
                case 473:
                    if ((base2 == 0) || (base2 == 2)) { finalIllusion = "Fairy"; }
                    else if (base2 == 1) { finalIllusion = "Tree Fairy"; }
                    else { finalIllusion = "Fairy"; }
                    break;
                case 474:
                    finalIllusion = "Witheran";
                    break;
                case 475:
                    finalIllusion = "Air Elemental3";
                    break;
                case 476:
                    finalIllusion = "Earth Elemental3";
                    break;
                case 477:
                    finalIllusion = "Fire Elemental3";
                    break;
                case 478:
                    finalIllusion = "Water Elemental3";
                    break;
                case 479:
                    finalIllusion = "Alligator";
                    break;
                case 480:
                    finalIllusion = "Bear";
                    break;
                case 482:
                    finalIllusion = "Wolf";
                    break;
                case 485:
                    finalIllusion = "Spectre";
                    break;
                case 487:
                    finalIllusion = "Banshee";
                    break;
                case 488:
                    finalIllusion = "Banshee2";
                    break;
                case 489:
                    finalIllusion = "Elddar";
                    break;
                case 490:
                    finalIllusion = "Forest Giant";
                    break;
                case 491:
                    finalIllusion = "Bone Golem";
                    break;
                case 494:
                    finalIllusion = "Shambling Mound";
                    break;
                case 495:
                    finalIllusion = "Scrykin";
                    break;
                case 496:
                    finalIllusion = "Treant";
                    break;
                case 497:
                    finalIllusion = "Regal Vampire";
                    break;
                case 504:
                    finalIllusion = "Clockwork Bomb";
                    break;
                case 512:
                    finalIllusion = "Floating Skull";
                    break;
                case 514:
                    finalIllusion = "Totem";
                    break;
                case 519:
                    if (base2 == 0) { finalIllusion = "Unicorn"; }
                    else { finalIllusion = "Nightmare"; }
                    break;
                case 520:
                    if (base2 == 0) { finalIllusion = "Bixie Drone"; }
                    else if (base2 == 2) { finalIllusion = "Bixie Queen"; }
                    else { finalIllusion = "Bixie " + base2; }
                    break;
                case 521:
                    if (base2 == 3) { finalIllusion = "Centaur Warrior"; }
                    else { finalIllusion = "Centaur"; }
                    break;
                case 522:
                    finalIllusion = "Drakkin";
                    break;
                case 524:
                    if (base2 == 0) { finalIllusion = "Gnoll"; }
                    else if (base2 == 1) { finalIllusion = "Undead Gnoll"; }
                    else if (base2 == 2) { finalIllusion = "Mucktail Gnoll"; }
                    else if (base2 == 3) { finalIllusion = "Gnoll Reaver"; }
                    else if (base2 == 4) { finalIllusion = "Blackburrow Gnoll"; }
                    else
                    {
                        finalIllusion = "Gnoll " + base2;
                    }
                    break;
                case 527:
                    finalIllusion = "Hideous Harpy";
                    break;
                case 529:
                    finalIllusion = "Satyr";
                    break;
                case 530:
                    finalIllusion = "Dragon";
                    break;
                case 549:
                    finalIllusion = "New Goo";
                    break;
                case 558:
                    finalIllusion = "Aviak";
                    break;
                case 559:
                    if (base2 == 1) { finalIllusion = "Death Beetle"; }
                    else { finalIllusion = "Beetle"; }
                    break;
                case 561:
                    finalIllusion = "Kedge";
                    break;
                case 562:
                    finalIllusion = "Kerran";
                    break;
                case 563:
                    finalIllusion = "Shissar2";
                    break;
                case 564:
                    if (base2 == 0) { finalIllusion = "Siren"; }
                    else if (base2 == 1) { finalIllusion = "Siren Sorceress"; }
                    else { finalIllusion = "Siren"; }
                    break;
                case 566:
                    if (base2 == 0) { finalIllusion = "Plaguebringer"; }
                    else if (base2 == 3) { finalIllusion = "Combine Human"; }
                    else if (base2 == 7 && max == 1) { finalIllusion = "Male Hooded Plaguebringer"; }
                    else if (base2 == 7 && max == 2) { finalIllusion = "Female Hooded Plaguebringer"; }
                    else if (base2 == 7) { finalIllusion = "Hooded Plaguebringer"; }
                    else if (base2 == 9) { finalIllusion = "Bokon"; }
                    else
                    {
                        finalIllusion = "Plaguebringer " + base2;
                    }
                    break;
                case 568:
                    if (base2 == 0) { finalIllusion = "Brownie"; }
                    else if (base2 == 2 && max == 1) { finalIllusion = "Male Brownie Noble"; }
                    else if (base2 == 2 && max == 2) { finalIllusion = "Female Brownie Noble"; }
                    else if (base2 == 2) { finalIllusion = "Brownie Noble"; }
                    else { finalIllusion = "Brownie"; }
                    break;
                case 570:
                    finalIllusion = "Steam Suit";
                    break;
                case 571:
                    finalIllusion = "Ghoul";
                    break;
                case 574:
                    finalIllusion = "Embattled Minotaur";
                    break;
                case 575:
                    finalIllusion = "Scarecrow";
                    break;
                case 576:
                    finalIllusion = "Shade2";
                    break;
                case 577:
                    finalIllusion = "Steamwork";
                    break;
                case 578:
                    finalIllusion = "Tyranont";
                    break;
                case 580:
                    finalIllusion = "Worg";
                    break;
                case 581:
                    finalIllusion = "Wyvern";
                    break;
                case 585:
                    finalIllusion = "Boulder";
                    break;
                case 587:
                    finalIllusion = "Elven Ghost";
                    break;
                case 600:
                    finalIllusion = "Invisible Man of Zomm";
                    break;
                case 602:
                    finalIllusion = "Burynai";
                    break;
                case 604:
                    finalIllusion = "Dracolich";
                    break;
                case 605:
                    finalIllusion = "Iksar Ghost";
                    break;
                case 606:
                    finalIllusion = "Iksar Skeleton";
                    break;
                case 607:
                    finalIllusion = "Mephit";
                    break;
                case 608:
                    finalIllusion = "Muddite";
                    break;
                case 609:
                    finalIllusion = "Raptor";
                    break;
                case 610:
                    finalIllusion = "Sarnak";
                    break;
                case 611:
                    finalIllusion = "Scorpion";
                    break;
                case 612:
                    finalIllusion = "Plague Fly";
                    break;
                case 613:
                    finalIllusion = "New Wurm";
                    break;
                case 614:
                    if (base2 == 0) { finalIllusion = "Burning Nekhon"; }
                    else if (base2 == 1) { finalIllusion = "Shadow Nekhon"; }
                    else
                    {
                        finalIllusion = "Nekhon " + base2;
                    }
                    break;
                case 615:
                    finalIllusion = "Crystal Hydra";
                    break;
                case 616:
                    finalIllusion = "Crystal Sphere";
                    break;
                case 620:
                    finalIllusion = "Vitrik";
                    break;
                case 626:
                    finalIllusion = "Rallosian Giant";
                    break;
                case 627:
                    finalIllusion = "Sokokar";
                    break;
                case 638:
                    finalIllusion = "Bellikos";
                    break;
                case 640:
                    finalIllusion = "Brell Serilis";
                    break;
                case 643:
                    finalIllusion = "Cliknar";
                    break;
                case 644:
                    finalIllusion = "Ant";
                    break;
                case 645:
                    if (base2 == 4) { finalIllusion = "Restless Coldain"; }
                    else
                    {
                        finalIllusion = "New Coldain " + base2;
                    }
                    break;
                case 647:
                    finalIllusion = "Crystal Sessiloid";
                    break;
                case 649:
                    finalIllusion = "Gigyn";
                    break;
                case 653:
                    if (base2 == 0) { finalIllusion = "Telmira"; }
                    else if (base2 == 1) { finalIllusion = "Flood Telmira"; }
                    else
                    {
                        finalIllusion = "Telmira " + base2;
                    }
                    break;
                case 658:
                    finalIllusion = "Morell Thule";
                    break;
                case 659:
                    finalIllusion = "Marionette";
                    break;
                case 660:
                    finalIllusion = "Book Dervish";
                    break;
                case 661:
                    finalIllusion = "Topiary Lion";
                    break;
                case 662:
                    finalIllusion = "Rotdog";
                    break;
                case 663:
                    finalIllusion = "Amygdalan";
                    break;
                case 664:
                    finalIllusion = "Sandman";
                    break;
                case 665:
                    finalIllusion = "Grandfather Clock";
                    break;
                case 666:
                    finalIllusion = "Gingerbread Man";
                    break;
                case 667:
                    finalIllusion = "Royal Guardian";
                    break;
                case 668:
                    if ((base2 == 0) || (base2 == 4)) { finalIllusion = "Rabbit"; }
                    else if (base2 == 3) { finalIllusion = "Gouzah Rabbit"; }
                    else if (base2 == 5) { finalIllusion = "Polka Dot Rabbit"; }
                    else
                    {
                        finalIllusion = "Rabbit " + base2;
                    }
                    break;
                case 670:
                    finalIllusion = "Cazic Thule";
                    break;
                case 681:
                    finalIllusion = "Invisible Man";
                    break;
                case 686:
                    finalIllusion = "Selyrah";
                    break;
                case 687:
                    finalIllusion = "Goral";
                    break;
                case 688:
                    finalIllusion = "Braxi";
                    break;
                case 689:
                    finalIllusion = "Kangon";
                    break;
                case 690:
                    finalIllusion = "Invisible Man";
                    break;
                case 694:
                    finalIllusion = "Tumbleweed";
                    break;
                case 695:
                    if (base2 == 0) { finalIllusion = "Undead Thelasa"; }
                    else if (base2 == 21) { finalIllusion = "Thel Ereth Ril"; }
                    else { finalIllusion = "Undead Thelasa"; }
                    break;
                case 696:
                    if (base2 == 0) { finalIllusion = "Swinetor"; }
                    else if (base2 == 1) { finalIllusion = "Swinetor Necro"; }
                    else
                    {
                        finalIllusion = "Swinetor " + base2;
                    }
                    break;
                case 697:
                    finalIllusion = "Triumvirate";
                    break;
                case 698:
                    if (base2 == 0) { finalIllusion = "Hadal"; }
                    else if (base2 == 2) { finalIllusion = "Hadal Templar"; }
                    else
                    {
                        finalIllusion = "Hadal " + base2;
                    }
                    break;
                case 700:
                    finalIllusion = "Parasitic Scavenger";
                    break;
                case 702:
                    finalIllusion = "Ship in a Bottle";
                    break;
                case 708:
                    finalIllusion = "Alaran Ghost";
                    break;
                case 709:
                    finalIllusion = "Skystrider";
                    break;
                case 711:
                    finalIllusion = "Aviak Pull Along";
                    break;
                case 713:
                    if (base2 == 0) { finalIllusion = "Santugs Antonican Dog"; }
                    else if (base2 == 1) { finalIllusion = "Grey Wolf"; }
                    else if (base2 == 2) { finalIllusion = "Halasian Wolf"; }
                    else if (base2 == 3) { finalIllusion = "Antonican Wolf"; }
                    else if (base2 == 4) { finalIllusion = "Grey Frostfell Dog"; }
                    else if (base2 == 5) { finalIllusion = "Halasian Frostfell Dog"; }
                    else if (base2 == 6) { finalIllusion = "Antonican Frostfell Dog"; }
                    else if (base2 == 7) { finalIllusion = "Santugs Grey Dog"; }
                    else if (base2 == 8) { finalIllusion = "Santugs Halasian Dog"; }
                    else { finalIllusion = "Dog"; }
                    break;
                case 715:
                    finalIllusion = "Holgresh";
                    break;
                case 718:
                    finalIllusion = "Ratman";
                    break;
                case 719:
                    finalIllusion = "Fallen Knight";
                    break;
                case 722:
                    finalIllusion = "Akhevan";
                    break;
                case 730:
                    finalIllusion = "Orb";
                    break;
                case 734:
                    finalIllusion = "Tirun";
                    break;
                case 741:
                    if (base2 == 0) { finalIllusion = "Bixie"; }
                    else if (base2 == 2) { finalIllusion = "Bixie Soldier"; }
                    else
                    {
                        finalIllusion = "Bixie " + base2;
                    }
                    break;
                case 742:
                    finalIllusion = "Butterfly";
                    break;
                case 743:
                    finalIllusion = "Ursarachnid";
                    break;
                case 745:
                    finalIllusion = "Molerat";
                    break;
                case 752:
                    finalIllusion = "Ruishi";
                    break;
                case 757:
                    finalIllusion = "Reindeer";
                    break;
                case 760:
                    finalIllusion = "Book Minion";
                    break;
                case 763:
                    finalIllusion = "Clockwork Gnome";
                    break;
                case 766:
                    finalIllusion = "Arc Worker";
                    break;
                case 767:
                    finalIllusion = "Imp";
                    break;
                case 768:
                    finalIllusion = "Relifed Skeleton";
                    break;
                case 769:
                    finalIllusion = "Cursed Siren";
                    break;
                case 771:
                    finalIllusion = "Tyrannosaurus";
                    break;
                case 774:
                    finalIllusion = "Ankylosaurus";
                    break;
                case 783:
                    finalIllusion = "New Treant";
                    break;
                case 785:
                    finalIllusion = "Thaell Ew";
                    break;
                case 791:
                    if (base2 == 1) { finalIllusion = "New Phoenix"; }
                    else { finalIllusion = "New Hawk"; }
                    break;
                case 792:
                    finalIllusion = "New Parrot";
                    break;
                case 796:
                    finalIllusion = "Ancient Wolf";
                    break;
                case 798:
                    finalIllusion = "Ancient Chokidai";
                    break;
                case 802:
                    finalIllusion = "Ancient Skeleton";
                    break;
                case 805:
                    finalIllusion = "Ancient Tiger";
                    break;
                case 807:
                    finalIllusion = "New Golem";
                    break;
                case 813:
                    finalIllusion = "New Wasp";
                    break;
                case 814:
                    finalIllusion = "New Scorpikis";
                    break;
                case 817:
                    finalIllusion = "New Succulent";
                    break;
                case 819:
                    finalIllusion = "New Devourer";
                    break;
                case 825:
                    finalIllusion = "Cat";
                    break;
                case 826:
                    finalIllusion = "Spectral Wolf";
                    break;
                case 829:
                    finalIllusion = "Valkyrie";
                    break;
                case 830:
                    finalIllusion = "Monkey";
                    break;
                case 837:
                    finalIllusion = "Gnoll Pup";
                    break;
                case 841:
                    finalIllusion = "Sarnak Skeleton";
                    break;
                case 842:
                    finalIllusion = "New Yeti";
                    break;
                case 843:
                    finalIllusion = "Drolvarg";
                    break;
                case 845:
                    if (base2 == 12) { finalIllusion = "Snow Kitten"; }
                    else
                    {
                        finalIllusion = "New Kitten " + base2;
                    }
                    break;
                case 855:
                    finalIllusion = "Earth Elemental4";
                    break;
                case 856:
                    finalIllusion = "Air Elemental4";
                    break;
                case 857:
                    finalIllusion = "Water Elemental4";
                    break;
                case 858:
                    finalIllusion = "Fire Elemental4";
                    break;
                case 862:
                    if ((base2 == 0) && (max == 1)) { finalIllusion = "Male Djinn"; }
                    else if ((base2 == 0) && (max == 2)) { finalIllusion = "Female Djinn"; }
                    else if ((base2 == 1) && (max == 1)) { finalIllusion = "Duende"; }
                    else if ((base2 == 1) && (max == 2)) { finalIllusion = "Ondine"; }
                    else if ((base2 == 2) && (max == 0)) { finalIllusion = "Aalishai Efreeti"; }
                    else if ((base2 == 2) && (max == 1)) { finalIllusion = "Male Efreeti"; }
                    else if ((base2 == 2) && (max == 2)) { finalIllusion = "Female Efreeti"; }
                    else { finalIllusion = "Djinn"; }
                    break;
                case 864:
                    if (base2 == 1) { finalIllusion = "Magmatic Snail"; }
                    else { finalIllusion = "Snail"; }
                    break;
                case 871:
                    finalIllusion = "Ulthork";
                    break;
                case 872:
                    if (base2 == 5) { finalIllusion = "Proudheart Hare"; }
                    else if (base2 == 6) { finalIllusion = "Trueheart Hare"; }
                    else if (base2 == 7) { finalIllusion = "Boundless Heart Hare"; }
                    else { finalIllusion = "Hare"; }
                    break;
                case 873:
                    finalIllusion = "New Zombie";
                    break;
                case 882:
                    finalIllusion = "Othmir";
                    break;
                case 883:
                    finalIllusion = "New Shark";
                    break;
                case 887:
                    finalIllusion = "Baby Dragon";
                    break;
                case 891:
                    finalIllusion = "Syl Ren";
                    break;
                case 895:
                    finalIllusion = "New Shade";
                    break;
                case 897:
                    if (base2 == 8) { finalIllusion = "Red Construct Owlbear"; }
                    else if (base2 == 9) { finalIllusion = "Blue Construct Owlbear"; }
                    else if (base2 == 10) { finalIllusion = "Brown Construct Owlbear"; }
                    else if (base2 == 11) { finalIllusion = "Teal Construct Owlbear"; }
                    else { finalIllusion = "New Owlbear"; }
                    break;
                case 900:
                    finalIllusion = "Blood Bag";
                    break;
                case 901:
                    finalIllusion = "New Stonegrabber";
                    break;
                case 904:
                    finalIllusion = "New Fungal Fiend";
                    break;
                case 905:
                    finalIllusion = "New Grimling";
                    break;
                case 908:
                    finalIllusion = "New Shrieker";
                    break;
                case 909:
                    finalIllusion = "New Underbulk";
                    break;
                case 914:
                    finalIllusion = "Gumdrop";
                    break;
                case 917:
                    finalIllusion = "Spectral Bear";
                    break;
                case 918:
                    if (base2 == 5) { finalIllusion = "Proudheart Lion"; }
                    else if (base2 == 6) { finalIllusion = "Trueheart Lion"; }
                    else if (base2 == 7) { finalIllusion = "Boundless Lion"; }
                    else { finalIllusion = "Stitchwork Lion"; }
                    break;
                case 919:
                    finalIllusion = "New Sporali";
                    break;
                case 925:
                    finalIllusion = "New Skunk";
                    break;
                case 929:
                    finalIllusion = "Badger";
                    break;
                case 934:
                    finalIllusion = "Fox";
                    break;
                case 935:
                    if (base2 == 3) { finalIllusion = "Proudheart Red Panda"; }
                    else if (base2 == 4) { finalIllusion = "Boundlessheart Red Panda"; }
                    else if (base2 == 5) { finalIllusion = "Trueheart Red Panda"; }
                    else if (base2 == 6) { finalIllusion = "Freeheart Red Panda"; }
                    else if (base2 == 7) { finalIllusion = "Aceheart Red Panda"; }
                    else if (base2 == 8) { finalIllusion = "Openheart Red Panda"; }
                    else if (base2 == 9) { finalIllusion = "Flawless Heart Red Panda"; }
                    else if (base2 == 10) { finalIllusion = "Boldheart Red Panda"; }
                    else if (base2 == 11) { finalIllusion = "Sisterheart Red Panda"; }
                    else { finalIllusion = "Red Panda"; }
                    break;
                case 936:
                    finalIllusion = "Candlefolk";
                    break;
                case 937:
                    finalIllusion = "Candlefolk 2";
                    break;
                case 939:
                    finalIllusion = "Rallosian Ogre";
                    break;
                case 942:
                    finalIllusion = "Candlemaster";
                    break;
                case 943:
                    finalIllusion = "Candlemaster 2";
                    break;
                case 945:
                    finalIllusion = "Scalewrought Monitor";
                    break;
                case 947:
                    finalIllusion = "Scalewrought Flyer";
                    break;
                case 949:
                    finalIllusion = "Scalewrought Ground Attacker";
                    break;
                case 958:
                    if (base2 == 0) { finalIllusion = "Blue Bovoch"; }
                    else if (base2 == 2) { finalIllusion = "Brown Bovoch"; }
                    else { finalIllusion = "Bovoch"; }
                    break;
                case 965:
                    finalIllusion = "Scrykin 2";
                    break;
                case 966:
                    finalIllusion = "Beaster Egg";
                    break;
                case 967:
                    finalIllusion = "Cloth Butterfly";
                    break;
                case 975:
                    finalIllusion = "Magic Storm";
                    break;
                case 981:
                    finalIllusion = "Gifty Giver Goblin";
                    break;
                default:
                    finalIllusion = "UNKNOWN finalIllusion " + base1;
                    break;
            }

            return finalIllusion;
        }
    }
}
