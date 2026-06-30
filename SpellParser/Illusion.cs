namespace SpellParser
{
    internal class Illusion
    {
        public static string SpellIllusion(double base1, double base2, double max)
        {

            switch (base1)
            {
                case -1:
                    if (max == 1) { return "Male"; }
                    else if (max == 2) { return "Female"; }
                    else { return "Swap Gender"; }
                case 1:
                    return "Human";
                case 2:
                    return "Barbarian";
                case 3:
                    return "Erudite";
                case 4:
                    return "Wood Elf";
                case 5:
                    return "High Elf";
                case 6:
                    return "Dark Elf";
                case 7:
                    return "Half Elf";
                case 8:
                    return "Dwarf";
                case 9:
                    return "Troll";
                case 10:
                    return "Ogre";
                case 11:
                    return "Halfling";
                case 12:
                    return "Gnome";
                case 13:
                    return "Old Aviak";
                case 14:
                    return "Old Werewolf";
                case 15:
                    return "Old Brownie";
                case 16:
                    return "Old Centaur";
                case 18:
                    return "Ice Giant";
                case 19:
                    return "Trakanon";
                case 20:
                    return "Venril Sathir";
                case 21:
                    return "Old Evil Eye";
                case 22:
                    return "Old Beetle";
                case 23:
                    return "Kerran";
                case 24:
                    return "Fish";
                case 25:
                    return "Old Fairy";
                case 27:
                    return "Froglok";
                case 28:
                    return "Fungusman";
                case 29:
                    return "Old Gargoyle";
                case 31:
                    return "Gelatinous Cube";
                case 33:
                    return "Ghoul";
                case 36:
                    if (base2 == 2) { return "Infected Rat"; }
                    else { return "Rat"; }
                case 38:
                    if (base2 == 2) { return "Jungle Spider"; }
                    else { return "Spider"; }
                case 39:
                    return "Old Gnoll";
                case 40:
                    return "Old Goblin";
                case 42:
                    if (base2 == 1) { return "Black Spirit Wolf"; }
                    else if (base2 == 2) { return "White Spirit Wolf"; }
                    else { return "Old Wolf"; }
                case 43:
                    if (base2 == 0) { return "Old Bear"; }
                    else if (base2 == 2) { return "Polar Bear"; }
                    else { return "Bear"; }
                case 44:
                    return "Freeport Militia";
                case 46:
                    return "Imp";
                case 48:
                    return "Kobold";
                case 51:
                    return "Lizard Man";
                case 52:
                    return "Mimic";
                case 54:
                    return "Old Orc";
                case 56:
                    return "Pixie";
                case 57:
                    return "Old Drachnid";
                case 58:
                    return "Solusek Ro";
                case 62:
                    return "Tunare";
                case 63:
                    return "Tiger";
                case 65:
                    return "Mayong";
                case 66:
                    return "Rallos Zek";
                case 68:
                    return "Tentacle Terror";
                case 69:
                    return "Will-O-Wisp";
                case 70:
                    if (base2 == 0) { return "Female Zombie"; }
                    else if (base2 == 1) { return "Mummy Zombie"; }
                    else { return "Zombie"; }
                case 74:
                    return "Piranha";
                case 75:
                    if (base2 == 0) { return "Earth Elemental"; }
                    else if (base2 == 1) { return "Fire Elemental"; }
                    else if (base2 == 2) { return "Water Elemental"; }
                    else if (base2 == 3) { return "Air Elemental"; }
                    else { return "Elemental"; }
                case 76:
                    if (base2 == 1) { return "Snow Leopard"; }
                    else { return "Puma"; }
                case 80:
                    return "Reanimated Hand";
                case 81:
                    return "Rivervale Guard";
                case 82:
                    return "Old Scarecrow";
                case 83:
                    return "Skunk";
                case 85:
                    return "Old Skeleton";
                case 87:
                    return "Armadillo";
                case 89:
                    return "Old Drake";
                case 91:
                    return "Old Alligator";
                case 94:
                    return "Kaladim Guard";
                case 95:
                    return "Old Cazic-Thule";
                case 96:
                    return "Cockatrice";
                case 98:
                    return "Old Vampire";
                case 99:
                    return "Old Amygdalan";
                case 100:
                    return "Old Dervish";
                case 102:
                    return "Tadpole";
                case 103:
                    return "Old Kedge";
                case 107:
                    return "Mammoth";
                case 109:
                    return "Wasp";
                case 110:
                    return "Mermaid";
                case 113:
                    return "Drixie";
                case 116:
                    return "Seahorse";
                case 118:
                    return "Ghost";
                case 119:
                    return "Sabertooth";
                case 120:
                    return "Spirit Wolf";
                case 121:
                    return "Gorgon";
                case 122:
                    return "Old Dragon";
                case 123:
                    return "Innoruuk";
                case 124:
                    return "Unicorn";
                case 125:
                    return "Pegasus";
                case 126:
                    return "Djinn";
                case 127:
                    return "Invisible Man";
                case 128:
                    return "Iksar";
                case 129:
                    return "Scorpion";
                case 130:
                    return "Vah Shir";
                case 131:
                    return "Old Sarnak";
                case 133:
                    return "Old Drolvarg";
                case 134:
                    return "Mosquito";
                case 135:
                    return "Rhinoceros";
                case 136:
                    return "Xalgoz";
                case 137:
                    return "Kunark Goblin";
                case 138:
                    return "Yeti";
                case 139:
                    return "Iksar2";
                case 140:
                    return "Kunark Giant";
                case 142:
                    return "Nearby Object";
                case 143:
                    return "Tree";
                case 145:
                    return "Goo";
                case 150:
                    return "Erollisi Marr";
                case 151:
                    return "Tribunal";
                case 153:
                    return "Bristlebane";
                case 155:
                    return "Sarnak Skeleton";
                case 156:
                    return "Ratman";
                case 161:
                    return "Old Iksar Skeleton";
                case 162:
                    return "Man-Eating Plant";
                case 163:
                    return "Old Raptor";
                case 175:
                    return "Enchanted Armor";
                case 176:
                    return "Snow Rabbit";
                case 177:
                    return "Walrus";
                case 178:
                    return "Geonid";
                case 181:
                    return "Tizmak";
                case 183:
                    if (base2 == 2) { return "Coldain Citizen"; }
                    else { return "Coldain"; }
                case 185:
                    return "Hag";
                case 190:
                    return "Othmir";
                case 191:
                    return "Ulthork";
                case 194:
                    return "Sea Turtle";
                case 199:
                    return "Shik`Nar";
                case 200:
                    return "Rockhopper";
                case 201:
                    return "Underbulk";
                case 202:
                    return "Grimling";
                case 203:
                    return "Worm";
                case 205:
                    return "Shadel";
                case 206:
                    return "Owlbear";
                case 207:
                    return "Rhino Beetle";
                case 209:
                    return "Earth Elemental2";
                case 210:
                    return "Air Elemental2";
                case 211:
                    return "Water Elemental2";
                case 212:
                    return "Fire Elemental2";
                case 214:
                    return "Thought Horror";
                case 217:
                    return "Shissar";
                case 218:
                    return "Fungal Fiend";
                case 220:
                    return "Stonegrabber";
                case 221:
                    return "Scarlet Cheetah";
                case 222:
                    return "Zelniak";
                case 223:
                    return "Lightcrawler";
                case 224:
                    return "Shadow";
                case 225:
                    return "Sunflower";
                case 226:
                    return "Sun Revenant";
                case 227:
                    return "Shrieker";
                case 228:
                    return "Galorian";
                case 229:
                    return "Netherbian";
                case 230:
                    return "Akheva";
                case 232:
                    return "Sonic Wolf";
                case 235:
                    return "Wretch";
                case 239:
                    return "Guard";
                case 261:
                    return "Hraquis";
                case 266:
                    return "Knight of Pestilence";
                case 267:
                    return "Lepertoloth";
                case 279:
                    return "Blood Raven";
                case 280:
                    return "Nightmare Gargoyle";
                case 285:
                    if (base2 == 1) { return "Boar Beast"; }
                    else { return "Tormentor"; }
                case 303:
                    return "Phoenix";
                case 314:
                    return "Wrulon";
                case 316:
                    return "Poison Frog";
                case 319:
                    return "War Boar";
                case 323:
                    return "Animated Armor";
                case 326:
                    return "Arachnid";
                case 330:
                    return "Guktan";
                case 331:
                    if (max == 1) { return "Male Troll Pirate"; }
                    else if (max == 2) { return "Female Troll Pirate"; }
                    else { return "Troll Pirate"; }
                case 338:
                    if (max == 1) { return "Male Gnome Pirate"; }
                    else if (max == 2) { return "Female Gnome Pirate"; }
                    else { return "Gnome Pirate"; }
                case 339:
                    if (max == 1) { return "Male Dark Elf Pirate"; }
                    else if (max == 2) { return "Female Dark Elf Pirate"; }
                    else { return "Dark Elf Pirate"; }
                case 340:

                    if (max == 1) { return "Male Ogre Pirate"; }
                    else if (max == 2) { return "Female Ogre Pirate"; }
                    else { return "Ogre Pirate"; }
                case 341:

                    if (max == 1) { return "Male Human Pirate"; }
                    else if (max == 2) { return "Female Human Pirate"; }
                    else { return "Human Pirate"; }
                case 342:
                    if (max == 1) { return "Male Erudite Pirate"; }
                    else if (max == 2) { return "Female Erudite Pirate"; }
                    else { return "Erudite Pirate"; }
                case 344:
                    return "Troll Zombie";
                case 349:
                    return "Froglok Skeleton";
                case 350:
                    return "Undead Froglok";
                case 353:
                    return "Veksar";
                case 356:
                    return "Scaled Wolf";
                case 360:
                    if (base2 == 1) { return "Nightrage Orphan"; }
                    else { return "Vampire"; }
                case 367:
                    if (base2 == 0) { return "Skeleton"; }
                    else if (base2 == 1) { return "Drybone Skeleton"; }
                    else if (base2 == 2) { return "Frostbone Skeleton"; }
                    else if (base2 == 3) { return "Firebone Skeleton"; }
                    else if (base2 == 4) { return "Scorched Skeleton"; }
                    else { return "Skeleton"; }
                case 368:
                    return "Mummy";
                case 371:
                    return "Froglok Ghost";
                case 373:
                    return "Shade";
                case 374:
                    if (base2 == 0) { return "Golem"; }
                    else if (base2 == 1) { return "Ice Golem"; }
                    else if (base2 == 3) { return "Crystal Golem"; }
                    else { return "Golem " + base2; }
                case 384:
                    return "Jokester";
                case 385:
                    return "Nihil";
                case 386:
                    return "Trusik";
                case 388:
                    return "Hynid";
                case 389:
                    return "Turepta";
                case 390:
                    return "Cragbeast";
                case 391:
                    return "Stonemite";
                case 392:
                    return "Ukun";
                case 394:
                    return "Ikaav";
                case 395:
                    return "Aneuk";
                case 396:
                    return "Kyv";
                case 397:
                    return "Noc";
                case 398:
                    return "Ra`tuk";
                case 399:
                    return "Taneth";
                case 400:
                    return "Huvul";
                case 401:
                    return "Mutna";
                case 402:
                    return "Mastruq";
                case 403:
                    return "Taelosian";
                case 405:
                    return "Stone Worker";
                case 406:
                    return "Mata Muram";
                case 407:
                    return "Lightning Warrior";
                case 409:
                    return "Bazu";
                case 410:
                    return "Feran";
                case 411:
                    return "Pyrilen";
                case 412:
                    return "Chimera";
                case 413:
                    return "Dragorn";
                case 414:
                    return "Murkglider";
                case 415:
                    return "Rat";
                case 416:
                    return "Bat";
                case 417:
                    return "Gelidran";
                case 419:
                    return "Girplan";
                case 425:
                    return "Crystal Shard";
                case 430:
                    return "Vergalid Drake";
                case 431:
                    return "Dervish";
                case 432:
                    return "Drake";
                case 433:
                    if (base2 == 1) { return "Solusek Goblin"; }
                    else if (base2 == 2) { return "Dagnor Goblin"; }
                    else if (base2 == 3) { return "Valley Goblin"; }
                    else if (base2 == 7) { return "Aqua Goblin"; }
                    else if (base2 == 8) { return "Goblin King"; }
                    else if (base2 == 11) { return "Rallosian Goblin"; }
                    else if (base2 == 12) { return "Frost Goblin"; }
                    else { return "Goblin"; }
                case 434:
                    return "Kirin";
                case 436:
                    return "Basilisk";
                case 439:
                    if (base2 == 9) { return "Domain Prowler"; }
                    else if (base2 == 11) { return "Spectral Tiger"; }
                    else { return "Puma"; }
                case 440:
                    return "Spider";
                case 441:
                    return "Spider Queen";
                case 442:
                    return "Animated Statue";
                case 450:
                    return "Lava Spider";
                case 451:
                    return "Lava Spider Queen";
                case 445:
                    return "Dragon Egg";
                case 454:
                    if (base2 == 0) { return "Werewolf"; }
                    else if (base2 == 9) { return "White Werewolf"; }
                    else { return "Werewolf " + base2; }
                case 455:
                    if (base2 == 0) { return "Kobold"; }
                    else if (base2 == 2) { return "Kobold King"; }
                    else { return "Kobold " + base2; }
                case 456:
                    if (base2 == 0) { return "Sporali"; }
                    else if (base2 == 2) { return "Violet Sporali"; }
                    else if (base2 == 11) { return "Azure Sporali"; }
                    else { return "Sporali " + base2; }
                case 457:
                    return "Gnomework";
                case 458:
                    if (base2 == 0) { return "Orc"; }
                    else if (base2 == 4) { return "Bloodmoon Orc"; }
                    else { return "Orc " + base2; }
                case 461:
                    return "Drachnid";
                case 462:
                    return "Drachnid Cocoon";
                case 463:
                    return "Fungus Patch";
                case 464:
                    if (base2 == 0) { return "Gargoyle"; }
                    else if (base2 == 1) { return "Runed Gargoyle"; }
                    else { return "Gargoyle " + base2; }
                case 467:
                    if (base2 == 0) { return "Undead Shiliskin"; }
                    else if (base2 == 5) { return "Armored Shiliskin"; }
                    else { return "Shiliskin " + base2; }
                case 468:
                    return "Snake";
                case 469:
                    return "Evil Eye";
                case 470:
                    return "Minotaur";
                case 471:
                    return "Zombie";
                case 472:
                    return "Clockwork Boar";
                case 473:
                    if ((base2 == 0) || (base2 == 2)) { return "Fairy"; }
                    else if (base2 == 1) { return "Tree Fairy"; }
                    else { return "Fairy"; }
                case 474:
                    return "Witheran";
                case 475:
                    return "Air Elemental3";
                case 476:
                    return "Earth Elemental3";
                case 477:
                    return "Fire Elemental3";
                case 478:
                    return "Water Elemental3";
                case 479:
                    return "Alligator";
                case 480:
                    return "Bear";
                case 482:
                    return "Wolf";
                case 485:
                    return "Spectre";
                case 487:
                    return "Banshee";
                case 488:
                    return "Banshee2";
                case 489:
                    return "Elddar";
                case 490:
                    return "Forest Giant";
                case 491:
                    return "Bone Golem";
                case 494:
                    return "Shambling Mound";
                case 495:
                    return "Scrykin";
                case 496:
                    return "Treant";
                case 497:
                    return "Regal Vampire";
                case 504:
                    return "Clockwork Bomb";
                case 512:
                    return "Floating Skull";
                case 514:
                    return "Totem";
                case 519:
                    if (base2 == 0) { return "Unicorn"; }
                    else { return "Nightmare"; }
                case 520:
                    if (base2 == 0) { return "Bixie Drone"; }
                    else if (base2 == 2) { return "Bixie Queen"; }
                    else { return "Bixie " + base2; }
                case 521:
                    if (base2 == 3) { return "Centaur Warrior"; }
                    else { return "Centaur"; }
                case 522:
                    return "Drakkin";
                case 524:
                    if (base2 == 0) { return "Gnoll"; }
                    else if (base2 == 1) { return "Undead Gnoll"; }
                    else if (base2 == 2) { return "Mucktail Gnoll"; }
                    else if (base2 == 3) { return "Gnoll Reaver"; }
                    else if (base2 == 4) { return "Blackburrow Gnoll"; }
                    else { return "Gnoll " + base2; }
                case 527:
                    return "Hideous Harpy";
                case 529:
                    return "Satyr";
                case 530:
                    return "Dragon";
                case 549:
                    return "New Goo";
                case 558:
                    return "Aviak";
                case 559:
                    if (base2 == 1) { return "Death Beetle"; }
                    else { return "Beetle"; }
                case 561:
                    return "Kedge";
                case 562:
                    return "Kerran";
                case 563:
                    return "Shissar2";
                case 564:
                    if (base2 == 0) { return "Siren"; }
                    else if (base2 == 1) { return "Siren Sorceress"; }
                    else { return "Siren"; }
                case 566:
                    if (base2 == 0) { return "Plaguebringer"; }
                    else if (base2 == 3) { return "Combine Human"; }
                    else if ((base2 == 7) && (max == 1)) { return "Male Hooded Plaguebringer"; }
                    else if ((base2 == 7) && (max == 2)) { return "Female Hooded Plaguebringer"; }
                    else if (base2 == 7) { return "Hooded Plaguebringer"; }
                    else if (base2 == 9) { return "Bokon"; }
                    else { return "Plaguebringer " + base2; }
                case 568:
                    if (base2 == 0) { return "Brownie"; }
                    else if ((base2 == 2 && max == 1)) { return "Male Brownie Noble"; }
                    else if ((base2 == 2 && max == 2)) { return "Female Brownie Noble"; }
                    else if (base2 == 2) { return "Brownie Noble"; }
                    else { return "Brownie"; }
                case 570:
                    return "Steam Suit";
                case 571:
                    return "Ghoul";
                case 574:
                    return "Embattled Minotaur";
                case 575:
                    return "Scarecrow";
                case 576:
                    return "Shade2";
                case 577:
                    return "Steamwork";
                case 578:
                    return "Tyranont";
                case 580:
                    return "Worg";
                case 581:
                    return "Wyvern";
                case 585:
                    return "Boulder";
                case 587:
                    return "Elven Ghost";
                case 600:
                    return "Invisible Man of Zomm";
                case 602:
                    return "Burynai";
                case 604:
                    return "Dracolich";
                case 605:
                    return "Iksar Ghost";
                case 606:
                    return "Iksar Skeleton";
                case 607:
                    return "Mephit";
                case 608:
                    return "Muddite";
                case 609:
                    return "Raptor";
                case 610:
                    return "Sarnak";
                case 611:
                    return "Scorpion";
                case 612:
                    return "Plague Fly";
                case 613:
                    return "New Wurm";
                case 614:
                    if (base2 == 0) { return "Burning Nekhon"; }
                    else if (base2 == 1) { return "Shadow Nekhon"; }
                    else { return "Nekhon " + base2; }
                case 615:
                    return "Crystal Hydra";
                case 616:
                    return "Crystal Sphere";
                case 620:
                    return "Vitrik";
                case 626:
                    return "Rallosian Giant";
                case 627:
                    return "Sokokar";
                case 638:
                    return "Bellikos";
                case 640:
                    return "Brell Serilis";
                case 643:
                    return "Cliknar";
                case 644:
                    return "Ant";
                case 645:
                    if (base2 == 4) { return "Restless Coldain"; }
                    else { return "New Coldain " + base2; }
                case 647:
                    return "Crystal Sessiloid";
                case 649:
                    return "Gigyn";
                case 653:
                    if (base2 == 0) { return "Telmira"; }
                    else if (base2 == 1) { return "Flood Telmira"; }
                    else { return "Telmira " + base2; }
                case 658:
                    return "Morell Thule";
                case 659:
                    return "Marionette";
                case 660:
                    return "Book Dervish";
                case 661:
                    return "Topiary Lion";
                case 662:
                    return "Rotdog";
                case 663:
                    return "Amygdalan";
                case 664:
                    return "Sandman";
                case 665:
                    return "Grandfather Clock";
                case 666:
                    return "Gingerbread Man";
                case 667:
                    return "Royal Guardian";
                case 668:
                    if ((base2 == 0) || (base2 == 4)) { return "Rabbit"; }
                    else if (base2 == 3) { return "Gouzah Rabbit"; }
                    else if (base2 == 5) { return "Polka Dot Rabbit"; }
                    else { return "Rabbit " + base2; }
                case 670:
                    return "Cazic Thule";
                case 681:
                    return "Invisible Man";
                case 686:
                    return "Selyrah";
                case 687:
                    return "Goral";
                case 688:
                    return "Braxi";
                case 689:
                    return "Kangon";
                case 690:
                    return "Invisible Man";
                case 694:
                    return "Tumbleweed";
                case 695:
                    if (base2 == 0) { return "Undead Thelasa"; }
                    else if (base2 == 21) { return "Thel Ereth Ril"; }
                    else { return "Undead Thelasa"; }
                case 696:
                    if (base2 == 0) { return "Swinetor"; }
                    else if (base2 == 1) { return "Swinetor Necro"; }
                    else { return "Swinetor " + base2; }
                case 697:
                    return "Triumvirate";
                case 698:
                    if (base2 == 0) { return "Hadal"; }
                    else if (base2 == 2) { return "Hadal Templar"; }
                    else { return "Hadal " + base2; }
                case 700:
                    return "Parasitic Scavenger";
                case 702:
                    return "Ship in a Bottle";
                case 708:
                    return "Alaran Ghost";
                case 709:
                    return "Skystrider";
                case 711:
                    return "Aviak Pull Along";
                case 713:
                    if (base2 == 0) { return "Santugs Antonican Dog"; }
                    else if (base2 == 1) { return "Grey Wolf"; }
                    else if (base2 == 2) { return "Halasian Wolf"; }
                    else if (base2 == 3) { return "Antonican Wolf"; }
                    else if (base2 == 4) { return "Grey Frostfell Dog"; }
                    else if (base2 == 5) { return "Halasian Frostfell Dog"; }
                    else if (base2 == 6) { return "Antonican Frostfell Dog"; }
                    else if (base2 == 7) { return "Santugs Grey Dog"; }
                    else if (base2 == 8) { return "Santugs Halasian Dog"; }
                    else { return "Dog"; }
                case 715:
                    return "Holgresh";
                case 718:
                    return "Ratman";
                case 719:
                    return "Fallen Knight";
                case 722:
                    return "Akhevan";
                case 730:
                    return "Orb";
                case 734:
                    return "Tirun";
                case 741:
                    if (base2 == 0) { return "Bixie"; }
                    else if (base2 == 2) { return "Bixie Soldier"; }
                    else { return "Bixie " + base2; }
                case 742:
                    return "Butterfly";
                case 743:
                    return "Ursarachnid";
                case 745:
                    return "Molerat";
                case 752:
                    return "Ruishi";
                case 757:
                    return "Reindeer";
                case 760:
                    return "Book Minion";
                case 763:
                    return "Clockwork Gnome";
                case 766:
                    return "Arc Worker";
                case 767:
                    return "Imp";
                case 768:
                    return "Relifed Skeleton";
                case 769:
                    return "Cursed Siren";
                case 771:
                    return "Tyrannosaurus";
                case 774:
                    return "Ankylosaurus";
                case 783:
                    return "New Treant";
                case 785:
                    return "Thaell Ew";
                case 791:
                    if (base2 == 1) { return "New Phoenix"; }
                    else { return "New Hawk"; }
                case 792:
                    return "New Parrot";
                case 796:
                    return "Ancient Wolf";
                case 798:
                    return "Ancient Chokidai";
                case 802:
                    return "Ancient Skeleton";
                case 805:
                    return "Ancient Tiger";
                case 807:
                    return "New Golem";
                case 813:
                    return "New Wasp";
                case 814:
                    return "New Scorpikis";
                case 817:
                    return "New Succulent";
                case 819:
                    return "New Devourer";
                case 825:
                    return "Cat";
                case 826:
                    return "Spectral Wolf";
                case 829:
                    return "Valkyrie";
                case 830:
                    return "Monkey";
                case 837:
                    return "Gnoll Pup";
                case 841:
                    return "Sarnak Skeleton";
                case 842:
                    return "New Yeti";
                case 843:
                    return "Drolvarg";
                case 845:
                    if (base2 == 12) { return "Snow Kitten"; }
                    else { return "New Kitten " + base2; }
                case 855:
                    return "Earth Elemental4";
                case 856:
                    return "Air Elemental4";
                case 857:
                    return "Water Elemental4";
                case 858:
                    return "Fire Elemental4";
                case 862:
                    if ((base2 == 0) && (max == 1)) { return "Male Djinn"; }
                    else if ((base2 == 0) && (max == 2)) { return "Female Djinn"; }
                    else if ((base2 == 1) && (max == 1)) { return "Duende"; }
                    else if ((base2 == 1) && (max == 2)) { return "Ondine"; }
                    else if ((base2 == 2) && (max == 0)) { return "Aalishai Efreeti"; }
                    else if ((base2 == 2) && (max == 1)) { return "Male Efreeti"; }
                    else if ((base2 == 2) && (max == 2)) { return "Female Efreeti"; }
                    else { return "Djinn"; }
                case 864:
                    if (base2 == 1) { return "Magmatic Snail"; }
                    else { return "Snail"; }
                case 871:
                    return "Ulthork";
                case 872:
                    if (base2 == 5) { return "Proudheart Hare"; }
                    else if (base2 == 6) { return "Trueheart Hare"; }
                    else if (base2 == 7) { return "Boundless Heart Hare"; }
                    else { return "Hare"; }
                case 873:
                    return "New Zombie";
                case 882:
                    return "Othmir";
                case 883:
                    return "New Shark";
                case 887:
                    return "Baby Dragon";
                case 891:
                    return "Syl Ren";
                case 895:
                    return "New Shade";
                case 897:
                    if (base2 == 8) { return "Red Construct Owlbear"; }
                    else if (base2 == 9) { return "Blue Construct Owlbear"; }
                    else if (base2 == 10) { return "Brown Construct Owlbear"; }
                    else if (base2 == 11) { return "Teal Construct Owlbear"; }
                    else { return "New Owlbear"; }
                case 900:
                    return "Blood Bag";
                case 901:
                    return "New Stonegrabber";
                case 904:
                    return "New Fungal Fiend";
                case 905:
                    return "New Grimling";
                case 908:
                    return "New Shrieker";
                case 909:
                    return "New Underbulk";
                case 914:
                    return "Gumdrop";
                case 917:
                    return "Spectral Bear";
                case 918:
                    if (base2 == 5) { return "Proudheart Lion"; }
                    else if (base2 == 6) { return "Trueheart Lion"; }
                    else if (base2 == 7) { return "Boundless Lion"; }
                    else { return "Stitchwork Lion"; }
                case 919:
                    return "New Sporali";
                case 925:
                    return "New Skunk";
                case 929:
                    return "Badger";
                case 934:
                    return "Fox";
                case 935:
                    if (base2 == 3) { return "Proudheart Red Panda"; }
                    else if (base2 == 4) { return "Boundlessheart Red Panda"; }
                    else if (base2 == 5) { return "Trueheart Red Panda"; }
                    else if (base2 == 6) { return "Freeheart Red Panda"; }
                    else if (base2 == 7) { return "Aceheart Red Panda"; }
                    else if (base2 == 8) { return "Openheart Red Panda"; }
                    else if (base2 == 9) { return "Flawless Heart Red Panda"; }
                    else if (base2 == 10) { return "Boldheart Red Panda"; }
                    else if (base2 == 11) { return "Sisterheart Red Panda"; }
                    else { return "Red Panda"; }
                case 936:
                    return "Candlefolk";
                case 937:
                    return "Candlefolk 2";
                case 939:
                    return "Rallosian Ogre";
                case 942:
                    return "Candlemaster";
                case 943:
                    return "Candlemaster 2";
                case 945:
                    return "Scalewrought Monitor";
                case 947:
                    return "Scalewrought Flyer";
                case 949:
                    return "Scalewrought Ground Attacker";
                case 958:
                    if (base2 == 0) { return "Blue Bovoch"; }
                    else if (base2 == 2) { return "Brown Bovoch"; }
                    else { return "Bovoch"; }
                case 965:
                    return "Scrykin 2";
                case 966:
                    return "Beaster Egg";
                case 967:
                    return "Cloth Butterfly";
                case 975:
                    return "Magic Storm";
                case 981:
                    return "Gifty Giver Goblin";
                default:
                    return "UNKNOWN Illusion " + base1;
            }

        }
    }
}
