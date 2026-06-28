namespace SpellParser
{
    internal class Calc
    {
        public static double CalcValue(double calc, double base1, double max, double tick, double level, ulong spa, ulong spellID)
        {
            double change = 0;
            double value = 0;

            if (calc == 0)
            {
                return base1;
            }

            if (calc == 100)
            {
                if ((max > 0) && (base1 > max))
                {
                    return max;
                }
                return base1;
            }
            if ((spellID == 4750) || (spellID == 31738))
            {
                level = Math.Floor(level / 10);
                if (level == 0) { level = 1; }

                if (spellID == 4750)
                {
                    level = Math.Min(10, level);
                }

                else
                {
                    level = Math.Min(20, level);
                }
            }

            switch (calc)
            {
                case 100:
                    break;
                case 101:
                    change = (double)Math.Floor(level / 2);
                    break;
                case 102:
                    change = level;
                    break;
                case 103:
                    change = level * 2;
                    break;
                case 104:
                    change = level * 3;
                    break;
                case 105:
                    change = level * 4;
                    break;
                case 107:
                    change = -1 * tick;
                    break;
                case 108:
                    change = -2 * tick;
                    break;
                case 109:
                    change = Math.Floor(level / 4);
                    break;
                case 110:
                    change = Math.Floor(level / 6);
                    break;
                case 111:
                    if (level > 16) { change = (level - 16) * 6; }
                    break;
                case 112:
                    if (level > 24) { change = (level - 24) * 8; }
                    break;
                case 113:
                    if (level > 34) { change = (level - 34) * 10; }
                    break;
                case 114:
                    if (level > 44) { change = (level - 44) * 15; }
                    break;
                case 115:
                    if (level > 15) { change = (level - 15) * 7; }
                    break;
                case 116:
                    if (level > 24) { change = (level - 24) * 10; }
                    break;
                case 117:
                    if (level > 34) { change = (level - 34) * 13; }
                    break;
                case 118:
                    if (level > 44) { change = (level - 44) * 20; }
                    break;
                case 119:
                    change = Math.Floor(level / 8);
                    break;
                case 120:
                    change = -5 * tick;
                    break;
                case 121:
                    change = Math.Floor(level / 3);
                    break;
                case 122:
                    change = -12 * tick;
                    break;
                case 123:
                    // random in range
                    change = ((Math.Abs(max) - (Math.Abs(base1))) / 2);
                    break;
                case 124:
                    if (level > 50) { change = (level - 50); }
                    break;
                case 125:
                    if (level > 50) { change = (level - 50) * 2; }
                    break;
                case 126:
                    if (level > 50) { change = (level - 50) * 3; }
                    break;
                case 127:
                    if (level > 50) { change = (level - 50) * 4; }
                    break;
                case 128:
                    if (level > 50) { change = (level - 50) * 5; }
                    break;
                case 129:
                    if (level > 50) { change = (level - 50) * 10; }
                    break;
                case 130:
                    if (level > 50) { change = (level - 50) * 15; }
                    break;
                case 131:
                    if (level > 50) { change = (level - 50) * 20; }
                    break;
                case 132:
                    if (level > 50) { change = (level - 50) * 25; }
                    break;
                case 139:
                    if (level > 30) { change = (level - 30) / 2; }
                    break;
                case 140:
                    if (level > 30) { change = (level - 30); }
                    break;
                case 141:
                    if (level > 30) { change = 3 * (level - 30) / 2; }
                    break;
                case 142:
                    if (level > 30) { change = 2 * (level - 60); }
                    break;
                case 143:
                    change = Math.Floor(3 * level / 4);
                    break;

                default:
                    if ((calc > 0) && (calc < 1000))
                    {
                        change = level * calc;
                    }

                    // 1000..1999 variable by tick
                    // e.g. splort (growing): Effect=0 Base1=1 Base2=0 Max=0 Calc=1035
                    //      34 - 69 - 104 - 139 - 174 - 209 - 244 - 279 - 314 - 349 - 384 - 419 - 454 - 489 - 524 - 559 - 594 - 629 - 664 - 699 - 699
                    // e.g. venonscale (decaying): Effect=0 Base1=-822 Base2=0 Max=822 Calc=1018
                    //
                    // e.g. Deathcloth Spore: Base1=-1000 Base2=0 Max=0 Calc=1999
                    // e.g. Bleeding Bite: Base1=-1000 Base2=0 Max=0 Calc=1100 (The damage done will decrease in severity over time.)
                    // e.g. Blood Rites: Base1=-1500 Base2=0 Max=0 Calc=1999
                    if ((calc >= 1000) && (calc < 2000))
                    {
                        change = tick * (calc - 1000) * -1;
                    }

                    // 2000..2999 variable by level
                    if ((calc >= 2000) && (calc < 3000))
                    {
                        change = level * (calc - 2000);
                    }

                    // if calc - 3000 = spa then it scales based on Level 100 Base
                    // if calc - 3500 = spa then it scales based on Level 105 Base
                    if ((calc >= 3000) && (calc < 4000))
                    {
                        if ((calc - 3000) == spa) { }
                        if ((calc - 3500) == spa) { }
                    }

                    // Copy of 1000-2000, except no cap
                    if ((calc >= 4000) && (calc < 5000))
                    {
                        change = tick * (calc - 4000) * -1;
                    }

                    // 5000+ variable by level, with different formulas every 5 levels?
                    if (calc >= 5000)
                    {
                        change = 0;
                    }
                    break;
            }

            value = (Math.Abs(base1)) + change;
            if ((max != 0) && (value > (Math.Abs(max))))
            {
                value = (Math.Abs(max));
            }

            if (base1 < 0)
            {
                value = -value;
            }

            if (value > 0) { return Math.Floor(value); }
            else { return Math.Ceiling(value); }
        }

        public static string CalcValueRange(double calc, double base1, double max, double duration, double level, ulong spa, ulong id)
        {
            string type = string.Empty;
            double start = CalcValue(calc, base1, max, 1, level, spa, id);
            double finish = (Math.Abs(CalcValue(calc, base1, max, duration, level, spa, id)));


            if ((Math.Abs(start)) < (Math.Abs(finish))) { type = "Growing"; }
            else if ((Math.Abs(start)) > (Math.Abs(finish))) { type = "Decaying"; }
            else { type = ""; }

            if (calc == 123)
            {
                return " (Random: " + base1 + " to " + max * ((base1 >= 0) ? 1 : -1) + ")";
            }

            if (calc == 107)
            {
                return " (" + type + " to " + finish + " @ 1/Tick)";
            }

            if (calc == 108)
            {
                return " (" + type + " to " + finish + " @ 2/Tick)";
            }

            if (calc == 120)
            {
                return " (" + type + " to " + finish + " @ 5/Tick)";
            }

            if (calc == 122)
            {
                return " (" + type + " to " + finish + " @ 12/Tick)";
            }

            if ((calc > 1000) && (calc < 2000))
            {
                return " (" + type + " to " + finish + " @ " + (calc - 1000) + "/Tick)";
            }

            if ((calc >= 3000) && (calc < 4000))
            {
                if ((calc - 3000) == spa)
                {
                    return " (Scales, Max Level: 100)";
                }
                if ((calc - 3500) == spa)
                {
                    return " (Scales, Max Level: 105)";
                }
            }

            if ((calc >= 4000) && (calc < 5000))
            {
                return " (" + type + " @ " + (calc - 4000) + "/Tick)";
            }

            return "";
        }

        public static double CalcDuration(double calc, double max, double level)
        {
            double value;

            switch (calc)
            {
                case 0:
                    value = 0;
                    break;
                case 1:
                    value = Math.Floor(level / 2);
                    if (value < 1)
                    {
                        value = 1;
                    }
                    break;
                case 2:
                    value = Math.Floor(level / 2) + 5;
                    if (value < 6)
                    {
                        value = 6;
                    }
                    break;
                case 3:
                    value = level * 30;
                    break;
                case 4:
                    value = 50;
                    break;
                case 5:
                    value = 2;
                    break;
                case 6:
                    value = Math.Floor(level / 2);
                    break;
                case 7:
                    value = level;
                    break;
                case 8:
                    value = level + 10;
                    break;
                case 9:
                    value = level * 2 + 10;
                    break;
                case 10:
                    value = level * 30 + 10;
                    break;
                case 11:
                    value = (level + 3) * 30;
                    break;
                case 12:
                    value = Math.Floor(level / 2);
                    if (value < 1)
                    {
                        value = 1;
                    }
                    break;
                case 13:
                    value = level * 4 + 10;
                    break;
                case 14:
                    value = level * 5 + 10;
                    break;
                case 15:
                    value = (level * 5 + 50) * 2;
                    break;
                case 50:
                    value = 72000;
                    break;
                case 3600:
                    value = 3600;
                    break;
                default:
                    value = max;
                    break;
            }

            if ((max > 0) && (value > max))
            {
                value = max;
            }

            return value;
        }
    }
}
