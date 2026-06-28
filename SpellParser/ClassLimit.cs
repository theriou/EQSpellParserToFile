namespace SpellParser
{
    internal class ClassLimit
    {
        [Flags]
        public enum SpellClassesMask
        {
            WAR = 1, CLR = 2, PAL = 4, RNG = 8, SHD = 16, DRU = 32, MNK = 64, BRD = 128, ROG = 256,
            SHM = 512, NEC = 1024, WIZ = 2048, MAG = 4096, ENC = 8192, BST = 16384, BER = 32768,
            ALL = 65535
        }
    }
}
