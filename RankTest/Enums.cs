namespace RankTest
{
    public enum WeaponIndex
    {
        NONE,
        USP_TACTICAL,
        MP412,
        MAGNUM_44,
        DESERT_EAGLE,
        P99,
        FIVE_SEVEN,
        ACR_68,
        Type_95,
        M4A1,
        AK_47,
        M16A4,
        MK14,
        CM_901,
        G36C,
        SCAR_L,
        FAD,
        MP5,
        PM_9,
        P90,
        PP90M1,
        UMP45,
        MP7,
        FMG9,
        G18,
        MP9,
        SKORPION,
        SPAS_12 = 0x1C,
        AA_12,
        STRIKER,
        MODEL_1887,
        USAS_12,
        KSG_12,
        M60E4,
        MK46,
        PKP_PECHENEG,
        L86_LSW,
        MG36,
        BARRETT_50,
        MSR,
        RSASS,
        DRAGUNOV,
        AS50,
        L118A,
        RPG_7 = 0x2E,
        JAVELIN = 0x35,
        STINGER,
        SMAW,
        M320_GLM,
        RIOT_SHIELD = 0x3F,
        XM25 = 0x42,
        AUGH_BAR = 0x5A
    }

    public enum PrimWeaponIndex
    {
        NONE,
        ACR_68 = 7,
        Type_95,
        M4A1,
        AK_47,
        M16A4,
        MK14,
        CM_901,
        G36C,
        SCAR_L,
        FAD,
        MP5,
        PM_9,
        P90,
        PP90M1,
        UMP45,
        MP7,
        SPAS_12 = 0x1C,
        AA_12,
        STRIKER,
        MODEL_1887,
        USAS_12,
        KSG_12,
        M60E4,
        MK46,
        PKP_PECHENEG,
        L86_LSW,
        MG36,
        BARRETT_50,
        MSR,
        RSASS,
        DRAGUNOV,
        AS50,
        L118A,
        RIOT_SHIELD = 0x3F,
        AUGH_BAR = 0x5A
    }

    public enum SecWeaponIndex
    {
        NONE,
        USP_TACTICAL,
        MP412,
        MAGNUM_44,
        DESERT_EAGLE,
        P99,
        FIVE_SEVEN,
        FMG9 = 23,
        G18,
        MP9,
        SKORPION,
        RPG_7 = 0X2E,
        JAVELIN = 0X35,
        STINGER,
        SMAW,
        M320_GLM,
        XM25 = 0X42,
        AUGH_BAR = 0X5A
    }

    public enum Proficiencies
    {
        NONE,
        SPEED = 0X23,
        ATTACHMENTS = 0X39,
        IMPACT = 0X84,
        KICK,
        FOCUS,
        BREATH = 0X88,
        RANGE,
        MELEE,
        STABILITY,
        DAMAGE
    }

    public enum Attachments
    {
        NONE,
        RED_DOT_SIGHT,
        ACOG_SCOPE,
        GRIP,
        AKIMBO,
        THERMAL,
        SHOTGUN,
        HEATBEAT_SENSOR,
        EXTENDED_MAGS = 0X09,
        RAPID_FIRE,
        HOLOGRAPHIC_SIGHT,
        TACTICAL_KNIFE,
        VARIABLE_ZOOM_SCOPE,
        GRENADE_LAUNCHER,
        SILENCER = 0X11,
        HAMR_SCOPE = 0X13,
        HYBRID_SIGHT = 0X15
    }

    public enum Camos
    {
        NONE,
        CLASSIC,
        SNOW,
        MULTICAM,
        DIGITAL_URBAN,
        HEX,
        CHOCO,
        MARINE,
        SNAKE,
        WINTER,
        BLUE,
        RED,
        AUTUMN,
        GOLD
    }

    public enum Reticle
    {
        NONE,
        TARGET_DOT,
        DELTA,
        U_DOT,
        MIL_DOT,
        OMEGA,
        LAMBDA
    }

    public enum Lethal
    {
        NONE,
        C4 = 0X65,
        CLAYMORE,
        THROWING_KNIFE = 0X6A,
        SEMTEX,
        FRAG,
        BOUNCING_BETTY,
    }

    public enum Tactical
    {
        NONE,
        SCRAMBLER = 0X4B,
        PORTABLE_RADAR,
        FLASH_GRENADE = 0X6E,
        SMOKE_GRENADE,
        CONCUSSION_GRENADE,
        TROPHY_SYSTEM = 0X72,
        EMP_GRENADE = 0X75,
        TACTICAL_INSERTION = 0X83
    }

    public enum Perks
    {
        NONE,
        DEAD_SILENCE = 0X08,
        EXTREME_CONDITIONING,
        SITREP,
        STEADY_AIM = 0X0C,
        SLEIGHT_OF_HAND = 0X0F,
        OVERKILL = 0X11,
        QUICKDRAW = 0X26,
        SCAVENGER = 0X2B,
        ASSASSIN = 0X30,
        BLIND_EYE,
        HARDLINE = 0X44,
        STALKER = 0X4A,
        BLAST_SHIELD = 0X4E,
        RECON = 0X5C,
        MARKSMAN = 0X94,
    }

    public enum Perks1
    {
        NONE,
        EXTREME_CONDITIONING = 9,
        SLEIGHT_OF_HAND = 0X0F,
        SCAVENGER = 0X2B,
        BLIND_EYE = 0x31,
        RECON = 0X5C,
    }

    public enum Perks2
    {
        NONE,
        OVERKILL = 0X11,
        QUICKDRAW = 0X26,
        ASSASSIN = 0X30,
        HARDLINE = 0X44,
        BLAST_SHIELD = 0X4E,
    }

    public enum Perks3
    {
        NONE,
        DEAD_SILENCE = 0X08,
        SITREP = 10,
        STEADY_AIM = 0X0C,
        STALKER = 0X4A,
        MARKSMAN = 0X94,
    }

    public enum StrikePackage
    {
        NONE,
        ASSAULT = 0X5E,
        SUPPORT = 0X5F,
        SPECIALIST = 0X61,
    }

    public enum Assault
    {
        NONE,
        UAV,
        CARE_PACKAGE,
        PREDATOR_MISSILE,
        IMS,
        SENTRY_GUN,
        PRECISION_AIRSTIKE = 0X07,
        ATTACK_HELICOPTER,
        STRAFE_RUN,
        AH6_OVERWATCH,
        REAPER,
        ASSAULT_DRONE,
        PAVE_LOW = 0X0E,
        AC130,
        JUGGERNAUT,
        OSPREY_GUNNER = 0X12
    }

    public enum Support
    {
        NONE,
        UAV = 0X13,
        COUNTER_UAV,
        BALLISTIC_VESTS,
        AIRDROP_TRAP,
        SAM_TURRET,
        RECON_DRONE,
        ADVANCED_UAV,
        REMOTE_TURRET,
        STEALTH_BOMBER,
        EMP,
        JUGGERNAUT_RECON,
        ESCORT_AIRDROP = 0X1F
    }

    public enum Specialist
    {
        NONE,
        EXTREME_CONDITIONING = 0X21,
        SLEIGHT_OF_HAND,
        SCAVENGER,
        BLIND_EYE,
        RECON,
        HARDLINE,
        ASSASSIN,
        QUICKDRAW,
        BLAST_SHIELD = 0X2A,
        SITREP,
        MARKSMAN,
        STEADY_AIM,
        DEAD_SILENCE,
        STALKER
    }

    public enum Deathstreaks
    {
        NONE,
        JUICED = 0X76,
        MARTYRDOM,
        FINAL_STAND,
        REVENGE = 0X7C,
        DEAD_MAN_S_SHEAD,
        HOLLOW_POINT
    }

    public enum GmodeIndex
    {
        NONE,
        Godmode = 0x6B
    }
}
