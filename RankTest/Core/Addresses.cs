namespace RankTest.Core
{
    internal class Addresses
    {
        internal static uint IsInParty => 0x89D29E;

        public static uint LocalXUIDString => 0x1BBBC58;

        internal static uint[] GrabberLevel => new uint[2] { 0x8A80E4, 0x89D18C };

        internal static uint[] GrabberXUID => new uint[2] { 0x8A8220, 0x89D2C8 };

        internal static uint GrabberInterval => 0x178;

        internal static uint StatsEntry => 0x1C187D4;

        internal static uint StatsSplitScreenEntry => 0x1C1B7D9;

        internal static uint Length => 0x3005;

        #region Stats
        public enum Stats
        {
            Prestige = 0xCA8, // 0x1C187D4 + 0xCA8
            Level = 0xA98, // 0x1C187D4 + 0xA98
            Score = 0xCB0, // 0x1C187D4 + 0xCB0
            Wins = 0xD0C, // 0x1C187D4 + 0xD0C
            Losses = 0xD10, // 0x1C187D4 + 0xD10
            Ties = 0xD14, // 0x1C187D4 + 0xD14
            Winstreak = 0xD18, // 0x1C187D4 + 0xD18
            Kills = 0xCD8, // 0x1C187D4 + 0xCD8
            Deaths = 0xCE0, // 0x1C187D4 + 0xCE0
            Headshots = 0xCEC, // 0x1C187D4 + 0xCEC
            Assists = 0xCE8, // 0x1C187D4 + 0xCE8
            Killstreak = 0xCDC, // 0x1C187D4 + 0xCDC
            GamePlayed = 0xCB4, // 0x1C187D4 + 0xCB4
            TimePlayed1 = 0xCF8, // 0x1C187D4 + 0xCF8
            TimePlayed2 = 0xCFC, // 0x1C187D4 + 0xCFC
            TimePlayed3 = 0xD00, // 0x1C187D4 + 0xD00
            DoubleXP = 0x2B5D, // 0x1C187D4 + 0x2B5D
            DoubleWeaponXP = 0x2B65, // 0x1C187D4 + 0x2B65
            Hits = 0xD24, // 0x1C187D4 + 0xD24
            Misses = 0xD28, // 0x1C187D4 + 0xD28
            Tokens = 0x2B07, // 0x1C187D4 + 0x2B07
            AddClasses = 0x2B0F, // 0x1C187D4 + 0x2B0F
            MWPrestige = 0x2BA2, // 0x1C187D4 + 0x2BA2
            WAWPrestige = 0x2BA7, // 0x1C187D4 + 0x2BA7
            MW2Prestige = 0x2BAD, // 0x1C187D4 + 0x2BAD
            BOPrestige = 0x2BB4, // 0x1C187D4 + 0x2BB4
            Accuracy = 0xD30, // 0x1C187D4 + 0xD30
            RatioKD = 0xD08, // 0x1C187D4 + 0xD08
            RatioWL = 0xD20, // 0x1C187D4 + 0xD20
            EmblemIndex = 0x28A2, // 0x1C187D4 + 0x28A2
            TitleIndex = 0x28A6, // 0x1C187D4 + 0x28A6
            UnlockAll0 = 0x17DB, // 0x1C187D4 + 0x17DB // 0x13, 0x02 (Pro perks?)
            UnlockAll1 = 0x8E0, // 0x1C187D4 + 0x8E0 // 0xB8, 0x1E... || 0X1E, 0x38... / 0x710 || 0x200 (Weapons lvl 31)
            UnlockAll2 = 0x28CC, // 0x1C187D4 + 0x28CC // 0xFF, 0xFF... 0x200 (Pro perks?)
            UnlockAll3 = 0x181E, // 0x1C187D4 + 0x181E // 0x0A, 0x0A... / 0x1064 (Unlock all)
            UnlockAll4 = 0xEB0, // 0x1C187D4 + 0xEB0
            UnlockAll5 = 0xA6C, // 0x1C187D4 + 0xA6C // 0xFF (288)
            UnlockAll6 = 0xAA0, // 0x1C187D4 + 0xA6C  (520)
            EliteCamo = 0x2B18 // 0x1C187D4 + 0x2B18 // 0xFF
        }
        #endregion

        #region Classes
        public enum Classes
        {
            ClassInterval = 0x62,
            ClassName1 = 0x1058, // 0x1C187D4 + 0x1058,
            ClassName2 = 0x10BA, // 0x1C187D4 + 0x10BA,
            ClassName3 = 0x111C, // 0x1C187D4 + 0x111C,
            ClassName4 = 0x117E, // 0x1C187D4 + 0x117E,
            ClassName5 = 0x11E0, // 0x1C187D4 + 0x11E0,
            ClassName6 = 0x1242, // 0x1C187D4 + 0x1242,
            ClassName7 = 0x12A4, // 0x1C187D4 + 0x12A4,
            ClassName8 = 0x1306, // 0x1C187D4 + 0x1306,
            ClassName9 = 0x1368, // 0x1C187D4 + 0x1368,
            ClassName10 = 0x13CA, // 0x1C187D4 + 0x13CA,
            ClassName11 = 0x142C, // 0x1C187D4 + 0x142C,
            ClassName12 = 0x148E, // 0x1C187D4 + 0x148E,
            ClassName13 = 0x14F0, // 0x1C187D4 + 0x14F0,
            ClassName14 = 0x1552, // 0x1C187D4 + 0x1552,
            ClassName15 = 0x15B4, // 0x1C187D4 + 0x15B4,
            PMClassName1 = 0x1616, // 0x1C187D4 + 0x1616,
            PMClassName2 = 0x1678, // 0x1C187D4 + 0x1678,
            PMClassName3 = 0x16DA, // 0x1C187D4 + 0x16DA,
            PMClassName4 = 0x173C, // 0x1C187D4 + 0x173C,
            PMClassName5 = 0x179E, // 0x1C187D4 + 0x179E,

            GodmodeClass1 = 0x108B, // 0x1C187D4 + 0x108B,
            GodmodeClass2 = 0x10ED, // 0x1C187D4 + 0x10ED,
            GodmodeClass3 = 0x114F, // 0x1C187D4 + 0x114F,
            GodmodeClass4 = 0x11B1, // 0x1C187D4 + 0x11B1,
            GodmodeClass5 = 0x1213, // 0x1C187D4 + 0x1213,
            GodmodeClass6 = 0x1275, // 0x1C187D4 + 0x1275,
            GodmodeClass7 = 0x12D7, // 0x1C187D4 + 0x12D7,
            GodmodeClass8 = 0x1339, // 0x1C187D4 + 0x1339,
            GodmodeClass9 = 0x139B, // 0x1C187D4 + 0x139B,
            GodmodeClass10 = 0x13FD, // 0x1C187D4 + 0x13FD,
            GodmodeClass11 = 0x145F, // 0x1C187D4 + 0x145F,
            GodmodeClass12 = 0x14C1, // 0x1C187D4 + 0x14C1,
            GodmodeClass13 = 0x1523, // 0x1C187D4 + 0x1523,
            GodmodeClass14 = 0x1585, // 0x1C187D4 + 0x1585,
            GodmodeClass15 = 0x15E7, // 0x1C187D4 + 0x15E7,
            PMGodmodeClass1 = 0x1649, // 0x1C187D4 + 0x1649,
            PMGodmodeClass2 = 0x16AB, // 0x1C187D4 + 0x16AB,
            PMGodmodeClass3 = 0x170D, // 0x1C187D4 + 0x170D,
            PMGodmodeClass4 = 0x176F, // 0x1C187D4 + 0x176F,
            PMGodmodeClass5 = 0x17D1, // 0x1C187D4 + 0x17D1,

            PrimaryWeapon = 0x1030, // 0x1C187D4 + 0x1030, //7 = ACR
            PrimaryWeaponProficiency = 0x1038, // 0x1C187D4 + 0x1038, //76 = Radar 75 = Störer
            PrimaryWeaponAttachment1 = 0x1032, // 0x1C187D4 + 0x1032,
            PrimaryWeaponAttachment2 = 0x1034, // 0x1C187D4 + 0x1034,
            PrimaryWeaponCamo = 0x1036, // 0x1C187D4 + 0x1036, // 13 =  Gold
            PrimaryWeaponReticle = 0x103A, // 0x1C187D4 + 0x103A, // maxValue = 6 // 4 = Best

            SecondaryWeapon = 0x103C, // 0x1C187D4 + 0x103C,
            SecondaryWeaponProficiency = 0x1044, // 0x1C187D4 + 0x1044, //76 = Radar 75 = Störer
            SecondaryWeaponAttachment1 = 0x103E, // 0x1C187D4 + 0x103E,
            SecondaryWeaponAttachment2 = 0x1040, // 0x1C187D4 + 0x1040,
            SecondaryWeaponCamo = 0x1042, // 0x1C187D4 + 0x1042, // 13 = Gold
            SecondaryWeaponReticle = 0x1046, // 0x1C187D4 + 0x1046, // maxValue = 6 // 4 = Best

            Lethal = 0x1048, // 0x1C187D4 + 0x1048,
            Tactical = 0x1054, // 0x1C187D4 + 0x1054,

            Perk1 = 0x104A, // 0x1C187D4 + 0x104A,
            Perk2 = 0x104C, // 0x1C187D4 + 0x104C,
            Perk3 = 0x104E, // 0x1C187D4 + 0x104E,

            Deathstreak = 0x106D, // 0x1C187D4 + 0x106D,

            Assault1 = 0x106F, // 0x1C187D4 + 0x106F,
            Assault2 = 0x1071, // 0x1C187D4 + 0x1071,
            Assault3 = 0x1073, // 0x1C187D4 + 0x1073,

            Support1 = 0x1075, // 0x1C187D4 + 0x1075,
            Support2 = 0x1077, // 0x1C187D4 + 0x1077,
            Support3 = 0x1079, // 0x1C187D4 + 0x1079,

            Specialist1 = 0x107B, // 0x1C187D4 + 0x107B,
            Specialist2 = 0x107D, // 0x1C187D4 + 0x107D,
            Specialist3 = 0x107F, // 0x1C187D4 + 0x107F,

            StrikePackage = 0x1052, // 0x1C187D4 + 0x1052 // Storm = 94 // Support = 95 // Specialist = 61
        }
        #endregion
    }
}
