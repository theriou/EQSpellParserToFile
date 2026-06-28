namespace SpellParser
{
    internal class Format
    {
        public static string FormatCount(string name, double value)
        {
            string finalString = string.Empty;

            if (value > 0)
            {
                finalString += "Increase ";
            }
            else if (value < 0)
            {
                finalString += "Decrease ";
            }

            return finalString + name + " by " + Math.Abs(value);
        }

        public static string FormatCountRange(string name, double value, double startValue, double endValue)
        {
            return string.Format("{0} {1} by {2} to {3}", value < 0 ? "Decrease" : "Increase", name, startValue, endValue);
        }

        public static string FormatPercent(string name, double value)
        {
            string finalString = string.Empty;

            if (value < 0)
            {
                finalString += "Decrease ";
            }
            else
            {
                finalString += "Increase ";
            }

            return finalString + name + " by " + Math.Abs(value) + "%";
        }
    }
}
